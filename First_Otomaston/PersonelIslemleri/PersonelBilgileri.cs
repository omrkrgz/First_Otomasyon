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
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {

                var q = from prsnl in db.Personels
                        join dprtmn in db.Departmen
    on prsnl.Departman_id equals dprtmn.Departmanid
                        join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                        where durum.DurumAdi == "Aktif"
                        select new
                        {
                            prsnl.Adi,
                            prsnl.Soyadi,
                            dprtmn.DepartmanAdi,
                            prsnl.DogumTarihi,
                            prsnl.DogumYeri,
                            prsnl.TcNo,
                            prsnl.TelefonNo,
                            prsnl.KullaniciAdi,
                            prsnl.Password,
                            prsnl.Adres,
                            durum.DurumAdi
                            
                        };
                DataGridPersoneller.DataSource = q.ToList();

                int count = (from row in db.Personels join durum in db.AktifPasifDurums
                             on row.Durum_id equals durum.Durumid
                             where durum.DurumAdi=="Aktif"
                             select row).Count();
                
                label2.Text = count.ToString();
            }
     
        }

       
        private void txtAra_TextChanged(object sender, EventArgs e)
        {   
            
            using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
            {
                string kelime = txtAra.Text.ToUpper();

                var q = from prsnl in db.Personels
                        join dprtmn in db.Departmen
    on prsnl.Departman_id equals dprtmn.Departmanid
                        join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                        where durum.DurumAdi == "Aktif" &&
                        prsnl.Adi.ToUpper().Contains(kelime) || prsnl.Soyadi.ToUpper().Contains(kelime) && durum.DurumAdi == "Aktif"
                        select new
                        {
                            prsnl.Adi,
                            prsnl.Soyadi,
                            dprtmn.DepartmanAdi,
                            prsnl.DogumTarihi,
                            prsnl.DogumYeri,
                            prsnl.TcNo,
                            prsnl.TelefonNo,
                            prsnl.KullaniciAdi,
                            prsnl.Password,
                            prsnl.Adres,
                            durum.DurumAdi


                        };
                DataGridPersoneller.DataSource = q.ToList();
            }
            
        }

        private void chcboxAdanZye_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chcboxAdanZye.Checked==true)
            {
                chcboxZdanAya.Checked = false;
                
                using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
                {
                    var q = from prsnl in db.Personels
                            join dprtmn in db.Departmen
        on prsnl.Departman_id equals dprtmn.Departmanid
                            join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                            orderby (prsnl.Adi)
                            where durum.DurumAdi == "Aktif"
                            select new
                            {
                                prsnl.Adi,
                                prsnl.Soyadi,
                                dprtmn.DepartmanAdi,
                                prsnl.DogumTarihi,
                                prsnl.DogumYeri,
                                prsnl.TcNo,
                                prsnl.TelefonNo,
                                prsnl.KullaniciAdi,
                                prsnl.Password,
                                prsnl.Adres,
                                durum.DurumAdi

                            };
                    DataGridPersoneller.DataSource = q.ToList();
                }
                   
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcboxZdanAya.Checked == true)
            {
                chcboxAdanZye.Checked = false;
                using (FirsOtomasyonEntities db = new FirsOtomasyonEntities())
                {
                    var q = from prsnl in db.Personels
                            join dprtmn in db.Departmen
        on prsnl.Departman_id equals dprtmn.Departmanid
                            join durum in db.AktifPasifDurums on prsnl.Durum_id equals durum.Durumid
                            orderby prsnl.Adi descending
                            where durum.DurumAdi == "Aktif"
                            select new
                            {
                                prsnl.Adi,
                                prsnl.Soyadi,
                                dprtmn.DepartmanAdi,
                                prsnl.DogumTarihi,
                                prsnl.DogumYeri,
                                prsnl.TcNo,
                                prsnl.TelefonNo,
                                prsnl.KullaniciAdi,
                                prsnl.Password,
                                prsnl.Adres,
                                durum.DurumAdi

                            };
                    DataGridPersoneller.DataSource = q.ToList();
                }

            }
        }

       
    }
}
