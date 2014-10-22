using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using FingerprintNetSample.DB;
using BLL;
using ByA;
using Entidades;

namespace FingerprintNetSample
{
    public partial class RegistroHuella : Form
    {
        public RegistroHuella(string idPersona, int idHuella)
        {
            InitializeComponent();
            fingerPrint = new FingerprintCore();
            idPersonaGlobal = idPersona;
            idHuellaPersonaGlobal = idHuella;
            fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
            fingerPrint.onFinger += new FingerEventHandler(fingerPrint_onFinger);
            fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);
            //fingerPrint.onImage += new ImageEventHandler(on_consolidate);
            fopt = new formOption();
        }
        //private bool consolidate = false;
        private bool PermisoGuardar = true;
        private formOption fopt;
        private string idPersonaGlobal;
        private int idHuellaPersonaGlobal;
        private FingerprintCore fingerPrint;
        private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            try
            {

                fingerPrint.Initialize();


                fingerPrint.CaptureInitialize();

                SetLaberThreshold();

                SetStatusMessage("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void SetLaberThreshold() 
        {
            int thresholdId, rotationMaxId;
            fingerPrint.GetIdentifyParameters(out thresholdId, out rotationMaxId);

           // int relationPos = (thresholdId ) / 300;

            float percent = (float)thresholdId / (float)200;
            
            int adj = (int)((prgbMatching.Right - prgbMatching.Left) * percent);

            lblThreshold.Left = adj;
            lblThreshold2.Left = adj - (lblThreshold2.Width/2);
        }

        private void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            SetFingerStatus(ie.Source, 2);
            rawImage = ie.RawImage;
            SetImage(ie.RawImage.Image);
            if (true) 
            {
               // buttonClick(button1);
                ExtractTemplate();

                if (true) 
                {
                    System.Threading.Thread.Sleep(100);
                   // buttonClick(button3);
                    Identify();
                }
            }
        }


        private delegate void delSetFingerStatus(string readerName, int status);
        private void SetFingerStatus(string readerName,int status )
        {
            if (lvwFPReaders.InvokeRequired == true)
            {
                this.Invoke(new delSetFingerStatus(SetFingerStatus), new object[] { readerName, status });
            }
            else 
            {
                ListViewItem[] listItens = lvwFPReaders.Items.Find(readerName, false);
                System.Threading.Thread.BeginCriticalRegion();
                foreach (ListViewItem item in listItens) 
                {
                    switch (status) 
                    {
                        case 0:
                            {
                                item.ImageIndex = 0;
                                
                            } break;
                        case 1:
                            {
                                item.ImageIndex = 1;
                            } break;
                        case 2: 
                            {
                                item.ImageIndex = 2;
                            } break;
                    }
                }
                System.Threading.Thread.Sleep(300);
                System.Threading.Thread.EndCriticalRegion();
            }
        }

        void fingerPrint_onFinger(object source, GriauleFingerprintLibrary.Events.FingerEventArgs fe)
        {
            switch (fe.EventType)
            {
                case GriauleFingerprintLibrary.Events.FingerEventType.FINGER_DOWN:
                    {
                        SetFingerStatus(fe.Source, 0);
                    } break;
                case GriauleFingerprintLibrary.Events.FingerEventType.FINGER_UP:
                    {
                        SetFingerStatus(fe.Source, 1);
                    } break;
            }
        }

        private delegate void delSetImage(Image img);
        void SetImage(Image img) 
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(SetImage), new object[] { img });
            }
            else 
            {
                pictureBox1.Image = img;          
            }
        }

        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {        
                fingerPrint.StartCapture(source.ToString());
                SetLvwFPReaders(se.Source, 0);
            }
            else
            {        
                fingerPrint.StopCapture(source);
                SetLvwFPReaders(se.Source, 1);
            }
        }

        private delegate void DelSetLvwFPReaders(string readerName, int op);
        private void SetLvwFPReaders(string readerName, int op) 
        {
            if (lvwFPReaders.InvokeRequired == true)
            {
                this.Invoke(new DelSetLvwFPReaders(SetLvwFPReaders), new object[] {readerName, op });
            }
            else 
            {
                switch (op) 
                {
                    case 0: 
                            {
                                lvwFPReaders.Items.Add(readerName, readerName, 1);                       
                            } break;
                    case 1: 
                            {
                                lvwFPReaders.Items.RemoveByKey(readerName);                
                            } break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fingerPrint.CaptureFinalize();
                fingerPrint.Finalizer();
            }
            catch { }
        }

        private void ExtractTemplate() 
        {
            if (rawImage != null)
            {
                try
                {
                    _template = null;
                    fingerPrint.Extract(rawImage, ref _template);

                    SetQualityBar(_template.Quality);

                    DisplayImage(_template, false);

                }
                catch {
                    SetQualityBar(-1);
                }
            }
        }

        delegate void delsetQuality(int quality);
        private void SetQualityBar(int quality) 
        {

            if (prgbQuality.InvokeRequired == true)
            {
                this.Invoke(new delsetQuality(SetQualityBar), new object[] { quality });
            }
            else
            {

                switch (quality)
                {
                    case 0:
                        {
                            prgbQuality.ProgressBarColor = System.Drawing.Color.LightCoral;
                            prgbQuality.Value = prgbQuality.Maximum / 3;
                        } break;
                    case 1:
                        {
                            prgbQuality.ProgressBarColor = System.Drawing.Color.YellowGreen;
                            prgbQuality.Value = (prgbQuality.Maximum / 3) * 2;
                        } break;
                    case 2:
                        {
                            prgbQuality.ProgressBarColor = System.Drawing.Color.MediumSeaGreen;
                            prgbQuality.Value = prgbQuality.Maximum;
                        } break;

                    default:
                        {
                            prgbQuality.ProgressBarColor = System.Drawing.Color.Gray;
                            prgbQuality.Value = 0;
                        } break;
                }
            }
        }

        delegate void delsetMatch(int score, Color color);
        private void SetMatchBar(int score , Color color)
        {

            if (prgbMatching.InvokeRequired == true)
            {
                this.Invoke(new delsetMatch(SetMatchBar), new object[] { score, color });
            }
            else
            {
                prgbMatching.Value = score > 200 ? 200 : score ;
                prgbMatching.ProgressBarColor = color;
            }
        }


        private void Identify()
        {
            GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate = null;
            try
            {
                if ((_template != null) && (_template.Size > 0))
                {
                    fingerPrint.IdentifyPrepare(_template);

                    //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();

                    BLL.mEnroll dl = new BLL.mEnroll();
                    //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                    FingerprintTemplateDTO _templateDTO = new FingerprintTemplateDTO();

                    //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                    List<FingerprintTemplateDTO> lst = dl.GetTemplates();
                    //IDataReader dataReader = dl.GetTemplates();
                    foreach(var item in lst)
                    {
                            int tempId = item.ID;
                            byte[] buff = item.Buffer;
                            int quality = item.Quality;

                            testTemplate = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();

                            testTemplate.Size = buff.Length;
                            testTemplate.Buffer = buff;
                            testTemplate.Quality = quality;

                            int score;
                            if (Identify(testTemplate, out score))
                            {
                                PermisoGuardar = false;
                                SetMatchBar(score, Color.SeaGreen);
                                string NombrePersona = GetPersonaId(item.ID).nombre;
                                SetStatusMessage("Huella existente: " + NombrePersona);
                                DisplayImage(_template, true);
                                return;
                            }
                            else
                            {
                                PermisoGuardar = true;
                                SetMatchBar(score, Color.LightCoral);
                                SetStatusMessage("No se encontro huella");
                            }
                    }

                        SetMatchBar(0, Color.Gray);
                        SetStatusMessage("Template Unmatched");

                    
                }
            }
            catch (FingerprintException ge)
            {
                if (ge.ErrorCode == -8)
                {
                    System.IO.FileStream dumpTemplate = System.IO.File.Create(@".\Dumptemplate.gt");
                    System.IO.StreamWriter stWriter = new System.IO.StreamWriter(dumpTemplate);

                    stWriter.WriteLine(BitConverter.ToString(testTemplate.Buffer, 0));
                    stWriter.Close();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private es_tercerosFotoDto GetPersonaId(int idHuella)
        {
            mPersonas objPersonas = new mPersonas();
            es_tercerosFotoDto persona = objPersonas.GetPorIdHuella(idHuella);
            return persona;
        }

        private delegate void delSetStatusMessage(string message);
        private void SetStatusMessage(string message) 
        {
            if (statusStrip1.InvokeRequired == true)
            {
                this.Invoke(new delSetStatusMessage(SetStatusMessage), new object[] { message });
            }
            else
            {
                tsslStatusMessage.Text = message;
            }
        }

        private bool Identify(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate, out int score) 
        {
            return fingerPrint.Identify(testTemplate,out score) ==  1? true : false;
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify) 
        {
            IntPtr hdc = FingerprintCore.GetDC();

            IntPtr image = new IntPtr();

            if (identify)
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image,FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else 
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }
            
            SetImage(Bitmap.FromHbitmap(image));

            FingerprintCore.ReleaseDC(hdc);
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            GrCaptureImageFormat imformat = new GrCaptureImageFormat();
            switch(saveFileDialog1.FilterIndex)
            {
                case 1:{imformat = GrCaptureImageFormat.GRCAP_IMAGE_FORMAT_BMP; }break;
            }
            try
            {
                fingerPrint.SaveRawImageToFile(rawImage, saveFileDialog1.FileName, imformat);
            }
            catch { }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {                
                fingerPrint.LoadImageFromFile(openFileDialog1.FileName, 500);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        public void Verificar()
        {

            VerifyDialog verify = new VerifyDialog();
            if (verify.ShowDialog(this) == DialogResult.OK)
            {
                int verifyCode = Convert.ToInt32(verify.VerifyCode);

                if ((_template != null) && (_template.Size > 0))
                {
                    try
                    {
                    fingerPrint.IdentifyPrepare(_template);


                    mEnroll dl = new mEnroll();
                    List<FingerprintTemplateDTO> lst = dl.GetTemplates();
                    //IDataReader dataReader = dl.GetTemplates();
                    foreach(var item in lst)
                    {
                            int tempId = item.ID;
                            byte[] buff = item.Buffer;
                            int quality = item.Quality;

                            GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();

                            testTemplate.Size = buff.Length;
                            testTemplate.Buffer = buff;

                            int score;
                            if (Identify(testTemplate, out score))
                            {
                                //WriteLog(string.Format("Fingerprint matched, ID:{0} - Score: {1}", tempId, score));
                                DisplayImage(_template, true);
                                return;
                            }
                            //                          WriteLog("Fingerprint not found.");
                        }
                    }
                    catch { }
                }
                else
                {
                    //                WriteLog("Must acquire a finger print image and extract a template, before verify within the database");
                }
            }
        }


        delegate void delControlEnable(ButtonBase button, bool value);
        private void controlEnable(ButtonBase button, bool value)
        {
            if (button.InvokeRequired == true)
            {
                this.Invoke(new delControlEnable(controlEnable), new object[] { button,value });
            }
            else 
            {
                button.Enabled = value;
            }
        }
      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementar con AEF");
            //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
            //dl.DeleteTemplate();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ret, thresholdId = 0, rotationMaxId = 0;
            int thresholdVr = 0, rotationMaxVr = 0;
            int minutiaeColor = 0, minutiaeMatchColor = 0;
            int segmentsColor = 0, segmentsMatchColor = 0;
            int directionsColor = 0, directionsMatchColor = 0;
            bool ok;

            for (; ; )
            {
                // get current identification/verification parameters
                fingerPrint.GetIdentifyParameters(out thresholdId, out rotationMaxId);
                fingerPrint.GetVerifyParameters(out thresholdVr, out rotationMaxVr);
                // set current identification/verification parameters on options form
                fopt.setParameters(thresholdId, rotationMaxId, thresholdVr, rotationMaxVr);

                // show form with match options and biometric display options
                if (fopt.ShowDialog() != DialogResult.OK) return;
                ok = true;
                // get parameters 
                fopt.getParameters(ref thresholdId, ref rotationMaxId, ref thresholdVr, ref rotationMaxVr,
                    ref minutiaeColor, ref minutiaeMatchColor, ref segmentsColor, ref segmentsMatchColor,
                    ref directionsColor, ref directionsMatchColor);
                if ((thresholdId < (int)FingerprintConstants.GR_MIN_THRESHOLD) || (thresholdId > (int)FingerprintConstants.GR_MAX_THRESHOLD) ||
                    (rotationMaxId < (int)FingerprintConstants.GR_ROT_MIN) || (rotationMaxId > (int)FingerprintConstants.GR_ROT_MAX))
                {
                    MessageBox.Show("Invalid identify parameters values!");
                    ok = false;
                }
                if ((thresholdVr < (int)FingerprintConstants.GR_MIN_THRESHOLD) || (thresholdVr > (int)FingerprintConstants.GR_MAX_THRESHOLD) ||
                    (rotationMaxVr < (int)FingerprintConstants.GR_ROT_MIN) || (rotationMaxVr > (int)FingerprintConstants.GR_ROT_MAX))
                {
                    MessageBox.Show("Invalid verify parameters values!");
                    ok = false;
                }
                // set new identification parameters
                if (ok)
                {
                    try
                    {
                        fingerPrint.SetIdentifyParameters(thresholdId, rotationMaxId);
                        fingerPrint.SetVerifyParameters(thresholdVr, rotationMaxVr);

                        fopt.acceptChanges();

                        fingerPrint.SetBiometricDisplayColors(minutiaeColor, minutiaeMatchColor, segmentsColor, segmentsMatchColor, directionsColor, directionsMatchColor);

                        SetLaberThreshold();
                        return;
                    }
                    catch (FingerprintException ex)
                    {
                        if (ex.ErrorCode == FingerprintConstants.GR_DEFAULT_USED)
                        {
                            MessageBox.Show("Invalid identify parameters values. Default values will be used.");

                        }
                        if (ex.ErrorCode == FingerprintConstants.GR_DEFAULT_USED)
                        {
                            MessageBox.Show("Invalid verify parameters values. Default values will be used.");

                        }

                    }
                }

                
            }

            
        }

        private void enrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarHuellaAntigua()
        {
            mEnroll objEnroll = new mEnroll();
            objEnroll.DeleteTemplate(idHuellaPersonaGlobal);
        }

        private ByARpt  AsignarHuellaPersona(int idHuella){
            mPersonas objPersona = new mPersonas();
            return objPersona.AsignarCodigoHuellaPersona(idPersonaGlobal, idHuella);
        }

        private int GetIdHuellaActual()
        {
            mEnroll objEnroll = new mEnroll();
            return objEnroll.GetIdUltimoTemplate();
        }

        private void identifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identify();
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractTemplate();
        }

        private void loadImageFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void startEnrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarEnroll();
        }

        public void StarEnroll()
        {
            Consolidation consolid = Consolidation.GetConsolidationInstance(ref fingerPrint);
            if (consolid.ShowDialog() == DialogResult.OK)
            {
                SetStatusMessage("Template Enroled");
            }
            else
            {
                SetStatusMessage("Consolidation Aborted");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void autoIdentifyToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked == true) 
            {
                
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enrollToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (PermisoGuardar == true)
                {
                    if (_template == null)
                    {
                        MessageBox.Show("Error...");
                        return;
                    }
                    mEnroll dl = new mEnroll();
                    FingerprintTemplateDTO _templateDTO = new FingerprintTemplateDTO();

                    _templateDTO.Buffer = _template.Buffer;
                    _templateDTO.Quality = _template.Quality;
                    dl.SaveTemplate(_templateDTO);

                    EliminarHuellaAntigua();

                    int IIdUltimoTemplate = GetIdHuellaActual();
                    ByARpt ResAsigHuella = AsignarHuellaPersona(IIdUltimoTemplate);
                    MessageBox.Show("Se asigno huella a la persona...");
                    this.Close();
                    //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                    //dl.SaveTemplate(_template);
                }
                else
                {
                    MessageBox.Show("No se puede guardar, esta huella ya esta registrada...");
                }
            }
            catch { }
        }


    }
}