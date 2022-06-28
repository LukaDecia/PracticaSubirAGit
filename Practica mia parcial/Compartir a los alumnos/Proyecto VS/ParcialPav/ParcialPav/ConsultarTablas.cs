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
    public partial class ConsultarTablas : Form
    {
        public ConsultarTablas()
        {
            InitializeComponent();
        }

        private void ConsultarTablas_Load(object sender, EventArgs e)
        {
            CargarGrillaEquipos();
            CargarGrillaJugadoresXEquipos();
        }

        private void CargarGrillaEquipos()
        {
            try
            {
                grillaEquipos.DataSource = Acceso.ObtenerEquipos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGrillaJugadoresXEquipos()
        {
            try
            {
                grillaJugadoresXEquipo.DataSource = Acceso.ObtenerJugadoresXEquipo();
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
