using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Otomaston
{
    public partial class StokKatEkle : Form
    {
        public StokKatEkle()
        {
            InitializeComponent();
        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        public StokKategori seciliKategori { get; set; }

        private void StokKatEkle_Load(object sender, EventArgs e)
        {
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = db.StokKategoris.OrderBy(x => x.KategoriAdi).ToList();
        }


        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                db.StokKategoris.Add(new StokKategori
                {
                    KategoriAdi = txtKategori.Text.ToUpper()
                });
                db.SaveChanges();
            }
            txtKategori.Clear();
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = db.StokKategoris.OrderBy(x => x.KategoriAdi).ToList();
            formuTemizle();
        }
        public void formuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is MaskedTextBox)
                    item.Text = string.Empty;
                else if (item is NumericUpDown)
                    item.Text = string.Empty;

            }
        }

        private void lstKategoriler_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;
            seciliKategori = lstKategoriler.SelectedItem as StokKategori;
            txtKategori.Text = seciliKategori.KategoriAdi;
        }
        private void btnSil_Click_1(object sender, EventArgs e)
        {

            if (lstKategoriler.SelectedItem == null) return;

            else if (db.Stoklars.Any(x => x.Kategori_id == seciliKategori.Kategorid))
            {
                MessageBox.Show("Kullanılan Kategori Silinemez", "BİLGİ");
                return;
            }

            seciliKategori = db.StokKategoris.Where(x => x.Kategorid == seciliKategori.Kategorid).FirstOrDefault();

            if (MessageBox.Show($"{seciliKategori.KategoriAdi.Trim()} kategorisi silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.StokKategoris.Remove(seciliKategori);
                db.SaveChanges();
                MessageBox.Show($"{seciliKategori.KategoriAdi.Trim()} kategorisi silindi");
            }

            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = db.StokKategoris.OrderBy(x => x.KategoriAdi).ToList();
        }
        private void txtKategoriAra_TextChanged_1(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                lstKategoriler.DisplayMember = "KategoriAdi";
                string kelime = txtKategoriAra.Text.ToLower();
                lstKategoriler.DataSource = db.StokKategoris.Where(x => x.KategoriAdi.ToLower().Contains(kelime)).ToList();
            }
        }

        public StokKategori guncellenecekKategori { get; set; }
        
        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            if (seciliKategori == null) return;

            guncellenecekKategori = db.StokKategoris.Where(x => x.Kategorid == seciliKategori.Kategorid).FirstOrDefault();

            guncellenecekKategori.KategoriAdi = txtKategori.Text.ToUpper();
            db.SaveChanges();
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = db.StokKategoris.OrderBy(x => x.KategoriAdi).ToList();
        }

        
    }
}
