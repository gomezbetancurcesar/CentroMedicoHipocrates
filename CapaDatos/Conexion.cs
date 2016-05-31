using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public string tabla = "";
        public SqlConnection getConexion()
        {
            String conexion = "";
            SqlConnection sql = new SqlConnection(conexion);
            return sql;
        }
    }
}
