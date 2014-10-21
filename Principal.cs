using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintNetSample
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registroEntradaYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosES frm = new RegistrosES();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.MdiParent = this;
            frm.Show();
        }


    }
}
