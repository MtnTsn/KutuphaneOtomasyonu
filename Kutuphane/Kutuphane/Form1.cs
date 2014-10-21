using System;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;
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
            pnlGiris.Visible = true;
            pnlYonGiris.Visible = false;
            pnlKulGiriss.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHata.Text = "Kullanıcı adınızı ve şifrenizi giriniz.";
            pbHataKul.Visible = false;
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
                    YoneticiEkrani frmYoneticiEkrani = new YoneticiEkrani();
                    if (frmYoneticiEkrani != null || frmYoneticiEkrani.IsDisposed) //eğer form açıksa tekrar açılmasını engellemek için yazdım ama işe yaramadı.
                    {
                        frmYoneticiEkrani.Show();
                    }
                }
                else
                {
                    pbHata.Visible = true;
                    lblHata.Text = "Kullanıcı adı veya parola hatalıdır. Tekrar deneyiniz.";
                    //System.Threading.Thread.Sleep(5000);
                    //lblHata.Text = "";
                    //pbHata.Visible = false;

                }

            }
            drOku.Close();
            baglanti.Close();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            string OgrenciNo = txtOgrNo.Text;
            string Sifre = txtOgrSifre.Text;
            int kontrol = 0;

            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();

            SqlCommand cmdOku = new SqlCommand("SELECT * FROM Kullanici", baglanti);
            SqlDataReader drOku = cmdOku.ExecuteReader();

            while (drOku.Read() && kontrol == 0)
            {
                if ((drOku["OgrenciNo"].ToString() == OgrenciNo) && (drOku["Sifre"].ToString() == Sifre))
                {
                    kontrol = 1;
                    KullaniciEkrani frmKullaniciEkrani = new KullaniciEkrani();
                    //if (frmKullaniciEkrani != null || frmKullaniciEkrani.IsDisposed)
                    //{
                        frmKullaniciEkrani.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Zaten giriş yaptınız.");
                    //}
                }
                else
                {
                    pbHataKul.Visible = true;
                    lblHataKul.Text = "Öğrenci numarası veya şifre hatalıdır. Tekrar deneyiniz.";
                    //System.Threading.Thread.Sleep(5000);
                    //lblHataKul.Text = "";
                    //pbHataKul.Visible = false;
                }

            }
            drOku.Close();
            baglanti.Close();
        }

        private void llKullaniciKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayit frmKullaniciKayit = new KullaniciKayit();
            frmKullaniciKayit.Show();
        }

        private void llYoneticiKaydi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiKayit frmYoneticiKayit = new YoneticiKayit();
            frmYoneticiKayit.Show();
        }








    }
}
