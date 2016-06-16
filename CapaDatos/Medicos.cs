using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Medicos
    {
        private Persona Persona = new Persona();
        private Especialidades Especialidad = new Especialidades();
        private int especialidad_id;
        private int persona_id;

        public Medicos()
        {
        }

        public int ioEspecialidadId
        {
            set { this.especialidad_id = value; }
            get { return this.especialidad_id; }
        }

        public int ioPersonaId
        {
            set { this.persona_id = value; }
            get { return this.persona_id; }
        }

        public Persona ioPersona
        {
            set { this.Persona = value; }
            get { return this.Persona; }
        }

        public Especialidades ioEspecialidad
        {
            set { this.Especialidad = value; }
            get { return this.Especialidad; }
        }

        public List<Medicos> buscarTodos()
        {
            List<Medicos> medicos = new List<Medicos>();
            Medicos medico;

            medico = new Medicos();
            medico.ioEspecialidadId = 1;
            medico.ioPersonaId = 1;
            medico.Persona = new Persona().buscarPorId(medico.ioPersonaId);
            medico.Especialidad = new Especialidades().buscarPorId(medico.ioEspecialidadId);
            medicos.Add(medico);

            return medicos;
        }

        public Medicos buscarPorRut(string rut)
        {
            Medicos medico = new Medicos();
            Persona persona = new Persona().buscarPorRut(rut);
            //ir a buscar a la base los datos del medico
            medico = this.buscarPorPersonaId(persona.ioId);
            return medico;
        }

        public Medicos buscarPorPersonaId(int personaId)
        {
            Medicos medico = new Medicos();
            medico.ioEspecialidadId = 1;
            medico.ioPersonaId = 1;
            medico.Persona = new Persona().buscarPorId(personaId);
            medico.Especialidad = new Especialidades().buscarPorId(medico.ioEspecialidadId);
            return medico;
        }
    }
}
