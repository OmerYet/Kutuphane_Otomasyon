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
    public partial class FrmIslemGeriAl : Form
    {
        public FrmIslemGeriAl()
        {
            InitializeComponent();
        }
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();

        public void Listele()
        {
            var kayitlar = db.Kayitlar.Where(x => x.Kayit_Durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }
         
        private void FrmIslemGeriAl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void geriAlbtn_Click(object sender, EventArgs e)
        {
            int secilenKayitId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.Kayit_iD == secilenKayitId).FirstOrDefault();
            kayit.Kayit_Durum = true;
            db.SaveChanges();
            Listele();
        }
    }
}
