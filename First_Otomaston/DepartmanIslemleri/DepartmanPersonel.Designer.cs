namespace First_Otomaston
{
    partial class DepartmanPersonel
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
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.dataGridPersoneller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(12, 12);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(210, 21);
            this.cmbDepartmanlar.TabIndex = 0;
            this.cmbDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanlar_SelectedIndexChanged);
            // 
            // dataGridPersoneller
            // 
            this.dataGridPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersoneller.Location = new System.Drawing.Point(12, 39);
            this.dataGridPersoneller.Name = "dataGridPersoneller";
            this.dataGridPersoneller.Size = new System.Drawing.Size(696, 314);
            this.dataGridPersoneller.TabIndex = 1;
            // 
            // DepartmanPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 365);
            this.Controls.Add(this.dataGridPersoneller);
            this.Controls.Add(this.cmbDepartmanlar);
            this.Name = "DepartmanPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmanPersonel";
            this.Load += new System.EventHandler(this.DepartmanPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.DataGridView dataGridPersoneller;
    }
}