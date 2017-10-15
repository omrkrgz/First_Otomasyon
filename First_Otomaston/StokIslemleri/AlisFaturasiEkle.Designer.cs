namespace First_Otomaston
{
    partial class AlisFaturasiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisFaturasiEkle));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPersonelSec = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStokKalemiEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAlisFaturasiSil = new System.Windows.Forms.Button();
            this.btnAlisFaturasiGuncelle = new System.Windows.Forms.Button();
            this.btnAlisFaturasiKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCariSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numStokIskonto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tutar = new System.Windows.Forms.Label();
            this.numStokTutar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numStokBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numStokAdet = new System.Windows.Forms.NumericUpDown();
            this.cmbStokSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFaturaAlis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokIskonto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokAdet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Personel Seç:";
            // 
            // cmbPersonelSec
            // 
            this.cmbPersonelSec.FormattingEnabled = true;
            this.cmbPersonelSec.Location = new System.Drawing.Point(81, 24);
            this.cmbPersonelSec.Name = "cmbPersonelSec";
            this.cmbPersonelSec.Size = new System.Drawing.Size(219, 21);
            this.cmbPersonelSec.TabIndex = 8;
            this.cmbPersonelSec.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelSec_SelectedIndexChanged_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(344, 193);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(832, 217);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fatura No";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CariAdıveKodu";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "StokAdıveKodu";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BirimFiyat";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tutar";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PersonelAdı";
            this.columnHeader7.Width = 132;
            // 
            // btnStokKalemiEkle
            // 
            this.btnStokKalemiEkle.FlatAppearance.BorderSize = 0;
            this.btnStokKalemiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokKalemiEkle.ImageIndex = 4;
            this.btnStokKalemiEkle.ImageList = this.ımageList1;
            this.btnStokKalemiEkle.Location = new System.Drawing.Point(344, 416);
            this.btnStokKalemiEkle.Name = "btnStokKalemiEkle";
            this.btnStokKalemiEkle.Size = new System.Drawing.Size(53, 51);
            this.btnStokKalemiEkle.TabIndex = 21;
            this.btnStokKalemiEkle.UseVisualStyleBackColor = true;
            this.btnStokKalemiEkle.Click += new System.EventHandler(this.btnStokKalemiEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Delete-Button-PNG-Image.png");
            this.ımageList1.Images.SetKeyName(1, "Gakuseisean-Ivista-2-Start-Menu-Search.ico");
            this.ımageList1.Images.SetKeyName(2, "refreshicontrans.png");
            this.ımageList1.Images.SetKeyName(3, "save-icon-20.png");
            this.ımageList1.Images.SetKeyName(4, "indir.png");
            // 
            // btnAlisFaturasiSil
            // 
            this.btnAlisFaturasiSil.FlatAppearance.BorderSize = 0;
            this.btnAlisFaturasiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlisFaturasiSil.ImageIndex = 0;
            this.btnAlisFaturasiSil.ImageList = this.ımageList1;
            this.btnAlisFaturasiSil.Location = new System.Drawing.Point(1125, 127);
            this.btnAlisFaturasiSil.Name = "btnAlisFaturasiSil";
            this.btnAlisFaturasiSil.Size = new System.Drawing.Size(53, 51);
            this.btnAlisFaturasiSil.TabIndex = 24;
            this.btnAlisFaturasiSil.UseVisualStyleBackColor = true;
            // 
            // btnAlisFaturasiGuncelle
            // 
            this.btnAlisFaturasiGuncelle.FlatAppearance.BorderSize = 0;
            this.btnAlisFaturasiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlisFaturasiGuncelle.ImageIndex = 2;
            this.btnAlisFaturasiGuncelle.ImageList = this.ımageList1;
            this.btnAlisFaturasiGuncelle.Location = new System.Drawing.Point(1066, 127);
            this.btnAlisFaturasiGuncelle.Name = "btnAlisFaturasiGuncelle";
            this.btnAlisFaturasiGuncelle.Size = new System.Drawing.Size(53, 51);
            this.btnAlisFaturasiGuncelle.TabIndex = 23;
            this.btnAlisFaturasiGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAlisFaturasiKaydet
            // 
            this.btnAlisFaturasiKaydet.FlatAppearance.BorderSize = 0;
            this.btnAlisFaturasiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlisFaturasiKaydet.ImageIndex = 3;
            this.btnAlisFaturasiKaydet.ImageList = this.ımageList1;
            this.btnAlisFaturasiKaydet.Location = new System.Drawing.Point(997, 127);
            this.btnAlisFaturasiKaydet.Name = "btnAlisFaturasiKaydet";
            this.btnAlisFaturasiKaydet.Size = new System.Drawing.Size(53, 51);
            this.btnAlisFaturasiKaydet.TabIndex = 22;
            this.btnAlisFaturasiKaydet.UseVisualStyleBackColor = true;
            this.btnAlisFaturasiKaydet.Click += new System.EventHandler(this.btnAlisFaturasiKaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmbPersonelSec);
            this.groupBox4.Location = new System.Drawing.Point(675, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 128);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCariSec);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(344, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 128);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cari Bilgileri";
            // 
            // cmbCariSec
            // 
            this.cmbCariSec.FormattingEnabled = true;
            this.cmbCariSec.Location = new System.Drawing.Point(65, 24);
            this.cmbCariSec.Name = "cmbCariSec";
            this.cmbCariSec.Size = new System.Drawing.Size(219, 21);
            this.cmbCariSec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cari Seç:";
            // 
            // numStokIskonto
            // 
            this.numStokIskonto.Location = new System.Drawing.Point(81, 148);
            this.numStokIskonto.Name = "numStokIskonto";
            this.numStokIskonto.Size = new System.Drawing.Size(200, 20);
            this.numStokIskonto.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tutar);
            this.groupBox1.Controls.Add(this.numStokTutar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numStokIskonto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numStokBirimFiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numStokAdet);
            this.groupBox1.Controls.Add(this.cmbStokSec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Bilgileri";
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.Location = new System.Drawing.Point(36, 190);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(35, 13);
            this.Tutar.TabIndex = 12;
            this.Tutar.Text = "Tutar:";
            // 
            // numStokTutar
            // 
            this.numStokTutar.Location = new System.Drawing.Point(81, 188);
            this.numStokTutar.Name = "numStokTutar";
            this.numStokTutar.Size = new System.Drawing.Size(200, 20);
            this.numStokTutar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "İskonto( tl )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Birim Fiyat:";
            // 
            // numStokBirimFiyat
            // 
            this.numStokBirimFiyat.Location = new System.Drawing.Point(81, 111);
            this.numStokBirimFiyat.Name = "numStokBirimFiyat";
            this.numStokBirimFiyat.Size = new System.Drawing.Size(200, 20);
            this.numStokBirimFiyat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adet:";
            // 
            // numStokAdet
            // 
            this.numStokAdet.Location = new System.Drawing.Point(81, 75);
            this.numStokAdet.Name = "numStokAdet";
            this.numStokAdet.Size = new System.Drawing.Size(200, 20);
            this.numStokAdet.TabIndex = 6;
            // 
            // cmbStokSec
            // 
            this.cmbStokSec.FormattingEnabled = true;
            this.cmbStokSec.Location = new System.Drawing.Point(81, 33);
            this.cmbStokSec.Name = "cmbStokSec";
            this.cmbStokSec.Size = new System.Drawing.Size(200, 21);
            this.cmbStokSec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok Seç:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimeFaturaAlis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFaturaNo);
            this.groupBox2.Location = new System.Drawing.Point(9, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 128);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alış Tarihi:";
            // 
            // dateTimeFaturaAlis
            // 
            this.dateTimeFaturaAlis.Location = new System.Drawing.Point(77, 70);
            this.dateTimeFaturaAlis.Name = "dateTimeFaturaAlis";
            this.dateTimeFaturaAlis.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFaturaAlis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fatura No:";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(77, 34);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(200, 20);
            this.txtFaturaNo.TabIndex = 6;
            // 
            // AlisFaturasiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnStokKalemiEkle);
            this.Controls.Add(this.btnAlisFaturasiSil);
            this.Controls.Add(this.btnAlisFaturasiGuncelle);
            this.Controls.Add(this.btnAlisFaturasiKaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AlisFaturasiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlisFaturasiEkle";
            this.Load += new System.EventHandler(this.AlisFaturasiEkle_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokIskonto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStokTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokAdet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPersonelSec;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnStokKalemiEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAlisFaturasiSil;
        private System.Windows.Forms.Button btnAlisFaturasiGuncelle;
        private System.Windows.Forms.Button btnAlisFaturasiKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCariSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numStokIskonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Tutar;
        private System.Windows.Forms.NumericUpDown numStokTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numStokBirimFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStokAdet;
        private System.Windows.Forms.ComboBox cmbStokSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFaturaAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaturaNo;
    }
}