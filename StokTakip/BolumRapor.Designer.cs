namespace StokTakip
{
    partial class BolumRapor
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
            this.zimmetBolumListeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StokTakipDatabaseDataSet1 = new StokTakip.StokTakipDatabaseDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zimmetBolumListeleTableAdapter = new StokTakip.StokTakipDatabaseDataSet1TableAdapters.zimmetBolumListeleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetBolumListeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTakipDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // zimmetBolumListeleBindingSource
            // 
            this.zimmetBolumListeleBindingSource.DataMember = "zimmetBolumListele";
            this.zimmetBolumListeleBindingSource.DataSource = this.StokTakipDatabaseDataSet1;
            // 
            // StokTakipDatabaseDataSet1
            // 
            this.StokTakipDatabaseDataSet1.DataSetName = "StokTakipDatabaseDataSet1";
            this.StokTakipDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.zimmetBolumListeleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakip.ReportBolum.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // zimmetBolumListeleTableAdapter
            // 
            this.zimmetBolumListeleTableAdapter.ClearBeforeFill = true;
            // 
            // BolumRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BolumRapor";
            this.Text = "BolumRapor";
            this.Load += new System.EventHandler(this.BolumRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zimmetBolumListeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTakipDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource zimmetBolumListeleBindingSource;
        private StokTakipDatabaseDataSet1 StokTakipDatabaseDataSet1;
        private StokTakipDatabaseDataSet1TableAdapters.zimmetBolumListeleTableAdapter zimmetBolumListeleTableAdapter;
    }
}