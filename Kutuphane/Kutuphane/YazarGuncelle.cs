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
    public partial class YazarGuncelle : Form
    {
        public YazarDuzenle frmYazarDuzenle = new YazarDuzenle();
        public YazarGuncelle()
        {
            InitializeComponent();
        }

        private void YazarGuncelle_Load(object sender, EventArgs e)
        {
            string Secim = frmYazarDuzenle.dgvYazar.CurrentCell.Value.ToString();
            txtAdiSoyadi.Text = frmYazarDuzenle.dgvYazar.CurrentRow.Cells["AdSoyad"].Value.ToString();//olmadı
            txtDogumYeri.Text = frmYazarDuzenle.dgvYazar.CurrentRow.Cells["DogumYeri"].Value.ToString();
            //txtIlkEseri.Text = frmYazarDuzenle.dgvYazar.CurrentRow.Cells["IlkEseri"].ToString();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            //int Secim = Convert.ToInt32(frmYazarDuzenle.lblYazarID.Text);
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdGuncelle = new SqlCommand("update Yazar set AdSoyad='" + txtAdiSoyadi.Text + "',DogumYeri='" + txtDogumYeri.Text + "',DogumTarihi='" + dtpDogumTarihi.Text + "',IlkEseri='" + txtIlkEseri.Text + "' where YazarID like'" + frmYazarDuzenle.lblYazarID.Text + "' ", baglanti);
            cmdGuncelle.ExecuteNonQuery();
            baglanti.Close();
        }


    }
}
