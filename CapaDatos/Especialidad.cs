using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Especialidad
    {
        private int id;
        private string nombre;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre{
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public Especialidad buscarPorId(int id)
        {
            Especialidad especialidad = new Especialidad();
            Conexion conexion = new Conexion();
            string query = "select * from especialidades where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                especialidad.id = Int32.Parse(dr["id"].ToString());
                especialidad.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return especialidad;
        }

        public List<Especialidad> buscarTodos()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            Especialidad especialidad;
            Conexion conexion = new Conexion();
            string query = "select * from especialidades";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                especialidad = new Especialidad();
                especialidad.id = Int32.Parse(dr["id"].ToString());
                especialidad.nombre = dr["nombre"].ToString();
                especialidades.Add(especialidad);
            }
            conexion.cerrarConexion();
            return especialidades;
        }
    }
}
