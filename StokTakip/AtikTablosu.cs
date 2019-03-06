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
    public partial class AtikTablosu : MetroFramework.Forms.MetroForm
    {
        public AtikTablosu()
        {
            InitializeComponent();
        }

        SqlCommand cmd = null;
        Connection bgl = new Connection();

        void atikListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC AtikGetir", bgl.baglanti());
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void AtikTablosu_Load(object sender, EventArgs e)
        {
            atikListele();
        }
    }
}
