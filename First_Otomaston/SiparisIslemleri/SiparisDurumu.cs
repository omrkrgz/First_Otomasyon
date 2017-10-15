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
    public partial class SiparisDurumu : Form
    {
        public SiparisDurumu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                db.SiparisDurums.Add(new SiparisDurum()
                {
                    DurumAdi = txtSiparisDurum.Text.ToUpper()

                });
                db.SaveChanges();
                txtSiparisDurum.Clear();
                lstDurumlar.DisplayMember = "DurumAdi";
                lstDurumlar.DataSource = db.SiparisDurums.OrderBy(x => x.DurumAdi).ToList();
            }
        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        private void SiparisDurumu_Load(object sender, EventArgs e)
        {
            lstDurumlar.DisplayMember = "DurumAdi";
            lstDurumlar.DataSource = db.SiparisDurums.OrderBy(x => x.DurumAdi).ToList();
        }
    }
}
