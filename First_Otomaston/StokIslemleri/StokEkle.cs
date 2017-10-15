using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace First_Otomaston
{
    public partial class StokEkle : Form
    {
        public StokEkle()
        {
            InitializeComponent();
        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();

        private void StokEkle_Load(object sender, EventArgs e)
        {
            cmbStokDurum.DataSource = db.AktifPasifDurums.ToList();
            cmbStokDurum.DisplayMember = "DurumAdi";
            cmbStokDurum.ValueMember = "Durumid";

            cmbKategoriler.DataSource = db.StokKategoris.OrderBy(x => x.KategoriAdi).ToList();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "Kategorid";


//            var q = from skt in db.Stoklars
//                    join ktgri in db.StokKategoris
//on skt.Kategori_id equals ktgri.Kategorid
//                    join durum in db.AktifPasifDurums
//on skt.Durum_id equals durum.Durumid
//                    select new
//                    {
//                        skt.Stokid,
//                        skt.StokKodu,
//                        skt.StokAdi,
//                        skt.StokAdet,
//                        skt.StokBarkod,
//                        skt.StokResmiYolu,
//                        ktgri.KategoriAdi,
//                        durum.DurumAdi
//                    };
//            dataGridStoklar.DataSource = q.OrderBy(x => x.StokAdi).ToList();
            //this.dataGridStoklar.Columns["Stokid"].Visible = false;
            //this.dataGridStoklar.Columns["StokResmiYolu"].Visible = false;
        }
        //////    this.dataGridStoklar.Columns["Stokid"].Visible = false;
        //////}

        //private byte[] byteDonustur(string path)
        //{
        //    byte[] data = null;
        //    FileInfo info = new FileInfo(path);
        //    long numbytes = info.Length;
        //    FileStream ftstream = new FileStream(path, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(ftstream);
        //    data = br.ReadBytes((int)numbytes);
        //    return data;

        //}
        public StokKategori seciliKategori { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "Kategorid";

            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                try
                {
                    if (txtStokAdi.Text=="" || txtStokKodu.Text=="")
                    {
                        MessageBox.Show("Yıldızli alanları doldurma zorunludur");
                        return;
                    }

                   else if (db.Stoklars.Any(x => x.StokKodu == txtStokKodu.Text.ToUpper()))
                    {
                        MessageBox.Show($"{txtStokKodu.Text.Trim()} bu stok kodu daha önce kullanılmış");
                        return;
                    }
                    var dosyaYolu = pictureBox1.ImageLocation.ToString();
                    var dosyaAdi = dosyaYolu.Split('\\').Last();
                    var kayitYeri = Application.StartupPath + "\\stok-resimleri\\" + dosyaAdi;
                    File.Copy(dosyaYolu, kayitYeri);


                    db.Stoklars.Add(new Stoklar
                    {
                        StokAdi = txtStokAdi.Text.ToUpper(),
                        StokBarkod = txtStokBarkodu.Text.ToUpper(),
                        StokKodu = txtStokKodu.Text.ToUpper(),
                        Kategori_id = seciliKategori.Kategorid,
                        //StokResmi = byteDonustur(this.pictureBox1.ImageLocation)//önce resim kaydeymet yapalım
                        StokResmiYolu = kayitYeri,
                        Durum_id=seciliDurum.Durumid

                    });
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
                
                db.SaveChanges();
                
                var q = from skt in db.Stoklars
                        join ktgri in db.StokKategoris
    on skt.Kategori_id equals ktgri.Kategorid
                        join durum in db.AktifPasifDurums
  on skt.Durum_id equals durum.Durumid
                        where(skt.StokKodu==txtStokKodu.Text)
                        select new
                        {
                            skt.Stokid,
                            skt.StokKodu,
                            skt.StokAdi,
                            skt.StokAdet,
                            skt.StokBarkod,
                            skt.StokResmiYolu,
                            ktgri.KategoriAdi,
                            durum.DurumAdi

                        };
                dataGridStoklar.DataSource = q.OrderBy(x => x.StokAdi).ToList();
                MessageBox.Show($"{txtStokAdi.Text.Trim().ToUpper()}  adlı stok başarıyla kayıt edildi");
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKategori = cmbKategoriler.SelectedItem as StokKategori;
        }
        public AktifPasifDurum seciliDurum { get; set; }
        private void cmbStokDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDurum = cmbStokDurum.SelectedItem as AktifPasifDurum;
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Lütfen bir resim seçiniz";
            open.Filter = "JPG|*.jpg|PNG|*.png";
            open.Multiselect = false;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = open.FileName;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridStoklar.Rows[e.RowIndex];

                txtStokKodu.Text = row.Cells["StokKodu"].Value.ToString();
                txtStokAdi.Text = row.Cells["StokAdi"].Value.ToString();
                txtStokBarkodu.Text = row.Cells["StokBarkod"].Value.ToString();
                cmbKategoriler.SelectedIndex = cmbKategoriler.FindString(row.Cells["KategoriAdi"].Value.ToString());
                //MemoryStream ms = new MemoryStream();
                ////byte img = (byte)row.Cells["StokResmi"].Value;
                //////img.Save(ms, ImageFormat.Jpeg);
                pictureBox1.ImageLocation = row.Cells["StokResmiYolu"].Value.ToString();
                cmbStokDurum.SelectedIndex = cmbStokDurum.FindString(row.Cells["DurumAdi"].Value.ToString());



            }
        }
        public Stoklar seciliStok { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dataGridStoklar.SelectedRows == null) return;
            seciliStok = db.Stoklars.Where(x => x.Stokid == seciliStok.Stokid).FirstOrDefault();

            db.Stoklars.Remove(seciliStok);


            //if (lstDepartmanlar.SelectedItem == null) return;

            //seciliDepartman = db.Departmen.Where(x => x.Departmanid == seciliDepartman.Departmanid).FirstOrDefault();
            //db.Departmen.Remove(seciliDepartman);
            //db.SaveChanges();

            //lstDepartmanlar.DisplayMember = "DepartmanAdi";
            //lstDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();

            //int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //var silinecekUrun = new UrunlerRepo().GetByID(id);
            //silinecekUrun.UrunAdı = txtUrunAdı.Text;
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //if (db.Stoklars.Any(x => x.StokKodu == txtStokKodu.Text.ToUpper()))
            //{
            //    //MessageBox.Show($"{txtStokKodu.Text.Trim()} bu stok kodu önce kullanılmış");
            //    //return;
            //}
            if (txtStokAdi.Text==""||txtStokKodu.Text=="")
            {
                MessageBox.Show("Yıldızli alanları doldurma zorunludur");
                return;
            }

         else if (MessageBox.Show($"{txtStokKodu.Text.Trim().ToUpper()}  adlı stok bilgileri güncellensin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridStoklar.SelectedRows[0].Cells[0].Value.ToString());
                var guncellenecekStok = db.Stoklars.Where(x => x.Stokid == id).FirstOrDefault();
                guncellenecekStok.StokAdi = txtStokAdi.Text.ToString().ToUpper();
                guncellenecekStok.StokKodu = txtStokKodu.Text.ToUpper();
                guncellenecekStok.StokBarkod = txtStokBarkodu.Text.ToUpper();
                guncellenecekStok.Kategori_id = int.Parse(cmbKategoriler.SelectedValue.ToString());
                guncellenecekStok.StokResmiYolu = pictureBox1.ImageLocation;
                guncellenecekStok.Durum_id = int.Parse(cmbStokDurum.SelectedValue.ToString());


                db.SaveChanges();
            }               

             var q = from skt in db.Stoklars
                      join ktgri in db.StokKategoris
  on skt.Kategori_id equals ktgri.Kategorid
                      join durum in db.AktifPasifDurums
on skt.Durum_id equals durum.Durumid
where(skt.StokKodu==txtStokKodu.Text)
                      select new
                    {
                        skt.Stokid,
                        skt.StokKodu,
                        skt.StokAdi,
                        skt.StokAdet,
                        skt.StokBarkod,
                        skt.StokResmiYolu,
                        ktgri.KategoriAdi,
                        durum.DurumAdi

                    };
            dataGridStoklar.DataSource = q.OrderBy(x => x.StokAdi).ToList();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 374;
            pictureBox1.Height = 224;
            pictureBox1.Location = new Point(358, 29);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           pictureBox1.Width = 500;
           pictureBox1.Height = 500;
           pictureBox1.Location = new Point(358, 29);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                string kelime = txtStokAra.Text.ToUpper();

                var q = from skt in db.Stoklars
                        join ktgri in db.StokKategoris
    on skt.Kategori_id equals ktgri.Kategorid
                        join durum in db.AktifPasifDurums
    on skt.Durum_id equals durum.Durumid
                        where skt.StokAdi.ToUpper().Contains(kelime) || skt.StokKodu.ToUpper().Contains(kelime)
                        select new
                        {
                            skt.Stokid,
                            skt.StokKodu,
                            skt.StokAdi,
                            skt.StokAdet,
                            skt.StokBarkod,
                            skt.StokResmiYolu,
                            ktgri.KategoriAdi,
                            durum.DurumAdi
                        };
                dataGridStoklar.DataSource = q.ToList();
                this.dataGridStoklar.Columns["Stokid"].Visible = false;
                this.dataGridStoklar.Columns["StokResmiYolu"].Visible = false;

                if (txtStokAra.Text == "")
                {
                    this.dataGridStoklar.Columns.Clear();
                }


            }
        }
    }
    
}
