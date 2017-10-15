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
    public partial class DepartmanEkle : Form
    {
        public DepartmanEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                db.Departmen.Add(new Departman()
                {
                    DepartmanAdi = txtDepartman.Text.ToUpper()

                });
                db.SaveChanges();
                txtDepartman.Clear();
                lstDepartmanlar.DisplayMember = "DepartmanAdi";
                lstDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();
            }
        }

        private void DepartmanEkle_Load(object sender, EventArgs e)
        {
            
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                lstDepartmanlar.DisplayMember = "DepartmanAdi";
                lstDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();
            }
        }
        public Departman seciliDepartman { get; set; }
        private void txtDepartmanAra_TextChanged(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                lstDepartmanlar.DisplayMember = "DepartmanAdi";
                string kelime = txtDepartmanAra.Text.ToLower();
                lstDepartmanlar.DataSource = db.Departmen.Where(x => x.DepartmanAdi.ToLower().Contains(kelime)).ToList();

                
            }

        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDepartmanlar.SelectedItem == null) return;

            seciliDepartman = db.Departmen.Where(x => x.Departmanid == seciliDepartman.Departmanid).FirstOrDefault();
            db.Departmen.Remove(seciliDepartman);
            db.SaveChanges();

            lstDepartmanlar.DisplayMember = "DepartmanAdi";
            lstDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();
        }

        private void lstDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstDepartmanlar.SelectedItem == null) return;
            seciliDepartman = lstDepartmanlar.SelectedItem as Departman;
            txtDepartman.Text = seciliDepartman.DepartmanAdi;

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (seciliDepartman == null) return;

            Departman güncellenekDepartman = db.Departmen.Where(x => x.Departmanid ==seciliDepartman.Departmanid).FirstOrDefault();
            
            güncellenekDepartman.DepartmanAdi = txtDepartman.Text.ToUpper();

            db.SaveChanges();

            lstDepartmanlar.DisplayMember = "DepartmanAdi";
            lstDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDepartman_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
