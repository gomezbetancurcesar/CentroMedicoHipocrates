using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Reserva
    {
        private int id;
        private int agenda_id;
        private int paciente_id;
        private int estado_reserva_id;
        private DateTime fecha_reserva;
        private Agenda Agenda = new Agenda();
        private Paciente Paciente = new Paciente();
        private EstadoReserva EstadoReserva = new EstadoReserva();

        public Reserva()
        {

        }

        public int ioId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int ioAgendaId
        {
            set { this.agenda_id = value; }
            get { return this.agenda_id; }
        }

        public int ioPacienteId
        {
            set { this.paciente_id = value; }
            get { return this.paciente_id; }
        }

        public int ioEstadoReservaId
        {
            set { this.estado_reserva_id = value; }
            get { return this.estado_reserva_id; }
        }

        public DateTime ioFechaReserva
        {
            set { this.fecha_reserva = value; }
            get { return this.fecha_reserva; }
        }

        public Agenda ioAgenda
        {
            set { this.Agenda = value; }
            get { return this.Agenda; }
        }

        public Paciente ioPaciente
        {
            set { this.Paciente = value; }
            get { return this.Paciente; }
        }

        public EstadoReserva ioEstadoReserva
        {
            set { this.EstadoReserva = value; }
            get { return this.EstadoReserva; }
        }

        public List<Reserva> buscarTodos()
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            //Ir a buscar a la base
            reserva = new Reserva();
            reservas.Add(reserva);
            return reservas;
        }

        public Reserva buscarPorId(int id)
        {
            //Ir a buscar a la base
            Reserva reserva = new Reserva();
            return reserva;
        }
    }
}
