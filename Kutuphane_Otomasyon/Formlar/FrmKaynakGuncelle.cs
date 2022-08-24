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
    public partial class FrmKaynakGuncelle : Form
    {
        public FrmKaynakGuncelle()
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
        private void FrmKaynakGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kaynakGuncellebtn_Click(object sender, EventArgs e)
        {
            int secilenKaynak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = db.Kaynaklar.Where(x => x.Kaynak_iD == secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.Kaynak_Ad = kaynakAdtxt.Text;
            guncellenecekKaynak.Kaynak_Tur = kaynakTurtxt.Text;
            guncellenecekKaynak.Kaynak_Yazar = kaynakYazartxt.Text;
            guncellenecekKaynak.Kaynak_SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);
            guncellenecekKaynak.Kaynak_Yayıncı = kaynakYayincitxt.Text;
            guncellenecekKaynak.Kaynak_BasımTarihi = Convert.ToDateTime(kaynakBasimTarihidate.Value);
            db.SaveChanges();
            Listele();

        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kaynakAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kaynakTurtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kaynakYazartxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kaynakYayincitxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kaynakBasimTarihidate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value);
        }
    }
}
