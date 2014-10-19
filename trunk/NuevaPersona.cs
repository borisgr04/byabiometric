using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByA;
using BLL;
using Entidades;

namespace FingerprintNetSample
{
    public partial class NuevaPersona : Form
    {
        public NuevaPersona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ByARpt res = new ByARpt();

            es_tercerosDto Persona = new es_tercerosDto();
            Persona.terceroid = txtIdentificacion.Text;
            Persona.tipodoc = cboTipoDocumento.Text;
            Persona.tipoper = cboTipoPersona.Text;
            Persona.direccion = txtDireccion.Text;
            Persona.telefono = txtTelefono.Text;
            Persona.correo = txtCorreo.Text;
            Persona.nombre = txtNombre.Text;

            mPersonas objTercero = new mPersonas();
            res = objTercero.Insert(Persona);
            MessageBox.Show(res.Mensaje);
            if (res.Error == false)
            {
                this.Close();
            }
        }

        private void NuevaPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtIdentificacion.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            cboTipoDocumento.Text = "";
            cboTipoPersona.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
