namespace Kutuphane
{
    partial class Kullanicilar
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
            this.components = new System.ComponentModel.Container();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.OgrenciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKullanicilar = new Kutuphane.KutuphaneDataSetKullanicilar();
            this.kullaniciTableAdapter = new Kutuphane.KutuphaneDataSetKullanicilarTableAdapters.KullaniciTableAdapter();
            this.btnBilgiler = new System.Windows.Forms.Button();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.llSifre = new System.Windows.Forms.LinkLabel();
            this.lblKitap = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOnaylanmayiBekleyenIstekler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilar)).BeginInit();
            this.pnlBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToOrderColumns = true;
            this.dgvKullanicilar.AutoGenerateColumns = false;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgrenciNo,
            this.Sifre,
            this.ISBN,
            this.Gun,
            this.AdSoyad});
            this.dgvKullanicilar.DataSource = this.kullaniciBindingSource;
            this.dgvKullanicilar.Location = new System.Drawing.Point(35, 107);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.Size = new System.Drawing.Size(247, 170);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.DataPropertyName = "OgrenciNo";
            this.OgrenciNo.HeaderText = "OgrenciNo";
            this.OgrenciNo.Name = "OgrenciNo";
            // 
            // Sifre
            // 
            this.Sifre.DataPropertyName = "Sifre";
            this.Sifre.HeaderText = "Sifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sifre.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Visible = false;
            // 
            // Gun
            // 
            this.Gun.DataPropertyName = "Gun";
            this.Gun.HeaderText = "Gun";
            this.Gun.Name = "Gun";
            this.Gun.Visible = false;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "AdSoyad";
            this.AdSoyad.Name = "AdSoyad";
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.kutuphaneDataSetKullanicilar;
            // 
            // kutuphaneDataSetKullanicilar
            // 
            this.kutuphaneDataSetKullanicilar.DataSetName = "KutuphaneDataSetKullanicilar";
            this.kutuphaneDataSetKullanicilar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // btnBilgiler
            // 
            this.btnBilgiler.Location = new System.Drawing.Point(302, 107);
            this.btnBilgiler.Name = "btnBilgiler";
            this.btnBilgiler.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiler.TabIndex = 1;
            this.btnBilgiler.Text = "Bilgiler";
            this.btnBilgiler.UseVisualStyleBackColor = true;
            this.btnBilgiler.Click += new System.EventHandler(this.btnBilgiler_Click);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Controls.Add(this.label4);
            this.pnlBilgiler.Controls.Add(this.llSifre);
            this.pnlBilgiler.Controls.Add(this.lblKitap);
            this.pnlBilgiler.Controls.Add(this.label12);
            this.pnlBilgiler.Controls.Add(this.lblSifre);
            this.pnlBilgiler.Controls.Add(this.label10);
            this.pnlBilgiler.Controls.Add(this.lblOgrenciNo);
            this.pnlBilgiler.Controls.Add(this.label8);
            this.pnlBilgiler.Controls.Add(this.lblAdSoyad);
            this.pnlBilgiler.Controls.Add(this.label3);
            this.pnlBilgiler.Location = new System.Drawing.Point(450, 39);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(328, 297);
            this.pnlBilgiler.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // llSifre
            // 
            this.llSifre.AutoSize = true;
            this.llSifre.Location = new System.Drawing.Point(111, 82);
            this.llSifre.Name = "llSifre";
            this.llSifre.Size = new System.Drawing.Size(38, 13);
            this.llSifre.TabIndex = 10;
            this.llSifre.TabStop = true;
            this.llSifre.Text = "Göster";
            this.llSifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSifre_LinkClicked);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(111, 122);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(0, 13);
            this.lblKitap.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Kitap";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(155, 91);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(0, 13);
            this.lblSifre.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Şifre";
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(111, 57);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Öğrenci NO";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(111, 29);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(35, 68);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciNo.TabIndex = 3;
            this.txtOgrenciNo.TextChanged += new System.EventHandler(this.txtOgrenciNo_TextChanged);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(141, 68);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtAdiSoyadi.TabIndex = 4;
            this.txtAdiSoyadi.TextChanged += new System.EventHandler(this.txtAdiSoyadi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adi Soyadi";
            // 
            // btnOnaylanmayiBekleyenIstekler
            // 
            this.btnOnaylanmayiBekleyenIstekler.Location = new System.Drawing.Point(302, 143);
            this.btnOnaylanmayiBekleyenIstekler.Name = "btnOnaylanmayiBekleyenIstekler";
            this.btnOnaylanmayiBekleyenIstekler.Size = new System.Drawing.Size(76, 60);
            this.btnOnaylanmayiBekleyenIstekler.TabIndex = 7;
            this.btnOnaylanmayiBekleyenIstekler.Text = "Onaylanmayi Bekleyen İstekler";
            this.btnOnaylanmayiBekleyenIstekler.UseVisualStyleBackColor = true;
            this.btnOnaylanmayiBekleyenIstekler.Click += new System.EventHandler(this.OnaylanmayiBekleyenİstekler_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 367);
            this.Controls.Add(this.btnOnaylanmayiBekleyenIstekler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.btnBilgiler);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilar)).EndInit();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private KutuphaneDataSetKullanicilar kutuphaneDataSetKullanicilar;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private KutuphaneDataSetKullanicilarTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.Button btnBilgiler;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llSifre;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrenciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOnaylanmayiBekleyenIstekler;
    }
}