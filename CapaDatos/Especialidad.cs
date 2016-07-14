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
        private string laboratorio;
        private int limite;
        private Doctor Doctor;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre{
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string ioLaboratorio
        {
            set { this.laboratorio = value; }
            get { return this.laboratorio; }
        }

        public int ioLimite
        {
            set { this.limite = value; }
            get { return this.limite; }
        }

        public Doctor ioDoctor
        {
            set { this.Doctor = value; }
            get { return this.Doctor; }
        }

        public Especialidad buscarPorId(int id)
        {
            Especialidad especialidad = new Especialidad();
            Conexion conexion = new Conexion();
            string query = "select * from especialidades where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                especialidad.ioId = Int32.Parse(dr["id"].ToString());
                especialidad.ioNombre = dr["nombre"].ToString();
                //especialidad.ioLaboratorio = dr["laboratorio"].ToString();
                //especialidad.limite = Int32.Parse(dr["limite"].ToString());
            }
            conexion.cerrarConexion();
            return especialidad;
        }

        public Especialidad buscarPorNombre(string nombre)
        {
            Especialidad especialidad = new Especialidad();
            Conexion conexion = new Conexion();
            string query = "select * from especialidades where nombre='" + nombre + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                especialidad.id = Int32.Parse(dr["id"].ToString());
                especialidad.nombre = dr["nombre"].ToString();
                //especialidad.ioLaboratorio = dr["laboratorio"].ToString();
                //especialidad.limite = Int32.Parse(dr["limite"].ToString());
            }
            conexion.cerrarConexion();
            return especialidad;
        }

        public List<Especialidad> buscarTodos(Boolean laboratorio = false)
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            Especialidad especialidad;
            Conexion conexion = new Conexion();
            string query = "select * from especialidades";
            if (laboratorio)
            {
                query += " where laboratorio = '1'";
            }else
            {
                query += " where laboratorio = '0'";
            }

            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                especialidad = new Especialidad();
                especialidad.id = Int32.Parse(dr["id"].ToString());
                especialidad.nombre = dr["nombre"].ToString();
                //especialidad.ioLaboratorio = dr["laboratorio"].ToString();
                //especialidad.limite = Int32.Parse(dr["limite"].ToString());
                if (laboratorio)
                {
                    List<Doctor> doctor = new Doctor().buscarPorEspecialidad(especialidad.ioNombre, true, false);
                    especialidad.ioDoctor = doctor.First();
                }
                especialidades.Add(especialidad);
            }
            conexion.cerrarConexion();
            return especialidades;
        }

        public Boolean guardar(Especialidad especialidad)
        {
            Conexion conexion = new Conexion();
            bool guardo = false;
            int id = conexion.getSequenceValor("SEQ_ESPECIALIDADES", 1);
            conexion.cerrarConexion();

            string query = "insert into ESPECIALIDADES (id, nombre) values (";
            query += id + ",";
            //query += "'" + especialidad.ioNombre+ "',";
            //query += "'" + especialidad.ioLaboratorio + "',";
            query += "'" + especialidad.ioNombre + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();

            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }

        public Boolean actualizar(Especialidad especialidad)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update ESPECIALIDADES set";
            query += " id=" + especialidad.ioId.ToString() + ",";
            query += " nombre='" + especialidad.ioNombre + "'";
            //query += " laboratorio='" + especialidad.ioLaboratorio + "',";
            //query += " limite=" + especialidad.ioLimite;
            query += " where id=" + especialidad.ioId.ToString();

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
