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

namespace StokTakip
{
    public partial class StokTablosu : MetroFramework.Forms.MetroForm
    {
        public StokTablosu()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();

        void StokListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC StokGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void StokTablosu_Load(object sender, EventArgs e)
        {
            StokListele();
        }
    }
}
