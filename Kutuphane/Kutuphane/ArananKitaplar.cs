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
    public partial class ArananKitaplar : Form
    {
        private YoneticiEkrani frmYoneticiEkrani;
        public ArananKitaplar()
        {
            InitializeComponent();
        }

        private void ArananKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSetKitaplar.Kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.kutuphaneDataSetKitaplar.Kitap);
            

        }

    }
}
