using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Region
    {
        private int id;
        private string nombre;

        public Region()
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

        public List<Region> buscarTodos()
        {
            List<Region> regiones = new List<Region>();

            //IR a buscar a la base
            //consultar("select * from Regiones");
            return regiones;
        }
    }
}
