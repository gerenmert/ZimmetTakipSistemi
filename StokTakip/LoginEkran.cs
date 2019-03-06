using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using System.Security.Authentication;

namespace StokTakip
{
    public partial class LoginEkran : MetroFramework.Forms.MetroForm
    {
        public LoginEkran()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();
        

        int bayrak = 0;




        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullanici.Text;
            string sifre = txtSifre.Text;

            giris(kullaniciadi, sifre);

        }



        public void giris(string kullaniciadi, string sifre)
        {
            try
            {
                string sql = "EXEC GIRIS @kullaniciadi , @sifre";

                cmd = new SqlCommand(sql, bgl.baglanti());
                cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                cmd.Parameters.AddWithValue("@sifre", sifre);


                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        int degisken = Convert.ToInt32(rdr["RolID"]);
                        if (degisken == 1)
                        {

                            bayrak = 1;
                            MessageBox.Show("Giriş Başarılı.", "  Hoşgeldiniz  ");
                            LoginEkran girisform = new LoginEkran();
                            girisform.Close();
                            Form1 ana = new Form1();
                            ana.rolDurum = Convert.ToInt32(rdr["RolID"]);
                            ana.Show();
                            this.Hide();
                        }
                        else if (degisken == 2)
                        {
                            bayrak = 1;
                            MessageBox.Show("Giriş Başarılı.", "  Hoşgeldiniz  ");
                            LoginEkran girisform = new LoginEkran();
                            girisform.Close();
                            Form1 ana = new Form1();
                            ana.rolDurum = Convert.ToInt32(rdr["RolID"]);
                            ana.Show();
                            this.Hide();
                        }
                        else if (degisken == 3)
                        {
                            bayrak = 1;
                            MessageBox.Show("Giriş Başarılı.", "  Hoşgeldiniz  ");
                            LoginEkran girisform = new LoginEkran();
                            girisform.Close();
                            Form1 ana = new Form1();
                            ana.rolDurum = Convert.ToInt32(rdr["RolID"]);
                            ana.Show();
                            this.Hide();
                        }
                    }

                    if (kullaniciadi == "" || sifre == "")
                    {
                        MetroMessageBox.Show(this, "Kullanıcı adı ya da şifreniz boş geçilemez!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                         //throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
                       
                    }
                    else if (bayrak == 0)
                    {
                        MetroMessageBox.Show(this, "Kullanıcı adı ya da şifreniz geçersiz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                         // throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                        
                    }


                    bgl.baglanti().Close();
                    // cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }
           

         

        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}

