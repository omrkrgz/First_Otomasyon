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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        AnaMenuler gor = new AnaMenuler();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                gor.departmanlarToolStripMenuItem.Visible = false;
            }
        }

        FirsOtomasyonEntities db = new FirsOtomasyonEntities();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text==""||txtSifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı veya Şifrenizi kontrol ediniz");
                return;
            }
            var kAdi = txtKullaniciAdi.Text.Trim();
            var sifre = txtSifre.Text.Trim();
            //var kisi = db.Personels.FirstOrDefault(p => p.KullaniciAdi.Equals(kAdi) && p.Password.Equals(sifre)); 
            var kisi = db.Personels.Where(p => p.KullaniciAdi == kAdi && p.Password == sifre).FirstOrDefault(); 
            if (kisi != null)
            {
                gor.Show();
                
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifrenizi kontrol ediniz");
                return;
            }

        }

        
    }
}
