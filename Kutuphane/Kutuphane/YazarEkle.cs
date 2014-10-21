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

    public partial class YazarEkle : Form
    {

        public YazarEkle()
        {
            InitializeComponent();

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdEkle = new SqlCommand("insert into Yazar (AdSoyad,DogumTarihi,DogumYeri,IlkEseri) values ('" +txtAdiSoyadi.Text+ "','" +dtpDogumTarihi.Text+ "','" +txtDogumYeri.Text+ "','" +txtIlkEseri.Text+ "') ", baglanti);
            cmdEkle.ExecuteNonQuery();
            baglanti.Close();

            pictureBox1.Visible = true;


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            YazarEkle frmYazarEkle = new YazarEkle();
            frmYazarEkle.Close();
        }


    }
}
