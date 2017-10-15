namespace First_Otomaston
{
    partial class SipariseEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipariseEkle));
            this.dateTimeSiparisTrh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.İndirim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridSiparisler = new System.Windows.Forms.DataGridView();
            this.btnSiparisKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.numTutar = new System.Windows.Forms.NumericUpDown();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbPersonelSiparis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStokSiparis = new System.Windows.Forms.Label();
            this.cmbStoklarSiparis = new System.Windows.Forms.ComboBox();
            this.numericIndirim = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.SprsSil = new System.Windows.Forms.Button();
            this.sprsGuncelle = new System.Windows.Forms.Button();
            this.cmbSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCariSec = new System.Windows.Forms.ComboBox();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndirim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeSiparisTrh
            // 
            this.dateTimeSiparisTrh.Location = new System.Drawing.Point(88, 64);
            this.dateTimeSiparisTrh.Name = "dateTimeSiparisTrh";
            this.dateTimeSiparisTrh.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSiparisTrh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş Tarihi:";
            // 
            // txtSiparisAdet
            // 
            this.txtSiparisAdet.Location = new System.Drawing.Point(116, 65);
            this.txtSiparisAdet.Name = "txtSiparisAdet";
            this.txtSiparisAdet.Size = new System.Drawing.Size(200, 20);
            this.txtSiparisAdet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sipariş Adeti:";
            // 
            // İndirim
            // 
            this.İndirim.AutoSize = true;
            this.İndirim.Location = new System.Drawing.Point(41, 166);
            this.İndirim.Name = "İndirim";
            this.İndirim.Size = new System.Drawing.Size(69, 13);
            this.İndirim.TabIndex = 4;
            this.İndirim.Text = "Sipariş Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sipariş Birim Fiyati:";
            // 
            // dataGridSiparisler
            // 
            this.dataGridSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSiparisler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSiparisler.Location = new System.Drawing.Point(12, 19);
            this.dataGridSiparisler.Name = "dataGridSiparisler";
            this.dataGridSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSiparisler.Size = new System.Drawing.Size(1301, 332);
            this.dataGridSiparisler.TabIndex = 8;
            this.dataGridSiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSiparisler_CellContentClick);
            // 
            // btnSiparisKaydet
            // 
            this.btnSiparisKaydet.FlatAppearance.BorderSize = 0;
            this.btnSiparisKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisKaydet.ImageKey = "save-icon-20.png";
            this.btnSiparisKaydet.ImageList = this.ımageList1;
            this.btnSiparisKaydet.Location = new System.Drawing.Point(1149, 138);
            this.btnSiparisKaydet.Name = "btnSiparisKaydet";
            this.btnSiparisKaydet.Size = new System.Drawing.Size(62, 70);
            this.btnSiparisKaydet.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSiparisKaydet, "Siparişi Kaydet");
            this.btnSiparisKaydet.UseVisualStyleBackColor = true;
            this.btnSiparisKaydet.Click += new System.EventHandler(this.btnSiparisKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "save-icon-20.png");
            this.ımageList1.Images.SetKeyName(1, "Delete-Button-PNG-Image.png");
            this.ımageList1.Images.SetKeyName(2, "refreshicontrans.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TeslimTarihi:";
            // 
            // dateTimeTeslimTarihi
            // 
            this.dateTimeTeslimTarihi.Location = new System.Drawing.Point(88, 103);
            this.dateTimeTeslimTarihi.Name = "dateTimeTeslimTarihi";
            this.dateTimeTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTeslimTarihi.TabIndex = 10;
            // 
            // numTutar
            // 
            this.numTutar.DecimalPlaces = 2;
            this.numTutar.Location = new System.Drawing.Point(116, 164);
            this.numTutar.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTutar.Name = "numTutar";
            this.numTutar.Size = new System.Drawing.Size(200, 20);
            this.numTutar.TabIndex = 12;
            this.numTutar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numTutar_MouseClick);
            // 
            // numFiyat
            // 
            this.numFiyat.DecimalPlaces = 2;
            this.numFiyat.Location = new System.Drawing.Point(116, 98);
            this.numFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(200, 20);
            this.numFiyat.TabIndex = 13;
            this.numFiyat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numFiyat_MouseClick);
            // 
            // cmbPersonelSiparis
            // 
            this.cmbPersonelSiparis.FormattingEnabled = true;
            this.cmbPersonelSiparis.Location = new System.Drawing.Point(120, 71);
            this.cmbPersonelSiparis.Name = "cmbPersonelSiparis";
            this.cmbPersonelSiparis.Size = new System.Drawing.Size(193, 21);
            this.cmbPersonelSiparis.TabIndex = 14;
            this.cmbPersonelSiparis.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelSiparis_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Siparişi Alan Personel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cari Seçiniz:";
            // 
            // cmbStokSiparis
            // 
            this.cmbStokSiparis.AutoSize = true;
            this.cmbStokSiparis.Location = new System.Drawing.Point(44, 32);
            this.cmbStokSiparis.Name = "cmbStokSiparis";
            this.cmbStokSiparis.Size = new System.Drawing.Size(69, 13);
            this.cmbStokSiparis.TabIndex = 19;
            this.cmbStokSiparis.Text = "Stok Seçiniz:";
            // 
            // cmbStoklarSiparis
            // 
            this.cmbStoklarSiparis.FormattingEnabled = true;
            this.cmbStoklarSiparis.Location = new System.Drawing.Point(116, 29);
            this.cmbStoklarSiparis.Name = "cmbStoklarSiparis";
            this.cmbStoklarSiparis.Size = new System.Drawing.Size(200, 21);
            this.cmbStoklarSiparis.TabIndex = 18;
            this.cmbStoklarSiparis.SelectedIndexChanged += new System.EventHandler(this.cmbStoklarSiparis_SelectedIndexChanged);
            // 
            // numericIndirim
            // 
            this.numericIndirim.DecimalPlaces = 2;
            this.numericIndirim.Location = new System.Drawing.Point(116, 131);
            this.numericIndirim.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericIndirim.Name = "numericIndirim";
            this.numericIndirim.Size = new System.Drawing.Size(200, 20);
            this.numericIndirim.TabIndex = 26;
            this.numericIndirim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericIndirim_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "İndirim( tl ):";
            // 
            // SprsSil
            // 
            this.SprsSil.FlatAppearance.BorderSize = 0;
            this.SprsSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SprsSil.ImageKey = "Delete-Button-PNG-Image.png";
            this.SprsSil.ImageList = this.ımageList1;
            this.SprsSil.Location = new System.Drawing.Point(1217, 138);
            this.SprsSil.Name = "SprsSil";
            this.SprsSil.Size = new System.Drawing.Size(62, 70);
            this.SprsSil.TabIndex = 28;
            this.toolTip1.SetToolTip(this.SprsSil, "Siparişi Sil");
            this.SprsSil.UseVisualStyleBackColor = true;
            this.SprsSil.Click += new System.EventHandler(this.SprsSil_Click);
            // 
            // sprsGuncelle
            // 
            this.sprsGuncelle.FlatAppearance.BorderSize = 0;
            this.sprsGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sprsGuncelle.ImageIndex = 2;
            this.sprsGuncelle.ImageList = this.ımageList1;
            this.sprsGuncelle.Location = new System.Drawing.Point(1275, 138);
            this.sprsGuncelle.Name = "sprsGuncelle";
            this.sprsGuncelle.Size = new System.Drawing.Size(62, 70);
            this.sprsGuncelle.TabIndex = 29;
            this.toolTip1.SetToolTip(this.sprsGuncelle, "Siparişi Güncelle");
            this.sprsGuncelle.UseVisualStyleBackColor = true;
            this.sprsGuncelle.Click += new System.EventHandler(this.sprsGuncelle_Click);
            // 
            // cmbSiparisDurumu
            // 
            this.cmbSiparisDurumu.FormattingEnabled = true;
            this.cmbSiparisDurumu.Location = new System.Drawing.Point(120, 110);
            this.cmbSiparisDurumu.Name = "cmbSiparisDurumu";
            this.cmbSiparisDurumu.Size = new System.Drawing.Size(193, 21);
            this.cmbSiparisDurumu.TabIndex = 30;
            this.cmbSiparisDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbSiparisDurumu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sipariş Satıldı Mı ?";
            // 
            // cmbCariSec
            // 
            this.cmbCariSec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCariSec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbCariSec.FormattingEnabled = true;
            this.cmbCariSec.Location = new System.Drawing.Point(120, 32);
            this.cmbCariSec.Name = "cmbCariSec";
            this.cmbCariSec.Size = new System.Drawing.Size(193, 21);
            this.cmbCariSec.TabIndex = 16;
            this.cmbCariSec.SelectedIndexChanged += new System.EventHandler(this.cmbCariSiparis_SelectedIndexChanged);
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(88, 28);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(200, 20);
            this.txtSiparisNo.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Sipariş No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeTeslimTarihi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimeSiparisTrh);
            this.groupBox1.Controls.Add(this.txtSiparisNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 196);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş No ve Tarih Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericIndirim);
            this.groupBox2.Controls.Add(this.txtSiparisAdet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.İndirim);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numTutar);
            this.groupBox2.Controls.Add(this.cmbStokSiparis);
            this.groupBox2.Controls.Add(this.numFiyat);
            this.groupBox2.Controls.Add(this.cmbStoklarSiparis);
            this.groupBox2.Location = new System.Drawing.Point(380, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 196);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPersonelSiparis);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbCariSec);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbSiparisDurumu);
            this.groupBox3.Location = new System.Drawing.Point(787, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 195);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cari , Personel , Durum Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridSiparisler);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1319, 358);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıtlı Siparişler";
            // 
            // SipariseEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 596);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sprsGuncelle);
            this.Controls.Add(this.SprsSil);
            this.Controls.Add(this.btnSiparisKaydet);
            this.Name = "SipariseEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Ekle";
            this.Load += new System.EventHandler(this.SipariseEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndirim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeSiparisTrh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiparisAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label İndirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridSiparisler;
        private System.Windows.Forms.Button btnSiparisKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeTeslimTarihi;
        private System.Windows.Forms.NumericUpDown numTutar;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.ComboBox cmbPersonelSiparis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cmbStokSiparis;
        private System.Windows.Forms.ComboBox cmbStoklarSiparis;
        private System.Windows.Forms.NumericUpDown numericIndirim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SprsSil;
        private System.Windows.Forms.Button sprsGuncelle;
        private System.Windows.Forms.ComboBox cmbSiparisDurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCariSec;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}