using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StokTakip
{
    public partial class Rapor1 : Form
    {
        public string KullaniciAdi;
        public Rapor1()
        {
            InitializeComponent();
        }
       
        private void Rapor1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StokTakipDatabaseDataSet.zimmetKisiListele' table. You can move, or remove it, as needed.
            this.zimmetKisiListeleTableAdapter.Fill(this.StokTakipDatabaseDataSet.zimmetKisiListele, KullaniciAdi);

            this.reportViewer1.RefreshReport();
        }
    }
}
