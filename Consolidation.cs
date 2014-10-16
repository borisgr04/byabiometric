using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.DataTypes;
using FingerprintNetSample.DB;
using BLL;
namespace FingerprintNetSample
{
  

    public partial class Consolidation : Form
    {
        private enum QualityTemplate
        {
            INSF = 1,
            SUF,
            GOOD,
            VERYGOOD
        }

        public FingerprintCore refFingercore;
        public static Consolidation consolid = null;
        private FingerprintRawImage rawImage;
        private FingerprintTemplate _template;
        private FingerprintTemplateDTO _templateDTO;
        private int stepCount;



        private Consolidation()
        {
            InitializeComponent();            
        }

        private Consolidation(ref FingerprintCore fingerCore) : this()
        {
            refFingercore = fingerCore;

            refFingercore.onImage += new ImageEventHandler(refFingercore_onImage);
        }

        void refFingercore_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage = ie.RawImage;
            SetImage(ie.RawImage.Image);
            stepCount++;
            //ExtractTemplate();

            try
            {
                _template = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
                int ret = (int)refFingercore.Enroll(ie.RawImage, ref _template, GrTemplateFormat.GR_FORMAT_DEFAULT, FingerprintConstants.GR_DEFAULT_CONTEXT);
                if (ret >= FingerprintConstants.GR_ENROLL_SUFFICIENT)
                {
                    //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                    //dl.SaveTemplate(template);                                                

                    if (ret == FingerprintConstants.GR_ENROLL_SUFFICIENT)
                    {
                        SetStatusMessage("Sufficient quality value.");
                        PerformStep(QualityTemplate.SUF,Color.YellowGreen);                   
                    }
                    else if (ret == FingerprintConstants.GR_ENROLL_GOOD) 
                    {
                        SetStatusMessage("Good quality value.");
                        PerformStep(QualityTemplate.GOOD, Color.MediumSeaGreen);
                    }
                    else if (ret == FingerprintConstants.GR_ENROLL_VERY_GOOD)
                    {
                        //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                        //dl.SaveTemplate(_template);
                        BLL.mEnroll dl = new BLL.mEnroll();
                        //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                        _templateDTO = new FingerprintTemplateDTO();
                        
                        _templateDTO.Buffer = _template.Buffer;
                        _templateDTO.Quality = _template.Quality;

                        dl.SaveTemplate(_templateDTO);

                        PerformStep(QualityTemplate.VERYGOOD, Color.SeaGreen);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (ret == FingerprintConstants.GR_ENROLL_MAX_LIMIT_REACHED)
                    {
                        //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                        //dl.SaveTemplate(_template);

                        //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                        //dl.SaveTemplate(_template);

                        BLL.mEnroll dl = new BLL.mEnroll();
                        //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                        _templateDTO = new FingerprintTemplateDTO();

                        _templateDTO.Buffer = _template.Buffer;
                        _templateDTO.Quality = _template.Quality;

                        dl.SaveTemplate(_templateDTO);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                    EnableOk();
                }                                
                else
                {
                    // WriteLog("The Template does not reach a good quality value");
                    SetStatusMessage("Please put your finger again");
                    PerformStep(QualityTemplate.INSF, Color.LightCoral);
                }
            }
            catch { }

          
            System.Threading.Thread.Sleep(100);
           
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
                toolStripStatusLabel1.Text = message;
            }
        }

        private delegate void delEnableOk();
        private void EnableOk() 
        {
            if (btnOk.InvokeRequired == true)
            {
                this.Invoke(new delEnableOk(EnableOk));
            }
            else 
            {
                btnOk.Enabled = true;
            }
        }

        private void ExtractTemplate()
        {
            if (rawImage != null)
            {
                try
                {
                    _template = null;
                    refFingercore.Extract(rawImage, ref _template);

                    //  SetQualityBar(_template.Quality);

                    DisplayImage(_template, false);

                }
                catch
                {
                   // SetQualityBar(-1);
                }
            }
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        {
            IntPtr hdc = FingerprintCore.GetDC();

            IntPtr image = new IntPtr();

            if (identify)
            {
                refFingercore.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                refFingercore.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }

            
            SetImage(Bitmap.FromHbitmap(image));

            FingerprintCore.ReleaseDC(hdc);
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
                Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }

        public static Consolidation GetConsolidationInstance(ref FingerprintCore fingerCore)
        {
            if (consolid == null || consolid.IsDisposed) 
            {
                consolid = new Consolidation(ref fingerCore);
            }

            return consolid;
        }

        private void Consolidation_Load(object sender, EventArgs e)
        {
            refFingercore.StartEnroll();
            SetStatusMessage("Enrollment Process Started");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                
                //IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                //dl.SaveTemplate(_template);

                //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                //dl.SaveTemplate(_template);
                BLL.mEnroll dl = new BLL.mEnroll();
                //DB.AEF.EnrollDAO dl = new DB.AEF.EnrollDAO();
                _templateDTO = new FingerprintTemplateDTO();

                _templateDTO.Buffer = _template.Buffer;
                _templateDTO.Quality = _template.Quality;

                dl.SaveTemplate(_templateDTO);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Abort;                
                this.Close();
            }
        }

        private delegate void delProgress(Color color);
        private void Progress(Color color) 
        {
            if (prgbConsolidation.InvokeRequired == true) 
            {
                this.Invoke(new delProgress(Progress), new object[] {color });
            }
            else 
            {
                prgbConsolidation.ProgressBarColor = color;
               /// prgbConsolidation.PerformStep();
            }
        }
        private delegate void delPerformStep(QualityTemplate quality, Color color);
        private void PerformStep(QualityTemplate quality, Color color)
        {
            if (prgbConsolidation.InvokeRequired == true)
            {
                this.Invoke(new delPerformStep(PerformStep), new object[] { quality, color });
            }
            else
            {
                int step = 0;
                switch (quality)
                {
                    case QualityTemplate.INSF:
                        {
                            step = ((int)(stepCount * 5));
                        } break;
                    case QualityTemplate.SUF:
                        {
                            step = 25 +((int)(stepCount * 3.75));
                        } break;
                    case QualityTemplate.GOOD:
                        {
                            step = 50 + ((int)(stepCount * 2.5));
                        } break;
                    case QualityTemplate.VERYGOOD:
                        {
                            step = 100;
                        } break;
                }

                prgbConsolidation.ProgressBarColor = color;
                prgbConsolidation.Value = step;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Consolidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            refFingercore.onImage -= new ImageEventHandler(refFingercore_onImage);
        }
    }
}