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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        public Departman seciliDepartman { get; set; }
       

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDepartman = cmbDepartman.SelectedItem as Departman;
            //dataGridPersonel.DataSource = db.Personels.Where(x => x.Departman_id == seciliDepartman.Departmanid).Select(x => new
            ////{
            ////    x.Adi,
            ////    x.Soyadi,
            ////    x.Departman.DepartmanAdi
            ////}).ToList();
        }
        public AktifPasifDurum seciliDurum { get; set; }
        private void cmbAktifPasif_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDurum = cmbAktifPasif.SelectedItem as AktifPasifDurum;
        }


        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            cmbDepartman.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();
            cmbDepartman.DisplayMember = "DepartmanAdi";
            cmbDepartman.ValueMember = "Departmanid";

            cmbAktifPasif.DataSource = db.AktifPasifDurums.OrderBy(x => x.DurumAdi).ToList();
            cmbAktifPasif.DisplayMember = "DurumAdi";
            cmbAktifPasif.ValueMember = "Durumid";



            var q = from prsnl in db.Personels
                    join dprtmn in db.Departmen
on prsnl.Departman_id equals dprtmn.Departmanid
                    join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                    select new
                    {
                        prsnl.Personelid,
                        prsnl.Adi,
                        prsnl.Soyadi,
                        dprtmn.DepartmanAdi,
                        prsnl.DogumTarihi,
                        prsnl.DogumYeri,
                        prsnl.TcNo,
                        prsnl.TelefonNo,
                        prsnl.KullaniciAdi,
                        prsnl.Password,
                        prsnl.Adres,
                        durum.DurumAdi
                        
                    };
            
            dataGridPersonel.DataSource = q.ToList();
            this.dataGridPersonel.Columns["Personelid"].Visible = false;
        }
        
        public Personel tcno { get; set; }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || mskdTcNo.Text == ""|| txtDogumYeri.Text==""|| mskdDogumTarihi.Text=="")
            {
                MessageBox.Show("Yıldızlı alanları doldurunuz", "Dikkat");
                return;
            }
           else if(db.Personels.Any(x=>x.TcNo==mskdTcNo.Text))
            {
                MessageBox.Show("Bu Tc No daha önce kullanılmış", "Dikkat");
                return;
            }
           
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {

                db.Personels.Add(new Personel
                {

                    Adi = txtAd.Text.ToUpper(),
                    Soyadi = txtSoyad.Text.ToUpper(),
                    TcNo = mskdTcNo.Text,
                    DogumTarihi = mskdDogumTarihi.Text,
                    KullaniciAdi = txtKullanıcıAdi.Text.ToUpper(),
                    Password = txtSifre.Text,
                    DogumYeri = txtDogumYeri.Text,
                    TelefonNo = mskdTelNo.Text,
                    Adres = txtAdres.Text,
                    Departman_id = seciliDepartman.Departmanid,
                    Durum_id = seciliDurum.Durumid,
                    
                    

                });

                db.SaveChanges();
              
            }
            var q = from prsnl in db.Personels
                    join dprtmn in db.Departmen
