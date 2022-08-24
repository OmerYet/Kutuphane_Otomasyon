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
    public partial class FrmIslemYap : Form
    {
        public FrmIslemYap()
        {
            InitializeComponent();
        }

        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kayitlar = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }

        private void FrmIslemYap_Load(object sender, EventArgs e)
        {
            //Kayıtlar listelendi
            Listele();

            //Kaynaklar listelendi
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklar.ToList();


            //İstenmeyen kaynak ve kullanıcı kolonları gizlendi.
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //Kolon adları düzenledik
            dataGridView1.Columns[0].HeaderText = "Kayıt No";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı No";
            dataGridView1.Columns[2].HeaderText = "Kaynak No";
            dataGridView1.Columns[3].HeaderText = "Kitap Veriliş Tarihi";
            dataGridView1.Columns[4].HeaderText = "Kitap Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Kitap Durumu";



        }
        
        private void islemyapBulbtn_Click(object sender, EventArgs e)
        {
            string arananTc = islemyTcBultxt.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(x => x.Kullanici_Tc == arananTc).FirstOrDefault();

            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.Kullanici_Ad + " " + kullaniciVarMi.Kullanici_Soyad;
            else
                label2.Text = "Böyle bir kullanıcı bulunmamaktadır!";
        }
        
        private void islemyAdAramatxt_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = islemyAdAramatxt.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x => x.Kaynak_Ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void islemyKitapIslembtn_Click(object sender, EventArgs e)
        {
            //Kişiyi aldık
            string secilenKisiTc = islemyTcBultxt.Text;
            var secilenKisi = db.Kullanicilar.Where(x => x.Kullanici_Tc.Equals(secilenKisiTc)).FirstOrDefault();

            //Kitabı aldık
            int secilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kaynaklar.Where(x => x.Kaynak_iD == secilenKitapId).FirstOrDefault();

            Kayitlar yeniKayit = new Kayitlar();
            yeniKayit.Kaynak_iD = secilenKitap.Kaynak_iD;
            yeniKayit.Kullanici_iD = secilenKisi.Kullanici_iD;
            yeniKayit.Kayit_AlisTarih = DateTime.Today;
            yeniKayit.Kayit_SonTarih = DateTime.Today.AddDays(60);
            yeniKayit.Kayit_Durum = false;
            db.Kayitlar.Add(yeniKayit);
            db.SaveChanges();

            Listele();

        }

        
    }
}
