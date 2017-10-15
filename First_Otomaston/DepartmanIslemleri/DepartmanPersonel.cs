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
    public partial class DepartmanPersonel : Form
    {
        public DepartmanPersonel()
        {
            InitializeComponent();
        }
        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        public Departman seciliDepartman { get; set; }

        private void DepartmanPersonel_Load(object sender, EventArgs e)
        {
            cmbDepartmanlar.DisplayMember = "DepartmanAdi";
            cmbDepartmanlar.ValueMember = "Departmanid";
            cmbDepartmanlar.DataSource = db.Departmen.OrderBy(x => x.DepartmanAdi).ToList();

            var q = from prsnl in db.Personels
                    join dprtmn in db.Departmen
on prsnl.Departman_id equals dprtmn.Departmanid
                    select new
                    {
                        prsnl.Adi,
                        prsnl.Soyadi,
                        dprtmn.DepartmanAdi
                    };
            dataGridPersoneller.DataSource = q.ToList();

           

        }

        private void cmbDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDepartman = cmbDepartmanlar.SelectedItem as Departman;
            dataGridPersoneller.DataSource = db.Personels.Where(x => x.Departman_id == seciliDepartman.Departmanid).Select(x => new
            {
                x.Adi,
                x.Soyadi,
                x.Departman.DepartmanAdi
            }).ToList();
        }

       
    }
}
