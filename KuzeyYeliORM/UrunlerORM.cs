using KuzeyYeliEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public class UrunlerORM
    {
        // select,insert,delete,update

        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UrunListele", Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;          
        }

        public static bool Ekle(Urunler u)
        {
            SqlCommand komut = new SqlCommand("UrunEkle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunad", u.UrunAdi);
            komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
            komut.Parameters.AddWithValue("@stok", u.Stok);
            komut.Parameters.AddWithValue("@tedarikciID", u.TedarikciID);
            komut.Parameters.AddWithValue("@kategoriID", u.KategoriID);

            return Tools.ExecuteNonQuery(komut);
        }

    }
}
