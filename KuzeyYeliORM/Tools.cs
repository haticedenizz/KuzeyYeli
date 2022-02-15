using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public static class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            int sonuc = 0;
            if (Baglanti.State == ConnectionState.Closed)
            {
                Baglanti.Open();
                sonuc = komut.ExecuteNonQuery();
            }
            else
                Baglanti.Close();

            return sonuc > 0 ? true : false;
        }
    }

}
