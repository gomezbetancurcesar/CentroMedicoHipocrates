using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EstadoDia
    {
        private int id;
        private string nombre;
        private string descripcion;

        public EstadoDia()
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

        public List<EstadoDia> buscarTodos()
        {
            List<EstadoDia> estados = new List<EstadoDia>();
            EstadoDia estado;

            //ir a la base
            estado = new EstadoDia();
            estados.Add(estado);
            return estados;
        }

        public EstadoDia buscarPorId(int id)
        {
            EstadoDia estado = new EstadoDia();
            //ir a la base de datos
            return estado;
        }
    }
}
