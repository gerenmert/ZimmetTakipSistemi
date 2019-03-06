namespace StokTakip
{
    partial class LoginEkran
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtKullanici = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(154, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(198, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            // 
            // 
            // 
            this.txtKullanici.CustomButton.Image = null;
            this.txtKullanici.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtKullanici.CustomButton.Name = "";
            this.txtKullanici.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtKullanici.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullanici.CustomButton.TabIndex = 1;
            this.txtKullanici.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullanici.CustomButton.UseSelectable = true;
            this.txtKullanici.CustomButton.Visible = false;
            this.txtKullanici.Lines = new string[0];
            this.txtKullanici.Location = new System.Drawing.Point(261, 74);
            this.txtKullanici.MaxLength = 16;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.PasswordChar = '\0';
            this.txtKullanici.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullanici.SelectedText = "";
            this.txtKullanici.SelectionLength = 0;
            this.txtKullanici.SelectionStart = 0;
            this.txtKullanici.ShortcutsEnabled = true;
            this.txtKullanici.Size = new System.Drawing.Size(120, 22);
            this.txtKullanici.TabIndex = 4;
            this.txtKullanici.UseSelectable = true;
            this.txtKullanici.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullanici.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullanici_KeyPress);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(261, 113);
            this.txtSifre.MaxLength = 9;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(120, 22);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(315, 158);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(66, 22);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseSelectable = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 108);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(411, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginEkran";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 19);
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtKullanici;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}