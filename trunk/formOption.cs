/*
 -------------------------------------------------------------------------------
 FingerPrint Sample
 (c) 2005 Griaule Tecnologia Ltda.
 http://www.griaule.com
 -------------------------------------------------------------------------------

 This sample is provided with "FingerPrint Fingerprint Recognition Library" and
 can't run without it. It's provided just as an example of using FingerPrint
 Fingerprint Recognition Library and should not be used as basis for any
 commercial product.

 Griaule Tecnologia makes no representations concerning either the merchantability
 of this software or the suitability of this sample for any particular purpose.

 THIS SAMPLE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
 IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 IN NO EVENT SHALL GRIAULE BE LIABLE FOR ANY DIRECT, INDIRECT,
 INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 You can download the free version of FingerPrint directly from Griaule website.
                                                                   
 These notices must be retained in any copies of any part of this
 documentation and/or sample.

 -------------------------------------------------------------------------------
*/

// -----------------------------------------------------------------------------------
// GUI routines: "Options" form
// -----------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using GriauleFingerprintLibrary;

namespace FingerprintNetSample
{
	public class formOption : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbIdentify;
		private System.Windows.Forms.GroupBox gbVerify;
		private System.Windows.Forms.TextBox txtIdentThres;
		private System.Windows.Forms.TextBox txtIdentRotTol;
		private System.Windows.Forms.Label lbIdentThres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVerifyRotTol;
		private System.Windows.Forms.Label lbVerifyRotTol;
		private System.Windows.Forms.TextBox txtVerifyThres;
		private System.Windows.Forms.Label lbVerifyThres;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.GroupBox gbMinColors;
		private System.Windows.Forms.GroupBox _moduleExtract;
		private System.Windows.Forms.GroupBox gbMinDirecColors;
		private System.Windows.Forms.Label lbMinColorReg;
		private System.Windows.Forms.Label lbMinColorMatch;
		private System.Windows.Forms.Label lbMinColorDoubleClick;
		private System.Windows.Forms.PictureBox pbMinutiaeColorMatched;
		private System.Windows.Forms.CheckBox cbShowMinutiaeReg;
		private System.Windows.Forms.CheckBox cbShowMinutiaeMatch;
		private System.Windows.Forms.CheckBox cbShowSegmentMatch;
		private System.Windows.Forms.CheckBox cbShowSegmentReg;
		private System.Windows.Forms.Label lbSegColorDoubleClick;
		private System.Windows.Forms.Label lbSegColorMatch;
		private System.Windows.Forms.Label lbSegColorReg;
		private System.Windows.Forms.PictureBox pbSegmentColorMatched;
		private System.Windows.Forms.PictureBox pbSegmentColor;
		private System.Windows.Forms.CheckBox cbShowDirectionMatch;
		private System.Windows.Forms.CheckBox cbShowDirectionReg;
		private System.Windows.Forms.Label lbDirColorDoubleClick;
		private System.Windows.Forms.Label lbMinDirColorMatch;
		private System.Windows.Forms.Label lbMinDirColorReg;
		private System.Windows.Forms.PictureBox pbDirectionColorMatched;
		private System.Windows.Forms.PictureBox pbDirectionColor;
		private System.Windows.Forms.PictureBox pbMinutiaeColor;
		private System.Windows.Forms.ColorDialog gridColor;
		private System.ComponentModel.Container components = null;

