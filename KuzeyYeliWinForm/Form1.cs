using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KuzeyYeliEntity;
using KuzeyYeliORM;

namespace KuzeyYeliWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
            KategoriListele();
            TedarikciListele();
        }

        private void TedarikciListele()
        {
            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";
            cmbTedarikci.DataSource = TedarickiORM.Listele();
        }

        private void KategoriListele()
        {
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource=          KategorilerORM.Listele();
        }

        private void UrunListele()
        {
            dataGridView1.DataSource = UrunlerORM.Listele();
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtUrunAdi.Text;
            u.Fiyat = nudFiyat.Value;
            u.Stok =(short)nudStok.Value;
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID =(int) cmbTedarikci.SelectedValue;

           bool sonuc= UrunlerORM.Ekle(u);
            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi.");
                UrunListele();
            }
            else
                MessageBox.Show("Kayıt ekleme sırasında hata oluştu.");
        }

        private void btn_Kategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Show();
        }
    }
}
