﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class FrmKullaniciListesi : Form
    {
        public FrmKullaniciListesi()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void FrmKullaniciListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
