namespace Kutuphane
{
    partial class formYoneticiEkrani
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
            this.btnKitDuzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitDuzenle
            // 
            this.btnKitDuzenle.Location = new System.Drawing.Point(12, 12);
            this.btnKitDuzenle.Name = "btnKitDuzenle";
            this.btnKitDuzenle.Size = new System.Drawing.Size(68, 54);
            this.btnKitDuzenle.TabIndex = 0;
            this.btnKitDuzenle.Text = "Kitapları Düzenle";
            this.btnKitDuzenle.UseVisualStyleBackColor = true;
            this.btnKitDuzenle.Click += new System.EventHandler(this.btnKitDuzenle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazar Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formYoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKitDuzenle);
            this.Name = "formYoneticiEkrani";
            this.Text = "YoneticiEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitDuzenle;
        private System.Windows.Forms.Button button1;
    }
}