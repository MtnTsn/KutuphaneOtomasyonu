namespace Kutuphane
{
    partial class KullaniciEkrani
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
            this.pnlKitapAra = new System.Windows.Forms.Panel();
            this.pnlKitaplar = new System.Windows.Forms.Panel();
            this.btnAyrintilar = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKitaplar = new Kutuphane.KutuphaneDataSetKitaplar();
            this.pnlDetayliArama = new System.Windows.Forms.Panel();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNormalArama = new System.Windows.Forms.LinkLabel();
            this.btnDetayliAra = new System.Windows.Forms.Button();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYayinYeri = new System.Windows.Forms.TextBox();
            this.cbDil = new System.Windows.Forms.ComboBox();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.cbAltTur = new System.Windows.Forms.ComboBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNormalArama = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.llDetayliArama = new System.Windows.Forms.LinkLabel();
            this.kitapTableAdapter = new Kutuphane.KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rafta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OduncBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKitapAra.SuspendLayout();
            this.pnlKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).BeginInit();
            this.pnlDetayliArama.SuspendLayout();
            this.pnlNormalArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKitapAra
            // 
            this.pnlKitapAra.Controls.Add(this.pnlKitaplar);
            this.pnlKitapAra.Controls.Add(this.pnlDetayliArama);
            this.pnlKitapAra.Controls.Add(this.pnlNormalArama);
            this.pnlKitapAra.Location = new System.Drawing.Point(10, 10);
            this.pnlKitapAra.Name = "pnlKitapAra";
            this.pnlKitapAra.Size = new System.Drawing.Size(931, 362);
            this.pnlKitapAra.TabIndex = 3;
            // 
            // pnlKitaplar
            // 
            this.pnlKitaplar.Controls.Add(this.btnAyrintilar);
            this.pnlKitaplar.Controls.Add(this.btnAl);
            this.pnlKitaplar.Controls.Add(this.dgvKitap);
            this.pnlKitaplar.Location = new System.Drawing.Point(279, 3);
            this.pnlKitaplar.Name = "pnlKitaplar";
            this.pnlKitaplar.Size = new System.Drawing.Size(625, 348);
            this.pnlKitaplar.TabIndex = 38;
            // 
            // btnAyrintilar
            // 
            this.btnAyrintilar.Location = new System.Drawing.Point(185, 223);
            this.btnAyrintilar.Name = "btnAyrintilar";
            this.btnAyrintilar.Size = new System.Drawing.Size(75, 23);
            this.btnAyrintilar.TabIndex = 39;
            this.btnAyrintilar.Text = "Ayrıntılar";
            this.btnAyrintilar.UseVisualStyleBackColor = true;
            this.btnAyrintilar.Click += new System.EventHandler(this.btnAyrintilar_Click);
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(75, 222);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(94, 24);
            this.btnAl.TabIndex = 38;
            this.btnAl.Text = "Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // dgvKitap
            // 
            this.dgvKitap.AllowUserToOrderColumns = true;
            this.dgvKitap.AutoGenerateColumns = false;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.KitapAdi,
            this.Bolum,
            this.Rafta,
            this.OduncBilgisi});
            this.dgvKitap.DataSource = this.kitapBindingSource;
            this.dgvKitap.Location = new System.Drawing.Point(16, 15);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.Size = new System.Drawing.Size(548, 164);
            this.dgvKitap.TabIndex = 37;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneDataSetKitaplarBindingSource;
            // 
            // kutuphaneDataSetKitaplarBindingSource
            // 
            this.kutuphaneDataSetKitaplarBindingSource.DataSource = this.kutuphaneDataSetKitaplar;
            this.kutuphaneDataSetKitaplarBindingSource.Position = 0;
            // 
            // kutuphaneDataSetKitaplar
            // 
            this.kutuphaneDataSetKitaplar.DataSetName = "KutuphaneDataSetKitaplar";
            this.kutuphaneDataSetKitaplar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlDetayliArama
            // 
            this.pnlDetayliArama.Controls.Add(this.txtKitapAdi);
            this.pnlDetayliArama.Controls.Add(this.label9);
            this.pnlDetayliArama.Controls.Add(this.lbNormalArama);
            this.pnlDetayliArama.Controls.Add(this.btnDetayliAra);
            this.pnlDetayliArama.Controls.Add(this.txtYayinevi);
            this.pnlDetayliArama.Controls.Add(this.txtYayinYeri);
            this.pnlDetayliArama.Controls.Add(this.cbDil);
            this.pnlDetayliArama.Controls.Add(this.cbBolum);
            this.pnlDetayliArama.Controls.Add(this.cbAltTur);
            this.pnlDetayliArama.Controls.Add(this.cbTur);
            this.pnlDetayliArama.Controls.Add(this.cbYazar);
            this.pnlDetayliArama.Controls.Add(this.label7);
            this.pnlDetayliArama.Controls.Add(this.label6);
            this.pnlDetayliArama.Controls.Add(this.label5);
            this.pnlDetayliArama.Controls.Add(this.label4);
            this.pnlDetayliArama.Controls.Add(this.label3);
            this.pnlDetayliArama.Controls.Add(this.label2);
            this.pnlDetayliArama.Controls.Add(this.label1);
            this.pnlDetayliArama.Location = new System.Drawing.Point(3, 3);
            this.pnlDetayliArama.Name = "pnlDetayliArama";
            this.pnlDetayliArama.Size = new System.Drawing.Size(270, 250);
            this.pnlDetayliArama.TabIndex = 34;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(87, 4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(152, 20);
            this.txtKitapAdi.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Kitap Adı";
            // 
            // lbNormalArama
            // 
            this.lbNormalArama.AutoSize = true;
            this.lbNormalArama.Location = new System.Drawing.Point(3, 230);
            this.lbNormalArama.Name = "lbNormalArama";
            this.lbNormalArama.Size = new System.Drawing.Size(88, 13);
            this.lbNormalArama.TabIndex = 49;
            this.lbNormalArama.TabStop = true;
            this.lbNormalArama.Text = "<---Normal Arama";
            // 
            // btnDetayliAra
            // 
            this.btnDetayliAra.Location = new System.Drawing.Point(139, 215);
            this.btnDetayliAra.Name = "btnDetayliAra";
            this.btnDetayliAra.Size = new System.Drawing.Size(75, 23);
            this.btnDetayliAra.TabIndex = 48;
            this.btnDetayliAra.Text = "Ara";
            this.btnDetayliAra.UseVisualStyleBackColor = true;
            this.btnDetayliAra.Click += new System.EventHandler(this.btnDetayliAra_Click);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(88, 159);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(152, 20);
            this.txtYayinevi.TabIndex = 47;
            // 
            // txtYayinYeri
            // 
            this.txtYayinYeri.Location = new System.Drawing.Point(88, 133);
            this.txtYayinYeri.Name = "txtYayinYeri";
            this.txtYayinYeri.Size = new System.Drawing.Size(152, 20);
            this.txtYayinYeri.TabIndex = 46;
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
            this.cbDil.Location = new System.Drawing.Point(88, 106);
            this.cbDil.Name = "cbDil";
            this.cbDil.Size = new System.Drawing.Size(152, 21);
            this.cbDil.TabIndex = 45;
            // 
            // cbBolum
            // 
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Items.AddRange(new object[] {
            "Umuttepe",
            "Anıtpark"});
            this.cbBolum.Location = new System.Drawing.Point(88, 79);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(152, 21);
            this.cbBolum.TabIndex = 44;
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
            this.cbAltTur.Location = new System.Drawing.Point(88, 54);
            this.cbAltTur.Name = "cbAltTur";
            this.cbAltTur.Size = new System.Drawing.Size(152, 21);
            this.cbAltTur.TabIndex = 43;
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Kitap",
            "E-Kitap",
            "Tez"});
            this.cbTur.Location = new System.Drawing.Point(88, 30);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(152, 21);
            this.cbTur.TabIndex = 42;
            // 
            // cbYazar
            // 
            this.cbYazar.DisplayMember = "AdSoyad";
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(88, 185);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(152, 21);
            this.cbYazar.TabIndex = 41;
            this.cbYazar.ValueMember = "YazarID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Yazar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Yayın Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bölüm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Alt Tür";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tür";
            // 
            // pnlNormalArama
            // 
            this.pnlNormalArama.Controls.Add(this.btnAra);
            this.pnlNormalArama.Controls.Add(this.label8);
            this.pnlNormalArama.Controls.Add(this.txtAnahtarKelime);
            this.pnlNormalArama.Controls.Add(this.llDetayliArama);
            this.pnlNormalArama.Location = new System.Drawing.Point(3, 3);
            this.pnlNormalArama.Name = "pnlNormalArama";
            this.pnlNormalArama.Size = new System.Drawing.Size(270, 250);
            this.pnlNormalArama.TabIndex = 36;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(38, 95);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 38;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Anahtar Kelime";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(38, 64);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(176, 20);
            this.txtAnahtarKelime.TabIndex = 36;
            // 
            // llDetayliArama
            // 
            this.llDetayliArama.AutoSize = true;
            this.llDetayliArama.Location = new System.Drawing.Point(180, 220);
            this.llDetayliArama.Name = "llDetayliArama";
            this.llDetayliArama.Size = new System.Drawing.Size(87, 13);
            this.llDetayliArama.TabIndex = 35;
            this.llDetayliArama.TabStop = true;
            this.llDetayliArama.Text = "Detaylı Arama--->";
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "KitapAdi";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // Bolum
            // 
            this.Bolum.DataPropertyName = "Bolum";
            this.Bolum.HeaderText = "Bolum";
            this.Bolum.Name = "Bolum";
            // 
            // Rafta
            // 
            this.Rafta.DataPropertyName = "Rafta";
            this.Rafta.HeaderText = "Rafta";
            this.Rafta.Name = "Rafta";
            // 
            // OduncBilgisi
            // 
            this.OduncBilgisi.DataPropertyName = "OduncBilgisi";
            this.OduncBilgisi.HeaderText = "OduncBilgisi";
            this.OduncBilgisi.Name = "OduncBilgisi";
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 460);
            this.Controls.Add(this.pnlKitapAra);
            this.Name = "KullaniciEkrani";
            this.Text = "KullaniciEkrani";
            this.Load += new System.EventHandler(this.KullaniciEkrani_Load);
            this.pnlKitapAra.ResumeLayout(false);
            this.pnlKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).EndInit();
            this.pnlDetayliArama.ResumeLayout(false);
            this.pnlDetayliArama.PerformLayout();
            this.pnlNormalArama.ResumeLayout(false);
            this.pnlNormalArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKitapAra;
        private System.Windows.Forms.Panel pnlKitaplar;
        private System.Windows.Forms.BindingSource kutuphaneDataSetKitaplarBindingSource;
        private KutuphaneDataSetKitaplar kutuphaneDataSetKitaplar;
        private System.Windows.Forms.Panel pnlNormalArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAnahtarKelime;
        private System.Windows.Forms.LinkLabel llDetayliArama;
        private System.Windows.Forms.Panel pnlDetayliArama;
        private System.Windows.Forms.LinkLabel lbNormalArama;
        private System.Windows.Forms.Button btnDetayliAra;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYayinYeri;
        private System.Windows.Forms.ComboBox cbDil;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.ComboBox cbAltTur;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAyrintilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rafta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OduncBilgisi;
        public System.Windows.Forms.DataGridView dgvKitap;
    }
}