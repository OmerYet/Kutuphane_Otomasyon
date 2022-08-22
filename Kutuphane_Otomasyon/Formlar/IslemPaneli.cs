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
    }
}
