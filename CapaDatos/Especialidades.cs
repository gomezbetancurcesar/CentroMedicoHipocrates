using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Especialidades
    {
        private int id;
        private string nombre;
        private Conexion conexion = new Conexion();

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre{
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public DataSet obtenerEspecialidades()
        {
            SqlConnection sql = this.conexion.getConexion();
            string query = "select * from especialidades";
            SqlDataAdapter da = new SqlDataAdapter(query, sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
