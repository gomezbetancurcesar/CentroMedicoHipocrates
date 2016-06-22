using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Paciente
    {
        private int id;
        private int isapre_id;
        private int usuario_id;
        private Usuario Usuario = new Usuario();
        private Isapre Isapre = new Isapre();

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

        public Paciente buscarPorId(int id)
        {
            Paciente paciente = new Paciente();
            //ir a la base
            return paciente;
        }

        public List<Paciente> buscarTodos()
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente;
            //ir a la base
            paciente = new Paciente();
            pacientes.Add(paciente);
            return pacientes;
        }
    }
}
