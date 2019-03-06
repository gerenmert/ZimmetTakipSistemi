namespace StokTakip
{
    partial class SatinAlma
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.stokKaydet = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SatinAlmaDateTime = new MetroFramework.Controls.MetroDateTime();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrunAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtBirimFiyat = new MetroFramework.Controls.MetroTextBox();
            this.txtToptanFiyat = new MetroFramework.Controls.MetroTextBox();
            this.txtUrunTipi = new MetroFramework.Controls.MetroTextBox();
            this.txtFirmaAdi = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(341, 81);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Ürün Adı :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(341, 156);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Birim Fiyatı :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(341, 190);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Toptan Fiyatı :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(341, 225);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Ürün Tipi :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(341, 256);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Adet :";
            // 
            // stokKaydet
            // 
            this.stokKaydet.Location = new System.Drawing.Point(440, 336);
            this.stokKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.stokKaydet.Name = "stokKaydet";
            this.stokKaydet.Size = new System.Drawing.Size(115, 60);
            this.stokKaydet.TabIndex = 5;
            this.stokKaydet.Text = "Kaydet";
            this.stokKaydet.UseSelectable = true;
            this.stokKaydet.Click += new System.EventHandler(this.stokKaydet_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(341, 121);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Satın Alma Tarihi :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(501, 255);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(341, 292);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Satın Alınan Firma Adı :";
            // 
            // SatinAlmaDateTime
            // 
            this.SatinAlmaDateTime.Enabled = false;
            this.SatinAlmaDateTime.Location = new System.Drawing.Point(501, 111);
            this.SatinAlmaDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.SatinAlmaDateTime.Name = "SatinAlmaDateTime";
            this.SatinAlmaDateTime.Size = new System.Drawing.Size(154, 29);
            this.SatinAlmaDateTime.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StokTakip.Properties.Resources.images__4_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrunAdi
            // 
            // 
            // 
            // 
            this.txtUrunAdi.CustomButton.Image = null;
            this.txtUrunAdi.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtUrunAdi.CustomButton.Name = "";
            this.txtUrunAdi.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUrunAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunAdi.CustomButton.TabIndex = 1;
            this.txtUrunAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunAdi.CustomButton.UseSelectable = true;
            this.txtUrunAdi.CustomButton.Visible = false;
            this.txtUrunAdi.Lines = new string[0];
            this.txtUrunAdi.Location = new System.Drawing.Point(501, 78);
            this.txtUrunAdi.MaxLength = 16;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.SelectionLength = 0;
            this.txtUrunAdi.SelectionStart = 0;
            this.txtUrunAdi.ShortcutsEnabled = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(154, 22);
            this.txtUrunAdi.TabIndex = 31;
            this.txtUrunAdi.UseSelectable = true;
            this.txtUrunAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // txtBirimFiyat
            // 
            // 
            // 
            // 
            this.txtBirimFiyat.CustomButton.Image = null;
            this.txtBirimFiyat.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtBirimFiyat.CustomButton.Name = "";
            this.txtBirimFiyat.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtBirimFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimFiyat.CustomButton.TabIndex = 1;
            this.txtBirimFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimFiyat.CustomButton.UseSelectable = true;
            this.txtBirimFiyat.CustomButton.Visible = false;
            this.txtBirimFiyat.Lines = new string[] {
        "0"};
            this.txtBirimFiyat.Location = new System.Drawing.Point(501, 156);
            this.txtBirimFiyat.MaxLength = 10;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.SelectionLength = 0;
            this.txtBirimFiyat.SelectionStart = 0;
            this.txtBirimFiyat.ShortcutsEnabled = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(154, 22);
            this.txtBirimFiyat.TabIndex = 32;
            this.txtBirimFiyat.Text = "0";
            this.txtBirimFiyat.UseSelectable = true;
            this.txtBirimFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyat_KeyPress_1);
            // 
            // txtToptanFiyat
            // 
            // 
            // 
            // 
            this.txtToptanFiyat.CustomButton.Image = null;
            this.txtToptanFiyat.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtToptanFiyat.CustomButton.Name = "";
            this.txtToptanFiyat.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtToptanFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToptanFiyat.CustomButton.TabIndex = 1;
            this.txtToptanFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToptanFiyat.CustomButton.UseSelectable = true;
            this.txtToptanFiyat.CustomButton.Visible = false;
            this.txtToptanFiyat.Lines = new string[] {
        "0"};
            this.txtToptanFiyat.Location = new System.Drawing.Point(500, 190);
            this.txtToptanFiyat.MaxLength = 32767;
            this.txtToptanFiyat.Name = "txtToptanFiyat";
            this.txtToptanFiyat.PasswordChar = '\0';
            this.txtToptanFiyat.ReadOnly = true;
            this.txtToptanFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToptanFiyat.SelectedText = "";
            this.txtToptanFiyat.SelectionLength = 0;
            this.txtToptanFiyat.SelectionStart = 0;
            this.txtToptanFiyat.ShortcutsEnabled = true;
            this.txtToptanFiyat.Size = new System.Drawing.Size(154, 22);
            this.txtToptanFiyat.TabIndex = 33;
            this.txtToptanFiyat.Text = "0";
            this.txtToptanFiyat.UseSelectable = true;
            this.txtToptanFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToptanFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUrunTipi
            // 
            // 
            // 
            // 
            this.txtUrunTipi.CustomButton.Image = null;
            this.txtUrunTipi.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtUrunTipi.CustomButton.Name = "";
            this.txtUrunTipi.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUrunTipi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunTipi.CustomButton.TabIndex = 1;
            this.txtUrunTipi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunTipi.CustomButton.UseSelectable = true;
            this.txtUrunTipi.CustomButton.Visible = false;
            this.txtUrunTipi.Lines = new string[0];
            this.txtUrunTipi.Location = new System.Drawing.Point(501, 227);
            this.txtUrunTipi.MaxLength = 16;
            this.txtUrunTipi.Name = "txtUrunTipi";
            this.txtUrunTipi.PasswordChar = '\0';
            this.txtUrunTipi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunTipi.SelectedText = "";
            this.txtUrunTipi.SelectionLength = 0;
            this.txtUrunTipi.SelectionStart = 0;
            this.txtUrunTipi.ShortcutsEnabled = true;
            this.txtUrunTipi.Size = new System.Drawing.Size(154, 22);
            this.txtUrunTipi.TabIndex = 34;
            this.txtUrunTipi.UseSelectable = true;
            this.txtUrunTipi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunTipi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrunTipi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunTipi_KeyPress);
            // 
            // txtFirmaAdi
            // 
            // 
            // 
            // 
            this.txtFirmaAdi.CustomButton.Image = null;
            this.txtFirmaAdi.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtFirmaAdi.CustomButton.Name = "";
            this.txtFirmaAdi.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtFirmaAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirmaAdi.CustomButton.TabIndex = 1;
            this.txtFirmaAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirmaAdi.CustomButton.UseSelectable = true;
            this.txtFirmaAdi.CustomButton.Visible = false;
            this.txtFirmaAdi.Lines = new string[0];
            this.txtFirmaAdi.Location = new System.Drawing.Point(500, 292);
            this.txtFirmaAdi.MaxLength = 16;
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.PasswordChar = '\0';
            this.txtFirmaAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirmaAdi.SelectedText = "";
            this.txtFirmaAdi.SelectionLength = 0;
            this.txtFirmaAdi.SelectionStart = 0;
            this.txtFirmaAdi.ShortcutsEnabled = true;
            this.txtFirmaAdi.Size = new System.Drawing.Size(154, 22);
            this.txtFirmaAdi.TabIndex = 35;
            this.txtFirmaAdi.UseSelectable = true;
            this.txtFirmaAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirmaAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirmaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirmaAdi_KeyPress);
            // 
            // SatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 598);
            this.ControlBox = false;
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtUrunTipi);
            this.Controls.Add(this.txtToptanFiyat);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.SatinAlmaDateTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stokKaydet);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Movable = false;
            this.Name = "SatinAlma";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Stok Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton stokKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime SatinAlmaDateTime;
        private MetroFramework.Controls.MetroTextBox txtUrunAdi;
        private MetroFramework.Controls.MetroTextBox txtBirimFiyat;
        private MetroFramework.Controls.MetroTextBox txtToptanFiyat;
        private MetroFramework.Controls.MetroTextBox txtUrunTipi;
        private MetroFramework.Controls.MetroTextBox txtFirmaAdi;
    }
}