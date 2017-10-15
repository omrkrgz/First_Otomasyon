namespace First_Otomaston
{
    partial class TumAlisFaturalarim
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
            this.dataGridTumFatularim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumFatularim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTumFatularim
            // 
            this.dataGridTumFatularim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTumFatularim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTumFatularim.Location = new System.Drawing.Point(5, 82);
            this.dataGridTumFatularim.Name = "dataGridTumFatularim";
            this.dataGridTumFatularim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTumFatularim.Size = new System.Drawing.Size(1198, 401);
            this.dataGridTumFatularim.TabIndex = 0;
            // 
            // TumAlisFaturalarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 495);
            this.Controls.Add(this.dataGridTumFatularim);
            this.Name = "TumAlisFaturalarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TumAlisFaturalarim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TumAlisFaturalarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumFatularim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTumFatularim;
    }
}