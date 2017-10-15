namespace First_Otomaston
{
    partial class DepartmanEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtDepartmanAra = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.lstDepartmanlar = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Eklenecek Departmanı Yazınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(11, 178);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 31);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(11, 141);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(77, 31);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtDepartmanAra
            // 
            this.txtDepartmanAra.Location = new System.Drawing.Point(203, 32);
            this.txtDepartmanAra.Name = "txtDepartmanAra";
            this.txtDepartmanAra.Size = new System.Drawing.Size(157, 20);
            this.txtDepartmanAra.TabIndex = 10;
            this.txtDepartmanAra.TextChanged += new System.EventHandler(this.txtDepartmanAra_TextChanged);
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(11, 58);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(157, 20);
            this.txtDepartman.TabIndex = 9;
            this.txtDepartman.TextChanged += new System.EventHandler(this.txtDepartman_TextChanged);
            // 
            // lstDepartmanlar
            // 
            this.lstDepartmanlar.FormattingEnabled = true;
            this.lstDepartmanlar.Location = new System.Drawing.Point(203, 58);
            this.lstDepartmanlar.Name = "lstDepartmanlar";
            this.lstDepartmanlar.Size = new System.Drawing.Size(182, 277);
            this.lstDepartmanlar.TabIndex = 8;
            this.lstDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.lstDepartmanlar_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(11, 104);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 31);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtDepartmanAra);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.lstDepartmanlar);
            this.Controls.Add(this.btnKaydet);
            this.Name = "DepartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmanEkle";
            this.Load += new System.EventHandler(this.DepartmanEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.TextBox txtDepartmanAra;
        public System.Windows.Forms.TextBox txtDepartman;
        public System.Windows.Forms.ListBox lstDepartmanlar;
        public System.Windows.Forms.Button btnKaydet;
    }
}