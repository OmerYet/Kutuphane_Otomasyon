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
    public partial class FrmKullaniciSil : Form
    {
        public FrmKullaniciSil()
        {
            InitializeComponent();
        }
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            dataGridView1.Columns[13].Visible = false;


        }
        private void FrmKullaniciSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciSilbtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.Kullanici_iD == secilenId).FirstOrDefault();
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }
    }
}
