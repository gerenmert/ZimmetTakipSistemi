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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StokTakip
{
    public partial class Listeler : MetroFramework.Forms.MetroForm
    {
        public Listeler()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();

        string KullaniciAdi;
        void zimmetKisiListele()
        {
            try
            {
                KullaniciAdi = txtKisiAdi.Text;

                //string kayit = "SELECT z.ZimmetID, p.PersonelID, p.PersonelAdi, p.PersonelSoyadi, b.BolumAdi, s.StokID, s.UrunAdi, z.ZimmetTarihi, z.AktifMi from  tblZimmet z INNER JOIN tblPersonel p ON z.PersonelID = p.PersonelID INNER JOIN tblStok s ON z.StokID = s.StokID INNER JOIN tblBolum b ON b.BolumID = p.BolumID where p.PersonelAdi LIKE '%'+ @KullaniciAdi + '%'";

                SqlDataAdapter Da = new SqlDataAdapter("[dbo].[zimmetKisiListele]", bgl.baglanti());

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);

                //SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
                //komut.Parameters.AddWithValue("@KullaniciAdi",KullaniciAdi);

                // SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                metroGrid1.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }





         
        }




        string BolumAdi;
        void zimmetBolumListele()
        {

            try
            {
                BolumAdi = txtBolumAdi.Text;
                //string kayit = "SELECT z.ZimmetID, p.PersonelID, p.PersonelAdi, p.PersonelSoyadi, b.BolumAdi, s.StokID, s.UrunAdi, z.ZimmetTarihi, z.AktifMi from  tblZimmet z INNER JOIN tblPersonel p ON z.PersonelID = p.PersonelID INNER JOIN tblStok s ON z.StokID = s.StokID INNER JOIN tblBolum b ON b.BolumID = p.BolumID where b.BolumAdi LIKE '%'+ @BolumAdi + '%'";
                //SqlCommand komut = new SqlCommand(kayit, bgl.baglanti());
                //komut.Parameters.AddWithValue("@BolumAdi", BolumAdi);

                SqlDataAdapter Da = new SqlDataAdapter("[dbo].[zimmetBolumListele]", bgl.baglanti());

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@BolumAdi", BolumAdi);




                //SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                metroGrid2.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Hata : " + ex);
            }

           
        }

       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Rapor1 ana = new Rapor1();
            ana.KullaniciAdi = KullaniciAdi;
            ana.Show();
            this.Hide();
        }

        private void btnBolumPrint_Click(object sender, EventArgs e)
        {
            BolumRapor bolum = new BolumRapor();
            bolum.BolumAdi = BolumAdi;
            bolum.Show();
            this.Hide();
        }

        private void txtBolumAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
            //Sadece harf girişine izin verilmekte.
            zimmetBolumListele();
        }

        private void metroTabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
            //Sadece harf girişine izin verilmekte.
        }

        private void txtKisiAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            zimmetKisiListele();
        }
    }
}
