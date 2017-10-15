namespace First_Otomaston
{
    partial class CariEkle
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
            this.btnCariGüncelle = new System.Windows.Forms.Button();
            this.btnCariKaydet = new System.Windows.Forms.Button();
            this.dataGridCariler = new System.Windows.Forms.DataGridView();
            this.mskdVK = new System.Windows.Forms.MaskedTextBox();
            this.mskdTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskdCariTelNo = new System.Windows.Forms.Label();
            this.txtCariAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.mskdVKN = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.txtYetkiliSoyad = new System.Windows.Forms.TextBox();
            this.txtYetkiliSoyadi = new System.Windows.Forms.Label();
            this.mskdTelno2 = new System.Windows.Forms.MaskedTextBox();
            this.mskdCariTelNo2 = new System.Windows.Forms.Label();
            this.txtCariAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAktifPasifDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCariGüncelle
            // 
            this.btnCariGüncelle.Location = new System.Drawing.Point(222, 474);
            this.btnCariGüncelle.Name = "btnCariGüncelle";
            this.btnCariGüncelle.Size = new System.Drawing.Size(75, 40);
            this.btnCariGüncelle.TabIndex = 74;
            this.btnCariGüncelle.Text = "Güncelle";
            this.btnCariGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnCariKaydet
            // 
            this.btnCariKaydet.Location = new System.Drawing.Point(125, 474);
            this.btnCariKaydet.Name = "btnCariKaydet";
            this.btnCariKaydet.Size = new System.Drawing.Size(75, 40);
            this.btnCariKaydet.TabIndex = 72;
            this.btnCariKaydet.Text = "Kaydet";
            this.btnCariKaydet.UseVisualStyleBackColor = true;
            this.btnCariKaydet.Click += new System.EventHandler(this.btnCariKaydet_Click);
            // 
            // dataGridCariler
            // 
            this.dataGridCariler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCariler.Location = new System.Drawing.Point(409, 22);
            this.dataGridCariler.Name = "dataGridCariler";
            this.dataGridCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCariler.Size = new System.Drawing.Size(738, 360);
            this.dataGridCariler.TabIndex = 71;
            this.dataGridCariler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCariler_CellContentClick);
            // 
            // mskdVK
            // 
            this.mskdVK.Location = new System.Drawing.Point(125, 301);
            this.mskdVK.Mask = "0000000000";
            this.mskdVK.Name = "mskdVK";
            this.mskdVK.Size = new System.Drawing.Size(161, 20);
            this.mskdVK.TabIndex = 69;
            // 
            // mskdTelNo
            // 
            this.mskdTelNo.Location = new System.Drawing.Point(125, 227);
            this.mskdTelNo.Mask = "(999) 000-0000";
            this.mskdTelNo.Name = "mskdTelNo";
            this.mskdTelNo.Size = new System.Drawing.Size(161, 20);
            this.mskdTelNo.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "KAYITLI KULLANICILAR";
            // 
            // mskdCariTelNo
            // 
            this.mskdCariTelNo.AutoSize = true;
            this.mskdCariTelNo.Location = new System.Drawing.Point(28, 230);
            this.mskdCariTelNo.Name = "mskdCariTelNo";
            this.mskdCariTelNo.Size = new System.Drawing.Size(84, 13);
            this.mskdCariTelNo.TabIndex = 64;
            this.mskdCariTelNo.Text = "Cari Telefon No:";
            // 
            // txtCariAdres
            // 
            this.txtCariAdres.AutoSize = true;
            this.txtCariAdres.Location = new System.Drawing.Point(54, 341);
            this.txtCariAdres.Name = "txtCariAdres";
            this.txtCariAdres.Size = new System.Drawing.Size(58, 13);
            this.txtCariAdres.TabIndex = 62;
            this.txtCariAdres.Text = "Cari Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(125, 338);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(266, 81);
            this.txtAdres.TabIndex = 60;
            // 
            // mskdVKN
            // 
            this.mskdVKN.AutoSize = true;
            this.mskdVKN.Location = new System.Drawing.Point(31, 304);
            this.mskdVKN.Name = "mskdVKN";
            this.mskdVKN.Size = new System.Drawing.Size(81, 13);
            this.mskdVKN.TabIndex = 58;
            this.mskdVKN.Text = "Vergi Kimlik No:";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.AutoSize = true;
            this.txtCariAdi.Location = new System.Drawing.Point(66, 82);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(46, 13);
            this.txtCariAdi.TabIndex = 57;
            this.txtCariAdi.Text = "Cari Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cari Kodu:";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(125, 42);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(161, 20);
            this.txtCariKod.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Yetkili Adı:";
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.Location = new System.Drawing.Point(125, 154);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(161, 20);
            this.txtYetkiliAdi.TabIndex = 76;
            // 
            // txtYetkiliSoyad
            // 
            this.txtYetkiliSoyad.Location = new System.Drawing.Point(125, 193);
            this.txtYetkiliSoyad.Name = "txtYetkiliSoyad";
            this.txtYetkiliSoyad.Size = new System.Drawing.Size(161, 20);
            this.txtYetkiliSoyad.TabIndex = 78;
            // 
            // txtYetkiliSoyadi
            // 
            this.txtYetkiliSoyadi.AutoSize = true;
            this.txtYetkiliSoyadi.Location = new System.Drawing.Point(39, 193);
            this.txtYetkiliSoyadi.Name = "txtYetkiliSoyadi";
            this.txtYetkiliSoyadi.Size = new System.Drawing.Size(73, 13);
            this.txtYetkiliSoyadi.TabIndex = 77;
            this.txtYetkiliSoyadi.Text = "Yetkili Soyadı:";
            // 
            // mskdTelno2
            // 
            this.mskdTelno2.Location = new System.Drawing.Point(125, 264);
            this.mskdTelno2.Mask = "(999) 000-0000";
            this.mskdTelno2.Name = "mskdTelno2";
            this.mskdTelno2.Size = new System.Drawing.Size(161, 20);
            this.mskdTelno2.TabIndex = 80;
            // 
            // mskdCariTelNo2
            // 
            this.mskdCariTelNo2.AutoSize = true;
            this.mskdCariTelNo2.Location = new System.Drawing.Point(28, 267);
            this.mskdCariTelNo2.Name = "mskdCariTelNo2";
            this.mskdCariTelNo2.Size = new System.Drawing.Size(90, 13);
            this.mskdCariTelNo2.TabIndex = 79;
            this.mskdCariTelNo2.Text = "Cari Telefon No2:";
            // 
            // txtCariAd
            // 
            this.txtCariAd.Location = new System.Drawing.Point(125, 79);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(161, 20);
            this.txtCariAd.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(292, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(292, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "*";
            // 
            // cmbAktifPasifDurum
            // 
            this.cmbAktifPasifDurum.FormattingEnabled = true;
            this.cmbAktifPasifDurum.Location = new System.Drawing.Point(125, 117);
            this.cmbAktifPasifDurum.Name = "cmbAktifPasifDurum";
            this.cmbAktifPasifDurum.Size = new System.Drawing.Size(161, 21);
            this.cmbAktifPasifDurum.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Durum:";
            // 
            // CariEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAktifPasifDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.mskdTelno2);
            this.Controls.Add(this.mskdCariTelNo2);
            this.Controls.Add(this.txtYetkiliSoyad);
            this.Controls.Add(this.txtYetkiliSoyadi);
            this.Controls.Add(this.txtYetkiliAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCariGüncelle);
            this.Controls.Add(this.btnCariKaydet);
            this.Controls.Add(this.dataGridCariler);
            this.Controls.Add(this.mskdVK);
            this.Controls.Add(this.mskdTelNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskdCariTelNo);
            this.Controls.Add(this.txtCariAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.mskdVKN);
            this.Controls.Add(this.txtCariAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariKod);
            this.Name = "CariEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Ekle";
            this.Load += new System.EventHandler(this.CariEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCariGüncelle;
        public System.Windows.Forms.Button btnCariKaydet;
        public System.Windows.Forms.DataGridView dataGridCariler;
        public System.Windows.Forms.MaskedTextBox mskdVK;
        public System.Windows.Forms.MaskedTextBox mskdTelNo;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label mskdCariTelNo;
        public System.Windows.Forms.Label txtCariAdres;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.Label mskdVKN;
        public System.Windows.Forms.Label txtCariAdi;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCariKod;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtYetkiliAdi;
        public System.Windows.Forms.TextBox txtYetkiliSoyad;
        public System.Windows.Forms.Label txtYetkiliSoyadi;
        public System.Windows.Forms.MaskedTextBox mskdTelno2;
        public System.Windows.Forms.Label mskdCariTelNo2;
        private System.Windows.Forms.TextBox txtCariAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAktifPasifDurum;
        public System.Windows.Forms.Label label3;
    }
}