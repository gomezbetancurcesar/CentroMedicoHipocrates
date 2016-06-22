using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstadoReserva
    {
        private int id;
        private string nombre;
        private string descripcion;

        public EstadoReserva()
        {

        }

        public int ioId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string ioNombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string ioDescripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public List<EstadoReserva> buscarTodos()
        {
            List<EstadoReserva> estados = new List<EstadoReserva>();
            EstadoReserva estado;

            //ir a la base
            estado = new EstadoReserva();
            estados.Add(estado);
            return estados;
        }

        public EstadoReserva buscarPorId(int id)
        {
            EstadoReserva estado = new EstadoReserva();
            //ir a la base de datos
            return estado;
        }
    }
}
