using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ParcialPav.AccesoADatos;

namespace ParcialPav
{
    public partial class ReporteJugador : Form
    {
        public ReporteJugador()
        {
            InitializeComponent();
        }

        private void ReporteJugador_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.reportViewer1.RefreshReport();
        }
        private void CargarReporte()
        {
            DataTable dt = Acceso.ObtenerListadoJugadores();
            ReportDataSource datos = new ReportDataSource("DatosJugadores", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }





    }
}
