using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Comuna
    {
        private int id;
        private string nombre;
        private int provincia_id;
        private Provincia Provincia;

        public Comuna()
        {

        }

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

        public int ioProvinciaId
        {
            set { this.provincia_id = value; }
            get { return this.provincia_id; }
        }

        public Provincia ioProvincia
        {
            set { this.Provincia = value; }
            get { return this.Provincia; }
        }

        public List<Comuna> buscarTodos(int provinciaId = -1)
        {
            List<Comuna> comunas = new List<Comuna>();
            //IR a buscar a la base
            return comunas;
        }
    }
}
