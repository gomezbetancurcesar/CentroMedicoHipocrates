using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Doctor
    {
        private Usuario Usuario;
        private Especialidad Especialidad;
        private Oficina Oficina;
        private int id;
        private int especialidad_id;
        private int usuario_id;
        private int oficina_id;

        public Doctor()
        {
        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioEspecialidadId
        {
            set { this.especialidad_id = value; }
            get { return this.especialidad_id; }
        }

        public int ioUsuarioId
        {
            set { this.usuario_id = value; }
            get { return this.usuario_id; }
        }

        public int ioOficinaId
        {
            set { this.oficina_id = value; }
            get { return this.oficina_id; }
        }

        public Usuario ioUsuario
        {
            set { this.Usuario = value; }
            get { return this.Usuario; }
        }

        public Especialidad ioEspecialidad
        {
            set { this.Especialidad = value; }
            get { return this.Especialidad; }
        }

        public Oficina ioOficina
        {
            set { this.Oficina = value; }
            get { return this.Oficina; }
        }

        public List<Doctor> buscarTodos()
        {
            List<Doctor> doctores = new List<Doctor>();
            Doctor doctor;
            Conexion conexion = new Conexion();
            string query = "select * from doctores";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                Console.WriteLine(dr["usuario_id"]);
                if(!dr["usuario_id"].ToString().Equals(""))
                {
                    doctor = new Doctor();
                    doctor.ioId = Int32.Parse(dr["id"].ToString());

                    doctor.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                    doctor.ioEspecialidadId = Int32.Parse(dr["especialidad_id"].ToString());
                    doctor.ioOficinaId = Int32.Parse(dr["oficina_id"].ToString());

                    doctor.ioUsuario = new Usuario().buscarPorId(doctor.ioUsuarioId);
                    doctor.ioEspecialidad = new Especialidad().buscarPorId(doctor.ioEspecialidadId);
                    doctor.ioOficina = new Oficina().buscarPorId(doctor.ioOficinaId);
                    doctores.Add(doctor);
                }
            }
            conexion.cerrarConexion();
            return doctores;
        }

        public Doctor buscarPorRut(string rut, Boolean fullData = false)
        {
            Doctor doctor = new Doctor();
            Conexion conexion = new Conexion();
            string query = "select doc.* from usuarios usu ";
            query += "inner join doctores doc on doc.usuario_id = usu.id ";
            query += "where usu.rut = '"+rut+"'";
            OracleDataReader dr = conexion.consultar(query);

            while (dr.Read())
            {
                doctor.ioId = Int32.Parse(dr["id"].ToString());
                doctor.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                doctor.ioEspecialidadId = Int32.Parse(dr["especialidad_id"].ToString());
                doctor.ioOficinaId = Int32.Parse(dr["oficina_id"].ToString());

                if (fullData)
                {
                    doctor.ioUsuario = new Usuario().buscarPorId(doctor.ioUsuarioId);
                    doctor.ioEspecialidad = new Especialidad().buscarPorId(doctor.ioEspecialidadId);
                    doctor.ioOficina = new Oficina().buscarPorId(doctor.ioOficinaId);
                }
            }
            conexion.cerrarConexion();
            return doctor;
        }

        public Doctor buscarPorPersonaId(int personaId)
        {
            Doctor doctor = new Doctor();
            Conexion conexion = new Conexion();
            string query = "select * from doctores ";
            query += "where usuario_id = " + personaId;
            OracleDataReader dr = conexion.consultar(query);

            while (dr.Read())
            {
                doctor.ioId = Int32.Parse(dr["id"].ToString());
                doctor.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                doctor.ioEspecialidadId = Int32.Parse(dr["especialidad_id"].ToString());
                doctor.ioOficinaId = Int32.Parse(dr["oficina_id"].ToString());
            }
            conexion.cerrarConexion();
            return doctor;
        }

        public Doctor buscarPorId(int id)
        {
            Doctor doctor = new Doctor();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from doctores where id="+ id);
            if (dr.Read())
            {
                doctor.ioId = Int32.Parse(dr["id"].ToString());
                doctor.ioEspecialidadId = Int32.Parse(dr["especialidad_id"].ToString());
                doctor.ioOficinaId = Int32.Parse(dr["oficina_id"].ToString());
                doctor.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());

                doctor.ioUsuario = new Usuario().buscarPorId(doctor.ioUsuarioId);
                doctor.ioEspecialidad = new Especialidad().buscarPorId(doctor.ioEspecialidadId);
                doctor.ioOficina = new Oficina().buscarPorId(doctor.ioOficinaId);
            }
            conexion.cerrarConexion();
            return doctor;
        }

        public List<Doctor> buscarPorEspecialidad(string nombreEspecialidad, Boolean fullData = false, Boolean includeUser = true)
        {
            List<Doctor> doctores = new List<Doctor>();
            Doctor doctor;
            Conexion conexion = new Conexion();

            Especialidad especialidad = new Especialidad().buscarPorNombre(nombreEspecialidad);
            OracleDataReader dr = conexion.consultar("select * from doctores where especialidad_id=" + especialidad.ioId);
            while (dr.Read())
            {
                doctor = new Doctor();
                doctor.ioId = Int32.Parse(dr["id"].ToString());
                doctor.ioEspecialidadId = Int32.Parse(dr["especialidad_id"].ToString());
                doctor.ioOficinaId = Int32.Parse(dr["oficina_id"].ToString());
                if (includeUser)
                {
                    doctor.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                }

                if (fullData)
                {
                    if (includeUser)
                    {
                        doctor.ioUsuario = new Usuario().buscarPorId(doctor.ioUsuarioId);
                    }
                    doctor.ioEspecialidad = new Especialidad().buscarPorId(doctor.ioEspecialidadId);
                    doctor.ioOficina = new Oficina().buscarPorId(doctor.ioOficinaId);
                }
                doctores.Add(doctor);
            }
            conexion.cerrarConexion();
            return doctores;
        }

        public Boolean guardar(Doctor doctor, Boolean guardarUsuario = true)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            string query = "";
            int id = conexion.getSequenceValor("SEQ_DOCTORES", 1);
            conexion.cerrarConexion();

            if (guardarUsuario)
            {
                int idUsuario = new Usuario().guardar(doctor.ioUsuario);
                query = "insert into doctores (id, usuario_id, especialidad_id, oficina_id) values (";
                query += id + ",";
                query += idUsuario + ",";
                query += doctor.ioEspecialidadId + ",";
                query += doctor.ioOficinaId + ")";
            }else
            {
                query = "insert into doctores (id, especialidad_id, oficina_id) values (";
                query += id + ",";
                query += doctor.ioEspecialidadId + ",";
                query += doctor.ioOficinaId + ")";
            }

            //Validamos si guardo el usuario
            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }

        public Boolean actualizar(Doctor doctor)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            bool guardaUsuario = new Usuario().actualizar(doctor.ioUsuario);
            if (guardaUsuario)
            {
                string query = "update doctores set";
                query += " id=" + doctor.ioId.ToString() + ",";
                query += " especialidad_id=" + doctor.ioEspecialidadId.ToString() + ",";
                query += " oficina_id=" + doctor.ioOficinaId.ToString();
                query += " where id=" + doctor.ioId.ToString();

                int filasIngresadas = conexion.ingresar(query);
                conexion.cerrarConexion();
                if (filasIngresadas > 0)
                {
                    guardo = true;
                }
            }
            return guardo;
        }
    }
}
