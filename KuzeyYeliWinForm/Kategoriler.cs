using KuzeyYeliORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliWinForm
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource=KategorilerORM.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KuzeyYeliEntity.Kategoriler k = new KuzeyYeliEntity.Kategoriler();

            k.KategoriAdi = txtKatAdi.Text;
            k.Tanimi = txtKatTanim.Text;           

            KategorilerORM.Ekle(k);
        }
    }
}
