using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Administrador
    {
        private Usuario Persona = new Usuario();
        private int persona_id;

        public Administrador()
        {

        }

        public Usuario ioPersona
        {
            set { this.Persona = value; }
            get { return this.Persona; }
        }

        public int ioPersonaId
        {
            set { this.persona_id = value; }
            get { return this.persona_id; }
        }

        public List<Administrador> buscarTodos()
        {
            List<Administrador> administradores = new List<Administrador>();
            Administrador administrador;

            //Buscar en la base de datos
            administrador = new Administrador();
            administrador.persona_id = 1;
            administrador.ioPersona = new Usuario().buscarPorId(administrador.ioPersonaId);

            administradores.Add(administrador);

            return administradores;
        }
    }
}
