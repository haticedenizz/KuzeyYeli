using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public class TedarickiORM
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("TedarikciListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
