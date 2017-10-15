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
    public partial class CariEkle : Form
    {
        public CariEkle()
        {
            InitializeComponent();
        }
        public void carileriListele()
        {
            dataGridCariler.DataSource = db.Carilers.Select(x => new
            {
                x.CariKod,
                x.CariAdi,
                x.YetkiliAdi,
                x.YetkiliSoyadi,
                x.CariTelNo,
                x.CariTelNo2,
                x.CariAdres,
                x.CariVKN,
                x.AktifPasifDurum.DurumAdi
            }).ToList();

        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        private void btnCariKaydet_Click(object sender, EventArgs e)
        {

            if (txtCariKod.Text == "" || txtCariAdi.Text == "")
            {
                MessageBox.Show("Yıldızlı(*) alanları doldurma zorunludur","Dikkat");
                return;
            }
            else if (db.Carilers.Any(x => x.CariKod == txtCariKod.Text.ToUpper()))
            {
                MessageBox.Show($"{txtCariKod.Text.Trim()} bu cari kodu daha önce kullanılmış","Dikkat");
                return;
            }


                using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {

                db.Carilers.Add(new Cariler()
                {
                    CariKod = txtCariKod.Text.ToUpper(),
                    CariAdi = txtCariAd.Text.ToUpper(),
                    YetkiliAdi = txtYetkiliAdi.Text.ToUpper(),
                    YetkiliSoyadi=txtYetkiliSoyad.Text.ToUpper(),
                    CariAdres = txtAdres.Text.ToUpper(),
                    CariTelNo = mskdTelNo.Text.ToUpper(),
                    CariTelNo2 = mskdTelno2.Text.ToUpper(),
                    CariVKN = mskdVK.Text.ToUpper(),
                    Durum_id = int.Parse(cmbAktifPasifDurum.SelectedValue.ToString())
                    

                });
                if (db.Carilers.Any(x => x.CariKod == txtCariKod.Text.ToUpper()))
                {
                    MessageBox.Show($"{txtCariKod.Text.ToUpper()} bu cari kodu daha önce kullanılmış");
                    return;
                }
                db.SaveChanges();
                MessageBox.Show($"{txtCariAd.Text} adlı cari başarıyla kaydedildi");
                carileriListele();
            }

        }

        private void CariEkle_Load(object sender, EventArgs e)
        {
            carileriListele();
            cmbAktifPasifDurum.DataSource = db.AktifPasifDurums.ToList();
            cmbAktifPasifDurum.DisplayMember = "DurumAdi";
            cmbAktifPasifDurum.ValueMember = "Durumid";

        }

        private void dataGridCariler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCariler.Rows.Count == 0 && dataGridCariler.Rows == null)
            {
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridCariler.Rows[e.RowIndex];

                cmbAktifPasifDurum.SelectedIndex = cmbAktifPasifDurum.FindString(row.Cells["DurumAdi"].Value.ToString());
                txtAdres.Text = row.Cells["CariAdres"].Value.ToString();
                txtCariAd.Text = row.Cells["CariAdi"].Value.ToString();
                txtCariKod.Text = row.Cells["CariKod"].Value.ToString();
                txtYetkiliAdi.Text = row.Cells["YetkiliAdi"].Value.ToString();
                txtYetkiliSoyad.Text = row.Cells["YetkiliSoyadi"].Value.ToString();  
                mskdTelNo.Text = row.Cells["CariTelNo"].Value.ToString();
                mskdTelno2.Text = row.Cells["CariTelNo2"].Value.ToString();
                mskdVK.Text = row.Cells["CariVKN"].Value.ToString();


            }
        }
    }  
}
