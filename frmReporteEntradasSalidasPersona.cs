using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.ReportesDto;
using BLL;
using ByA;
using Microsoft.Reporting.WinForms;


namespace FingerprintNetSample
{
    public partial class frmReporteEntradasSalidasPersona : Form
    {
        public frmReporteEntradasSalidasPersona()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmReporteEntradasSalidasPersona_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            DateTime Finicial = dtFechaInicial.Value;
            DateTime Ffinal = dtFechaFinal.Value;
            string idTercero = txtDocumento.Text;

            mReportes objReporte = new mReportes();
            List<RegistroEntradasSalidasDto> lReg = objReporte.GetEntradasSalidasPersona(Finicial, Ffinal, idTercero);
            if (lReg.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSEntradasSalidas", lReg));
                reportViewer1.RefreshReport();
            }
            else 
            {
                MessageBox.Show("No hay eventos entre esas fechas...");
            }
        }
    }
}
