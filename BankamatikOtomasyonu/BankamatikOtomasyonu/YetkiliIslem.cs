﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me= new MusteriEkle();
            me.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            musteriAra ma = new musteriAra();
            ma.Show();
        }
    }
}