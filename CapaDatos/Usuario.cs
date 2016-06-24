﻿using System;
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
            string query = "select * from usuarios where id=" + id;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                usuario.ioId = Int32.Parse(dr["id"].ToString());
                usuario.ioRut = dr["rut"].ToString();
                usuario.ioNombre = dr["nombres"].ToString();
                usuario.ioApellidoPaterno = dr["apellido_paterno"].ToString();
                usuario.ioApellidoMaterno = dr["apellido_materno"].ToString();
                usuario.ioDireccion = dr["direccion"].ToString();
                usuario.fechaNacimento = Convert.ToDateTime(dr["fecha_nacimiento"].ToString());
                usuario.ioPassword = dr["password"].ToString();
                usuario.ioComunaId = Int32.Parse(dr["comuna_id"].ToString());

                usuario.ioComuna = new Comuna().buscarPorId(usuario.ioComunaId);
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
                usuario.UsuarioRoles = new UsuarioRoles().buscarPorUsuarioId(usuario.id);
                usuario.Rol = new Rol().buscarPorId(usuario.UsuarioRoles.ioRolId);
            }
            conexion.cerrarConexion();
            return usuario;
        }

        public List<Usuario> buscarPorRol(string rol)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            Conexion conexion = new Conexion();
            string query = "select usu.* from roles r ";
            query += "inner join usuario_roles ur on r.id = ur.rol_id ";
            query += "inner join usuarios usu on ur.usuario_id = usu.id";
            query += "where r.nombre = '"+rol+"'";
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                usuario = new Usuario();
                usuario.id = Int32.Parse(dr["id"].ToString());
                usuario.rut = dr["rut"].ToString();
                usuario.nombres = dr["nombres"].ToString();
                usuario.apellidoPaterno = dr["apellido_paterno"].ToString();
                usuario.apellidoMaterno = dr["apellido_materno"].ToString();
                //usuario.UsuarioRoles = new UsuarioRoles().buscarPorUsuarioId(usuario.id);
                //usuario.Rol = new Rol().buscarPorId(usuario.UsuarioRoles.ioRolId);
                usuarios.Add(usuario);
            }
            conexion.cerrarConexion();
            return usuarios;
        }

        public Boolean guardar(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            bool guardo = false;

            int id = conexion.getSequenceValor("SEQ_USUARIOS", 1);
            conexion.cerrarConexion();

            string query = "insert into usuarios (id, comuna_id, nombres, apellido_paterno, apellido_materno, rut, fecha_nacimiento, direccion, password) values (";
            query += id + ",";
            query += usuario.ioComunaId + ",";
            query += "'" + usuario.ioNombre + "',";
            query += "'" + usuario.ioApellidoPaterno + "',";
            query += "'" + usuario.ioApellidoMaterno + "',";
            query += "'" + usuario.ioRut + "',";
            query += " DATE '" + usuario.ioFechaNacimento.Date.ToString("yyyy-MM-dd") + "',";
            query += "'" + usuario.ioDireccion + "',";
            query += "'" + usuario.ioPassword + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }

        public Boolean actualizar(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            bool guardo = false;

            string query = "update usuarios set";
            query += " id=" + usuario.ioId.ToString() + ",";
            query += " comuna_id=" + usuario.ioComunaId.ToString() + ",";
            query += " nombres='" + usuario.ioNombre + "',";
            query += " apellido_paterno='" + usuario.ioApellidoPaterno + "',";
            query += " apellido_materno='" + usuario.ioApellidoMaterno + "',";
            query += " rut='" + usuario.ioRut + "',";
            query += " fecha_nacimiento= DATE '" + usuario.ioFechaNacimento.Date.ToString("yyyy-MM-dd") + "',";
            query += " direccion='" + usuario.ioDireccion + "',";
            query += " password='" + usuario.ioPassword + "'";
            query += " where id=" + usuario.ioId.ToString();
            Console.WriteLine(query);
            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }
    }
}
