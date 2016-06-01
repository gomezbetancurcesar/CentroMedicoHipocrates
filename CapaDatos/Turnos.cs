using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Turnos
    {
        private int id;
        private DateTime hora_inicio;
        private DateTime hora_fin;
        private int diaId;
        private int estadoId;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public DateTime ioHoraInicio
        {
            set { this.hora_inicio = value; }
            get { return this.hora_inicio; }
        }

        public DateTime ioHoraFin
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
    }
}