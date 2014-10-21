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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetKullanicilar.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.kutuphaneDataSetKullanicilar.Kullanici);

        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            pnlBilgiler.Visible = true;

        }

        private void txtOgrenciNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdSorgu = new SqlCommand("select * from Kullanici where OgrenciNo like '%" + txtOgrenciNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKullanicilar.DataSource = dt;
            baglanti.Close();
        }

        private void txtAdiSoyadi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdSorgu = new SqlCommand("select * from Kullanici where AdSoyad like '%" + txtAdiSoyadi.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKullanicilar.DataSource = dt;
            baglanti.Close();
        }

        private void llSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llSifre.Text=="Göster")
            {
                lblSifre.Text = dgvKullanicilar.CurrentRow.Cells["Sifre"].Value.ToString();
                llSifre.Text = "Gizle";
            }
            else
            {
                lblSifre.Text = "*******";
                llSifre.Text = "Göster";
            }
            
        }

        private void OnaylanmayiBekleyenİstekler_Click(object sender, EventArgs e)
        {
            OnaylanmayiBekleyenIstekler frmOnaylanmayiBekleyenİstekler = new OnaylanmayiBekleyenIstekler();
            frmOnaylanmayiBekleyenİstekler.Show();
        }




    }
}
