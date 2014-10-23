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
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;

namespace FingerprintNetSample
{
    public partial class EditarPersona : Form
    {
        es_tercerosDto persona;
        public EditarPersona(es_tercerosDto oReg)
        {
            InitializeComponent();
            persona = oReg;
            BuscarDispositivos();
            BuscarMostarImagen();
        }

        private void BuscarMostarImagen()
        {
            mPersonas obj = new mPersonas();
            byte[] fotoPersona = obj.ObtenerFotoTercero(persona.terceroid);
            MemoryStream ms = new MemoryStream(fotoPersona);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;

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

            es_tercerosFotoDto Persona = new es_tercerosFotoDto();
            Persona.terceroid = txtIdentificacion.Text;
            Persona.tipodoc = cboTipoDocumento.Text;
            Persona.tipoper = cboTipoPersona.Text;
            Persona.direccion = txtDireccion.Text;
            Persona.telefono = txtTelefono.Text;
            Persona.correo = txtCorreo.Text;
            Persona.nombre = txtNombre.Text;

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Persona.foto = ms.ToArray();

            mPersonas objTercero = new mPersonas();
            res = objTercero.UpdateFoto(Persona);
            MessageBox.Show(res.Mensaje);
            if (res.Error == false)
            {
                this.Close();
            }
        }

        private void IniciarVideo()
        {
            if (existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CerrarFormulario();
            }
        }

        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = imagen;
        }

        private void CerrarFormulario()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }

            Dispose();
            Close();
        }

        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IniciarVideo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    pictureBox1.Image = pictureBox1.Image;
                }
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
            fotografiaHecha = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            abrir.InitialDirectory = "c:/users/orley/desktop";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string Dir = abrir.FileName;
                Bitmap picture = new Bitmap(Dir);
                pictureBox1.Image = (Image)picture;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
