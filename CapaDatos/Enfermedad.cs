using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Enfermedad
    {
        private string id;
        private string nombre;
        private List<FichaEnfermedad> FichaEnfermedad;

        public Enfermedad()
        {

        }

        public string ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public List<FichaEnfermedad> ioFichaEnfermedad
        {
            set { this.FichaEnfermedad = value; }
            get { return this.FichaEnfermedad; }
        }

        public Enfermedad buscarPorId(int id, Boolean fullData = false)
        {
            Enfermedad enfermedad = new Enfermedad();
            //Buscar las isapres
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from enfermedades where id = " + id);
            if (dr.Read())
            {
                enfermedad.ioId = dr["id"].ToString();
                enfermedad.ioNombre = dr["nombre"].ToString();
                if (fullData)
                {
                    enfermedad.ioFichaEnfermedad = new FichaEnfermedad().buscarPor(0, enfermedad.ioId);
                }
            }
            conexion.cerrarConexion();
            return enfermedad;
        }

        public List<Enfermedad> buscarTodos()
        {
            List<Enfermedad> enfermedades = new List<Enfermedad>();
            Enfermedad enfermedad;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from enfermedades");
            while (dr.Read())
            {
                enfermedad = new Enfermedad();
                enfermedad.ioId = dr["id"].ToString();
                enfermedad.ioNombre = dr["nombre"].ToString();
                enfermedades.Add(enfermedad);
            }
            conexion.cerrarConexion();
            return enfermedades;
        }

        public Enfermedad buscarPorNombre(string nombre)
        {
            Enfermedad enfermedad = new Enfermedad();
            Conexion conexion = new Conexion();
            string query = "select * from enfermedades where nombre='" + nombre + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                enfermedad.ioId = dr["id"].ToString();
                enfermedad.ioNombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return enfermedad;
        }

        public Boolean guardar(Enfermedad enfermedad)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "insert into enfermedades (id, nombre) values (";
            query += "'" + enfermedad.ioId + "',";
            query += "'" + enfermedad.ioNombre + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean actualizar(Enfermedad enfermedad)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update enfermedades set";
            query += " nombre='" + enfermedad.ioNombre + "'";
            query += " where id='" + enfermedad.ioId + "'";
            Console.WriteLine(query);
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
