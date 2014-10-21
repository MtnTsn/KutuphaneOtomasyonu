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
    public partial class KitapDuzenle : Form
    {
        public KitapDuzenle()
        {
            InitializeComponent();
        }

        private void formKitapDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetYazar.Yazar' table. You can move, or remove it, as needed.
            this.yazarTableAdapter.Fill(this.kutuphaneDataSetYazar.Yazar);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdEkle = new SqlCommand("insert into Kitap (ISBN,KitapAdi,Tur,AltTur,Bolum,Dil,YayinTarihi,YayinYeri,Yayinevi,YazarID) values ('"+txtISBN.Text+"','"+txtKitapAdi.Text+"','"+cbTur.Text+"','"+cbAltTur.Text+"','"+cbBolum.Text+"','"+cbDil.Text+"','"+dtYayinTarihi.Text+"','"+txtYayinYeri.Text+"','"+txtYayinevi.Text+"','"+cbYazar.SelectedValue+"') ",baglanti);
            cmdEkle.ExecuteNonQuery();
            SqlCommand cmdOzetTablosunaEkle = new SqlCommand("insert into Ozet (ISBN,Ozet,AnahtarKelimeler) values ('" + txtISBN.Text + "','"+txtOzet.Text+"','"+txtKitapAdi.Text+ " " + cbYazar.Text + "')  ", baglanti);
            cmdOzetTablosunaEkle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdSil = new SqlCommand("delete from Kitap where ISBN='" + txtISBN.Text + "' ", baglanti);
            cmdSil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdGuncelle = new SqlCommand("update Kitap set KitapAdi='" + txtKitapAdi.Text + "',Tur='" + cbTur.Text + "',AltTur='" + cbAltTur.Text + "',Bolum='" + cbBolum.Text + "',Dil='" + cbDil.Text + "',YayinTarihi='" + dtYayinTarihi.Text + "',YayinYeri='" + txtYayinYeri.Text + "',Yayinevi='" + txtYayinevi.Text + "',YazarID='" + cbYazar.SelectedValue + "' where ISBN like '" + txtISBN.Text + "' ", baglanti);
            cmdGuncelle.ExecuteNonQuery();
            baglanti.Close();
        }




    }
}
