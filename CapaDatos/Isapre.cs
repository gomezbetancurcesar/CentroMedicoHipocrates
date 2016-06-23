using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Isapre
    {
        private int id;
        private string nombre;

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

        public Isapre buscarPorId(int id)
        {
            Isapre isapre = new Isapre();
            //Buscar las isapres
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from isapres where id = " + id);
            if (dr.Read())
            {
                isapre.id = Int32.Parse(dr["id"].ToString());
                isapre.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return isapre;
        }

        public List<Isapre> buscarTodos()
        {
            List<Isapre> isapres = new List<Isapre>();
            Isapre isapre;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from isapres");
            while (dr.Read())
            {
                isapre = new Isapre();
                isapre.id = Int32.Parse(dr["id"].ToString());
                isapre.nombre = dr["nombre"].ToString();
                isapres.Add(isapre);
            }
            conexion.cerrarConexion();
            return isapres;
        }

        public Boolean guardar(Isapre isapre)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            int id = conexion.getSequenceValor("SEQ_ISAPRES", 1);
            conexion.cerrarConexion();

            string query = "insert into ISAPRES (id, nombre) values (";
            query += id + ",";
            query += "'" +isapre.ioNombre + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean actualizar(Isapre isapre)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update ISAPRES set";
            query += " id=" + isapre.ioId.ToString() + ",";
            query += " nombre='" + isapre.ioNombre + "'";
            query += " where id=" + isapre.ioId.ToString();

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }
    }
}
