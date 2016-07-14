using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Paciente
    {
        private int id;
        private int isapre_id;
        private int usuario_id;
        private Usuario Usuario;
        private Isapre Isapre;

        public Paciente()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioIsapreId
        {
            set { this.isapre_id = value; }
            get { return this.isapre_id; }
        }

        public int ioUsuarioId
        {
            set { this.usuario_id = value; }
            get { return this.usuario_id; }
        }

        public Isapre ioIsapre
        {
            set { this.Isapre = value; }
            get { return this.Isapre; }
        }

        public Usuario ioUsuario
        {
            set { this.Usuario = value; }
            get { return this.Usuario; }
        }

        public Paciente buscarPorId(int id, Boolean fullData = false)
        {
            Paciente paciente = new Paciente();
            Conexion conexion = new Conexion();
            string query = "select * from pacientes where id="+id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                paciente.ioId = Int32.Parse(dr["id"].ToString());
                paciente.ioIsapreId = Int32.Parse(dr["isapre_id"].ToString());
                paciente.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                if (fullData)
                {
                    paciente.ioIsapre = new Isapre().buscarPorId(paciente.ioIsapreId);
                    paciente.ioUsuario = new Usuario().buscarPorId(paciente.ioUsuarioId);
                }
            }
            conexion.cerrarConexion();
            return paciente;
        }

        public List<Paciente> buscarTodos(Boolean fullData = false)
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente;
            Conexion conexion = new Conexion();
            string query = "select * from pacientes";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                paciente = new Paciente();
                paciente.ioId = Int32.Parse(dr["id"].ToString());
                paciente.ioIsapreId = Int32.Parse(dr["isapre_id"].ToString());
                paciente.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                if (fullData)
                {
                    paciente.ioIsapre = new Isapre().buscarPorId(paciente.ioIsapreId);
                    paciente.ioUsuario = new Usuario().buscarPorId(paciente.ioUsuarioId);
                }
                pacientes.Add(paciente);
            }
            conexion.cerrarConexion();
            return pacientes;
        }

        public Paciente buscarPorUsuarioId(int usuarioId, Boolean fullData = false)
        {
            Paciente paciente = new Paciente();
            Conexion conexion = new Conexion();
            string query = "select * from pacientes where usuario_id=" + usuarioId;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                paciente.ioId = Int32.Parse(dr["id"].ToString());
                paciente.ioIsapreId = Int32.Parse(dr["isapre_id"].ToString());
                paciente.ioUsuarioId = Int32.Parse(dr["usuario_id"].ToString());
                if (fullData)
                {
                    paciente.ioIsapre = new Isapre().buscarPorId(paciente.ioIsapreId);
                    paciente.ioUsuario = new Usuario().buscarPorId(usuarioId);
                }
            }
            conexion.cerrarConexion();
            return paciente;
        }

        public Usuario buscarPorRut(String rut, Boolean fullData = true)
        {
            Usuario usuario = new Usuario();
            Conexion conexion = new Conexion();

            usuario = new Usuario().buscarPorRut(rut, fullData);
            if (!usuario.ioId.Equals(0))
            {
                usuario.ioPaciente = this.buscarPorUsuarioId(usuario.ioId, fullData);
            }
            return usuario;
        }

        public int guardar(Paciente paciente)
        {
            Conexion conexion = new Conexion();
            int idPaciente = -1;
            int idUsuario = -1;
            if (paciente.ioUsuario.ioId.Equals(0))
            {
                paciente.ioUsuario.ioPassword = paciente.ioUsuario.ioRut;
                paciente.ioUsuario.ioUsuarioRoles = new UsuarioRoles();
                //Rol de paciente
                paciente.ioUsuario.ioUsuarioRoles.ioRolId = 1;
                idUsuario = new Usuario().guardar(paciente.ioUsuario);
            }
            else
            {
                idUsuario = paciente.ioUsuario.ioId;
                new Usuario().actualizar(paciente.ioUsuario);
            }

            if (idUsuario > 0)
            {
                idPaciente = conexion.getSequenceValor("SEQ_PACIENTES", 1);
                conexion.cerrarConexion();

                string query = "insert into pacientes (id, isapre_id, usuario_id) values (";
                query += idPaciente + ",";
                query += paciente.ioIsapreId + ",";
                query += idUsuario + ")";

                int filasIngresadas = conexion.ingresar(query);
                conexion.cerrarConexion();
                if (filasIngresadas > 0)
                {
                    return idPaciente;
                }
            }else
            {
                return -1;
            }
            return idPaciente;
        }

        public Boolean actualizar(Paciente paciente)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            bool guardaUsuario = new Usuario().actualizar(paciente.ioUsuario);
            if (guardaUsuario)
            {
                string query = "update pacientes set";
                query += " isapre_id=" + paciente.ioIsapreId.ToString();
                query += " where id=" + paciente.ioId.ToString();

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
