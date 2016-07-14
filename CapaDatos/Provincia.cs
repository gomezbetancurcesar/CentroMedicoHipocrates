using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Provincia
    {
        private int id;
        private string nombre;
        private int region_id;
        private Region Region;

        public Provincia()
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

        public int ioRegionId
        {
            get { return this.region_id; }
            set { this.region_id = value; }
        }

        public Region ioRegion
        {
            get { return this.Region; }
            set { this.Region = value; }
        }

        public List<Provincia> buscarTodos(int regionId = -1, Boolean fullData = false)
        {
            List<Provincia> provincias = new List<Provincia>();
            Provincia provincia;
            Conexion conexion = new Conexion();
            string query = "select * from provincias";
            if (regionId > 0)
            {
                query += " where region_id = " + regionId;
            }
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                provincia = new Provincia();
                provincia.ioId = Int32.Parse(dr["id"].ToString());
                provincia.ioRegionId = Int32.Parse(dr["region_id"].ToString());
                provincia.nombre = dr["nombre"].ToString();
                if (fullData)
                {
                    provincia.ioRegion = new Region().buscarPorId(provincia.ioRegionId);
                }
                provincias.Add(provincia);
            }
            conexion.cerrarConexion();
            return provincias;
        }

        public Provincia buscarPorNombre(string nombre)
        {
            Provincia provincia = new Provincia();
            Conexion conexion = new Conexion();
            string query = "select * from provincias where nombre='" + nombre + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                provincia.ioId = Int32.Parse(dr["id"].ToString());
                provincia.ioNombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return provincia;
        }

        public Provincia buscarPorId(int id, Boolean fullData = false)
        {
            Provincia provincia = new Provincia();
            Conexion conexion = new Conexion();
            string query = "select * from provincias where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                provincia.ioId = Int32.Parse(dr["id"].ToString());
                provincia.ioNombre = dr["nombre"].ToString();
                provincia.ioRegionId = Int32.Parse(dr["region_id"].ToString());
                if (fullData)
                {
                    provincia.Region = new Region().buscarPorId(provincia.ioRegionId);
                }
            }
            conexion.cerrarConexion();
            return provincia;
        }
    }
}
