using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class UsuarioRoles
    {
        private int id;
        private int usuario_id;
        private int rol_id;
        private Usuario Usuario;
        private Rol Rol;

        public UsuarioRoles()
        {
        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioUsuarioId
        {
            set { this.usuario_id = value; }
            get { return this.usuario_id; }
        }

        public int ioRolId
        {
            set { this.rol_id = value; }
            get { return this.rol_id; }
        }

        public Usuario ioUsuario
        {
            set { this.Usuario = value; }
            get { return this.Usuario; }
        }

        public Rol ioRol
        {
            set { this.Rol = value; }
            get { return this.Rol; }
        }

        public UsuarioRoles buscarPorId(int id)
        {
            UsuarioRoles usuarioRol = new UsuarioRoles();
            //ir a la base!
            return usuarioRol;
        }

        public UsuarioRoles buscarPorUsuarioId(int usuarioId)
        {
            UsuarioRoles usuarioRol = new UsuarioRoles();
            Conexion conexion = new Conexion();
            string query = "select * from usuario_roles where usuario_id=" + usuarioId;
            OracleDataReader dr = conexion.consultar(query);
            if (dr.Read())
            {
                usuarioRol.id = Int32.Parse(dr["id"].ToString());
                usuarioRol.usuario_id = Int32.Parse(dr["usuario_id"].ToString());
                usuarioRol.rol_id = Int32.Parse(dr["rol_id"].ToString());
            }
            //conexion.cerrarConexion();
            return usuarioRol;
        }

        public Boolean guardar(UsuarioRoles usuarioRoles)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            int id = conexion.getSequenceValor("SEQ_USUARIO_ROLES", 1);
            conexion.cerrarConexion();

            string query = "insert into usuario_roles (id, usuario_id, rol_id) values (";
            query += id + ",";
            query += usuarioRoles.ioUsuarioId + ",";
            query += usuarioRoles.ioRolId + ")";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }

        public Boolean actualizar(UsuarioRoles usuarioRoles)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            string query = "update usuario_roles set";
            query += " id=" + usuarioRoles.ioId.ToString() + ",";
            query += " usuario_id=" + usuarioRoles.ioUsuarioId.ToString() + ",";
            query += " rol_id=" + usuarioRoles.ioRolId.ToString() + ",";
            query += " where id=" + usuarioRoles.ioId.ToString();

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
