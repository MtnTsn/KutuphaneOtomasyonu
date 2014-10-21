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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            lblHata.Text = "Lütfen Formu doldurun\n ve Tamam'a basın.";
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text!=txtSifreTekrar.Text || txtSifre.Text=="")
            {
                lblHata.Text="Lütfen şifrenizi konrtol ediniz.";
                pbHata.Visible = true;
                
            }
            else if (txtOgrenciNo.Text=="")
            {
                lblHata.Text = "Lutfen öğrenci numaranızı girip\n tekrar deneyiniz.";
                pbHata.Visible = true;
            }
            else
            {
                lblHata.Text = "Tebrikler. Kaydınız tamamlandı. \nÇıkış yapabilirsiniz.";
                pbOk.Visible = true;
                SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmdEkle = new SqlCommand("insert into Kullanici (OgrenciNo,AdSoyad,Sifre) values ('" + txtOgrenciNo.Text + "','" + txtAdSoyad.Text + "','" + txtSifre.Text + "') ", baglanti);
                cmdEkle.ExecuteNonQuery();
                baglanti.Close();
            }

        }


    }
}
