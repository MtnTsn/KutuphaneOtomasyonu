using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            pnlGiris.Visible = true;
            pnlYonGiris.Visible = false;
            pnlKulGiriss.Visible = false;
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            pnlYonGiris.Visible = true;
            pnlKulGiriss.Visible = false;
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            pnlYonGiris.Visible = false;
            pnlKulGiriss.Visible = true;    
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            pnlYonGiris.Visible = false;
            pnlKulGiriss.Visible = false;    
        }

        private void btnGerii_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            pnlYonGiris.Visible = false;
            pnlKulGiriss.Visible = false;
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKulAdi.Text;
            string Parola = txtParola.Text;
            int kontrol = 0;

            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            
            SqlCommand cmdOku = new SqlCommand("SELECT * FROM Yonetici", baglanti);
            SqlDataReader drOku = cmdOku.ExecuteReader();
            
            
            while (drOku.Read() && kontrol==0)
            {
                if ((drOku["KullaniciAdi"].ToString() == KullaniciAdi) && (drOku["Parola"].ToString() == Parola))
                {
                    kontrol = 1;
                    formYoneticiEkrani YoneticiEkrani = new formYoneticiEkrani();
                    if (YoneticiEkrani!=null || YoneticiEkrani.IsDisposed)
                    {
                        YoneticiEkrani.Show();
                    }
                    
                    
                }
                else
                {
                    lblHata.Text = "Kullanıcı adı veya parola hatalıdır. Tekrar deneyiniz.";
                }

            }
            drOku.Close();
            baglanti.Close();
        }

        private void btnOgrGiris_Click(object sender, EventArgs e)
        {

        }

    }
}
