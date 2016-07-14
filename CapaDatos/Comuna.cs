using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Comuna
    {
        private int id;
        private string nombre;
        private int provincia_id;
        private Provincia Provincia;

        public Comuna()
        { 
        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public int ioProvinciaId
        {
            set { this.provincia_id = value; }
            get { return this.provincia_id; }
        }

        public Provincia ioProvincia
        {
            set { this.Provincia = value; }
            get { return this.Provincia; }
        }

        public List<Comuna> buscarTodos(int provinciaId = -1 , Boolean fullData = false)
        {
            List<Comuna> comunas = new List<Comuna>();
            Comuna comuna;
            Conexion conexion = new Conexion();
            string query = "select * from comunas";
            if(provinciaId > 0)
            {
                query += " where provincia_id = " + provinciaId;
            }
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                comuna = new Comuna();
                comuna.ioId = Int32.Parse(dr["id"].ToString());
                comuna.ioProvinciaId = Int32.Parse(dr["provincia_id"].ToString());
                comuna.nombre = dr["nombre"].ToString();
                if (fullData)
                {
                    comuna.ioProvincia = new Provincia().buscarPorId(comuna.ioProvinciaId);
                }
                comunas.Add(comuna);
            }
            conexion.cerrarConexion();
            return comunas;
        }

        public Comuna buscarPorNombre(string nombre)
        {
            Comuna comuna = new Comuna();
            Conexion conexion = new Conexion();
            string query = "select * from comunas where nombre='" + nombre + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                comuna.ioId = Int32.Parse(dr["id"].ToString());
                comuna.ioNombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return comuna;
        }

        public Comuna buscarPorId(int id, Boolean fullData = false)
        {
            Comuna comuna = new Comuna();
            Conexion conexion = new Conexion();
            string query = "select * from comunas where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                comuna.ioId = Int32.Parse(dr["id"].ToString());
                comuna.ioNombre = dr["nombre"].ToString();
                comuna.ioProvinciaId = Int32.Parse(dr["provincia_id"].ToString());
                if (fullData)
                {
                    comuna.ioProvincia = new Provincia().buscarPorId(comuna.ioProvinciaId, true);
                }
            }
            conexion.cerrarConexion();
            return comuna;
        }
    }
}