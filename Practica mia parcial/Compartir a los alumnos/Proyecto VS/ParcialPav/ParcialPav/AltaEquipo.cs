using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialPav.AccesoADatos;

namespace ParcialPav
{
    public partial class AltaEquipo : Form
    {
        public AltaEquipo()
        {
            InitializeComponent();
        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {
            CargarFecha();
            CargarUltimoNroEquipo();
            txtNombreJugador.Enabled = false;
            CargarComboCategorias();
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarComboPosiciones();
            cmbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtFecha.Enabled = false;
        }

        private void CargarUltimoNroEquipo()
        {
            txtNroNuevoEquipo.Text = (Acceso.ObtenerUltimoIDEquipo() + 1).ToString();
            txtNroNuevoEquipo.Enabled = false;
        }

        private void CargarComboCategorias()
        {
            cmbCategorias.DataSource = Acceso.ObtenerCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";
            cmbCategorias.SelectedIndex = -1;
        }

        private void CargarComboPosiciones()
        {
            cmbPosicion.DataSource = Acceso.ObtenerPosiciones();
            cmbPosicion.DisplayMember = "Nombre";
            cmbPosicion.ValueMember = "Id";
            cmbPosicion.SelectedIndex = -1;
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            if (txtNroJugador.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese un número de jugador.");
            }
            else
            {
                DataTable tabla = Acceso.ObtenerJugadorXNro(int.Parse(txtNroJugador.Text));
                if (tabla.Rows.Count > 0)
                {
                    txtNombreJugador.Text = tabla.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("No existe el número del jugador ingresado.");
                }
            }
        }

        List<Jugador> listaJugadores = new List<Jugador>();
        private void btnAgregarJugadores_Click(object sender, EventArgs e)
        {
            if (txtNroJugador.Text.Equals("") || txtNombreJugador.Text.Equals("") || cmbPosicion.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else
            {
                Jugador jugador = new Jugador(int.Parse(txtNroJugador.Text),txtNombreJugador.Text);
                listaJugadores.Add(jugador);
                gridJugadores.Rows.Add(txtNroJugador.Text.ToString(),txtNombreJugador.Text,cmbPosicion.SelectedValue.ToString());

            }
        }

        private void btnConfirmarEquipo_Click(object sender, EventArgs e)
        {
            if (txtNombreDeEquipo.Text.Equals("") || cmbCategorias.SelectedIndex.Equals(-1) || gridJugadores.Rows.Count < 1)
            {
                MessageBox.Show("Por favor ingrese todos los datos.");
            }
            else
            {
                bool resultado = Acceso.AltaNuevoEquipo(txtNombreDeEquipo.Text,DateTime.Parse(txtFecha.Text),listaJugadores,int.Parse(txtNroNuevoEquipo.Text));
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
            txtNroNuevoEquipo.Text = "";
            txtNombreDeEquipo.Text = "";
            txtNroJugador.Text = "";
            txtNombreJugador.Text = "";
            cmbCategorias.SelectedIndex = -1;
            cmbPosicion.SelectedIndex = -1;
            gridJugadores.Rows.Clear();
        }






















    }
}
