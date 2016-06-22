using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Usuario
    {
        private int id;
        private int comuna_id;
        private string nombres;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string rut;
        private DateTime fechaNacimento;
        private string direccion;
        private string password;
        private Comuna Comuna;
        private UsuarioRoles UsuarioRoles;
        private Rol Rol;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string ioNombre
        {
            set { this.nombres = value; }
            get { return this.nombres; }
        }

        public string ioApellidoMaterno
        {
            set { this.apellidoMaterno = value; }
            get { return this.apellidoMaterno; }
        }

        public string ioApellidoPaterno
        {
            set { this.apellidoPaterno = value; }
            get { return this.apellidoPaterno; }
        }

        public string ioRut
        {
            set { this.rut = value; }
            get { return this.rut; }
        }

        public DateTime ioFechaNacimento
        {
            set { this.fechaNacimento = value; }
            get { return this.fechaNacimento; }
        }

        public int ioComunaId
        {
            set { this.comuna_id = value; }
            get { return this.comuna_id; }
        }

        public string ioDireccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }

        public string ioPassword
        {
            set { this.password = value; }
            get { return this.password; }
        }

        public Comuna ioComuna
        {
            set { this.Comuna = value; }
            get { return this.Comuna; }
        }

        public UsuarioRoles ioUsuarioRoles
        {
            set { this.UsuarioRoles = value; }
            get { return this.UsuarioRoles; }
        }

        public Rol ioRol
        {
            set { this.Rol = value; }
            get { return this.Rol; }
        }

        public Usuario buscarPorRut(string rut)
        {
            Usuario usuario = new Usuario();
            Conexion conexion = new Conexion();
            string query = "select * from usuarios where rut='" + rut + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                usuario.id = Int32.Parse(dr["id"].ToString());
                usuario.rut = dr["rut"].ToString();
                usuario.nombres = dr["nombres"].ToString();
                usuario.apellidoPaterno = dr["apellido_paterno"].ToString();
                usuario.apellidoMaterno = dr["apellido_materno"].ToString();
                usuario.direccion = dr["direccion"].ToString();
                //usuario.fechaNacimento = DateTime.ParseExact(dr["rut"].ToString(), "MM/dd/yyyy", null);
            }
            conexion.cerrarConexion();
            return usuario;
        }

        public Usuario buscarPorId(int id)
        {
            Usuario usuario = new Usuario();
            Conexion conexion = new Conexion();
            string query = "select * from usuarios where id='" + id + "'";
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                usuario.id = Int32.Parse(dr["id"].ToString());
                usuario.rut = dr["rut"].ToString();
                usuario.nombres = dr["nombres"].ToString();
                usuario.apellidoPaterno = dr["apellido_paterno"].ToString();
                usuario.apellidoMaterno = dr["apellido_materno"].ToString();
                usuario.direccion = dr["direccion"].ToString();
                //usuario.fechaNacimento = DateTime.ParseExact(dr["rut"].ToString(), "MM/dd/yyyy", null);
            }
            conexion.cerrarConexion();
            return usuario;
        }

        public Usuario login(string rut, string password)
        {
            Usuario usuario = new Usuario();
            Conexion conexion = new Conexion();
            string query = "select * from usuarios where rut='"+rut+"' and password='"+password+"'";
            OracleDataReader dr = conexion.consultar(query);
            if(dr.Read())
            {
                usuario.id = Int32.Parse(dr["id"].ToString());
                usuario.rut = dr["rut"].ToString();
                usuario.nombres = dr["nombres"].ToString();
                usuario.apellidoPaterno = dr["apellido_paterno"].ToString();
                usuario.apellidoMaterno = dr["apellido_materno"].ToString();
                //usuario.fechaNacimento = DateTime.ParseExact(dr["rut"].ToString(), "MM/dd/yyyy", null);
                //usuario.direccion = dr["direccion"].ToString();
                usuario.UsuarioRoles = new UsuarioRoles().buscarPorUsuarioId(usuario.id);
                usuario.Rol = new Rol().buscarPorId(usuario.UsuarioRoles.ioRolId);
            }
            conexion.cerrarConexion();
            return usuario;
        }
    }
}
