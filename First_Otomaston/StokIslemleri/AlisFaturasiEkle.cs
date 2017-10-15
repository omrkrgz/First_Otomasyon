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
    public partial class AlisFaturasiEkle : Form
    {
        public AlisFaturasiEkle()
        {
            InitializeComponent();
        }

        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        private void AlisFaturasiEkle_Load(object sender, EventArgs e)
        {

            AutoCompleteStringCollection collectionstok = new AutoCompleteStringCollection();

            List<Stoklar> stokgor = db.Stoklars.Where(x => x.AktifPasifDurum.DurumAdi == "Aktif").ToList();
            foreach (var item in stokgor)
            {
                collectionstok.Add(item.StokAdi.Trim() + " " + item.StokKodu);
            }

            cmbStokSec.DataSource = db.Stoklars.Where(x => x.AktifPasifDurum.DurumAdi == "Aktif").Select(x => new
            {
                x.Stokid,
                StokAdıveStokKodu = x.StokAdi.Trim() + " " + x.StokKodu,
            }).ToList();

            cmbStokSec.DisplayMember = "StokAdıveStokKodu";
            cmbStokSec.ValueMember = "Stokid";
            cmbStokSec.AutoCompleteCustomSource = collectionstok;
            //Combobox'umuzun otomatik tamamlama türünü seçiyoruz.
            cmbStokSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Combobox'umuzun AutoCompleteSource özelliğinin CustomSource türünde bir yapı olacağını bildiriyoruz.
            cmbStokSec.AutoCompleteSource = AutoCompleteSource.CustomSource;


            List<Cariler> carigor = db.Carilers.Where(x => x.AktifPasifDurum.DurumAdi == "Aktif").ToList();
            foreach (var item in carigor)
            {
                collectionstok.Add(item.CariAdi.Trim() + " " + item.CariKod);
            }

            cmbCariSec.DataSource = db.Carilers.Where(x => x.AktifPasifDurum.DurumAdi == "Aktif").Select(x => new
            {
                x.CariId,
                CariAdıveCariKodu = x.CariAdi.Trim() + " " + x.CariKod,
            }).ToList();

            cmbCariSec.DisplayMember = "CariAdıveCariKodu";
            cmbCariSec.ValueMember = "cariId";
            cmbCariSec.AutoCompleteCustomSource = collectionstok;
            //Combobox'umuzun otomatik tamamlama türünü seçiyoruz.
            cmbCariSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Combobox'umuzun AutoCompleteSource özelliğinin CustomSource türünde bir yapı olacağını bildiriyoruz.
            cmbCariSec.AutoCompleteSource = AutoCompleteSource.CustomSource;



            cmbPersonelSec.DataSource = db.Personels.ToList();

            cmbPersonelSec.DisplayMember = "Adi";
            cmbPersonelSec.ValueMember = "Personelid";




        }
        public Stoklar secilenStok { get; set; }
        private void cmbUrunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenStok = cmbStokSec.SelectedItem as Stoklar;
        }
        public Cariler secilenCari { get; set; }
        private void cmbCariSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenCari = cmbCariSec.SelectedItem as Cariler;
        }

        public Personel secilenPersonel { get; set; }
        private void cmbPersonelSec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            secilenPersonel = cmbPersonelSec.SelectedItem as Personel;
        }

        private void btnStokKalemiEkle_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.Text = txtFaturaNo.Text;
            li.SubItems.Add(cmbCariSec.SelectedValue.ToString());
            li.SubItems.Add(cmbStokSec.SelectedValue.ToString());
            li.SubItems.Add(numStokAdet.Value.ToString());
            li.SubItems.Add(numStokBirimFiyat.Value.ToString());
            li.SubItems.Add(numStokTutar.Value.ToString());
            li.SubItems.Add(secilenPersonel.Adi);

            li.Tag = cmbStokSec.SelectedValue;

            listView1.Items.Add(li);
        }
        private void btnAlisFaturasiKaydet_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
                {
                    db.AlisFaturalaris.Add(new AlisFaturalari
                    {
                        Cari_id = int.Parse(cmbCariSec.SelectedValue.ToString()),
                        Stok_id = (int)item.Tag,
                        Personel_id = int.Parse(cmbPersonelSec.SelectedValue.ToString()),
                        FaturaNo = txtFaturaNo.Text,
                        AlısTarihi = dateTimeFaturaAlis.Value,
                        Adet = int.Parse(item.SubItems[3].Text),
                        Fiyat = int.Parse(item.SubItems[4].Text),
                        Tutar = int.Parse(item.SubItems[5].Text)

                    });

                    db.SaveChanges();
                }

            }
        }

       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtFaturaNo.Text = listView1.SelectedItems[0].Text;
                //cmbPersonelSec.SelectedItem = secilenPersonel.Adi;

            }
        }
    }

}

