using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon.Kullanici
{
    public partial class FrmKullaniciEkle : Form
    {
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            dataGridView1.Columns[13].Visible = false;

        }
        
        private void FrmKullaniciEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciKaydetbtn_Click(object sender, EventArgs e)
        {
           Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Kullanici_Ad = kullaniciAdtxt.Text;
            kullanicilar.Kullanici_Soyad = kullaniciSoyadtxt.Text;
            kullanicilar.Kullanici_Yas =Convert.ToInt32(kullaniciYastxt.Text);
            kullanicilar.Kullanici_Tc = kullaniciTctxt.Text;
            kullanicilar.Kullanici_Tel = kullaniciTelefontxt.Text;
            kullanicilar.Kullanici_Ceza = Convert.ToDouble(kullaniciCezatxt.Text);
            kullanicilar.Kullanici_KitapSayisi =Convert.ToInt32( kullaniciKitapSayisitxt.Text);
            kullanicilar.Kullanici_SayfaSayisi = Convert.ToInt32( kullaniciSayfaSayisitxt.Text);
            kullanicilar.Kullanici_FavTuriD = Convert.ToInt32(kullaniciFavTurtxt.Text);
            kullanicilar.Kullanici_Mail = kullaniciMailtxt.Text;
            kullanicilar.Kutuphane_iD = Convert.ToInt32(kullaniciKutuphanetxt.Text);
            if (radioE.Checked == true)
            {
                kullanicilar.Kullanici_Cinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                kullanicilar.Kullanici_Cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz!");
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();

        }
    }
}
