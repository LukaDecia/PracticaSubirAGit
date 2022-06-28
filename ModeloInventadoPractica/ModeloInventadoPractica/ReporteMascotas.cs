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
using ModeloInventadoPractica.AccesoADatos;

namespace ModeloInventadoPractica
{
    public partial class ReporteMascotas : Form
    {
        public ReporteMascotas()
        {
            InitializeComponent();
        }

        private void ReporteMascotas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void CargarReporte()
        {
            DataTable dt = Acceso.ObtenerListadoMascotas();
            ReportDataSource datos = new ReportDataSource("DatosMascotas", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }





    }
}
