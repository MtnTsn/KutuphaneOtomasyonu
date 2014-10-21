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
    public partial class KitapAyrintilariYonetici : Form
    {
        public YoneticiEkrani frmYoneticiEkrani;
        public KitapAyrintilariYonetici()
        {
            InitializeComponent();
        }

        private void KitapAyrintilariYonetici_Load(object sender, EventArgs e)
        {
            lblISBN.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["ISBN"].Value.ToString();
            lblKitapAdi.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["KitapAdi"].Value.ToString();
            lblTur.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["Tur"].Value.ToString();
            lblAltTur.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["AltTur"].Value.ToString();
            lblBolum.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["Bolum"].Value.ToString();
            lblDil.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["Dil"].Value.ToString();
            lblYayinTarihi.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["YayinTarihi"].Value.ToString();
            lblYayinYeri.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["YayinYeri"].Value.ToString();
            lblYayinevi.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["Yayinevi"].Value.ToString();
            lblYazar.Text = frmYoneticiEkrani.dgvKitap.CurrentRow.Cells["Yazar"].Value.ToString();
        }
    }
}
