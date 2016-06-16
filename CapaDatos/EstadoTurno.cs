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

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public EstadoTurno buscarPorId(int id)
        {
            EstadoTurno estado = new EstadoTurno();
            //Ir a buscar a la base
            estado.id = id;
            if (id.Equals(1))
            {
                estado.nombre = "Habilitado";
            }else
            {
                estado.nombre = "No Habilitado";
            }
            return estado;
        }
    }
}
