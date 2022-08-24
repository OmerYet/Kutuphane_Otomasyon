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
    public partial class FrmKaynakListesi : Form
    {
        public FrmKaynakListesi()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            DbKutuphaneOtomasyonEntities db = new DbKutuphaneOtomasyonEntities();
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
            dataGridView1.Columns[7].Visible = false;


        }

        private void FrmKaynakListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
