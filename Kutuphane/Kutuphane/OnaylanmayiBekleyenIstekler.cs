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
    public partial class OnaylanmayiBekleyenIstekler : Form
    {
        public OnaylanmayiBekleyenIstekler()
        {
            InitializeComponent();
        }

        private void OnaylanmayiBekleyenIstekler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetKitaplar.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kutuphaneDataSetKitaplar.Kitap);

        }

        private void btnSecileniOnayla_Click(object sender, EventArgs e)
        {
            string ISBN = dgvKitap.CurrentRow.Cells["ISBN"].Value.ToString();
            string OgrenciNo="100201007";
            string sayi = "1";
            SqlConnection baglanti = new SqlConnection("Data Source=lenovo\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            SqlCommand cmdRafta = new SqlCommand("update Kitap set Rafta='" + sayi + "' where ISBN like '" + ISBN + "' ", baglanti);
            cmdRafta.ExecuteNonQuery();
            SqlCommand cmdISBN = new SqlCommand("update Kullanici set ISBN='"+ISBN+"' where OgrenciNo like '"+OgrenciNo+"' ", baglanti);
            cmdISBN.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
