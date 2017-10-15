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
    public partial class StokToplamSatilanR : Form
    {
        public StokToplamSatilanR()
        {
            InitializeComponent();
        }

        private void StokToplamSatilanR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FirsOtomasyonDataSet.Stoklar1' table. You can move, or remove it, as needed.
            this.Stoklar1TableAdapter.Fill(this.FirsOtomasyonDataSet.Stoklar1);

            this.reportViewer1.RefreshReport();
        }
    }
}
