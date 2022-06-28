using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloInventadoPractica.AccesoADatos;

namespace ModeloInventadoPractica
{
    public partial class AdopcionMascota : Form
    {
        public AdopcionMascota()
        {
            InitializeComponent();
        }

        private void AdopcionMascota_Load(object sender, EventArgs e)
        {
            CargarNroPedido();
            CargarFecha();
            CargarComboCategoria();
            CargarComboTipoMascota();
        }

        private void CargarNroPedido()
        {
            txtNroPedido.Text = (Acceso.ObtenerUltimoNroPedido() + 1).ToString();
            txtNroPedido.Enabled = false;
        }

        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtFecha.Enabled = false;
        }

        private void CargarComboCategoria()
        {
            cmbCategoria.DataSource = Acceso.ObtenerCategorias();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboTipoMascota()
        {
            cmbTipoMascota.DataSource = Acceso.ObtenerTiposMascotas();
            cmbTipoMascota.DisplayMember = "Nombre";
            cmbTipoMascota.ValueMember = "Id";
            cmbTipoMascota.SelectedIndex = -1;
            cmbTipoMascota.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNroMascota.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el número de mascota.");
            }
            else
            {
                DataTable tabla = Acceso.ObtenerMascotaXId(int.Parse(txtNroMascota.Text));
                if (tabla.Rows.Count > 0)
                {
                    txtNombreMascota.Text = tabla.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("No existe la mascota.");
                }
            }
        }

        List<Mascota> listaMascotas = new List<Mascota>();
        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            if (txtNroMascota.Text.Equals("") || txtNombreMascota.Text.Equals("") || cmbTipoMascota.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else
            {
                Mascota mascota = new Mascota(int.Parse(txtNroMascota.Text),txtNombreMascota.Text);
                listaMascotas.Add(mascota);
                grillaMascotas.Rows.Add(txtNroMascota.Text, txtNombreMascota.Text, cmbTipoMascota.SelectedValue.ToString());

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombreAdoptante.Text.Equals("") || cmbCategoria.SelectedIndex.Equals(-1) || grillaMascotas.Rows.Count < 1)
            {
                MessageBox.Show("Por favor ingrese todos los datos.");
            }
            else
            {
                bool resultado = Acceso.GenerarPedidoAdopcion(txtNombreAdoptante.Text, DateTime.Parse(txtFecha.Text), listaMascotas, int.Parse(txtNroPedido.Text));
                if (resultado)
                {
                    MessageBox.Show("Transacción realizada con éxito.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al realizar la transacción.");
                }
            }

        }

        private void LimpiarCampos()
        {
            CargarFecha();
            CargarNroPedido();
            txtNombreAdoptante.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbTipoMascota.SelectedIndex = -1;
            txtNroMascota.Text = "";
            txtNombreMascota.Text = "";
            grillaMascotas.Rows.Clear();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteMascotas ventana = new ReporteMascotas();
            ventana.ShowDialog();
        }
    }
}
