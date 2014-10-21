using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapAyrintilariKullanici : Form
    {
        public KullaniciEkrani frmKullaniciEkrani;
        public KitapAyrintilariKullanici()
        {
            InitializeComponent();
        }

        private void KitapAyrintilariKullanici_Load(object sender, EventArgs e)
        {
            lblISBN.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["ISBN"].Value.ToString();
            lblKitapAdi.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["KitapAdi"].Value.ToString();
            lblTur.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["Tur"].Value.ToString();
            lblAltTur.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["AltTur"].Value.ToString();
            lblBolum.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["Bolum"].Value.ToString();
            lblDil.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["Dil"].Value.ToString();
            lblYayinTarihi.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["YayinTarihi"].Value.ToString();
            lblYayinYeri.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["YayinYeri"].Value.ToString();
            lblYayinevi.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["Yayinevi"].Value.ToString();
            lblYazar.Text = frmKullaniciEkrani.dgvKitap.CurrentRow.Cells["Yazar"].Value.ToString();

        }
    }
}
