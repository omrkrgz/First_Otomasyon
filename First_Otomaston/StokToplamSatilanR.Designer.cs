namespace First_Otomaston
{
    partial class StokToplamSatilanR
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FirsOtomasyonDataSet = new First_Otomaston.FirsOtomasyonDataSet();
            this.Stoklar1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stoklar1TableAdapter = new First_Otomaston.FirsOtomasyonDataSetTableAdapters.Stoklar1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FirsOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Stoklar1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "First_Otomaston.Raporlar.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(856, 310);
            this.reportViewer1.TabIndex = 0;
            // 
            // FirsOtomasyonDataSet
            // 
            this.FirsOtomasyonDataSet.DataSetName = "FirsOtomasyonDataSet";
            this.FirsOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Stoklar1BindingSource
            // 
            this.Stoklar1BindingSource.DataMember = "Stoklar1";
            this.Stoklar1BindingSource.DataSource = this.FirsOtomasyonDataSet;
            // 
            // Stoklar1TableAdapter
            // 
            this.Stoklar1TableAdapter.ClearBeforeFill = true;
            // 
            // StokToplamSatilanR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 310);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StokToplamSatilanR";
            this.Text = "Stok Bazlı Toplam Sipariş";
            this.Load += new System.EventHandler(this.StokToplamSatilanR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirsOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Stoklar1BindingSource;
        private FirsOtomasyonDataSet FirsOtomasyonDataSet;
        private FirsOtomasyonDataSetTableAdapters.Stoklar1TableAdapter Stoklar1TableAdapter;
    }
}