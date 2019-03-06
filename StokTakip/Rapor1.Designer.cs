namespace StokTakip
{
    partial class Rapor1
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
            this.zimmetKisiListeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StokTakipDatabaseDataSet = new StokTakip.StokTakipDatabaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zimmetKisiListeleTableAdapter = new StokTakip.StokTakipDatabaseDataSetTableAdapters.zimmetKisiListeleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetKisiListeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTakipDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zimmetKisiListeleBindingSource
            // 
            this.zimmetKisiListeleBindingSource.DataMember = "zimmetKisiListele";
            this.zimmetKisiListeleBindingSource.DataSource = this.StokTakipDatabaseDataSet;
            // 
            // StokTakipDatabaseDataSet
            // 
            this.StokTakipDatabaseDataSet.DataSetName = "StokTakipDatabaseDataSet";
            this.StokTakipDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.zimmetKisiListeleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakip.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // zimmetKisiListeleTableAdapter
            // 
            this.zimmetKisiListeleTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rapor1";
            this.Text = "Rapor1";
            this.Load += new System.EventHandler(this.Rapor1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zimmetKisiListeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTakipDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource zimmetKisiListeleBindingSource;
        private StokTakipDatabaseDataSet StokTakipDatabaseDataSet;
        private StokTakipDatabaseDataSetTableAdapters.zimmetKisiListeleTableAdapter zimmetKisiListeleTableAdapter;
    }
}