on prsnl.Departman_id equals dprtmn.Departmanid
join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
where(prsnl.TcNo==mskdTcNo.Text)
                    select new 
                    {
                        prsnl.Personelid,
                        prsnl.Adi,
                        prsnl.Soyadi,
                        dprtmn.DepartmanAdi,
                        prsnl.DogumTarihi,
                        prsnl.DogumYeri,
                        prsnl.TcNo,
                        prsnl.TelefonNo,
                        prsnl.KullaniciAdi,
                        prsnl.Password,
                        prsnl.Adres,
                        durum.DurumAdi

                    
                        
                    };
            dataGridPersonel.DataSource = q.ToList();
            MessageBox.Show($"{txtAd.Text.Trim().ToUpper()} {txtSoyad.Text.Trim().ToUpper()} adlı personel kayıt edildi");
        }
        int indexrow;
        private void dataGridPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            if (e.RowIndex>= 0)
            {
                DataGridViewRow row = this.dataGridPersonel.Rows[e.RowIndex];

                txtAd.Text = row.Cells["Adi"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyadi"].Value.ToString();
                mskdTcNo.Text = row.Cells["TcNo"].Value.ToString();
                txtAdres.Text= row.Cells["Adres"].Value.ToString();
                txtDogumYeri.Text= row.Cells["DogumYeri"].Value.ToString();
                txtKullanıcıAdi.Text= row.Cells["KullaniciAdi"].Value.ToString();
                txtSifre.Text= row.Cells["Password"].Value.ToString();
                mskdDogumTarihi.Text= row.Cells["DogumTarihi"].Value.ToString();
                mskdTelNo.Text= row.Cells["TelefonNo"].Value.ToString();
                cmbDepartman.SelectedIndex = cmbDepartman.FindString(row.Cells["DepartmanAdi"].Value.ToString());
                cmbAktifPasif.SelectedIndex = cmbAktifPasif.FindString(row.Cells["DurumAdi"].Value.ToString());

            }
        }


        public Personel silinecekPersonel { get; set; }
        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridPersonel.SelectedRows[0].Cells[0].Value.ToString());
            silinecekPersonel = db.Personels.Where(x => x.Personelid == id).FirstOrDefault();

            if (db.Siparislers.Any(x => x.Personel_id == silinecekPersonel.Personelid))
            {
                MessageBox.Show("İşlem yapılan Personel silinemez", "DİKKAT");
                return;
            }

            else if (MessageBox.Show($"{silinecekPersonel.Adi.Trim()} adlı personel silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.Personels.Remove(silinecekPersonel);
                db.SaveChanges();
                MessageBox.Show($"{silinecekPersonel.Adi.Trim()} adlı personel silindi");

                var q = from prsnl in db.Personels
                        join dprtmn in db.Departmen
    on prsnl.Departman_id equals dprtmn.Departmanid
                        join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                        select new
                        {
                            prsnl.Personelid,
                            prsnl.Adi,
                            prsnl.Soyadi,
                            dprtmn.DepartmanAdi,
                            prsnl.DogumTarihi,
                            prsnl.DogumYeri,
                            prsnl.TcNo,
                            prsnl.TelefonNo,
                            prsnl.KullaniciAdi,
                            prsnl.Password,
                            prsnl.Adres,
                            durum.DurumAdi


                        };
                dataGridPersonel.DataSource = q.ToList();
            }
        }
        public Personel guncellenecekPersonel { get; set; }
        
        private void btnPersonelGüncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{txtAd.Text.Trim().ToUpper()} {txtSoyad.Text.Trim().ToUpper()} adlı personelin bilgileri güncellensin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridPersonel.SelectedRows[0].Cells[0].Value.ToString());
                var guncellenecekPersonel = db.Personels.Where(x => x.Personelid == id).FirstOrDefault();
                guncellenecekPersonel.Adi = txtAd.Text.ToUpper();
                guncellenecekPersonel.Soyadi = txtSoyad.Text.ToUpper();
                guncellenecekPersonel.Departman_id = int.Parse(cmbDepartman.SelectedValue.ToString());
                guncellenecekPersonel.KullaniciAdi = txtKullanıcıAdi.Text.ToUpper();
                guncellenecekPersonel.Password = txtSifre.Text;
                guncellenecekPersonel.Adres = txtAdres.Text;
                guncellenecekPersonel.DogumYeri = txtDogumYeri.Text.ToUpper();
                guncellenecekPersonel.TcNo = mskdTcNo.Text;
                guncellenecekPersonel.TelefonNo = mskdTelNo.Text;
                guncellenecekPersonel.DogumTarihi = mskdDogumTarihi.Text;
                guncellenecekPersonel.Durum_id = int.Parse(cmbAktifPasif.SelectedValue.ToString());

                db.SaveChanges();
            }

            var q = from prsnl in db.Personels
                    join dprtmn in db.Departmen
on prsnl.Departman_id equals dprtmn.Departmanid
                    join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                    where (prsnl.TcNo == mskdTcNo.Text)
                    select new
                    {
                        prsnl.Personelid,
                        prsnl.Adi,
                        prsnl.Soyadi,
                        dprtmn.DepartmanAdi,
                        prsnl.DogumTarihi,
                        prsnl.DogumYeri,
                        prsnl.TcNo,
                        prsnl.TelefonNo,
                        prsnl.KullaniciAdi,
                        prsnl.Password,
                        prsnl.Adres,
                        durum.DurumAdi


                    };
            //bunu yazmazsan  güncellemez
            dataGridPersonel.DataSource = q.ToList();
         

        }
       
    }
}
