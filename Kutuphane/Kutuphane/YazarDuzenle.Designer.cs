namespace Kutuphane
{
    partial class YazarDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarDuzenle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kutuphaneDataSetYazar = new Kutuphane.KutuphaneDataSetYazar();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarTableAdapter = new Kutuphane.KutuphaneDataSetYazarTableAdapters.YazarTableAdapter();
            this.dgvYazar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtYazarAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYazarID = new System.Windows.Forms.Label();
            this.YazarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlkEseri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazar)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneDataSetYazar
            // 
            this.kutuphaneDataSetYazar.DataSetName = "KutuphaneDataSetYazar";
            this.kutuphaneDataSetYazar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "Yazar";
            this.yazarBindingSource.DataSource = this.kutuphaneDataSetYazar;
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // dgvYazar
            // 
            this.dgvYazar.AllowUserToOrderColumns = true;
            this.dgvYazar.AutoGenerateColumns = false;
            this.dgvYazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYazar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YazarID,
            this.AdSoyad,
            this.DogumTarihi,
            this.DogumYeri,
            this.IlkEseri});
            this.dgvYazar.DataSource = this.yazarBindingSource;
            this.dgvYazar.Location = new System.Drawing.Point(12, 73);
            this.dgvYazar.Name = "dgvYazar";
            this.dgvYazar.Size = new System.Drawing.Size(545, 210);
            this.dgvYazar.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(108, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 42);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(38, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(64, 42);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(496, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(61, 55);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(170, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 42);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtYazarAra
            // 
            this.txtYazarAra.Location = new System.Drawing.Point(331, 37);
            this.txtYazarAra.Name = "txtYazarAra";
            this.txtYazarAra.Size = new System.Drawing.Size(116, 20);
            this.txtYazarAra.TabIndex = 5;
            this.txtYazarAra.TextChanged += new System.EventHandler(this.txtYazarAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yazar Adı";
            // 
            // lblYazarID
            // 
            this.lblYazarID.AutoSize = true;
            this.lblYazarID.Location = new System.Drawing.Point(276, 13);
            this.lblYazarID.Name = "lblYazarID";
            this.lblYazarID.Size = new System.Drawing.Size(0, 13);
            this.lblYazarID.TabIndex = 7;
            // 
            // YazarID
            // 
            this.YazarID.DataPropertyName = "YazarID";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YazarID.DefaultCellStyle = dataGridViewCellStyle2;
            this.YazarID.HeaderText = "YazarID";
            this.YazarID.Name = "YazarID";
            this.YazarID.ReadOnly = true;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "AdSoyad";
            this.AdSoyad.Name = "AdSoyad";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // DogumYeri
            // 
            this.DogumYeri.DataPropertyName = "DogumYeri";
            this.DogumYeri.HeaderText = "DogumYeri";
            this.DogumYeri.Name = "DogumYeri";
            // 
            // IlkEseri
            // 
            this.IlkEseri.DataPropertyName = "IlkEseri";
            this.IlkEseri.HeaderText = "IlkEseri";
            this.IlkEseri.Name = "IlkEseri";
            // 
            // YazarDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 295);
            this.Controls.Add(this.lblYazarID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYazarAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvYazar);
            this.MaximizeBox = false;
            this.Name = "YazarDuzenle";
            this.Text = "YazarDuzenle";
            this.Load += new System.EventHandler(this.YazarDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KutuphaneDataSetYazar kutuphaneDataSetYazar;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private KutuphaneDataSetYazarTableAdapters.YazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnYenile;
        public System.Windows.Forms.DataGridView dgvYazar;
        private System.Windows.Forms.TextBox txtYazarAra;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblYazarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlkEseri;


    }
}