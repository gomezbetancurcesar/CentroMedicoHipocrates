using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dias
    {
        private int id;
        private DateTime fecha;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public DateTime ioFecha
        {
            set { this.fecha = value; }
            get { return this.fecha; }
        }
    }
}
