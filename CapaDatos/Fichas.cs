using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Fichas
    {
        private int id;
        private int reserva_id;
        private DateTime fecha_creacion;
        private DateTime fecha_modificacion;
        private string tratamientos;
        private string enfermedades;
        private Reserva Reserva = new Reserva();

        public Fichas()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioReservaId
        {
            set { this.reserva_id = value; }
            get { return this.reserva_id; }
        }

        public DateTime ioFechaCreacion
        {
            set { this.fecha_creacion = value; }
            get { return this.fecha_creacion; }
        }

        public DateTime ioFechaModificacion
        {
            set { this.fecha_modificacion = value; }
            get { return this.fecha_modificacion; }
        }

        public string ioTratamientos
        {
            set { this.tratamientos = value; }
            get { return this.tratamientos; }
        }

        public string ioEnfermedades
        {
            set { this.enfermedades = value; }
            get { return this.enfermedades; }
        }

        public Reserva ioReserva
        {
            set { this.Reserva = value; }
            get { return this.Reserva; }
        }

        public Fichas buscarPorId(int id)
        {
            Fichas ficha = new Fichas();
            //ir a la base
            return ficha;
        }

        public List<Fichas> buscarTodos()
        {
            List<Fichas> fichas = new List<Fichas>();
            Fichas ficha;
            //ir a la base
            ficha = new Fichas();
            fichas.Add(ficha);
            return fichas;
        }
    }
}
