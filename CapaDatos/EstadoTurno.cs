using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstadoTurno
    {
        private int id;
        private string nombre;
        private string descripcion;

        public EstadoTurno()
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

        public List<EstadoTurno> buscarTodos()
        {
            List<EstadoTurno> estados = new List<EstadoTurno>();
            EstadoTurno estado;

            //ir a la base
            estado = new EstadoTurno();
            estados.Add(estado);
            return estados;
        }

        public EstadoTurno buscarPorId(int id)
        {
            EstadoTurno estado = new EstadoTurno();
            //ir a la base de datos
            return estado;
        }
    }
}
