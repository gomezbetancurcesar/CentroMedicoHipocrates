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
        private Usuario Usuario = new Usuario();
        private Rol Rol = new Rol();

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
    }
}
