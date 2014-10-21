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
    public partial class formYoneticiEkrani : Form
    {
        public formYoneticiEkrani()
        {
            InitializeComponent();
        }

        private void btnKitDuzenle_Click(object sender, EventArgs e)
        {
            formEkleSilGuncelle EkleSilGuncelle = new formEkleSilGuncelle();
            EkleSilGuncelle.Show();
        }
    }
}
