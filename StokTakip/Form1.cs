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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            var tarihSaat = SistemGirisTarih.CreateAsSingleton();
            labelTarih.Text=tarihSaat.TarihGoster();
        }

        SatinAlma satinalma;
        public int rolDurum;
        private void MdiFormsClose()
        {
            //close all child form
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }
        private void MdiFormsShow(Form chForm)
        {
            chForm.Show();
        }

        private Form MdiFormsStyle(Form chForm)
        {
            chForm.MdiParent = this;
            chForm.LayoutMdi(MdiLayout.Cascade);
            chForm.StartPosition = FormStartPosition.Manual;
            chForm.Location = new Point(0, 0); // Always opens the forms at 15,15
            chForm.Dock = DockStyle.Fill;
            return chForm;
        }

        private void stokKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new SatinAlma()));
        }

        private void ZimmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new Zimmet()));
        }

        private void AtikKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new AtikKontrol()));
        }

        public void roleGoreEkran()
        {
            if (rolDurum == 1) //admin
            {
                return;
            }
            else if(rolDurum == 2)
            {
                KullaniciEkleToolStripMenuItem.Visible = false;
            }
            else if (rolDurum == 3)
            {
                stokKaydıToolStripMenuItem.Visible = false;
                ZimmetToolStripMenuItem.Visible = false;
                AtikKontrolToolStripMenuItem.Visible = false;
                KullaniciEkleToolStripMenuItem.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roleGoreEkran();
        }

        private void KullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new KullaniciEkle()));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MdiFormsClose();
            MdiFormsShow(MdiFormsStyle(new Listeler()));
        }
    }
}
