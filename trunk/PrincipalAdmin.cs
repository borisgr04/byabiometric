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
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void registroEntradaYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gPersonas frm = new gPersonas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            gPersonas frm = new gPersonas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


    }
}
