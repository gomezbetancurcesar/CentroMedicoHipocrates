using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Provincia
    {
        private int id;
        private string nombre;
        private int region_id;
        private Region Region;

        public Provincia()
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

        public int ioRegionId
        {
            get { return this.region_id; }
            set { this.region_id = value; }
        }

        public Region ioRegion
        {
            get { return this.Region; }
            set { this.Region = value; }
        }

        public Provincia buscarPorId(int id)
        {
            Provincia provincia = new Provincia();
            return provincia;
        }

        public List<Provincia> buscarTodos(int idRegion = -1)
        {
            List<Provincia> provincias = new List<Provincia>();
            //IR a buscar a la base
            return provincias;
        }
    }
}
