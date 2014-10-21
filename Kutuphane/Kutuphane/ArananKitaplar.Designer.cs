namespace Kutuphane
{
    partial class ArananKitaplar
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
            this.ıSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raftaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncBilgisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetKitaplar = new Kutuphane.KutuphaneDataSetKitaplar();
            this.kitapTableAdapter = new Kutuphane.KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıSBNDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.raftaDataGridViewTextBoxColumn,
            this.oduncBilgisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            this.ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
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
            this.kitapBindingSource.DataSource = this.kutuphaneDataSetKitaplar;
            // 
            // kutuphaneDataSetKitaplar
            // 
            this.kutuphaneDataSetKitaplar.DataSetName = "KutuphaneDataSetKitaplar";
            this.kutuphaneDataSetKitaplar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // ArananKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 311);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArananKitaplar";
            this.Text = "ArananKitaplar";
            this.Load += new System.EventHandler(this.ArananKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneDataSetKitaplar kutuphaneDataSetKitaplar;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KutuphaneDataSetKitaplarTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raftaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncBilgisiDataGridViewTextBoxColumn;





    }
}