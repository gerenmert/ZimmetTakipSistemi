namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZimmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AtikKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KullaniciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTarih = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokKaydıToolStripMenuItem,
            this.ZimmetToolStripMenuItem,
            this.AtikKontrolToolStripMenuItem,
            this.KullaniciEkleToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(17, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokKaydıToolStripMenuItem
            // 
            this.stokKaydıToolStripMenuItem.Image = global::StokTakip.Properties.Resources.images__4_;
            this.stokKaydıToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.stokKaydıToolStripMenuItem.Name = "stokKaydıToolStripMenuItem";
            this.stokKaydıToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.stokKaydıToolStripMenuItem.Text = "Satın Alma";
            this.stokKaydıToolStripMenuItem.Click += new System.EventHandler(this.stokKaydıToolStripMenuItem_Click);
            // 
            // ZimmetToolStripMenuItem
            // 
            this.ZimmetToolStripMenuItem.Image = global::StokTakip.Properties.Resources.images__3____Kopya;
            this.ZimmetToolStripMenuItem.Name = "ZimmetToolStripMenuItem";
            this.ZimmetToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ZimmetToolStripMenuItem.Text = "Zimmet";
            this.ZimmetToolStripMenuItem.Click += new System.EventHandler(this.ZimmetToolStripMenuItem_Click);
            // 
            // AtikKontrolToolStripMenuItem
            // 
            this.AtikKontrolToolStripMenuItem.Image = global::StokTakip.Properties.Resources.geri_donusum_kutusu;
            this.AtikKontrolToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AtikKontrolToolStripMenuItem.Name = "AtikKontrolToolStripMenuItem";
            this.AtikKontrolToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.AtikKontrolToolStripMenuItem.Text = "Atık Kontrol";
            this.AtikKontrolToolStripMenuItem.Click += new System.EventHandler(this.AtikKontrolToolStripMenuItem_Click);
            // 
            // KullaniciEkleToolStripMenuItem
            // 
            this.KullaniciEkleToolStripMenuItem.Checked = true;
            this.KullaniciEkleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KullaniciEkleToolStripMenuItem.Image = global::StokTakip.Properties.Resources.images;
            this.KullaniciEkleToolStripMenuItem.Name = "KullaniciEkleToolStripMenuItem";
            this.KullaniciEkleToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.KullaniciEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.KullaniciEkleToolStripMenuItem.Click += new System.EventHandler(this.KullaniciEkleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::StokTakip.Properties.Resources.images__2_;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 24);
            this.toolStripMenuItem1.Text = "Ara, Listele ve Rapor Oluştur";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(647, 22);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(81, 19);
            this.labelTarih.TabIndex = 8;
            this.labelTarih.Text = "metroLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(801, 545);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 19);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Zimmet Takip Sistemi";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem KullaniciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZimmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AtikKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MetroFramework.Controls.MetroLabel labelTarih;
    }
}

