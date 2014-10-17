using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace FingerprintNetSample
{
    public partial class gPersonas : Form
    {
        public gPersonas()
        {
            InitializeComponent();
        }

        private void gPersonas_Load(object sender, EventArgs e)
        {
            CargarGrillaPersonas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaPersona vNuevaPersona = new NuevaPersona();
            vNuevaPersona.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrillaPersonas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPersona();
        }

        private void CargarGrillaPersonas()
        {
            mPersonas objPersonas = new mPersonas();
            dgPersonas.DataSource = objPersonas.Gets();
            dgPersonas.Refresh();
        }
        private void EditarPersona()
        {
            string idtercero = dgPersonas.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(idtercero);
        }

        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
