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
   public class KategorilerORM
    {
        // select,insert,delete,update

        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("KategoriListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;             

        }

        public static bool Ekle(Kategoriler k)
        {
            SqlCommand komut = new SqlCommand("KategoriEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@katadi", k.KategoriAdi);
            komut.Parameters.AddWithValue("@tanim", k.Tanimi);      

            return Tools.ExecuteNonQuery(komut);
        }
    }
}
