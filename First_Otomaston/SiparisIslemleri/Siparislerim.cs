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
    public partial class Siparislerim : Form
    {
        public Siparislerim()
        {
            InitializeComponent();
        }

        private void Siparislerim_Load(object sender, EventArgs e)
        {
//            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
//            {
//                var q = from cariler in db.Carilers
//                        join sprsdety in db.Siparislers
//    on cariler.CariId equals sprsdety.Cari_id
//                        join prsnl in db.Personels
//    on sprsdety.Personel_id equals prsnl.Personelid
//                        join stklr in db.Stoklars
//on sprsdety.Stok_id equals stklr.Stokid
//                        join durum in db.SiparisDurums
//on sprsdety.Durum_id equals durum.DurumId
//                        select new
//                        {
//                            sprsdety.SiparisId,
//                            sprsdety.SiparisTarihi,
//                            durum.DurumAdi,
//                            StokAdıveStokKodu = stklr.StokAdi.Trim() + " " + stklr.StokKodu,
//                            //stklr.StokKodu,
//                            //stklr.StokAdi,
//                            sprsdety.SiparisAdet,
//                            sprsdety.SiparisFiyat,
//                            İndirim = sprsdety.indirim,
//                            sprsdety.SiparisTutar,
//                            //cariler.CariAdi,
//                            //cariler.CariKod,
//                            CariAdıveKodu = cariler.CariAdi.Trim() + " " + cariler.CariKod,
//                            PersonelAdı = prsnl.Adi,
//                            PersonelSoyadı = prsnl.Soyadi,
//                            sprsdety.TeslimTarihi


//                        };
//                dataGridSiparisler.DataSource = q.ToList();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
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
where sprsdety.SiparisTarihi.Value>=dateTimeilkTarih.Value.Date && sprsdety.SiparisTarihi.Value<=dateTimeSonTarih.Value.Date
                        select new
                        {
                         
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
        }

       
    }
}
