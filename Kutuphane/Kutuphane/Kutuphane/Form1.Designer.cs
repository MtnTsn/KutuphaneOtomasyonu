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
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.pnlYonGiris = new System.Windows.Forms.Panel();
            this.lblHata = new System.Windows.Forms.Label();
            this.btnGerii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.pnlKulGiriss = new System.Windows.Forms.Panel();
            this.txtOgrSifre = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOgrGiris = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlGiris.SuspendLayout();
            this.pnlYonGiris.SuspendLayout();
            this.pnlKulGiriss.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.btnKullanici);
            this.pnlGiris.Controls.Add(this.btnYonetici);
            this.pnlGiris.Location = new System.Drawing.Point(12, 12);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(500, 300);
            this.pnlGiris.TabIndex = 0;
            // 
            // btnKullanici
            // 
            this.btnKullanici.Location = new System.Drawing.Point(252, 127);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(73, 69);
            this.btnKullanici.TabIndex = 1;
            this.btnKullanici.Text = "Kullanıcı Giriş";
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.Location = new System.Drawing.Point(160, 127);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(73, 69);
            this.btnYonetici.TabIndex = 0;
            this.btnYonetici.Text = "Yönetici Giriş";
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // pnlYonGiris
            // 
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
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(56, 155);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 7;
            // 
            // btnGerii
            // 
            this.btnGerii.Location = new System.Drawing.Point(25, 260);
            this.btnGerii.Name = "btnGerii";
            this.btnGerii.Size = new System.Drawing.Size(75, 23);
            this.btnGerii.TabIndex = 6;
            this.btnGerii.Text = "Geri";
            this.btnGerii.UseVisualStyleBackColor = true;
            this.btnGerii.Click += new System.EventHandler(this.btnGerii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(190, 105);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(152, 20);
            this.txtParola.TabIndex = 2;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(190, 69);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(152, 20);
            this.txtKulAdi.TabIndex = 1;
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Location = new System.Drawing.Point(171, 182);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(94, 36);
            this.btnYoneticiGiris.TabIndex = 8;
            this.btnYoneticiGiris.Text = "Giriş";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // pnlKulGiriss
            // 
            this.pnlKulGiriss.Controls.Add(this.txtOgrSifre);
            this.pnlKulGiriss.Controls.Add(this.txtOgrNo);
            this.pnlKulGiriss.Controls.Add(this.label4);
            this.pnlKulGiriss.Controls.Add(this.label3);
            this.pnlKulGiriss.Controls.Add(this.btnOgrGiris);
            this.pnlKulGiriss.Controls.Add(this.btnGeri);
            this.pnlKulGiriss.Location = new System.Drawing.Point(12, 12);
            this.pnlKulGiriss.Name = "pnlKulGiriss";
            this.pnlKulGiriss.Size = new System.Drawing.Size(500, 300);
            this.pnlKulGiriss.TabIndex = 5;
            // 
            // txtOgrSifre
            // 
            this.txtOgrSifre.Location = new System.Drawing.Point(223, 88);
            this.txtOgrSifre.Name = "txtOgrSifre";
            this.txtOgrSifre.Size = new System.Drawing.Size(136, 20);
            this.txtOgrSifre.TabIndex = 4;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(223, 49);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(136, 20);
            this.txtOgrNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrenci No";
            // 
            // btnOgrGiris
            // 
            this.btnOgrGiris.Location = new System.Drawing.Point(190, 182);
            this.btnOgrGiris.Name = "btnOgrGiris";
            this.btnOgrGiris.Size = new System.Drawing.Size(75, 23);
            this.btnOgrGiris.TabIndex = 0;
            this.btnOgrGiris.Text = "Giriş";
            this.btnOgrGiris.UseVisualStyleBackColor = true;
            this.btnOgrGiris.Click += new System.EventHandler(this.btnOgrGiris_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(24, 263);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 328);
            this.Controls.Add(this.pnlYonGiris);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.pnlKulGiriss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlGiris.ResumeLayout(false);
            this.pnlYonGiris.ResumeLayout(false);
            this.pnlYonGiris.PerformLayout();
            this.pnlKulGiriss.ResumeLayout(false);
            this.pnlKulGiriss.PerformLayout();
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
        private System.Windows.Forms.Button btnOgrGiris;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGerii;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Button btnYoneticiGiris;


    }
}

