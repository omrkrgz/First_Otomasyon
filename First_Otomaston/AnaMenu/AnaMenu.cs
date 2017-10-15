
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
    public partial class AnaMenuler : Form
    {
        public AnaMenuler()
        {
            InitializeComponent();
        }

        private void departmanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmanEkle ekle = new DepartmanEkle();
                ekle.ShowDialog();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle ekle = new PersonelEkle();
            ekle.ShowDialog();
        }

        private void departmanlaraPersonelİlişkisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmanPersonel gir = new DepartmanPersonel();
            gir.ShowDialog();
        }

        private void personelleriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelBilgileri gir = new PersonelBilgileri();
            gir.ShowDialog();
        }

       

        private void girişYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPanel gir = new LoginPanel();
            gir.ShowDialog();
        }

        private void AnaMenuler_Load(object sender, EventArgs e)
        {

        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle ac = new PersonelEkle();
            ac.ShowDialog();

        }

        private void stokKategorisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokKatEkle ekle = new StokKatEkle();
            ekle.ShowDialog();                                                                                           
        }

        private void stlmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokEkle ac = new StokEkle();
            ac.ShowDialog();
        }

        private void cariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariEkle ac = new CariEkle();
            ac.ShowDialog();
        }

        private void siparisEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SipariseEkle ac = new SipariseEkle();
            ac.ShowDialog();

           
        }

        

        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparislerim ac = new Siparislerim();
            ac.ShowDialog();
        }

       

       

        private void siparişDurumuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisDurumu ac = new SiparisDurumu();
            ac.ShowDialog();
        }

       

        

        private void tümAlışFaturalarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumAlisFaturalarim ac = new TumAlisFaturalarim();
            ac.ShowDialog();
        }

        private void tümStoklarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumStoklarim ac = new TumStoklarim();
            ac.ShowDialog();
        }

        private void stokAdetGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlisFaturasiEkle ac = new AlisFaturasiEkle();
            ac.ShowDialog();
        }
    }
}
