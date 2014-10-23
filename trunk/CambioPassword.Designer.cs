namespace FingerprintNetSample
{
    partial class CambioPassword
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
            this.tittlegrupo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewConPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tittlegrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tittlegrupo
            // 
            this.tittlegrupo.Controls.Add(this.btnRestablecer);
            this.tittlegrupo.Controls.Add(this.btnCancelar);
            this.tittlegrupo.Controls.Add(this.btnGuardar);
            this.tittlegrupo.Controls.Add(this.txtNewConPass);
            this.tittlegrupo.Controls.Add(this.label3);
            this.tittlegrupo.Controls.Add(this.txtNewPass);
            this.tittlegrupo.Controls.Add(this.label2);
            this.tittlegrupo.Controls.Add(this.txtOldPass);
            this.tittlegrupo.Controls.Add(this.label1);
            this.tittlegrupo.Location = new System.Drawing.Point(12, 12);
            this.tittlegrupo.Name = "tittlegrupo";
            this.tittlegrupo.Size = new System.Drawing.Size(309, 262);
            this.tittlegrupo.TabIndex = 0;
            this.tittlegrupo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(119, 26);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(161, 20);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(119, 71);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(161, 20);
            this.txtNewPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva contraseña";
            // 
            // txtNewConPass
            // 
            this.txtNewConPass.Location = new System.Drawing.Point(119, 112);
            this.txtNewConPass.Name = "txtNewConPass";
            this.txtNewConPass.PasswordChar = '*';
            this.txtNewConPass.Size = new System.Drawing.Size(161, 20);
            this.txtNewConPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar contraseña";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Image = global::FingerprintNetSample.Properties.Resources.gnome_edit_clear__1_;
            this.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestablecer.Location = new System.Drawing.Point(107, 153);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(81, 74);
            this.btnRestablecer.TabIndex = 25;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::FingerprintNetSample.Properties.Resources.back_2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(194, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 74);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::FingerprintNetSample.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 74);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 287);
            this.Controls.Add(this.tittlegrupo);
            this.Name = "CambioPassword";
            this.Text = "Cambio contraseñas";
            this.Load += new System.EventHandler(this.CambioPassword_Load);
            this.tittlegrupo.ResumeLayout(false);
            this.tittlegrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tittlegrupo;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewConPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}