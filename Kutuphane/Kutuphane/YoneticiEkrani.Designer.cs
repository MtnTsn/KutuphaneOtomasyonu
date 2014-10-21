namespace Kutuphane
{
    partial class YoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            this.btnKitDuzenle = new System.Windows.Forms.Button();
            this.btnYazarDuzenle = new System.Windows.Forms.Button();
            this.pnlKitapAra = new System.Windows.Forms.Panel();
            this.pnlKitaplar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAyrintilar = new System.Windows.Forms.Button();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raftaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncBilgisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKitapOzetYazar = new Kutuphane.KutuphaneDataSetKitapOzetYazar();
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
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetYazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetYazar = new Kutuphane.KutuphaneDataSetYazar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNormalArama = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.llDetayliArama = new System.Windows.Forms.LinkLabel();
            this.kitapTableAdapter = new Kutuphane.KutuphaneDataSetKitapOzetYazarTableAdapters.KitapTableAdapter();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.yazarTableAdapter = new Kutuphane.KutuphaneDataSetYazarTableAdapters.YazarTableAdapter();
            this.yazarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlKitapAra.SuspendLayout();
            this.pnlKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitapOzetYazar)).BeginInit();
            this.pnlDetayliArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).BeginInit();
            this.pnlNormalArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKitDuzenle
            // 
            this.btnKitDuzenle.Location = new System.Drawing.Point(12, 13);
            this.btnKitDuzenle.Name = "btnKitDuzenle";
            this.btnKitDuzenle.Size = new System.Drawing.Size(57, 37);
            this.btnKitDuzenle.TabIndex = 0;
            this.btnKitDuzenle.Text = "Kitapları Düzenle";
            this.btnKitDuzenle.UseVisualStyleBackColor = true;
            this.btnKitDuzenle.Click += new System.EventHandler(this.btnKitapDuzenle_Click);
            // 
            // btnYazarDuzenle
            // 
            this.btnYazarDuzenle.Location = new System.Drawing.Point(75, 13);
            this.btnYazarDuzenle.Name = "btnYazarDuzenle";
            this.btnYazarDuzenle.Size = new System.Drawing.Size(93, 37);
            this.btnYazarDuzenle.TabIndex = 1;
            this.btnYazarDuzenle.Text = "Yazar Düzenle";
            this.btnYazarDuzenle.UseVisualStyleBackColor = true;
            this.btnYazarDuzenle.Click += new System.EventHandler(this.btnYazarDuzenle_Click);
            // 
            // pnlKitapAra
            // 
            this.pnlKitapAra.Controls.Add(this.pnlKitaplar);
            this.pnlKitapAra.Controls.Add(this.pnlDetayliArama);
            this.pnlKitapAra.Controls.Add(this.pnlNormalArama);
            this.pnlKitapAra.Location = new System.Drawing.Point(12, 56);
            this.pnlKitapAra.Name = "pnlKitapAra";
            this.pnlKitapAra.Size = new System.Drawing.Size(931, 362);
            this.pnlKitapAra.TabIndex = 2;
            // 
            // pnlKitaplar
            // 
            this.pnlKitaplar.Controls.Add(this.label10);
            this.pnlKitaplar.Controls.Add(this.btnAyrintilar);
            this.pnlKitaplar.Controls.Add(this.dgvKitap);
            this.pnlKitaplar.Location = new System.Drawing.Point(279, 3);
            this.pnlKitaplar.Name = "pnlKitaplar";
            this.pnlKitaplar.Size = new System.Drawing.Size(625, 348);
            this.pnlKitaplar.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "label10";
            // 
            // btnAyrintilar
            // 
            this.btnAyrintilar.Location = new System.Drawing.Point(76, 244);
            this.btnAyrintilar.Name = "btnAyrintilar";
            this.btnAyrintilar.Size = new System.Drawing.Size(75, 23);
            this.btnAyrintilar.TabIndex = 38;
            this.btnAyrintilar.Text = "Ayrıntılar";
            this.btnAyrintilar.UseVisualStyleBackColor = true;
            this.btnAyrintilar.Click += new System.EventHandler(this.btnAyrintilar_Click);
            // 
            // dgvKitap
            // 
            this.dgvKitap.AllowUserToOrderColumns = true;
            this.dgvKitap.AutoGenerateColumns = false;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.raftaDataGridViewTextBoxColumn,
            this.oduncBilgisiDataGridViewTextBoxColumn});
            this.dgvKitap.DataSource = this.kitapBindingSource;
            this.dgvKitap.Location = new System.Drawing.Point(13, 27);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.Size = new System.Drawing.Size(548, 164);
            this.dgvKitap.TabIndex = 37;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // raftaDataGridViewTextBoxColumn
            // 
            this.raftaDataGridViewTextBoxColumn.DataPropertyName = "Rafta";
            this.raftaDataGridViewTextBoxColumn.HeaderText = "Rafta";
            this.raftaDataGridViewTextBoxColumn.Name = "raftaDataGridViewTextBoxColumn";
            // 
            // oduncBilgisiDataGridViewTextBoxColumn
            // 
            this.oduncBilgisiDataGridViewTextBoxColumn.DataPropertyName = "OduncBilgisi";
            this.oduncBilgisiDataGridViewTextBoxColumn.HeaderText = "OduncBilgisi";
            this.oduncBilgisiDataGridViewTextBoxColumn.Name = "oduncBilgisiDataGridViewTextBoxColumn";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneDataSetKitapOzetYazar;
            // 
            // kutuphaneDataSetKitapOzetYazar
            // 
            this.kutuphaneDataSetKitapOzetYazar.DataSetName = "KutuphaneDataSetKitapOzetYazar";
            this.kutuphaneDataSetKitapOzetYazar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtKitapAdi.Location = new System.Drawing.Point(101, 13);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(152, 20);
            this.txtKitapAdi.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Kitap Adı";
            // 
            // lbNormalArama
            // 
            this.lbNormalArama.AutoSize = true;
            this.lbNormalArama.Location = new System.Drawing.Point(3, 220);
            this.lbNormalArama.Name = "lbNormalArama";
            this.lbNormalArama.Size = new System.Drawing.Size(88, 13);
            this.lbNormalArama.TabIndex = 49;
            this.lbNormalArama.TabStop = true;
            this.lbNormalArama.Text = "<---Normal Arama";
            this.lbNormalArama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNormalArama_LinkClicked);
            // 
            // btnDetayliAra
            // 
            this.btnDetayliAra.Location = new System.Drawing.Point(135, 220);
            this.btnDetayliAra.Name = "btnDetayliAra";
            this.btnDetayliAra.Size = new System.Drawing.Size(75, 23);
            this.btnDetayliAra.TabIndex = 48;
            this.btnDetayliAra.Text = "Ara";
            this.btnDetayliAra.UseVisualStyleBackColor = true;
            this.btnDetayliAra.Click += new System.EventHandler(this.btnDetayliAra_Click);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(101, 167);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(152, 20);
            this.txtYayinevi.TabIndex = 47;
            // 
            // txtYayinYeri
            // 
            this.txtYayinYeri.Location = new System.Drawing.Point(101, 141);
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
            this.cbDil.Location = new System.Drawing.Point(101, 114);
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
            this.cbBolum.Location = new System.Drawing.Point(101, 87);
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
            this.cbAltTur.Location = new System.Drawing.Point(101, 62);
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
            this.cbTur.Location = new System.Drawing.Point(101, 38);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(152, 21);
            this.cbTur.TabIndex = 42;
            // 
            // cbYazar
            // 
            this.cbYazar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.yazarBindingSource, "YazarID", true));
            this.cbYazar.DataSource = this.yazarBindingSource;
            this.cbYazar.DisplayMember = "AdSoyad";
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(101, 193);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(152, 21);
            this.cbYazar.TabIndex = 41;
            this.cbYazar.ValueMember = "YazarID";
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "Yazar";
            this.yazarBindingSource.DataSource = this.kutuphaneDataSetYazarBindingSource;
            // 
            // kutuphaneDataSetYazarBindingSource
            // 
            this.kutuphaneDataSetYazarBindingSource.DataSource = this.kutuphaneDataSetYazar;
            this.kutuphaneDataSetYazarBindingSource.Position = 0;
            // 
            // kutuphaneDataSetYazar
            // 
            this.kutuphaneDataSetYazar.DataSetName = "KutuphaneDataSetYazar";
            this.kutuphaneDataSetYazar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Yazar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Yayın Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bölüm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Alt Tür";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tür";
            // 
            // pnlNormalArama
            // 
            this.pnlNormalArama.Controls.Add(this.pictureBox1);
            this.pnlNormalArama.Controls.Add(this.btnAra);
            this.pnlNormalArama.Controls.Add(this.label8);
            this.pnlNormalArama.Controls.Add(this.txtAnahtarKelime);
            this.pnlNormalArama.Controls.Add(this.llDetayliArama);
            this.pnlNormalArama.Location = new System.Drawing.Point(3, 3);
            this.pnlNormalArama.Name = "pnlNormalArama";
            this.pnlNormalArama.Size = new System.Drawing.Size(270, 250);
            this.pnlNormalArama.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 76);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(39, 118);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 33);
            this.btnAra.TabIndex = 38;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Anahtar Kelime";
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(17, 84);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(146, 20);
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
            this.llDetayliArama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDetatliArama_LinkClicked);
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Location = new System.Drawing.Point(174, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(68, 38);
            this.btnKullanicilar.TabIndex = 3;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // yazarBindingSource1
            // 
            this.yazarBindingSource1.DataMember = "Yazar";
            this.yazarBindingSource1.DataSource = this.kutuphaneDataSetYazarBindingSource;
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 430);
            this.Controls.Add(this.btnKullanicilar);
            this.Controls.Add(this.pnlKitapAra);
            this.Controls.Add(this.btnYazarDuzenle);
            this.Controls.Add(this.btnKitDuzenle);
            this.Name = "YoneticiEkrani";
            this.Text = "YoneticiEkrani";
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.pnlKitapAra.ResumeLayout(false);
            this.pnlKitaplar.ResumeLayout(false);
            this.pnlKitaplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitapOzetYazar)).EndInit();
            this.pnlDetayliArama.ResumeLayout(false);
            this.pnlDetayliArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).EndInit();
            this.pnlNormalArama.ResumeLayout(false);
            this.pnlNormalArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitDuzenle;
        private System.Windows.Forms.Button btnYazarDuzenle;
        private System.Windows.Forms.Panel pnlKitapAra;
        private System.Windows.Forms.LinkLabel llDetayliArama;
        private System.Windows.Forms.Panel pnlDetayliArama;
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
        private System.Windows.Forms.LinkLabel lbNormalArama;
        private System.Windows.Forms.Panel pnlNormalArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAnahtarKelime;
        private KutuphaneDataSetKitapOzetYazar kutuphaneDataSetKitapOzetYazar;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneDataSetKitapOzetYazarTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raftaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncBilgisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlKitaplar;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAyrintilar;
        public System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource kutuphaneDataSetYazarBindingSource;
        private KutuphaneDataSetYazar kutuphaneDataSetYazar;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private KutuphaneDataSetYazarTableAdapters.YazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.BindingSource yazarBindingSource1;
        public System.Windows.Forms.Label label10;
    }
}