using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Region
    {
        private int id;
        private string nombre;

        public Region()
        {

        }

        public int ioId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string ioNombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public List<Region> buscarTodos()
        {
            List<Region> regiones = new List<Region>();
            Region region;
            Conexion conexion = new Conexion();
            string query = "select * from regiones";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                region = new Region();
                region.ioId = Int32.Parse(dr["id"].ToString());
                region.nombre = dr["nombre"].ToString();
                regiones.Add(region);
            }
            conexion.cerrarConexion();
            return regiones;
        }

        public Region buscarPorNombre(string nombre)
        {
            Region region = new Region();
            Conexion conexion = new Conexion();
            string query = "select * from regiones where nombre='" + nombre + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                region.ioId = Int32.Parse(dr["id"].ToString());
                region.ioNombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return region;
        }

        public Region buscarPorId(int id)
        {
            Region region = new Region();
            Conexion conexion = new Conexion();
            string query = "select * from regiones where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                region.ioId = Int32.Parse(dr["id"].ToString());
                region.ioNombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return region;
        }
    }
}
