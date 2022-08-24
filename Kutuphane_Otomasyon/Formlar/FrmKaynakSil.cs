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
    public partial class FrmKaynakSil : Form
    {
        public FrmKaynakSil()
        {
            InitializeComponent();
        }
        DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
            dataGridView1.Columns[7].Visible = false;

        }
        private void FrmKaynakSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kaynakSilbtn_Click(object sender, EventArgs e)
        {
            int secilenKaynakIdsi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinecekKaynak = db.Kaynaklar.Where(x => x.Kaynak_iD == secilenKaynakIdsi).FirstOrDefault();
            db.Kaynaklar.Remove(silinecekKaynak);
            db.SaveChanges();
            Listele();
        }
    }
}
