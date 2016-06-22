using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Turno
    {
        private int id;
        private string hora_inicio;
        private string hora_fin;
        private int estado_turno_id;
        private EstadoTurno EstadoTurno;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioHoraInicio
        {
            set { this.hora_inicio = value; }
            get { return this.hora_inicio; }
        }

        public string ioHoraFin
        {
            set { this.hora_fin = value; }
            get { return this.hora_fin; }
        }

        public int ioEstadoTurnoId
        {
            set { this.estado_turno_id = value; }
            get { return this.estado_turno_id; }
        }

        public EstadoTurno ioEstadoTurno
        {
            set { this.EstadoTurno = value; }
            get { return this.EstadoTurno; }
        }

        public Turno buscarPorId(int id)
        {
            Turno turno = new Turno();
            return turno;
        }

        public List<Turno> buscarTodos(int estado = 0)
        {
            List<Turno> turnos = new List<Turno>();
            Turno turno;
            //Ir a buscar a la base!
            turno = new Turno();
            turno.hora_inicio = "08:30";
            turno.hora_fin = "09:00";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "09:00";
            turno.hora_fin = "09:30";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "09:30";
            turno.hora_fin = "10:00";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "10:00";
            turno.hora_fin = "10:30";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "10:30";
            turno.hora_fin = "11:00";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "11:00";
            turno.hora_fin = "11:30";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "11:30";
            turno.hora_fin = "12:00";
            turnos.Add(turno);

            turno = new Turno();
            turno.hora_inicio = "12:00";
            turno.hora_fin = "12:00";
            turnos.Add(turno);
            return turnos;
        }
    }
}