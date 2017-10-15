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
    public partial class TumStoklarim : Form
    {
        public TumStoklarim()
        {
            InitializeComponent();
        }
        public Stoklar netstok { get; set; }
        private void TumStoklarim_Load(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                var q = from skt in db.Stoklars
                        join ktgri in db.StokKategoris
    on skt.Kategori_id equals ktgri.Kategorid
                        join durum in db.AktifPasifDurums
  on skt.Durum_id equals durum.Durumid
                        where durum.DurumAdi=="Aktif"
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
                dataGridTümStoklarim.DataSource = q.OrderBy(x=>x.StokAdi).ToList();
                this.dataGridTümStoklarim.Columns["Stokid"].Visible = false;

               

                
            }
        }
    }
}

