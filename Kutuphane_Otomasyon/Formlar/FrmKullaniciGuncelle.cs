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
    public partial class FrmKullaniciGuncelle : Form
    {
        public FrmKullaniciGuncelle()
        {
            InitializeComponent();
        }
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kullaniciSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciYastxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("E"))
                radioE.Checked = true;
            else
                radioK.Checked = true;
            kullaniciKitapSayisitxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kullaniciSayfaSayisitxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kullaniciFavTurtxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            kullaniciTctxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            kullaniciTelefontxt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            kullaniciMailtxt.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            kullaniciCezatxt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            kullaniciKutuphanetxt.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void FrmKullaniciGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciGuncellebtn_Click(object sender, EventArgs e)
        {
            int secilentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.Kullanici_iD == secilentId).FirstOrDefault();
            kullanici.Kullanici_Ad = kullaniciAdtxt.Text;
            kullanici.Kullanici_Soyad = kullaniciSoyadtxt.Text;
            kullanici.Kullanici_Yas = Convert.ToInt32(kullaniciYastxt.Text);
            kullanici.Kullanici_Tc = kullaniciTctxt.Text;
            kullanici.Kullanici_Tel = kullaniciTelefontxt.Text;
            kullanici.Kullanici_Ceza = Convert.ToDouble(kullaniciCezatxt.Text);
            kullanici.Kullanici_KitapSayisi = Convert.ToInt32(kullaniciKitapSayisitxt.Text);
            kullanici.Kullanici_SayfaSayisi = Convert.ToInt32(kullaniciSayfaSayisitxt.Text);
            kullanici.Kullanici_FavTuriD = Convert.ToInt32(kullaniciFavTurtxt.Text);
            kullanici.Kullanici_Mail = kullaniciMailtxt.Text;
            kullanici.Kutuphane_iD = Convert.ToInt32(kullaniciKutuphanetxt.Text);
            if (radioE.Checked == true)
            {
                kullanici.Kullanici_Cinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                kullanici.Kullanici_Cinsiyet = "K";
            }
            db.SaveChanges();
            Listele();
        }
    }
}
