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
    public partial class YoneticiKayit : Form
    {
        public YoneticiKayit()
        {
            InitializeComponent();
        }

        private void YoneticiKaydi_Load(object sender, EventArgs e)
        {
            lblHata.Text = "Lütfen Formu doldurun\n ve Tamam'a basın.";
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            pbHata.Visible = false;
            pbOk.Visible = false;

            if (txtKullaniciAdi.Text=="" || txtParola.Text=="")
            {
                lblHata.Text = "Kullanıcı adı veya parola boş geçilemez.\nLutfen tekrar deneyiniz.";
                pbHata.Visible = true;
            }
            else if (txtParola.Text!=txtParolaTekrar.Text)
            {
                lblHata.Text = "Girilen parolalar uyuşmuyor.\nLutfen tekrar deneyiniz.";
                pbHata.Visible = true;
            }
            else
            {
                lblHata.Text = "Tebrikler. Kaydınız tamamlandı. \nÇıkış yapabilirsiniz.";
                pbOk.Visible = true;
                SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmdEkle = new SqlCommand("insert into Yonetici (KullaniciAdi,Parola) values ('" + txtKullaniciAdi.Text + "','" + txtParola.Text + "') ", baglanti);
                cmdEkle.ExecuteNonQuery();
                baglanti.Close();
            }
        }


    }
}
