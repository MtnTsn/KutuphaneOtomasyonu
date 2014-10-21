using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class YoneticiEkrani : Form
    {
        public KitapAyrintilariYonetici frmKitapAyrintilariYonetici;
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetYazar.Yazar' table. You can move, or remove it, as needed.
            this.yazarTableAdapter.Fill(this.kutuphaneDataSetYazar.Yazar);
            // TODO: This line of code loads data into the 'kutuphaneDataSetKitapOzetYazar.Kitap' table. You can move, or remove it, as needed.
            //başlangıçta tablo boş görünsün
            //this.kitapTableAdapter.Fill(this.kutuphaneDataSetKitapOzetYazar.Kitap);
            pnlDetayliArama.Visible = false;
            pnlKitaplar.Visible = false;
            
        }

        private void btnKitapDuzenle_Click(object sender, EventArgs e)
        {
            KitapDuzenle frmKitapDuzenle = new KitapDuzenle();
            frmKitapDuzenle.Show();
        }

        private void btnYazarDuzenle_Click(object sender, EventArgs e)
        {
            YazarDuzenle frmYazarDuzenle = new YazarDuzenle();
            frmYazarDuzenle.Show();
        }

        private void llDetatliArama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDetayliArama.Visible = true;
            pnlNormalArama.Visible = false;
        }

        private void llNormalArama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDetayliArama.Visible = false;
            pnlNormalArama.Visible = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            pnlKitaplar.Visible = true;
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdSorgu = new SqlCommand("select * from Ozet where AnahtarKelimeler like '%"+txtAnahtarKelime.Text+"%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitap.DataSource = dt;
            baglanti.Close();

        }

        private void btnDetayliAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            if (txtKitapAdi.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where KitapAdi like '%" + txtKitapAdi.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (cbTur.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where Tur like '%" + cbTur.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (cbAltTur.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where AltTur like '%" + cbAltTur.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (cbBolum.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where Bolum like '%" + cbBolum.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (cbDil.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where Dil like '%" + cbDil.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (txtYayinYeri.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where YayinYeri like '%" + txtYayinYeri.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (txtYayinevi.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Kitap where Yayinevi like '%" + txtYayinevi.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            if (cbYazar.Text != "")
            {
                SqlCommand cmdSorgu = new SqlCommand("select * from Yazar where YazarID like '%" + cbYazar.SelectedValue + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKitap.DataSource = dt;
            }
            baglanti.Close();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            Kullanicilar frmKullanicilar = new Kullanicilar();
            frmKullanicilar.Show();
        }

        private void btnAyrintilar_Click(object sender, EventArgs e)
        {
            KitapAyrintilariYonetici frmKitapAyrintilariYonetici = new KitapAyrintilariYonetici();
            label10.Text = dgvKitap.CurrentCell.ToString();
            frmKitapAyrintilariYonetici.Show();
        }





    }
}
