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
    public partial class KullaniciTablosu : MetroFramework.Forms.MetroForm
    {
        public KullaniciTablosu()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();

        void kullaniciListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC KullaniciGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void KullaniciTablosu_Load(object sender, EventArgs e)
        {
            kullaniciListele();
        }
    }
}
