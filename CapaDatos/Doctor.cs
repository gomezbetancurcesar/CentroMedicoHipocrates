using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Doctor
    {
        private Usuario Usuario = new Usuario();
        private Especialidad Especialidad = new Especialidad();
        private Oficina Oficina = new Oficina();
        private int especialidad_id;
        private int usuario_id;
        private int oficina_id;

        public Doctor()
        {
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
            List<Doctor> medicos = new List<Doctor>();
            Doctor medico;

            medico = new Doctor();
            medico.ioEspecialidadId = 1;
            medico.ioUsuarioId = 1;
            medico.ioOficinaId = 1;
            medico.Usuario = new Usuario().buscarPorId(medico.ioUsuarioId);
            medico.Especialidad = new Especialidad().buscarPorId(medico.ioEspecialidadId);
            medico.Oficina = new Oficina().buscarPorId(medico.ioOficinaId);
            medicos.Add(medico);

            return medicos;
        }

        public Doctor buscarPorRut(string rut)
        {
            Doctor medico = new Doctor();
            Usuario persona = new Usuario().buscarPorRut(rut);
            //ir a buscar a la base los datos del medico
            medico = this.buscarPorPersonaId(persona.ioId);
            return medico;
        }

        public Doctor buscarPorPersonaId(int personaId)
        {
            Doctor medico = new Doctor();
            medico.ioEspecialidadId = 1;
            medico.ioUsuarioId = 1;
            medico.Usuario = new Usuario().buscarPorId(personaId);
            medico.Especialidad = new Especialidad().buscarPorId(medico.ioEspecialidadId);
            return medico;
        }
    }
}
