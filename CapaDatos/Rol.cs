using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Rol
    {
        private int id;
        private string nombre;

        public Rol()
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

        public List<Rol> buscarTodos()
        {
            List<Rol> roles = new List<Rol>();
            Rol rol;
            Conexion conexion = new Conexion();
            string query = "select * from roles";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                rol = new Rol();
                rol.id = Int32.Parse(dr["id"].ToString());
                rol.nombre = dr["nombre"].ToString();
                roles.Add(rol);
            }
            conexion.cerrarConexion();
            return roles;
        }

        public Rol buscarPorId(int id)
        {
            Rol rol = new Rol();
            Conexion conexion = new Conexion();
            string query = "select * from roles where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                rol.id = Int32.Parse(dr["id"].ToString());
                rol.nombre =dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return rol;
        }
    }
}
