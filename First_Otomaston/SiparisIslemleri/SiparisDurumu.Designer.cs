namespace First_Otomaston
{
    partial class SiparisDurumu
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
            this.txtSiparisDurum = new System.Windows.Forms.TextBox();
            this.lstDurumlar = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Eklenecek Siparis Durumu Yazınız";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(105, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 31);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(105, 136);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(77, 31);
            this.btnGüncelle.TabIndex = 20;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // txtSiparisDurum
            // 
            this.txtSiparisDurum.Location = new System.Drawing.Point(105, 62);
            this.txtSiparisDurum.Name = "txtSiparisDurum";
            this.txtSiparisDurum.Size = new System.Drawing.Size(157, 20);
            this.txtSiparisDurum.TabIndex = 18;
            // 
            // lstDurumlar
            // 
            this.lstDurumlar.FormattingEnabled = true;
            this.lstDurumlar.Location = new System.Drawing.Point(281, 62);
            this.lstDurumlar.Name = "lstDurumlar";
            this.lstDurumlar.Size = new System.Drawing.Size(182, 277);
            this.lstDurumlar.TabIndex = 17;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(105, 99);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 31);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // SiparisDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtSiparisDurum);
            this.Controls.Add(this.lstDurumlar);
            this.Controls.Add(this.btnKaydet);
            this.Name = "SiparisDurumu";
            this.Text = "SiparisDurumu";
            this.Load += new System.EventHandler(this.SiparisDurumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.TextBox txtSiparisDurum;
        public System.Windows.Forms.ListBox lstDurumlar;
        public System.Windows.Forms.Button btnKaydet;
    }
}