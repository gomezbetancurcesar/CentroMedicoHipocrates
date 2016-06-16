using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Turnos
    {
        private int id;
        private string hora_inicio;
        private string hora_fin;
        private int diaId;
        private int estadoId;
        private EstadoTurno Estado;

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

        public int ioDiaId
        {
            set { this.diaId = value; }
            get { return this.diaId; }
        }

        public int ioEstadoId
        {
            set { this.estadoId = value; }
            get { return this.estadoId; }
        }

        public EstadoTurno ioEstado
        {
            set { this.Estado = value; }
            get { return this.Estado; }
        }

        public List<Turnos> turnosDisponibles()
        {
            List<Turnos> turnos = new List<Turnos>();
            Turnos turno;
            //Ir a buscar a la base!
            turno = new Turnos();
            turno.hora_inicio = "08:30";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "09:00";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "09:30";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "10:00";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "10:30";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "11:00";
            turno.estadoId = 2;
            turno.ioEstado = new EstadoTurno().buscarPorId(2);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "11:30";
            turno.estadoId = 2;
            turno.ioEstado = new EstadoTurno().buscarPorId(2);
            turnos.Add(turno);

            turno = new Turnos();
            turno.hora_inicio = "12:00";
            turno.estadoId = 1;
            turno.ioEstado = new EstadoTurno().buscarPorId(1);
            turnos.Add(turno);
            return turnos;
        }
    }
}