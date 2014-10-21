namespace Kutuphane
{
    partial class KitapDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYayinYeri = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.yazarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetYazar = new Kutuphane.KutuphaneDataSetYazar();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbAltTur = new System.Windows.Forms.ComboBox();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.cbDil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yazarTableAdapter = new Kutuphane.KutuphaneDataSetYazarTableAdapters.YazarTableAdapter();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alt Tür";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayın Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yayın Yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Yayınevi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Yazar";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(123, 18);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(151, 20);
            this.txtISBN.TabIndex = 9;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(123, 45);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(151, 20);
            this.txtKitapAdi.TabIndex = 10;
            // 
            // txtYayinYeri
            // 
            this.txtYayinYeri.Location = new System.Drawing.Point(123, 215);
            this.txtYayinYeri.Name = "txtYayinYeri";
            this.txtYayinYeri.Size = new System.Drawing.Size(151, 20);
            this.txtYayinYeri.TabIndex = 15;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(123, 246);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(151, 20);
            this.txtYayinevi.TabIndex = 16;
            // 
            // cbYazar
            // 
            this.cbYazar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.yazarBindingSource1, "YazarID", true));
            this.cbYazar.DataSource = this.yazarBindingSource1;
            this.cbYazar.DisplayMember = "AdSoyad";
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(123, 276);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(151, 21);
            this.cbYazar.TabIndex = 17;
            this.cbYazar.ValueMember = "YazarID";
            // 
            // yazarBindingSource1
            // 
            this.yazarBindingSource1.DataMember = "Yazar";
            this.yazarBindingSource1.DataSource = this.kutuphaneDataSetYazar;
            // 
            // kutuphaneDataSetYazar
            // 
            this.kutuphaneDataSetYazar.DataSetName = "KutuphaneDataSetYazar";
            this.kutuphaneDataSetYazar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(213, 312);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(61, 56);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(280, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 56);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(342, 312);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(60, 56);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtYayinTarihi
            // 
            this.dtYayinTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtYayinTarihi.Location = new System.Drawing.Point(123, 183);
            this.dtYayinTarihi.Name = "dtYayinTarihi";
            this.dtYayinTarihi.Size = new System.Drawing.Size(151, 20);
            this.dtYayinTarihi.TabIndex = 21;
            // 
            // cbTur
            // 
            this.cbTur.Items.AddRange(new object[] {
            "Kitap",
            "E-Kitap",
            "Tez"});
            this.cbTur.Location = new System.Drawing.Point(123, 72);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(151, 21);
            this.cbTur.TabIndex = 22;
            // 
            // cbAltTur
            // 
            this.cbAltTur.FormattingEnabled = true;
            this.cbAltTur.Items.AddRange(new object[] {
            "Anı",
            "Araştırma",
            "Belge",
            "Biyografi",
            "Deneme",
            "Doktora",
            "Felsefe",
            "Gezi",
            "Masal",
            "Otobiyografi",
            "Roman",
            "Yüksek Lisans",
            "Şiir"});
            this.cbAltTur.Location = new System.Drawing.Point(123, 100);
            this.cbAltTur.Name = "cbAltTur";
            this.cbAltTur.Size = new System.Drawing.Size(151, 21);
            this.cbAltTur.TabIndex = 23;
            // 
            // cbBolum
            // 
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Items.AddRange(new object[] {
            "Umuttepe",
            "Anıtpark"});
            this.cbBolum.Location = new System.Drawing.Point(123, 127);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(151, 21);
            this.cbBolum.TabIndex = 24;
            // 
            // cbDil
            // 
            this.cbDil.FormattingEnabled = true;
            this.cbDil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Almanca",
            "Portekizce",
            "İspanyolca",
            "Arapça",
            "Fransızca",
            "Rusça"});
            this.cbDil.Location = new System.Drawing.Point(123, 155);
            this.cbDil.Name = "cbDil";
            this.cbDil.Size = new System.Drawing.Size(151, 21);
            this.cbDil.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Dil";
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(290, 45);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(286, 244);
            this.txtOzet.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Özet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 26);
            this.label12.TabIndex = 29;
            this.label12.Text = "Kitap silmek için \r\nISBN girmeniz yeterlidir.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // KitapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(588, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbDil);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.cbAltTur);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.dtYayinTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbYazar);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYayinYeri);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "KitapDuzenle";
            this.Text = "Kitap Düzenle";
            this.Load += new System.EventHandler(this.formKitapDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYayinYeri;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtYayinTarihi;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbAltTur;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.ComboBox cbDil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private KutuphaneDataSetYazar kutuphaneDataSetYazar;
        private System.Windows.Forms.BindingSource yazarBindingSource1;
        private KutuphaneDataSetYazarTableAdapters.YazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}