		// Initializes formOption.
		public formOption()
		{
			//Required for Windows Design Support
			InitializeComponent();
		}

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOption));
            this.gbIdentify = new System.Windows.Forms.GroupBox();
            this.txtIdentRotTol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentThres = new System.Windows.Forms.TextBox();
            this.lbIdentThres = new System.Windows.Forms.Label();
            this.gbVerify = new System.Windows.Forms.GroupBox();
            this.txtVerifyRotTol = new System.Windows.Forms.TextBox();
            this.lbVerifyRotTol = new System.Windows.Forms.Label();
            this.txtVerifyThres = new System.Windows.Forms.TextBox();
            this.lbVerifyThres = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbMinColors = new System.Windows.Forms.GroupBox();
            this.cbShowMinutiaeMatch = new System.Windows.Forms.CheckBox();
            this.cbShowMinutiaeReg = new System.Windows.Forms.CheckBox();
            this.lbMinColorDoubleClick = new System.Windows.Forms.Label();
            this.lbMinColorMatch = new System.Windows.Forms.Label();
            this.lbMinColorReg = new System.Windows.Forms.Label();
            this.pbMinutiaeColorMatched = new System.Windows.Forms.PictureBox();
            this.pbMinutiaeColor = new System.Windows.Forms.PictureBox();
            this._moduleExtract = new System.Windows.Forms.GroupBox();
            this.cbShowSegmentMatch = new System.Windows.Forms.CheckBox();
            this.cbShowSegmentReg = new System.Windows.Forms.CheckBox();
            this.lbSegColorDoubleClick = new System.Windows.Forms.Label();
            this.lbSegColorMatch = new System.Windows.Forms.Label();
            this.lbSegColorReg = new System.Windows.Forms.Label();
            this.pbSegmentColorMatched = new System.Windows.Forms.PictureBox();
            this.pbSegmentColor = new System.Windows.Forms.PictureBox();
            this.gbMinDirecColors = new System.Windows.Forms.GroupBox();
            this.cbShowDirectionMatch = new System.Windows.Forms.CheckBox();
            this.cbShowDirectionReg = new System.Windows.Forms.CheckBox();
            this.lbDirColorDoubleClick = new System.Windows.Forms.Label();
            this.lbMinDirColorMatch = new System.Windows.Forms.Label();
            this.lbMinDirColorReg = new System.Windows.Forms.Label();
            this.pbDirectionColorMatched = new System.Windows.Forms.PictureBox();
            this.pbDirectionColor = new System.Windows.Forms.PictureBox();
            this.gridColor = new System.Windows.Forms.ColorDialog();
            this.gbIdentify.SuspendLayout();
            this.gbVerify.SuspendLayout();
            this.gbMinColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinutiaeColorMatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinutiaeColor)).BeginInit();
            this._moduleExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegmentColorMatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegmentColor)).BeginInit();
            this.gbMinDirecColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirectionColorMatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirectionColor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIdentify
            // 
            this.gbIdentify.Controls.Add(this.txtIdentRotTol);
            this.gbIdentify.Controls.Add(this.label1);
            this.gbIdentify.Controls.Add(this.txtIdentThres);
            this.gbIdentify.Controls.Add(this.lbIdentThres);
            this.gbIdentify.Location = new System.Drawing.Point(8, 16);
            this.gbIdentify.Name = "gbIdentify";
            this.gbIdentify.Size = new System.Drawing.Size(168, 80);
            this.gbIdentify.TabIndex = 0;
            this.gbIdentify.TabStop = false;
            this.gbIdentify.Text = "Identify";
            // 
            // txtIdentRotTol
            // 
            this.txtIdentRotTol.Location = new System.Drawing.Point(112, 48);
            this.txtIdentRotTol.Name = "txtIdentRotTol";
            this.txtIdentRotTol.Size = new System.Drawing.Size(40, 20);
            this.txtIdentRotTol.TabIndex = 1;
            this.txtIdentRotTol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rotation Tolerance:";
            // 
            // txtIdentThres
            // 
            this.txtIdentThres.Location = new System.Drawing.Point(112, 24);
            this.txtIdentThres.Name = "txtIdentThres";
            this.txtIdentThres.Size = new System.Drawing.Size(40, 20);
            this.txtIdentThres.TabIndex = 0;
            this.txtIdentThres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbIdentThres
            // 
            this.lbIdentThres.AutoSize = true;
            this.lbIdentThres.Location = new System.Drawing.Point(48, 24);
            this.lbIdentThres.Name = "lbIdentThres";
            this.lbIdentThres.Size = new System.Drawing.Size(57, 13);
            this.lbIdentThres.TabIndex = 2;
            this.lbIdentThres.Text = "Threshold:";
            // 
            // gbVerify
            // 
            this.gbVerify.Controls.Add(this.txtVerifyRotTol);
            this.gbVerify.Controls.Add(this.lbVerifyRotTol);
            this.gbVerify.Controls.Add(this.txtVerifyThres);
            this.gbVerify.Controls.Add(this.lbVerifyThres);
            this.gbVerify.Location = new System.Drawing.Point(184, 16);
            this.gbVerify.Name = "gbVerify";
            this.gbVerify.Size = new System.Drawing.Size(168, 80);
            this.gbVerify.TabIndex = 1;
            this.gbVerify.TabStop = false;
            this.gbVerify.Text = "Verify";
            // 
            // txtVerifyRotTol
            // 
            this.txtVerifyRotTol.Location = new System.Drawing.Point(120, 48);
            this.txtVerifyRotTol.Name = "txtVerifyRotTol";
            this.txtVerifyRotTol.Size = new System.Drawing.Size(40, 20);
            this.txtVerifyRotTol.TabIndex = 5;
            this.txtVerifyRotTol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbVerifyRotTol
            // 
            this.lbVerifyRotTol.AutoSize = true;
            this.lbVerifyRotTol.Location = new System.Drawing.Point(16, 48);
            this.lbVerifyRotTol.Name = "lbVerifyRotTol";
            this.lbVerifyRotTol.Size = new System.Drawing.Size(101, 13);
            this.lbVerifyRotTol.TabIndex = 7;
            this.lbVerifyRotTol.Text = "Rotation Tolerance:";
            // 
            // txtVerifyThres
            // 
            this.txtVerifyThres.Location = new System.Drawing.Point(120, 24);
            this.txtVerifyThres.Name = "txtVerifyThres";
            this.txtVerifyThres.Size = new System.Drawing.Size(40, 20);
            this.txtVerifyThres.TabIndex = 4;
            this.txtVerifyThres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbVerifyThres
            // 
            this.lbVerifyThres.AutoSize = true;
            this.lbVerifyThres.Location = new System.Drawing.Point(56, 24);
            this.lbVerifyThres.Name = "lbVerifyThres";
            this.lbVerifyThres.Size = new System.Drawing.Size(57, 13);
            this.lbVerifyThres.TabIndex = 6;
            this.lbVerifyThres.Text = "Threshold:";
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(88, 392);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(72, 24);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(192, 392);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(72, 24);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            // 
            // gbMinColors
            // 
            this.gbMinColors.Controls.Add(this.cbShowMinutiaeMatch);
            this.gbMinColors.Controls.Add(this.cbShowMinutiaeReg);
            this.gbMinColors.Controls.Add(this.lbMinColorDoubleClick);
            this.gbMinColors.Controls.Add(this.lbMinColorMatch);
            this.gbMinColors.Controls.Add(this.lbMinColorReg);
            this.gbMinColors.Controls.Add(this.pbMinutiaeColorMatched);
            this.gbMinColors.Controls.Add(this.pbMinutiaeColor);
            this.gbMinColors.Location = new System.Drawing.Point(8, 104);
            this.gbMinColors.Name = "gbMinColors";
            this.gbMinColors.Size = new System.Drawing.Size(344, 88);
            this.gbMinColors.TabIndex = 4;
            this.gbMinColors.TabStop = false;
            this.gbMinColors.Text = "Minutiae Colors";
            // 
            // cbShowMinutiaeMatch
            // 
            this.cbShowMinutiaeMatch.Checked = true;
            this.cbShowMinutiaeMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMinutiaeMatch.Location = new System.Drawing.Point(160, 56);
            this.cbShowMinutiaeMatch.Name = "cbShowMinutiaeMatch";
            this.cbShowMinutiaeMatch.Size = new System.Drawing.Size(56, 16);
            this.cbShowMinutiaeMatch.TabIndex = 6;
            this.cbShowMinutiaeMatch.Text = "Show";
            // 
            // cbShowMinutiaeReg
            // 
            this.cbShowMinutiaeReg.Checked = true;
            this.cbShowMinutiaeReg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMinutiaeReg.Location = new System.Drawing.Point(160, 24);
            this.cbShowMinutiaeReg.Name = "cbShowMinutiaeReg";
            this.cbShowMinutiaeReg.Size = new System.Drawing.Size(56, 16);
            this.cbShowMinutiaeReg.TabIndex = 5;
            this.cbShowMinutiaeReg.Text = "Show";
            // 
            // lbMinColorDoubleClick
            // 
            this.lbMinColorDoubleClick.Location = new System.Drawing.Point(232, 40);
            this.lbMinColorDoubleClick.Name = "lbMinColorDoubleClick";
            this.lbMinColorDoubleClick.Size = new System.Drawing.Size(100, 32);
            this.lbMinColorDoubleClick.TabIndex = 4;
            this.lbMinColorDoubleClick.Text = "Double click the color to change it.";
            // 
            // lbMinColorMatch
            // 
            this.lbMinColorMatch.AutoSize = true;
            this.lbMinColorMatch.Location = new System.Drawing.Point(16, 56);
            this.lbMinColorMatch.Name = "lbMinColorMatch";
            this.lbMinColorMatch.Size = new System.Drawing.Size(40, 13);
            this.lbMinColorMatch.TabIndex = 3;
            this.lbMinColorMatch.Text = "Match:";
            // 
            // lbMinColorReg
            // 
            this.lbMinColorReg.AutoSize = true;
            this.lbMinColorReg.Location = new System.Drawing.Point(16, 24);
            this.lbMinColorReg.Name = "lbMinColorReg";
            this.lbMinColorReg.Size = new System.Drawing.Size(47, 13);
            this.lbMinColorReg.TabIndex = 2;
            this.lbMinColorReg.Text = "Regular:";
            // 
            // pbMinutiaeColorMatched
            // 
            this.pbMinutiaeColorMatched.BackColor = System.Drawing.Color.Purple;
            this.pbMinutiaeColorMatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMinutiaeColorMatched.Location = new System.Drawing.Point(80, 56);
            this.pbMinutiaeColorMatched.Name = "pbMinutiaeColorMatched";
            this.pbMinutiaeColorMatched.Size = new System.Drawing.Size(72, 16);
            this.pbMinutiaeColorMatched.TabIndex = 1;
            this.pbMinutiaeColorMatched.TabStop = false;
            this.pbMinutiaeColorMatched.DoubleClick += new System.EventHandler(this.pbMinutiaeColorMatched_DoubleClick);
            // 
            // pbMinutiaeColor
            // 
            this.pbMinutiaeColor.BackColor = System.Drawing.Color.Blue;
            this.pbMinutiaeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMinutiaeColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbMinutiaeColor.Location = new System.Drawing.Point(80, 24);
            this.pbMinutiaeColor.Name = "pbMinutiaeColor";
            this.pbMinutiaeColor.Size = new System.Drawing.Size(72, 16);
            this.pbMinutiaeColor.TabIndex = 0;
            this.pbMinutiaeColor.TabStop = false;
            this.pbMinutiaeColor.DoubleClick += new System.EventHandler(this.pbMinutiaeColor_DoubleClick);
            // 
            // _moduleExtract
            // 
            this._moduleExtract.Controls.Add(this.cbShowSegmentMatch);
            this._moduleExtract.Controls.Add(this.cbShowSegmentReg);
            this._moduleExtract.Controls.Add(this.lbSegColorDoubleClick);
            this._moduleExtract.Controls.Add(this.lbSegColorMatch);
            this._moduleExtract.Controls.Add(this.lbSegColorReg);
            this._moduleExtract.Controls.Add(this.pbSegmentColorMatched);
            this._moduleExtract.Controls.Add(this.pbSegmentColor);
            this._moduleExtract.Location = new System.Drawing.Point(8, 200);
            this._moduleExtract.Name = "_moduleExtract";
            this._moduleExtract.Size = new System.Drawing.Size(344, 88);
            this._moduleExtract.TabIndex = 5;
            this._moduleExtract.TabStop = false;
            this._moduleExtract.Text = "Segments Colors";
            // 
            // cbShowSegmentMatch
            // 
            this.cbShowSegmentMatch.Checked = true;
            this.cbShowSegmentMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowSegmentMatch.Location = new System.Drawing.Point(158, 56);
            this.cbShowSegmentMatch.Name = "cbShowSegmentMatch";
            this.cbShowSegmentMatch.Size = new System.Drawing.Size(56, 16);
            this.cbShowSegmentMatch.TabIndex = 13;
            this.cbShowSegmentMatch.Text = "Show";
            // 
            // cbShowSegmentReg
            // 
            this.cbShowSegmentReg.Checked = true;
            this.cbShowSegmentReg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowSegmentReg.Location = new System.Drawing.Point(158, 24);
            this.cbShowSegmentReg.Name = "cbShowSegmentReg";
            this.cbShowSegmentReg.Size = new System.Drawing.Size(56, 16);
            this.cbShowSegmentReg.TabIndex = 12;
            this.cbShowSegmentReg.Text = "Show";
            // 
            // lbSegColorDoubleClick
            // 
            this.lbSegColorDoubleClick.Location = new System.Drawing.Point(230, 40);
            this.lbSegColorDoubleClick.Name = "lbSegColorDoubleClick";
            this.lbSegColorDoubleClick.Size = new System.Drawing.Size(100, 32);
            this.lbSegColorDoubleClick.TabIndex = 11;
            this.lbSegColorDoubleClick.Text = "Double click the color to change it.";
            // 
            // lbSegColorMatch
            // 
            this.lbSegColorMatch.AutoSize = true;
            this.lbSegColorMatch.Location = new System.Drawing.Point(14, 56);
            this.lbSegColorMatch.Name = "lbSegColorMatch";
            this.lbSegColorMatch.Size = new System.Drawing.Size(40, 13);
            this.lbSegColorMatch.TabIndex = 10;
            this.lbSegColorMatch.Text = "Match:";
            // 
            // lbSegColorReg
            // 
            this.lbSegColorReg.AutoSize = true;
            this.lbSegColorReg.Location = new System.Drawing.Point(14, 24);
            this.lbSegColorReg.Name = "lbSegColorReg";
            this.lbSegColorReg.Size = new System.Drawing.Size(47, 13);
            this.lbSegColorReg.TabIndex = 9;
            this.lbSegColorReg.Text = "Regular:";
            // 
            // pbSegmentColorMatched
            // 
            this.pbSegmentColorMatched.BackColor = System.Drawing.Color.Purple;
            this.pbSegmentColorMatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegmentColorMatched.Location = new System.Drawing.Point(78, 56);
            this.pbSegmentColorMatched.Name = "pbSegmentColorMatched";
            this.pbSegmentColorMatched.Size = new System.Drawing.Size(72, 16);
            this.pbSegmentColorMatched.TabIndex = 8;
            this.pbSegmentColorMatched.TabStop = false;
            this.pbSegmentColorMatched.DoubleClick += new System.EventHandler(this.pbSegmentColorMatched_DoubleClick);
            // 
            // pbSegmentColor
            // 
            this.pbSegmentColor.BackColor = System.Drawing.Color.Lime;
            this.pbSegmentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegmentColor.Location = new System.Drawing.Point(78, 24);
            this.pbSegmentColor.Name = "pbSegmentColor";
            this.pbSegmentColor.Size = new System.Drawing.Size(72, 16);
            this.pbSegmentColor.TabIndex = 7;
            this.pbSegmentColor.TabStop = false;
            this.pbSegmentColor.DoubleClick += new System.EventHandler(this.pbSegmentColor_DoubleClick);
            // 
            // gbMinDirecColors
            // 
            this.gbMinDirecColors.Controls.Add(this.cbShowDirectionMatch);
            this.gbMinDirecColors.Controls.Add(this.cbShowDirectionReg);
            this.gbMinDirecColors.Controls.Add(this.lbDirColorDoubleClick);
            this.gbMinDirecColors.Controls.Add(this.lbMinDirColorMatch);
            this.gbMinDirecColors.Controls.Add(this.lbMinDirColorReg);
            this.gbMinDirecColors.Controls.Add(this.pbDirectionColorMatched);
            this.gbMinDirecColors.Controls.Add(this.pbDirectionColor);
            this.gbMinDirecColors.Location = new System.Drawing.Point(8, 296);
            this.gbMinDirecColors.Name = "gbMinDirecColors";
            this.gbMinDirecColors.Size = new System.Drawing.Size(344, 88);
            this.gbMinDirecColors.TabIndex = 6;
            this.gbMinDirecColors.TabStop = false;
            this.gbMinDirecColors.Text = "Minutiae Direction Colors";
            // 
            // cbShowDirectionMatch
            // 
            this.cbShowDirectionMatch.Checked = true;
            this.cbShowDirectionMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDirectionMatch.Location = new System.Drawing.Point(158, 56);
            this.cbShowDirectionMatch.Name = "cbShowDirectionMatch";
            this.cbShowDirectionMatch.Size = new System.Drawing.Size(56, 16);
            this.cbShowDirectionMatch.TabIndex = 13;
            this.cbShowDirectionMatch.Text = "Show";
            // 
            // cbShowDirectionReg
            // 
            this.cbShowDirectionReg.Checked = true;
            this.cbShowDirectionReg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDirectionReg.Location = new System.Drawing.Point(158, 24);
            this.cbShowDirectionReg.Name = "cbShowDirectionReg";
            this.cbShowDirectionReg.Size = new System.Drawing.Size(56, 16);
            this.cbShowDirectionReg.TabIndex = 12;
            this.cbShowDirectionReg.Text = "Show";
            // 
            // lbDirColorDoubleClick
            // 
            this.lbDirColorDoubleClick.Location = new System.Drawing.Point(230, 40);
            this.lbDirColorDoubleClick.Name = "lbDirColorDoubleClick";
            this.lbDirColorDoubleClick.Size = new System.Drawing.Size(100, 32);
            this.lbDirColorDoubleClick.TabIndex = 11;
            this.lbDirColorDoubleClick.Text = "Double click the color to change it.";
            // 
            // lbMinDirColorMatch
            // 
            this.lbMinDirColorMatch.AutoSize = true;
            this.lbMinDirColorMatch.Location = new System.Drawing.Point(14, 56);
            this.lbMinDirColorMatch.Name = "lbMinDirColorMatch";
            this.lbMinDirColorMatch.Size = new System.Drawing.Size(40, 13);
            this.lbMinDirColorMatch.TabIndex = 10;
            this.lbMinDirColorMatch.Text = "Match:";
            // 
            // lbMinDirColorReg
            // 
            this.lbMinDirColorReg.AutoSize = true;
            this.lbMinDirColorReg.Location = new System.Drawing.Point(14, 24);
            this.lbMinDirColorReg.Name = "lbMinDirColorReg";
            this.lbMinDirColorReg.Size = new System.Drawing.Size(47, 13);
            this.lbMinDirColorReg.TabIndex = 9;
            this.lbMinDirColorReg.Text = "Regular:";
            // 
            // pbDirectionColorMatched
            // 
            this.pbDirectionColorMatched.BackColor = System.Drawing.Color.Purple;
            this.pbDirectionColorMatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDirectionColorMatched.Location = new System.Drawing.Point(78, 56);
            this.pbDirectionColorMatched.Name = "pbDirectionColorMatched";
            this.pbDirectionColorMatched.Size = new System.Drawing.Size(72, 16);
            this.pbDirectionColorMatched.TabIndex = 8;
            this.pbDirectionColorMatched.TabStop = false;
            this.pbDirectionColorMatched.DoubleClick += new System.EventHandler(this.pbDirectionColorMatched_DoubleClick);
            // 
            // pbDirectionColor
            // 
            this.pbDirectionColor.BackColor = System.Drawing.Color.Red;
            this.pbDirectionColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDirectionColor.Location = new System.Drawing.Point(78, 24);
            this.pbDirectionColor.Name = "pbDirectionColor";
            this.pbDirectionColor.Size = new System.Drawing.Size(72, 16);
            this.pbDirectionColor.TabIndex = 7;
            this.pbDirectionColor.TabStop = false;
            this.pbDirectionColor.DoubleClick += new System.EventHandler(this.pbDirectionColor_DoubleClick);
            // 
            // formOption
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 421);
            this.Controls.Add(this.gbMinDirecColors);
            this.Controls.Add(this._moduleExtract);
            this.Controls.Add(this.gbMinColors);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbVerify);
            this.Controls.Add(this.gbIdentify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.formOption_Load);
            this.gbIdentify.ResumeLayout(false);
            this.gbIdentify.PerformLayout();
            this.gbVerify.ResumeLayout(false);
            this.gbVerify.PerformLayout();
            this.gbMinColors.ResumeLayout(false);
            this.gbMinColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinutiaeColorMatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinutiaeColor)).EndInit();
            this._moduleExtract.ResumeLayout(false);
            this._moduleExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegmentColorMatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegmentColor)).EndInit();
            this.gbMinDirecColors.ResumeLayout(false);
            this.gbMinDirecColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirectionColorMatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDirectionColor)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		// Commit changes made by user
		public void acceptChanges() 
		{
			clMinutiaeColor = pbMinutiaeColor.BackColor;
			clMinutiaeMatchColor = pbMinutiaeColorMatched.BackColor;
			clSegmentsColor = pbSegmentColor.BackColor;
			clSegmentsMatchColor = pbSegmentColorMatched.BackColor;
			clDirectionsColor = pbDirectionColor.BackColor;
			clDirectionsMatchColor = pbDirectionColorMatched.BackColor;
			bShowMinutiae = cbShowMinutiaeReg.Checked;
			bShowMinutiaeMatch = cbShowMinutiaeMatch.Checked;
			bShowSegments = cbShowSegmentReg.Checked;
			bShowSegmentsMatch = cbShowSegmentMatch.Checked;
			bShowDirections = cbShowDirectionReg.Checked;
			bShowDirectionsMatch = cbShowDirectionMatch.Checked;
		}
		
		// Set current values of threshold and rotation for verification and identification
		public void setParameters(int thresholdId, int rotationMaxId, int thresholdVr, int rotationMaxVr) 
		{
			txtIdentThres.Text = Convert.ToString(thresholdId);
			txtIdentRotTol.Text = Convert.ToString(rotationMaxId);
			txtVerifyThres.Text = Convert.ToString(thresholdVr);
			txtVerifyRotTol.Text = Convert.ToString(rotationMaxVr);
		}

		// Convert Color type to BGR format used by FingerPrint
		private int Color2BGR(Color color) 
		{
			int rgb = color.ToArgb() & 0xFFFFFF;
			return (rgb & 0xFF00) + ((rgb & 0xFF) << 16) + ((rgb & 0xFF0000) >> 16);
		}

		// Get the new values set by user
		public void getParameters(ref int thresholdId, ref int rotationMaxId, ref int thresholdVr, ref int rotationMaxVr,
					ref int minutiaeColor, ref int minutiaeMatchColor, ref int segmentsColor, ref int segmentsMatchColor,
					ref int directionsColor, ref int directionsMatchColor) 
		{
			// convert threshold and rotation values
			thresholdId = Convert.ToInt32(txtIdentThres.Text);
			rotationMaxId = Convert.ToInt32(txtIdentRotTol.Text);
			thresholdVr = Convert.ToInt32(txtVerifyThres.Text);
			rotationMaxVr = Convert.ToInt32(txtVerifyRotTol.Text);
			// convert colors to BGR
			minutiaeColor = Color2BGR(pbMinutiaeColor.BackColor);
			minutiaeMatchColor = Color2BGR(pbMinutiaeColorMatched.BackColor);
			segmentsColor = Color2BGR(pbSegmentColor.BackColor);
			segmentsMatchColor = Color2BGR(pbSegmentColorMatched.BackColor);
			directionsColor = Color2BGR(pbDirectionColor.BackColor);
			directionsMatchColor = Color2BGR(pbDirectionColorMatched.BackColor);
			// check if anything should not be displayed
			if (!cbShowMinutiaeReg.Checked) minutiaeColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
			if (!cbShowMinutiaeMatch.Checked) minutiaeMatchColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
			if (!cbShowSegmentReg.Checked) segmentsColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
			if (!cbShowSegmentMatch.Checked) segmentsMatchColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
			if (!cbShowDirectionReg.Checked) directionsColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
			if (!cbShowDirectionMatch.Checked) directionsMatchColor = (int)FingerprintConstants.GR_IMAGE_NO_COLOR;
		}

		// Set current values in GUI
		private void formOption_Load(object sender, System.EventArgs e)
		{
			// if not initialized, get initial values
			if (!initialized) acceptChanges();
			// set current values in GUI
			pbMinutiaeColor.BackColor = clMinutiaeColor;
			pbMinutiaeColorMatched.BackColor = clMinutiaeMatchColor;
			pbSegmentColor.BackColor = clSegmentsColor;
			pbSegmentColorMatched.BackColor = clSegmentsMatchColor;
			pbDirectionColor.BackColor = clDirectionsColor;
			pbDirectionColorMatched.BackColor = clDirectionsMatchColor;
			cbShowMinutiaeReg.Checked = bShowMinutiae;
			cbShowMinutiaeMatch.Checked = bShowMinutiaeMatch;
			cbShowSegmentReg.Checked = bShowSegments;
			cbShowSegmentMatch.Checked = bShowSegmentsMatch;
			cbShowDirectionReg.Checked = bShowDirections;
			cbShowDirectionMatch.Checked = bShowDirectionsMatch;
			// flag as already initialized
			initialized = true;
		}

		// display color dialog and set minutiae color
		private void pbMinutiaeColor_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbMinutiaeColor.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) {
				pbMinutiaeColor.BackColor = gridColor.Color;
			}
		}

		// display color dialog and set matching minutiae color
		private void pbMinutiaeColorMatched_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbMinutiaeColorMatched.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) 
			{
				pbMinutiaeColorMatched.BackColor = gridColor.Color;
			}
		}

		// display color dialog and set segments color
		private void pbSegmentColor_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbSegmentColor.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) 
			{
				pbSegmentColor.BackColor = gridColor.Color;
			}
		}

		// display color dialog and set matching segments color
		private void pbSegmentColorMatched_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbSegmentColorMatched.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) 
			{
				pbSegmentColorMatched.BackColor = gridColor.Color;
			}
		}

		// display color dialog and set directions color
		private void pbDirectionColor_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbDirectionColor.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) 
			{
				pbDirectionColor.BackColor = gridColor.Color;
			}
		}

		// display color dialog and set matching directions color
		private void pbDirectionColorMatched_DoubleClick(object sender, System.EventArgs e)
		{
			gridColor.Color = pbDirectionColorMatched.BackColor;
			if (gridColor.ShowDialog() == DialogResult.OK) 
			{
				pbDirectionColorMatched.BackColor = gridColor.Color;
			}
		}

		private Color clMinutiaeColor;
		private Color clMinutiaeMatchColor;
		private Color clSegmentsColor;
		private Color clSegmentsMatchColor;
		private Color clDirectionsColor;
		private Color clDirectionsMatchColor;
		private bool bShowMinutiae;
		private bool bShowMinutiaeMatch;
		private bool bShowSegments;
		private bool bShowSegmentsMatch;
		private bool bShowDirections;
		private bool bShowDirectionsMatch;
		private bool initialized;



	}
}
