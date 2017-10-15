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
    public partial class StokDurumR : Form
    {
        public StokDurumR()
        {
            InitializeComponent();
        }

        private void StokDurumR_Load(object sender, EventArgs e)
        {
            
        }

        private void StokDurumR_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FirsOtomasyonDataSet.StoklarimR' table. You can move, or remove it, as needed.
            this.StoklarimRTableAdapter.Fill(this.FirsOtomasyonDataSet.StoklarimR);
            // TODO: This line of code loads data into the 'FirsOtomasyonDataSet.SiparislerimR' table. You can move, or remove it, as needed.
            this.SiparislerimRTableAdapter.Fill(this.FirsOtomasyonDataSet.SiparislerimR);

            this.reportViewer1.RefreshReport();
        }
    }
}
