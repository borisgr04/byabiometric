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
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using FingerprintNetSample.DB;


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
            es_tercerosDto tercero = new es_tercerosDto();
            tercero.terceroid = dgPersonas.CurrentRow.Cells[0].Value.ToString();
            tercero.nombre = dgPersonas.CurrentRow.Cells[1].Value.ToString();
            tercero.tipodoc = dgPersonas.CurrentRow.Cells[2].Value.ToString();
            tercero.tipoper = dgPersonas.CurrentRow.Cells[3].Value.ToString();
            tercero.direccion = dgPersonas.CurrentRow.Cells[4].Value.ToString();
            tercero.telefono = dgPersonas.CurrentRow.Cells[5].Value.ToString();
            tercero.correo = dgPersonas.CurrentRow.Cells[6].Value.ToString();
            EditarPersona vEditarPersona = new EditarPersona(tercero);
            vEditarPersona.Show();
        }
        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnRegistrarHuella_Click(object sender, EventArgs e)
        {
            string Documento = dgPersonas.CurrentRow.Cells[0].Value.ToString();
            int idHuella = int.Parse(dgPersonas.CurrentRow.Cells[7].Value.ToString());
            RegistroHuella vRegistroHuella = new RegistroHuella(Documento, idHuella);
            vRegistroHuella.Show();
        }

        private void huellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosES vEntradasSalidas = new RegistrosES();
            vEntradasSalidas.Show();
        }

        private void gPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
