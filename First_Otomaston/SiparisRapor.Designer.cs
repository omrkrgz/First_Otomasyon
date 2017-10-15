namespace First_Otomaston
{
    partial class SiparisRapor
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
            this.firsOtomasyonDataSet1 = new First_Otomaston.FirsOtomasyonDataSet();
            this.FirsOtomasyonDataSet = new First_Otomaston.FirsOtomasyonDataSet();
            this.SiparislerimRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SiparislerimRTableAdapter = new First_Otomaston.FirsOtomasyonDataSetTableAdapters.SiparislerimRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firsOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirsOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparislerimRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SiparislerimRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "First_Otomaston.Raporlar.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(830, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // firsOtomasyonDataSet1
            // 
            this.firsOtomasyonDataSet1.DataSetName = "FirsOtomasyonDataSet";
            this.firsOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FirsOtomasyonDataSet
            // 
            this.FirsOtomasyonDataSet.DataSetName = "FirsOtomasyonDataSet";
            this.FirsOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SiparislerimRBindingSource
            // 
            this.SiparislerimRBindingSource.DataMember = "SiparislerimR";
            this.SiparislerimRBindingSource.DataSource = this.FirsOtomasyonDataSet;
            // 
            // SiparislerimRTableAdapter
            // 
            this.SiparislerimRTableAdapter.ClearBeforeFill = true;
            // 
            // SiparisRapor
            // 
            this.ClientSize = new System.Drawing.Size(830, 493);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SiparisRapor";
            this.Text = "Siparişlerim";
            this.Load += new System.EventHandler(this.SiparisRapor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.firsOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirsOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparislerimRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FirsOtomasyonDataSet firsOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource SiparislerimRBindingSource;
        private FirsOtomasyonDataSet FirsOtomasyonDataSet;
        private FirsOtomasyonDataSetTableAdapters.SiparislerimRTableAdapter SiparislerimRTableAdapter;
    }
}