using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Isapre
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

        public Isapre buscarPorId(int id)
        {
            Isapre isapres = new Isapre();
            //Buscar las isapres
            isapres.id = 1;
            isapres.nombre = "Colmena";

            return isapres;
        }
    }
}
