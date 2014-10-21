namespace FingerprintNetSample
{
    partial class Reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bd_esDataSet = new FingerprintNetSample.bd_esDataSet();
            this.es_entradassalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.es_entradassalidasTableAdapter = new FingerprintNetSample.bd_esDataSetTableAdapters.es_entradassalidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bd_esDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.es_entradassalidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.es_entradassalidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FingerprintNetSample.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(66, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bd_esDataSet
            // 
            this.bd_esDataSet.DataSetName = "bd_esDataSet";
            this.bd_esDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // es_entradassalidasBindingSource
            // 
            this.es_entradassalidasBindingSource.DataMember = "es_entradassalidas";
            this.es_entradassalidasBindingSource.DataSource = this.bd_esDataSet;
            // 
            // es_entradassalidasTableAdapter
            // 
            this.es_entradassalidasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_esDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.es_entradassalidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource es_entradassalidasBindingSource;
        private bd_esDataSet bd_esDataSet;
        private bd_esDataSetTableAdapters.es_entradassalidasTableAdapter es_entradassalidasTableAdapter;
    }
}