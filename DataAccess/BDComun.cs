using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=LAPTOP-QHC355DF\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");

            conectar.Open();
            return conectar;
        }
    }
}
