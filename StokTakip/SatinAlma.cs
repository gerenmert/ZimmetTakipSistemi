using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace StokTakip
{
    public partial class SatinAlma : MetroFramework.Forms.MetroForm
    {
        public SatinAlma()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();

        public void StokEkle(string UrunAdi, int UrunAdet, DateTime SatinAlmaTarihi, string UrunTipi, double BirimFiyat, double ToptanFiyat, string FirmaAdi)
        {

            try
            {
                if (UrunAdi != "" && BirimFiyat != null && txtFirmaAdi.Text != "" && txtUrunTipi.Text != "" && ToptanFiyat != null && txtFirmaAdi.Text != "")
                {
                    string query = "EXEC StokEkle @UrunAdi,@SatinAlmaTarihi,@BirimFiyati,@ToptanFiyati,@UrunTipi,@UrunAdeti,@FirmaAdi";
                    //cmd = new SqlCommand(query, Connection.STR);
                    cmd = new SqlCommand(query, bgl.baglanti());
                    cmd.Parameters.AddWithValue("@UrunAdi", UrunAdi);
                    cmd.Parameters.AddWithValue("@SatinAlmaTarihi", SatinAlmaTarihi);
                    cmd.Parameters.AddWithValue("@BirimFiyati", BirimFiyat);
                    cmd.Parameters.AddWithValue("@ToptanFiyati", ToptanFiyat);
                    cmd.Parameters.AddWithValue("@UrunTipi", UrunTipi);
                    cmd.Parameters.AddWithValue("@UrunAdeti", UrunAdet);
                    cmd.Parameters.AddWithValue("@FirmaAdi", FirmaAdi);

                    cmd.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Stok Ekleme Başarılı.");
                }
                else
                {
                    //throw new ValidationException(" Urunadı veya Urunadeti veya satın alma tarihi veya uruntipi veya birimfiyat veya toptanfiyat veya firmaadi  boş geçilemez!");

                    MetroMessageBox.Show(this, " Urunadı veya Urunadeti veya satın alma tarihi veya uruntipi veya birimfiyat veya toptanfiyat veya firmaadi  boş geçilemez!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }

            


            
          
        }

        private void stokKaydet_Click(object sender, EventArgs e)
        {

            if (txtUrunAdi.Text != "" && txtBirimFiyat.Text != "" && txtFirmaAdi.Text != "" && txtUrunTipi.Text != "" && txtToptanFiyat.Text != "" && txtFirmaAdi.Text != "")
            {
                string UrunAdi = txtUrunAdi.Text.Trim();
                double BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                string FirmaAdi = txtFirmaAdi.Text.Trim();
                string UrunTipi = txtUrunTipi.Text.Trim();
                double ToptanFiyat = Convert.ToDouble(txtToptanFiyat.Text);
                int UrunAdet = Convert.ToInt32(numericUpDown1.Value);
                DateTime SatinAlmaTarihi = SatinAlmaDateTime.Value;


                StokEkle(UrunAdi, UrunAdet, SatinAlmaTarihi, UrunTipi, BirimFiyat, ToptanFiyat, FirmaAdi);

                StokTablosu stokTablosu = new StokTablosu();
                stokTablosu.Show();
            }
            else
            {

               

                MetroMessageBox.Show(this, " Urunadı veya Urunadeti veya satın alma tarihi veya uruntipi veya birimfiyat veya toptanfiyat veya firmaadi  boş geçilemez!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);


            }







        }


        public  string Temizle(string Metin)
        {
            return Metin.Replace(",", "");
           
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        { if(txtBirimFiyat.Text!="" && txtBirimFiyat.Text != null)
            {
                double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                int adet = Convert.ToInt32(numericUpDown1.Value);
                txtToptanFiyat.Text = (birimFiyat * adet).ToString();
                //Toptan fiyat birim fiyat ile adetin çarpımı olacağı için otomatik olarak hesaplanır.
            }

        }


        private void txtBirimFiyat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            //Sadece sayı ve virgül girişine izin verilmiştir.
            txtBirimFiyat.Text = Temizle(txtBirimFiyat.Text);
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&  !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void txtUrunTipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtFirmaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
