using System;
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
    public partial class Form1 : Form
    {
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = personelAdGiristxt.Text;
            string gelenSifre = personelSifreGiristxt.Text;

            //linq sorgusu
            var Personel = db.Personeller.Where(x => x.Personel_KullaniciAd.Equals(gelenAd)&&x.Personel_Sifre.Equals(gelenSifre)).FirstOrDefault();

            if (Personel == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı!");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
            
        }

        private void personelAdGiristxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void personelSifreGiristxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
