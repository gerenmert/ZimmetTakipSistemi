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
    public partial class AtikKontrol : MetroFramework.Forms.MetroForm
    {
        public AtikKontrol()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        SqlCommand cmd2 = null;
        SqlCommand cmd3 = null;
        Connection bgl = new Connection();
        int sonuc;

        void zimmetListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC ZimmetGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void AtikKontrol_Load(object sender, EventArgs e)
        {
            zimmetListele();
        }

        public void AtikEkle()
        {
            sonuc = 0;
            try
            {
                string ZimmetID = txtZimmetID.Text;
                DateTime AtilmaTarihi = AtikDateTime.Value;

                string query2 = "SELECT * FROM tblZimmet WHERE @ZimmetID = ZimmetID";
                cmd2 = new SqlCommand(query2, bgl.baglanti());
                cmd2.Parameters.AddWithValue("@ZimmetID", ZimmetID);


                string query3 = "SELECT AktifMi FROM tblZimmet WHERE @ZimmetID = ZimmetID";
                cmd3 = new SqlCommand(query3, bgl.baglanti());
                cmd3.Parameters.AddWithValue("@ZimmetID", ZimmetID);


                using (SqlDataReader reader = cmd2.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        using (SqlDataReader reader2 = cmd3.ExecuteReader())
                        {
                            if (reader2.Read())
                            {
                                if (Convert.ToInt32(reader2["AktifMi"]) == 1)
                                {
                                    sonuc = 1;
                                    MessageBox.Show("Atığa Atma Başarılı ");

                                }
                                else
                                {
                                    MessageBox.Show("Pasif ürün atığa eklenemez !!");
                                }
                            }
                        }

                            
                    }
                    else
                    {

                       
                        MessageBox.Show("Atiğa atilacak zimmetli ürün yok ");

                    }


                }
                bgl.baglanti().Close();


                string query = "EXEC AtikEkle @ZimmetID, @AtilmaTarihi";
                //cmd = new SqlCommand(query, Connection.STR);
                cmd = new SqlCommand(query, bgl.baglanti());
                cmd.Parameters.AddWithValue("@ZimmetID", ZimmetID);
                cmd.Parameters.AddWithValue("@AtilmaTarihi", AtilmaTarihi);

                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }
        }


       




        private void btnAtikEkle_Click(object sender, EventArgs e)
        {
            AtikEkle();

            if (sonuc==1)
            {
                AtikTablosu atikTablosu = new AtikTablosu();
                atikTablosu.Show();
            }
            
        }

        private void txtZimmetID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Sadece rakam girişine izin verilmiştir.
        }
    }
}
