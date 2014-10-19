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
using BLL;
using ByA;

namespace FingerprintNetSample
{
    public partial class EditarPersona : Form
    {
        es_tercerosDto persona;
        public EditarPersona(es_tercerosDto oReg)
        {
            InitializeComponent();
            persona = oReg;
        }

        private void EditarPersona_Load(object sender, EventArgs e)
        {
            txtNombre.Text = persona.nombre;
            txtIdentificacion.Text = persona.terceroid;
            txtTelefono.Text = persona.terceroid;
            txtDireccion.Text = persona.direccion;
            txtCorreo.Text = persona.correo;
            cboTipoDocumento.Text = persona.tipodoc;
            cboTipoPersona.Text = persona.tipoper;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            res = objTercero.Update(Persona);
            MessageBox.Show(res.Mensaje);
            if (res.Error == false)
            {
                this.Close();
            }
        }
    }
}
