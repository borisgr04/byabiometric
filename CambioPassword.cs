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
using ByA;
using Entidades;

namespace FingerprintNetSample
{
    public partial class CambioPassword : Form
    {
        public CambioPassword(string mod)
        {
            InitializeComponent();
            tmod = mod;
        }

        private string tmod;

        private void CambioPassword_Load(object sender, EventArgs e)
        {
            tittlegrupo.Text = tmod;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtNewConPass.Text)
            {
                ByARpt res = new ByARpt();
                Autentificacion obj = new Autentificacion();
                if (tmod == "Contraseña administrador")
                {
                    res = obj.CambioContraseña("carlos", txtOldPass.Text, txtNewPass.Text);
                }
                else
                {
                    res = obj.CambioContraseña("boris", txtOldPass.Text, txtNewPass.Text);
                }
                MessageBox.Show(res.Mensaje);
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseñas nuevas no coinciden...");
            }
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtNewConPass.Text = "";
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtNewConPass.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
