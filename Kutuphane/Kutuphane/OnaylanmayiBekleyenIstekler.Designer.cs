namespace Kutuphane
{
    partial class OnaylanmayiBekleyenIstekler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kutuphaneDataSetKullanicilar = new Kutuphane.KutuphaneDataSetKullanicilar();
            this.kutuphaneDataSetKullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKitaplar = new Kutuphane.KutuphaneDataSetKitaplar();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTableAdapter = new Kutuphane.KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rafta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OduncBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnSecileniOnayla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Rafta,
            this.OduncBilgisi});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // kutuphaneDataSetKullanicilar
            // 
            this.kutuphaneDataSetKullanicilar.DataSetName = "KutuphaneDataSetKullanicilar";
            this.kutuphaneDataSetKullanicilar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneDataSetKullanicilarBindingSource
            // 
            this.kutuphaneDataSetKullanicilarBindingSource.DataSource = this.kutuphaneDataSetKullanicilar;
            this.kutuphaneDataSetKullanicilarBindingSource.Position = 0;
            // 
            // kutuphaneDataSetKitaplar
            // 
            this.kutuphaneDataSetKitaplar.DataSetName = "KutuphaneDataSetKitaplar";
            this.kutuphaneDataSetKitaplar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneDataSetKitaplar;
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
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnSecileniOnayla
            // 
            this.btnSecileniOnayla.Location = new System.Drawing.Point(62, 189);
            this.btnSecileniOnayla.Name = "btnSecileniOnayla";
            this.btnSecileniOnayla.Size = new System.Drawing.Size(53, 45);
            this.btnSecileniOnayla.TabIndex = 1;
            this.btnSecileniOnayla.Text = "Seçileni Onayla";
            this.btnSecileniOnayla.UseVisualStyleBackColor = true;
            this.btnSecileniOnayla.Click += new System.EventHandler(this.btnSecileniOnayla_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(367, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 201);
            this.panel1.TabIndex = 2;
            // 
            // OnaylanmayiBekleyenIstekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSecileniOnayla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OnaylanmayiBekleyenIstekler";
            this.Text = "OnaylanmayiBekleyenIstekler";
            this.Load += new System.EventHandler(this.OnaylanmayiBekleyenIstekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kutuphaneDataSetKullanicilarBindingSource;
        private KutuphaneDataSetKullanicilar kutuphaneDataSetKullanicilar;
        private KutuphaneDataSetKitaplar kutuphaneDataSetKitaplar;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rafta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OduncBilgisi;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnSecileniOnayla;
        private System.Windows.Forms.Panel panel1;
    }
}