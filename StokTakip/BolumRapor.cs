using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class BolumRapor : Form
    {
        public BolumRapor()
        {
            InitializeComponent();
        }
        public string BolumAdi;
        private void BolumRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StokTakipDatabaseDataSet1.zimmetBolumListele' table. You can move, or remove it, as needed.
            this.zimmetBolumListeleTableAdapter.Fill(this.StokTakipDatabaseDataSet1.zimmetBolumListele, BolumAdi);

            this.reportViewer1.RefreshReport();
        }
    }
}
