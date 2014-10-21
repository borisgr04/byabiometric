namespace FingerprintNetSample
{
    partial class RegistrosES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosES));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvwFPReaders = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThreshold2 = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.tsslStatusMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startEnrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgbMatching = new FingerprintNetSample.ColorProgressBar();
            this.prgbQuality = new FingerprintNetSample.ColorProgressBar();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 360);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lvwFPReaders);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(384, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 360);
            this.panel5.TabIndex = 2;
            // 
            // lvwFPReaders
            // 
            this.lvwFPReaders.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvwFPReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFPReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFPReaders.GridLines = true;
            this.lvwFPReaders.LabelWrap = false;
            this.lvwFPReaders.LargeImageList = this.imageList1;
            this.lvwFPReaders.Location = new System.Drawing.Point(0, 0);
            this.lvwFPReaders.MultiSelect = false;
            this.lvwFPReaders.Name = "lvwFPReaders";
            this.lvwFPReaders.ShowGroups = false;
            this.lvwFPReaders.Size = new System.Drawing.Size(166, 358);
            this.lvwFPReaders.TabIndex = 0;
            this.lvwFPReaders.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sensorFingerIn.bmp");
            this.imageList1.Images.SetKeyName(1, "sensorFingerout.bmp");
            this.imageList1.Images.SetKeyName(2, "sensorFingerImageCap.bmp");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(392, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 357);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(390, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem,
            this.openImageToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(68, 48);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 537);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.lblThreshold2);
            this.panel3.Controls.Add(this.lblThreshold);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblQuality);
            this.panel3.Controls.Add(this.prgbMatching);
            this.panel3.Controls.Add(this.prgbQuality);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 177);
            this.panel3.TabIndex = 4;
            // 
            // lblThreshold2
            // 
            this.lblThreshold2.AutoSize = true;
            this.lblThreshold2.Location = new System.Drawing.Point(12, 113);
            this.lblThreshold2.Name = "lblThreshold2";
            this.lblThreshold2.Size = new System.Drawing.Size(46, 13);
            this.lblThreshold2.TabIndex = 7;
            this.lblThreshold2.Text = "Humbral";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(12, 97);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(9, 13);
            this.lblThreshold.TabIndex = 6;
            this.lblThreshold.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comparacíon";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(3, 5);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(99, 13);
            this.lblQuality.TabIndex = 2;
            this.lblQuality.Text = "Calidad de la huella";
            // 
            // tsslStatusMessages
            // 
            this.tsslStatusMessages.Name = "tsslStatusMessages";
            this.tsslStatusMessages.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // enrollToolStripMenuItem
            // 
            this.enrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollToolStripMenuItem1,
            this.startEnrollToolStripMenuItem});
            this.enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            this.enrollToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.enrollToolStripMenuItem.Text = "Enroll";
            // 
            // enrollToolStripMenuItem1
            // 
            this.enrollToolStripMenuItem1.Name = "enrollToolStripMenuItem1";
            this.enrollToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.enrollToolStripMenuItem1.Text = "Enroll";
            this.enrollToolStripMenuItem1.Click += new System.EventHandler(this.enrollToolStripMenuItem1_Click);
            // 
            // startEnrollToolStripMenuItem
            // 
            this.startEnrollToolStripMenuItem.Name = "startEnrollToolStripMenuItem";
            this.startEnrollToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startEnrollToolStripMenuItem.Text = "Start Enroll";
            this.startEnrollToolStripMenuItem.Click += new System.EventHandler(this.startEnrollToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 151);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatusMessage
            // 
            this.tsslStatusMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslStatusMessage.Name = "tsslStatusMessage";
            this.tsslStatusMessage.Size = new System.Drawing.Size(159, 21);
            this.tsslStatusMessage.Text = "toolStripStatusLabel1";
            // 
            // prgbMatching
            // 
            this.prgbMatching.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prgbMatching.Location = new System.Drawing.Point(-9, 87);
            this.prgbMatching.Maximum = 200;
            this.prgbMatching.Minimum = 0;
            this.prgbMatching.Name = "prgbMatching";
            this.prgbMatching.ProgressBarColor = System.Drawing.Color.Blue;
            this.prgbMatching.Size = new System.Drawing.Size(549, 23);
            this.prgbMatching.Step = 0;
            this.prgbMatching.TabIndex = 1;
            this.prgbMatching.Value = 0;
            // 
            // prgbQuality
            // 
            this.prgbQuality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prgbQuality.Location = new System.Drawing.Point(3, 20);
            this.prgbQuality.Maximum = 100;
            this.prgbQuality.Minimum = 0;
            this.prgbQuality.Name = "prgbQuality";
            this.prgbQuality.ProgressBarColor = System.Drawing.Color.WhiteSmoke;
            this.prgbQuality.Size = new System.Drawing.Size(549, 23);
            this.prgbQuality.Step = 0;
            this.prgbQuality.TabIndex = 0;
            this.prgbQuality.Value = 0;
            // 
            // RegistrosES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 537);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(568, 576);
            this.Name = "RegistrosES";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Entradas y  Salidas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuality;
        //        private System.Windows.Forms.ProgressBar prgbMatching;
        private ColorProgressBar prgbQuality;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessages;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        
        
        
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;                                
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startEnrollToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvwFPReaders;
        private System.Windows.Forms.Label lblThreshold2;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ColorProgressBar prgbMatching;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessage;

    }
}

