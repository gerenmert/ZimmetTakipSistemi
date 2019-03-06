using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace StokTakip
{
    public partial class KullaniciEkle : MetroFramework.Forms.MetroForm
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();
        int tut = 0;

        public void kullaniciEkle(int BolumID, int RolID, string KullaniciAdi, string KullaniciSifre)
        {
            tut = 0;

            try
            {
                if (BolumID != null && RolID != null && KullaniciAdi != "" && KullaniciSifre != "")
                {


                    if ((BolumID >= 1 && BolumID <= 8) && (RolID >= 1 && RolID <= 3))
                    {

                        string query = "EXEC KullaniciEkle @BolumID,@RolID,@KullaniciAdi,@KullaniciSifre";
                        //cmd = new SqlCommand(query, Connection.STR);
                        cmd = new SqlCommand(query, bgl.baglanti());
                        cmd.Parameters.AddWithValue("@BolumID", BolumID);
                        cmd.Parameters.AddWithValue("@RolID", RolID);
                        cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        cmd.Parameters.AddWithValue("@KullaniciSifre", KullaniciSifre);

                        cmd.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Kullanıcı Ekleme Başarılı.");
                        tut = 1;
                    }
                    else
                    {
                        // throw new ValidationException("Girdiğiniz Rol ID veya Bolum ID sistemimizde kayıtlı değil !");
                        MetroMessageBox.Show(this, "Girdiğiniz Rol ID veya Bolum ID sistemimizde kayıtlı değil !", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);


                    }
                }
                else
                {
                    //throw new ValidationException(" Rol ID veya Bolum ID veya KullaniciAdi veya KullaniciSifre boş geçilemez!");

                    MetroMessageBox.Show(this, " Rol ID veya Bolum ID veya KullaniciAdi veya KullaniciSifre boş geçilemez!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }


           







        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            if (txtBolumID.Text != "" && txtRolID.Text != "" && txtKullaniciAdi.Text != "" && txtKullaniciSifre.Text != "")
            {
                int BolumID = Convert.ToInt32(txtBolumID.Text);
                int RolID = Convert.ToInt32(txtRolID.Text);
                string KullaniciAdi = txtKullaniciAdi.Text.Trim();
                string KullaniciSifre = txtKullaniciSifre.Text.Trim();

                kullaniciEkle(BolumID, RolID, KullaniciAdi, KullaniciSifre);

                if (tut == 1)
                {
                    KullaniciTablosu kullanicTablosu = new KullaniciTablosu();
                    kullanicTablosu.Show();
                }
               

            }
            else
            {
                MetroMessageBox.Show(this, " Rol ID veya Bolum ID veya KullaniciAdi veya KullaniciSifre boş geçilemez!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }


          

        }

        private void txtBolumID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Sadece rakam girişine izin verilmiştir.
        }

        private void txtRolID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Sadece rakam girişine izin verilmiştir.
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtKullaniciSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
