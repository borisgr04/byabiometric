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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPermiso();
        }

        private void GetPermiso()
        {
            Autentificacion objAutentificacion = new Autentificacion();
            es_rtpLogin respu = objAutentificacion.Login(txtUsuario.Text, txtPassword.Text);
            if (respu.permiso == true)
            {
                switch (respu.rol)
                {
                    case "admin":
                        this.Hide();
                        PrincipalAdmin vistaPrincipal = new PrincipalAdmin();
                        vistaPrincipal.ShowDialog();
                        break;
                    case "entsal":
                        this.Hide();
                        PrincipalES from = new PrincipalES();
                        from.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error: Datos incorrectos...");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                GetPermiso();
            }
        }

        
    }
}
