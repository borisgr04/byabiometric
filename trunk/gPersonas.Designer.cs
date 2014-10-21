namespace FingerprintNetSample
{
    partial class gPersonas
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
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrarHuella = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cedulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPersonas
            // 
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Location = new System.Drawing.Point(12, 82);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.Size = new System.Drawing.Size(799, 256);
            this.dgPersonas.TabIndex = 0;
            this.dgPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de personas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(298, 357);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(92, 35);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(396, 357);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrarHuella
            // 
            this.btnRegistrarHuella.Location = new System.Drawing.Point(494, 357);
            this.btnRegistrarHuella.Name = "btnRegistrarHuella";
            this.btnRegistrarHuella.Size = new System.Drawing.Size(92, 35);
            this.btnRegistrarHuella.TabIndex = 5;
            this.btnRegistrarHuella.Text = "Registrar huella";
            this.btnRegistrarHuella.UseVisualStyleBackColor = true;
            this.btnRegistrarHuella.Click += new System.EventHandler(this.btnRegistrarHuella_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroESToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registroESToolStripMenuItem
            // 
            this.registroESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cedulaToolStripMenuItem,
            this.huellaToolStripMenuItem});
            this.registroESToolStripMenuItem.Name = "registroESToolStripMenuItem";
            this.registroESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registroESToolStripMenuItem.Text = "Registro E/S";
            // 
            // cedulaToolStripMenuItem
            // 
            this.cedulaToolStripMenuItem.Name = "cedulaToolStripMenuItem";
            this.cedulaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cedulaToolStripMenuItem.Text = "Cedula";
            // 
            // huellaToolStripMenuItem
            // 
            this.huellaToolStripMenuItem.Name = "huellaToolStripMenuItem";
            this.huellaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.huellaToolStripMenuItem.Text = "Huella";
            this.huellaToolStripMenuItem.Click += new System.EventHandler(this.huellaToolStripMenuItem_Click);
            // 
            // gPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 415);
            this.Controls.Add(this.btnRegistrarHuella);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPersonas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gPersonas";
            this.Text = "Gestion de personas";
            this.Load += new System.EventHandler(this.gPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrarHuella;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cedulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huellaToolStripMenuItem;
    }
}