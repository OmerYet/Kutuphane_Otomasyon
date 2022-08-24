using Kutuphane_Otomasyon.Formlar;
using Kutuphane_Otomasyon.Kullanici;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalıdır.
            islempEklebtn.Visible = false;
            islempGuncellebtn.Visible = false;
            islempSilbtn.Visible = false;
            //kaynak butonları girişte kapalıdır.
            islempKaynakEklebtn.Visible = false;
            islempKaynakGuncellebtn.Visible = false;
            islempKaynakSilbtn.Visible = false;
        }

        //Kullanıcılar
        private void islempKullanicibtn_Click(object sender, EventArgs e)
        { 
            if(islempEklebtn.Visible == false)
            {

            islempEklebtn.Visible = true;
            islempGuncellebtn.Visible = true;
            islempSilbtn.Visible = true;

            }
            else
            {
                islempEklebtn.Visible = false;
                islempGuncellebtn.Visible = false;
                islempSilbtn.Visible = false;
            }

            FrmKullaniciListesi klistesiform = new FrmKullaniciListesi();
            klistesiform.MdiParent = this;
            klistesiform.Show();
            
        }

        private void islempEklebtn_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle ekleForm = new FrmKullaniciEkle();
            ekleForm.MdiParent = this;
            ekleForm.Show();

        }

        private void islempSilbtn_Click(object sender, EventArgs e)
        {
            FrmKullaniciSil silForm = new FrmKullaniciSil();
            silForm.MdiParent = this;
            silForm.Show();
        }

        private void islempGuncellebtn_Click(object sender, EventArgs e)
        {
            FrmKullaniciGuncelle guncelleForm = new FrmKullaniciGuncelle();
            guncelleForm.MdiParent = this;
            guncelleForm.Show();
        }



        //Kaynaklar


        private void islempKaynakbtn_Click(object sender, EventArgs e)
        {
            if (islempKaynakEklebtn.Visible == false)
            {

                islempKaynakEklebtn.Visible = true;
                islempKaynakGuncellebtn.Visible = true;
                islempKaynakSilbtn.Visible = true;

            }
            else
            {
                islempKaynakEklebtn.Visible = false;
                islempKaynakGuncellebtn.Visible = false;
                islempKaynakSilbtn.Visible = false;
            }

            FrmKaynakListesi kalistesiform= new FrmKaynakListesi();
            kalistesiform.MdiParent = this;
            kalistesiform.Show();
        }

        private void islempKaynakEklebtn_Click(object sender, EventArgs e)
        {
            FrmKaynakEkle kaynakekleForm = new FrmKaynakEkle();
            kaynakekleForm.MdiParent = this;
            kaynakekleForm.Show();
        }

        private void islempKaynakGuncellebtn_Click(object sender, EventArgs e)
        {
            FrmKaynakGuncelle kaynakguncelleForm = new FrmKaynakGuncelle();
            kaynakguncelleForm.MdiParent = this;
            kaynakguncelleForm.Show();
        }

        private void islempKaynakSilbtn_Click(object sender, EventArgs e)
        {
            FrmKaynakSil kaynaksilForm = new FrmKaynakSil();
            kaynaksilForm.MdiParent = this;
            kaynaksilForm.Show();
        }


        //İşlem Yap 
        private void islemyIslemYapbtn_Click(object sender, EventArgs e)
        {
            FrmIslemYap islemyapForm = new FrmIslemYap();
            islemyapForm.MdiParent = this;
            islemyapForm.Show();
        }

        //Geri Al
        private void islempGeriAlbtn_Click(object sender, EventArgs e)
        {
            FrmIslemGeriAl islemGeriAlForm = new FrmIslemGeriAl();
            islemGeriAlForm.MdiParent = this;
            islemGeriAlForm.Show();
        }
    }
}
