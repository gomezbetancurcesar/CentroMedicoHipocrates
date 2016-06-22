using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dia
    {
        private int id;
        private DateTime fecha;
        private int estado_dia_id;
        private EstadoDia EstadoDia;

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

        public int ioEstadoDiaId
        {
            set { this.estado_dia_id = value; }
            get { return this.estado_dia_id; }
        }

        public EstadoDia ioEstadoDia
        {
            set { this.EstadoDia = value; }
            get { return this.EstadoDia; }
        }

        public List<Dia> buscarTodos()
        {
            List<Dia> dias = new List<Dia>();
            Dia dia;

            //ir a buscar los dias a la base
            dia = new Dia();
            dia.id = 1;
            dia.fecha = DateTime.Now.Date;

            dia = new Dia();
            dia.id = 2;
            dia.fecha = DateTime.Now.Date.AddDays(1).Date;

            dia = new Dia();
            dia.id = 3;
            dia.fecha = DateTime.Now.Date.AddDays(2).Date;
            return dias;
        }
    }
}
