using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Recepcionista
    {
        private Usuario Persona = new Usuario();
        private int persona_id;

        public Recepcionista()
        {
        }

        public Usuario ioPersona
        {
            get { return this.Persona; }
            set { this.Persona = value; }
        }

        public int ioPersonaID
        {
            get { return this.persona_id; }
            set { this.persona_id = value; }
        }

        public List<Recepcionista> buscarTodos()
        {
            List<Recepcionista> recepcionistas = new List<Recepcionista>();
            Recepcionista recepcionista;
            //Ir a buscar los recepcionistas a la base
            recepcionista = new Recepcionista();
            recepcionista.ioPersonaID = 1;
            recepcionista.ioPersona = new Usuario().buscarPorId(recepcionista.ioPersonaID);

            return recepcionistas;
        }
    }
}
