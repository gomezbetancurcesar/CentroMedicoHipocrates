using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Agenda
    {
        private int id;
        private int turno_id;
        private int dia_id;
        private int doctor_id;
        private int es_sobrecupo;
        private DateTime fecha_creacion;
        private Turno Turno;
        private Dia Dia;
        private Doctor Doctor;

        public Agenda()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioTurnoId
        {
            set { this.turno_id = value; }
            get { return this.turno_id; }
        }

        public int ioDiaId
        {
            set { this.dia_id = value; }
            get { return this.dia_id; }
        }

        public int ioDoctorId
        {
            set { this.doctor_id = value; }
            get { return this.doctor_id; }
        }

        public int ioEsSobrecupo
        {
            set { this.es_sobrecupo = value; }
            get { return this.es_sobrecupo; }
        }

        public Turno ioTurno
        {
            set { this.Turno = value; }
            get { return this.Turno; }
        }

        public Dia ioDia
        {
            set { this.Dia = value; }
            get { return this.Dia; }
        }

        public Doctor ioDoctor
        {
            set { this.Doctor = value; }
            get { return this.Doctor; }
        }
    }
}
