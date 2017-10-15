using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Otomaston
{
    public partial class SipariseEkle : Form
    {
        public SipariseEkle()
        {
            InitializeComponent();
        }

        public void siparisleriListele()
        {
            var q = from cariler in db.Carilers
                    join sprsdety in db.Siparislers
on cariler.CariId equals sprsdety.Cari_id
                    join prsnl in db.Personels
on sprsdety.Personel_id equals prsnl.Personelid
                    join stklr in db.Stoklars
on sprsdety.Stok_id equals stklr.Stokid
                    join durum in db.SiparisDurums
on sprsdety.Durum_id equals durum.DurumId
where(sprsdety.SiparisNo==txtSiparisNo.Text)
                    select new
                    {
                        
                        sprsdety.SiparisId,
                        sprsdety.SiparisNo,
                        sprsdety.SiparisTarihi,
                        durum.DurumAdi,
                        StokAdıveStokKodu = stklr.StokAdi.Trim() + " " + stklr.StokKodu,
                        //stklr.StokKodu,
                        //stklr.StokAdi,
                        sprsdety.SiparisAdet,
                        sprsdety.SiparisFiyat,
                        İndirim = sprsdety.indirim,
                        sprsdety.SiparisTutar,
                        //cariler.CariAdi,
                        //cariler.CariKod,
                        CariAdıveKodu = cariler.CariAdi.Trim() + " " + cariler.CariKod,
                        PersonelAdı = prsnl.Adi,
                        PersonelSoyadı = prsnl.Soyadi,
                        sprsdety.TeslimTarihi


                    };
            dataGridSiparisler.DataSource = q.ToList();
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

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            if (txtSiparisAdet.Text == "" || txtSiparisNo.Text=="" || numFiyat.Value == 0 || numTutar.Value == 0 || cmbCariSec.SelectedIndex== -1 || cmbStoklarSiparis.SelectedIndex== -1 || cmbPersonelSiparis.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                return;
            }
            else if (db.Siparislers.Any(x => x.SiparisNo == txtSiparisNo.Text.ToUpper()))
            {
                MessageBox.Show($"{txtSiparisNo.Text.Trim()} bu sipariş kodu daha önce kullanılmış");
                return;
            }
            //decimal fiyat = Convert.ToDecimal(numFiyat.Value);
            //decimal adet = Convert.ToDecimal(txtSiparisAdet.Text);
            //decimal tutar = fiyat * adet;
            //numTutar.Text = tutar.ToString();
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {

                db.Siparislers.Add(new Siparisler
                {
                    SiparisNo = txtSiparisNo.Text.ToUpper(),  
                    SiparisTarihi = dateTimeSiparisTrh.Value,
                    TeslimTarihi = dateTimeTeslimTarihi.Value,
                    SiparisAdet = int.Parse(txtSiparisAdet.Text),
                    SiparisFiyat = numFiyat.Value,
                    indirim = numericIndirim.Value,
                    SiparisTutar = ((numFiyat.Value) * int.Parse(txtSiparisAdet.Text)) -
                    numericIndirim.Value,
                    Personel_id = seciliPersonel.Personelid,
                    Cari_id = int.Parse(cmbCariSec.SelectedValue.ToString()),
                    Stok_id = int.Parse(cmbStoklarSiparis.SelectedValue.ToString()),
                    Durum_id =seciliDurum.DurumId
  
                });

                db.SaveChanges();
                 MessageBox.Show($"SiparisNo:{txtSiparisNo.Text.Trim().ToUpper()} Tutar:{numTutar.Value} siparis kayıt edildi","BİLGİ");


                siparisleriListele();
                formuTemizle();
            }
        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
       

        private void SipariseEkle_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection collectionstok = new AutoCompleteStringCollection();

            List<Stoklar> stokgor = db.Stoklars.Where(x=>x.AktifPasifDurum.DurumAdi=="Aktif").ToList();
            foreach (var item in stokgor)
            {
                collectionstok.Add(item.StokAdi.Trim() + " " + item.StokKodu);
            }

            cmbStoklarSiparis.DataSource = db.Stoklars.Where(x=>x.AktifPasifDurum.DurumAdi=="Aktif").Select(x => new
            {
                x.Stokid,
                StokAdıveStokKodu = x.StokAdi.Trim() + " " + x.StokKodu,
            }).ToList();

            cmbStoklarSiparis.DisplayMember = "StokAdıveStokKodu";
            cmbStoklarSiparis.ValueMember = "Stokid";
            cmbStoklarSiparis.AutoCompleteCustomSource = collectionstok;
            //Combobox'umuzun otomatik tamamlama türünü seçiyoruz.
            cmbStoklarSiparis.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Combobox'umuzun AutoCompleteSource özelliğinin CustomSource türünde bir yapı olacağını bildiriyoruz.
            cmbStoklarSiparis.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            List<Cariler> carigor = db.Carilers.Where(x=>x.AktifPasifDurum.DurumAdi=="Aktif").ToList();
            foreach (var item in carigor)
            {
                collection.Add(item.CariAdi.Trim()+" "+item.CariKod);
            }

            cmbCariSec.DataSource = db.Carilers.Where(x=>x.AktifPasifDurum.DurumAdi=="Aktif").Select(x => new
            {
                x.CariId,
                CariAdıveKodu = x.CariAdi.Trim()+" "+x.CariKod,
            }).ToList();

            cmbCariSec.DisplayMember = "CariAdıveKodu";
            cmbCariSec.ValueMember="CariId";
            cmbCariSec.AutoCompleteCustomSource = collection;
            //Combobox'umuzun otomatik tamamlama türünü seçiyoruz.
            cmbCariSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Combobox'umuzun AutoCompleteSource özelliğinin CustomSource türünde bir yapı olacağını bildiriyoruz.
            cmbCariSec.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmbCariSec.SelectedIndex = -1;
            cmbStoklarSiparis.SelectedIndex = -1;



            cmbPersonelSiparis.DataSource = db.Personels.Where(x => x.AktifPasifDurum.DurumAdi == "Aktif").ToList();
            cmbPersonelSiparis.DisplayMember = "Adi";
            cmbPersonelSiparis.ValueMember = "Personelid";

            cmbSiparisDurumu.DataSource = db.SiparisDurums.ToList();
            cmbSiparisDurumu.DisplayMember = "DurumAdi";
            cmbSiparisDurumu.ValueMember = "DurumId";


            var q = from cariler in db.Carilers
                    join sprsdety in db.Siparislers
                    on cariler.CariId equals sprsdety.Cari_id
                   join prsnl in db.Personels
                    on sprsdety.Personel_id equals prsnl.Personelid
                     join stklr in db.Stoklars
                    on sprsdety.Stok_id equals stklr.Stokid
                   join durum in db.SiparisDurums
                    on sprsdety.Durum_id equals durum.DurumId
                 
                    select new
                    {

                        sprsdety.SiparisId,
                        sprsdety.SiparisNo,
                        sprsdety.SiparisTarihi,
                        durum.DurumAdi,
                        StokAdıveStokKodu = stklr.StokAdi.Trim() + " " + stklr.StokKodu,
                        //stklr.StokKodu,
                        //stklr.StokAdi,
                        sprsdety.SiparisAdet,
                        sprsdety.SiparisFiyat,
                        İndirim = sprsdety.indirim,
                        sprsdety.SiparisTutar,
                        //cariler.CariAdi,
                        //cariler.CariKod,
                        CariAdıveKodu = cariler.CariAdi.Trim() + " " + cariler.CariKod,
                        PersonelAdı = prsnl.Adi,
                        PersonelSoyadı = prsnl.Soyadi,
                        sprsdety.TeslimTarihi


                    };
            dataGridSiparisler.DataSource = q.ToList();



            cmbCariSec.SelectedIndex = -1;
            cmbStoklarSiparis.SelectedIndex = -1;
            this.dataGridSiparisler.Columns["SiparisId"].Visible = false;
        }
        public Stoklar seciliStok { get; set; }
        private void cmbStoklarSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliStok = cmbStoklarSiparis.SelectedItem as Stoklar;
        }
        public Personel seciliPersonel { get; set; }
        private void cmbPersonelSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliPersonel = cmbPersonelSiparis.SelectedItem as Personel;
        }
        public Cariler seciliCari { get; set; }
        private void cmbCariSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliCari = cmbCariSec.SelectedItem as Cariler;
            
           
        }

        public SiparisDurum seciliDurum { get; set; }

        private void cmbSiparisDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDurum = cmbSiparisDurumu.SelectedItem as SiparisDurum;
        }

        private void numTutar_MouseClick(object sender, MouseEventArgs e)
        {
           
            decimal fiyat = numFiyat.Value;
            decimal adet = int.Parse(txtSiparisAdet.Text);
            decimal indirim = numericIndirim.Value;

            decimal tutar = (fiyat * adet) - indirim;
            numTutar.Value = tutar;
        }


        private void numFiyat_MouseClick(object sender, MouseEventArgs e)
        {
            if (numFiyat.Text=="0,00")
            {
                numFiyat.Text = "";
            }
            
        }

        private void dataGridSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridSiparisler.Rows.Count == 0 && dataGridSiparisler.Rows == null)
            //{
            //    return;
            //}

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridSiparisler.Rows[e.RowIndex];

                cmbStoklarSiparis.SelectedIndex = cmbStoklarSiparis.FindString(row.Cells["StokAdıveStokKodu"].Value.ToString());
                cmbCariSec.SelectedIndex = cmbCariSec.FindString(row.Cells["CariAdıveKodu"].Value.ToString());
                cmbPersonelSiparis.SelectedIndex = cmbPersonelSiparis.FindString(row.Cells["PersonelAdı"].Value.ToString());
                cmbSiparisDurumu.SelectedIndex = cmbSiparisDurumu.FindString(row.Cells["DurumAdi"].Value.ToString());
                txtSiparisNo.Text= row.Cells["SiparisNo"].Value.ToString();
                txtSiparisAdet.Text = row.Cells["SiparisAdet"].Value.ToString();
                numFiyat.Value = Convert.ToDecimal(row.Cells["SiparisFiyat"].Value.ToString());
                numTutar.Value= Convert.ToDecimal(row.Cells["SiparisTutar"].Value.ToString());
                numericIndirim.Value= Convert.ToDecimal(row.Cells["İndirim"].Value.ToString());
                dateTimeSiparisTrh.Value= Convert.ToDateTime(row.Cells["SiparisTarihi"].Value.ToString());
                dateTimeTeslimTarihi.Value = Convert.ToDateTime(row.Cells["TeslimTarihi"].Value.ToString());


                //txtStokAdi.Text = row.Cells["StokAdi"].Value.ToString();
                //txtStokBarkodu.Text = row.Cells["StokBarkod"].Value.ToString();
                ////MemoryStream ms = new MemoryStream();
                //////byte img = (byte)row.Cells["StokResmi"].Value;
                ////////img.Save(ms, ImageFormat.Jpeg);
                //pictureBox1.ImageLocation = row.Cells["StokResmiYolu"].Value.ToString();
            }
           

        }

        private void numericIndirim_MouseClick(object sender, MouseEventArgs e)
        {
            if (numericIndirim.Text == "0,00")
            {
                numericIndirim.Text = "";
            }
        }

        private void SprsSil_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dataGridSiparisler.SelectedRows[0].Cells[0].Value.ToString());
            var silinecekSiparis = db.Siparislers.Where(x => x.SiparisId == id).FirstOrDefault();

            if (MessageBox.Show($"{silinecekSiparis.SiparisNo} numaralı sipariş silinsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Siparislers.Remove(silinecekSiparis);
                db.SaveChanges();
            }
            else
            {
                return;
            }

            siparisleriListele();



        }
        public Siparisler guncellenecekSiparis { get; set; }
        private void sprsGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSiparisNo.Text == "") return;

            {
                int id = int.Parse(dataGridSiparisler.SelectedRows[0].Cells[0].Value.ToString());
                guncellenecekSiparis = db.Siparislers.Where(x => x.SiparisId == id).FirstOrDefault();
                guncellenecekSiparis.SiparisNo = txtSiparisNo.Text;
                guncellenecekSiparis.SiparisTarihi = dateTimeSiparisTrh.Value;
                guncellenecekSiparis.TeslimTarihi = dateTimeTeslimTarihi.Value;
                guncellenecekSiparis.Durum_id = int.Parse(cmbSiparisDurumu.SelectedValue.ToString());
                guncellenecekSiparis.Stok_id = int.Parse(cmbStoklarSiparis.SelectedValue.ToString());
                guncellenecekSiparis.Cari_id = int.Parse(cmbCariSec.SelectedValue.ToString());
                guncellenecekSiparis.Personel_id = int.Parse(cmbPersonelSiparis.SelectedValue.ToString());
                guncellenecekSiparis.SiparisAdet = int.Parse(txtSiparisAdet.Text.ToString());
                guncellenecekSiparis.SiparisFiyat = numFiyat.Value;
                guncellenecekSiparis.SiparisTutar = numTutar.Value;
                guncellenecekSiparis.indirim = numericIndirim.Value;
            }
            if (MessageBox.Show($"{guncellenecekSiparis.SiparisNo} nolu sipariş güncellensin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.SaveChanges();
                MessageBox.Show($"{guncellenecekSiparis.SiparisNo} nolu sipariş güncellendi ?");
                siparisleriListele();
            }

                

           
        }


    }
    
}

