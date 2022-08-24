using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon.Formlar
{
    public partial class FrmKaynakEkle : Form
    {
        public FrmKaynakEkle()
        {
            InitializeComponent();
        }
        DbKutuphaneOtomasyonEntities db =  new DbKutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
            dataGridView1.Columns[7].Visible = false;

        }
        private void FrmKaynakEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kaynakKaydetbtn_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.Kaynak_Ad = kaynakAdtxt.Text;
            kaynaklar.Kaynak_Tur = kaynakTurtxt.Text;
            kaynaklar.Kaynak_Yazar = kaynakYazartxt.Text;
            kaynaklar.Kaynak_SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);
            kaynaklar.Kaynak_Yayıncı = kaynakYayincitxt.Text;
            kaynaklar.Kaynak_BasımTarihi = Convert.ToDateTime(kaynakBasimTarihidate.Value);

            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();
            Listele();
        }
    }
}
