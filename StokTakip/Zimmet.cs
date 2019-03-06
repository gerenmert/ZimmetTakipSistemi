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

namespace StokTakip
{
    public partial class Zimmet : MetroFramework.Forms.MetroForm
    {
        public Zimmet()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        SqlCommand cmd2 = null;
        SqlCommand cmd3 = null;
        SqlCommand cmd4 = null;
        Connection bgl = new Connection();

        int sonuc;

        void stokListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC UrunGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        void personelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC PersonelGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid2.DataSource = dt;
        }

        private void Zimmet_Load(object sender, EventArgs e)
        {
            stokListele();
            personelListele();
        }

        public void zimmetEkle()
        {
            sonuc = 0;
            try
            {
                string PersonelID = txtPersonelID.Text;
                string StokID = txtStokID.Text;
                DateTime ZimmetTarihi = ZimmetEkleDateTime.Value;

                string query3 = "SELECT * FROM tblPersonel WHERE @PersonelID = PersonelID";
                cmd3 = new SqlCommand(query3, bgl.baglanti());
                cmd3.Parameters.AddWithValue("@PersonelID", PersonelID);

                string query2 = "SELECT UrunAdeti FROM tblStok WHERE @StokID = StokID";
                cmd2 = new SqlCommand(query2, bgl.baglanti());
                cmd2.Parameters.AddWithValue("@StokID", StokID);


                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                   
                        if (reader.Read())
                        {
                            if (0 == Convert.ToInt32(reader["UrunAdeti"]))
                            {
                                MessageBox.Show("Zimmete eklenecek ürün stokta mevcut değil.");
                            }
                            else
                            {
                                using (SqlDataReader reader2 = cmd3.ExecuteReader())
                                {
                                    if (reader2.Read())
                                    {
                                        MessageBox.Show("Zimmet Ekleme Başarılı.");
                                        sonuc = 1;
                                    }
                                    else
                                        MessageBox.Show("Personel bulunamadı");
                                }
                            }
                        }
                      else
                          MessageBox.Show("Ürün mevcut değildir");

                }
                bgl.baglanti().Close();


               

                string query = "EXEC ZimmetEkle @PersonelID,@StokID,@ZimmetTarihi";
                //cmd = new SqlCommand(query, Connection.STR);
                cmd = new SqlCommand(query, bgl.baglanti());
                cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                cmd.Parameters.AddWithValue("@StokID", StokID);
                cmd.Parameters.AddWithValue("@ZimmetTarihi", ZimmetTarihi);

                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }
        }

        private void btnZimmetEkle_Click_1(object sender, EventArgs e)
        {
            zimmetEkle();
            stokListele();

            if(sonuc == 1)
            {
                ZimmetTablosu zimmetTablosu = new ZimmetTablosu();
                zimmetTablosu.Show();
            }
            
        }

        private void txtPersonelID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Sadece rakam girişine izin verilmiştir.
        }

        private void txtStokID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Sadece rakam girişine izin verilmiştir.
        }
    }
}
