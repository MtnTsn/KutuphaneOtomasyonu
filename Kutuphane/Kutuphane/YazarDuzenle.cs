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
    public partial class YazarDuzenle : Form
    {
        
        public YazarDuzenle()
        {
            InitializeComponent();
        }
        
        private void YazarDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetYazar.Yazar' table. You can move, or remove it, as needed.
            this.yazarTableAdapter.Fill(this.kutuphaneDataSetYazar.Yazar);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            //string Secim = dgvYazar.Rows[dgvYazar.CurrentRow.Index].Cells["YazarID"].ToString();
            string Secim = dgvYazar.CurrentCell.Value.ToString();
            SqlCommand cmdSil = new SqlCommand("delete from Yazar where YazarID='" + Secim + "'", baglanti);
            cmdSil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YazarEkle frmYazarEkle = new YazarEkle();
            frmYazarEkle.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvYazar.Refresh();
            this.yazarTableAdapter.Fill(this.kutuphaneDataSetYazar.Yazar);
            dgvYazar.Refresh();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            YazarGuncelle frmYazarGuncelle = new YazarGuncelle();
            lblYazarID.Text = dgvYazar.CurrentCell.Value.ToString();
            frmYazarGuncelle.Show();
        }

        private void txtYazarAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdSorgu = new SqlCommand("select * from Yazar where AdSoyad like '%" + txtYazarAra.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmdSorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvYazar.DataSource = dt;
            baglanti.Close();
        }

    }
}
