namespace Kutuphane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.pnlYonGiris = new System.Windows.Forms.Panel();
            this.llYoneticiKaydi = new System.Windows.Forms.LinkLabel();
            this.pbHata = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.btnGerii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.pnlKulGiriss = new System.Windows.Forms.Panel();
            this.lbKullaniciKayit = new System.Windows.Forms.LinkLabel();
            this.pbHataKul = new System.Windows.Forms.PictureBox();
            this.lblHataKul = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOgrSifre = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlYonGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlKulGiriss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHataKul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.pictureBox5);
            this.pnlGiris.Controls.Add(this.label5);
            this.pnlGiris.Controls.Add(this.btnKullanici);
            this.pnlGiris.Controls.Add(this.btnYonetici);
            this.pnlGiris.Location = new System.Drawing.Point(12, 12);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(500, 300);
            this.pnlGiris.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(190, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 99);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(169, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kütüphanemize Hoşgeldiniz\r\nLütfen Giriş türünüzü seçiniz.";
            // 
            // btnKullanici
            // 
            this.btnKullanici.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanici.Image")));
            this.btnKullanici.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanici.Location = new System.Drawing.Point(258, 206);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(88, 59);
            this.btnKullanici.TabIndex = 1;
            this.btnKullanici.Text = "Kullanıcı Giriş";
            this.btnKullanici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYonetici.Image = ((System.Drawing.Image)(resources.GetObject("btnYonetici.Image")));
            this.btnYonetici.Location = new System.Drawing.Point(139, 206);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(88, 59);
            this.btnYonetici.TabIndex = 0;
            this.btnYonetici.Text = "Yönetici Giriş";
            this.btnYonetici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYonetici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // pnlYonGiris
            // 
            this.pnlYonGiris.Controls.Add(this.llYoneticiKaydi);
            this.pnlYonGiris.Controls.Add(this.pbHata);
            this.pnlYonGiris.Controls.Add(this.pictureBox4);
            this.pnlYonGiris.Controls.Add(this.pictureBox3);
            this.pnlYonGiris.Controls.Add(this.lblHata);
            this.pnlYonGiris.Controls.Add(this.btnGerii);
            this.pnlYonGiris.Controls.Add(this.label2);
            this.pnlYonGiris.Controls.Add(this.label1);
            this.pnlYonGiris.Controls.Add(this.txtParola);
            this.pnlYonGiris.Controls.Add(this.txtKulAdi);
            this.pnlYonGiris.Controls.Add(this.btnYoneticiGiris);
            this.pnlYonGiris.Location = new System.Drawing.Point(12, 12);
            this.pnlYonGiris.Name = "pnlYonGiris";
            this.pnlYonGiris.Size = new System.Drawing.Size(500, 300);
            this.pnlYonGiris.TabIndex = 1;
            // 
            // llYoneticiKaydi
            // 
            this.llYoneticiKaydi.AutoSize = true;
            this.llYoneticiKaydi.Location = new System.Drawing.Point(433, 262);
            this.llYoneticiKaydi.Name = "llYoneticiKaydi";
            this.llYoneticiKaydi.Size = new System.Drawing.Size(43, 13);
            this.llYoneticiKaydi.TabIndex = 12;
            this.llYoneticiKaydi.TabStop = true;
            this.llYoneticiKaydi.Text = "Kayıt Ol";
            this.llYoneticiKaydi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llYoneticiKaydi_LinkClicked);
            // 
            // pbHata
            // 
            this.pbHata.Image = ((System.Drawing.Image)(resources.GetObject("pbHata.Image")));
            this.pbHata.Location = new System.Drawing.Point(225, 109);
            this.pbHata.Name = "pbHata";
            this.pbHata.Size = new System.Drawing.Size(64, 65);
            this.pbHata.TabIndex = 11;
            this.pbHata.TabStop = false;
            this.pbHata.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(401, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 78);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 76);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(161, 190);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 7;
            // 
            // btnGerii
            // 
            this.btnGerii.Image = ((System.Drawing.Image)(resources.GetObject("btnGerii.Image")));
            this.btnGerii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerii.Location = new System.Drawing.Point(24, 250);
            this.btnGerii.Name = "btnGerii";
            this.btnGerii.Size = new System.Drawing.Size(100, 36);
            this.btnGerii.TabIndex = 6;
            this.btnGerii.Text = "Geri";
            this.btnGerii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerii.UseVisualStyleBackColor = true;
            this.btnGerii.Click += new System.EventHandler(this.btnGerii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(207, 60);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(152, 20);
            this.txtParola.TabIndex = 2;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(207, 34);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(152, 20);
            this.txtKulAdi.TabIndex = 1;
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnYoneticiGiris.Image")));
            this.btnYoneticiGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYoneticiGiris.Location = new System.Drawing.Point(225, 214);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(73, 51);
            this.btnYoneticiGiris.TabIndex = 8;
            this.btnYoneticiGiris.Text = "Giriş";
            this.btnYoneticiGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYoneticiGiris.UseVisualStyleBackColor = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // pnlKulGiriss
            // 
            this.pnlKulGiriss.Controls.Add(this.lbKullaniciKayit);
            this.pnlKulGiriss.Controls.Add(this.pbHataKul);
            this.pnlKulGiriss.Controls.Add(this.lblHataKul);
            this.pnlKulGiriss.Controls.Add(this.pictureBox2);
            this.pnlKulGiriss.Controls.Add(this.pictureBox1);
            this.pnlKulGiriss.Controls.Add(this.txtOgrSifre);
            this.pnlKulGiriss.Controls.Add(this.txtOgrNo);
            this.pnlKulGiriss.Controls.Add(this.label4);
            this.pnlKulGiriss.Controls.Add(this.label3);
            this.pnlKulGiriss.Controls.Add(this.btnKullaniciGiris);
            this.pnlKulGiriss.Controls.Add(this.btnGeri);
            this.pnlKulGiriss.Location = new System.Drawing.Point(12, 12);
            this.pnlKulGiriss.Name = "pnlKulGiriss";
            this.pnlKulGiriss.Size = new System.Drawing.Size(500, 300);
            this.pnlKulGiriss.TabIndex = 5;
            // 
            // lbKullaniciKayit
            // 
            this.lbKullaniciKayit.AutoSize = true;
            this.lbKullaniciKayit.Location = new System.Drawing.Point(433, 273);
            this.lbKullaniciKayit.Name = "lbKullaniciKayit";
            this.lbKullaniciKayit.Size = new System.Drawing.Size(43, 13);
            this.lbKullaniciKayit.TabIndex = 14;
            this.lbKullaniciKayit.TabStop = true;
            this.lbKullaniciKayit.Text = "Kayıt Ol";
            this.lbKullaniciKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llKullaniciKayit_LinkClicked);
            // 
            // pbHataKul
            // 
            this.pbHataKul.Image = ((System.Drawing.Image)(resources.GetObject("pbHataKul.Image")));
            this.pbHataKul.Location = new System.Drawing.Point(210, 115);
            this.pbHataKul.Name = "pbHataKul";
            this.pbHataKul.Size = new System.Drawing.Size(64, 63);
            this.pbHataKul.TabIndex = 13;
            this.pbHataKul.TabStop = false;
            this.pbHataKul.Visible = false;
            // 
            // lblHataKul
            // 
            this.lblHataKul.AutoSize = true;
            this.lblHataKul.Location = new System.Drawing.Point(125, 202);
            this.lblHataKul.Name = "lblHataKul";
            this.lblHataKul.Size = new System.Drawing.Size(0, 13);
            this.lblHataKul.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(373, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 102);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtOgrSifre
            // 
            this.txtOgrSifre.Location = new System.Drawing.Point(210, 73);
            this.txtOgrSifre.Name = "txtOgrSifre";
            this.txtOgrSifre.Size = new System.Drawing.Size(136, 20);
            this.txtOgrSifre.TabIndex = 4;
            this.txtOgrSifre.UseSystemPasswordChar = true;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(210, 47);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(136, 20);
            this.txtOgrNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrenci No";
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKullaniciGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGiris.Image")));
            this.btnKullaniciGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(207, 224);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(67, 51);
            this.btnKullaniciGiris.TabIndex = 0;
            this.btnKullaniciGiris.Text = "Giriş";
            this.btnKullaniciGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(24, 250);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 36);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.pnlKulGiriss);
            this.Controls.Add(this.pnlYonGiris);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlYonGiris.ResumeLayout(false);
            this.pnlYonGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlKulGiriss.ResumeLayout(false);
            this.pnlKulGiriss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHataKul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Panel pnlYonGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.Panel pnlKulGiriss;
        private System.Windows.Forms.TextBox txtOgrSifre;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGerii;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbHataKul;
        private System.Windows.Forms.Label lblHataKul;
        private System.Windows.Forms.LinkLabel lbKullaniciKayit;
        private System.Windows.Forms.LinkLabel llYoneticiKaydi;
        private System.Windows.Forms.PictureBox pbHata;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;


    }
}

