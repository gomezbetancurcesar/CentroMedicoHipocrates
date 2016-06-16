using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string rut;
        private DateTime fechaNacimento;
        private int comunaId;
        private int provinciaId;
        private int regionId;

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

        public string ioApellidoMaterno
        {
            set { this.apellidoMaterno = value; }
            get { return this.apellidoMaterno; }
        }

        public string ioApellidoPaterno
        {
            set { this.apellidoPaterno = value; }
            get { return this.apellidoPaterno; }
        }

        public string ioRut
        {
            set { this.rut = value; }
            get { return this.rut; }
        }

        public DateTime ioFechaNacimento
        {
            set { this.fechaNacimento = value; }
            get { return this.fechaNacimento; }
        }

        public int ioComunaId
        {
            set { this.comunaId = value; }
            get { return this.comunaId; }
        }

        public int ioProvinciaId
        {
            set { this.provinciaId = value; }
            get { return this.provinciaId; }
        }

        public int ioRegionId
        {
            set { this.regionId = value; }
            get { return this.regionId; }
        }

        public Persona buscarPorRut(string rut)
        {
            Persona persona = new Persona();

            //Ir a buscar los datos de la persona a la base
            persona.nombre = "Cesar";
            persona.apellidoPaterno = "Gomez";
            persona.apellidoMaterno = "Betancur";
            persona.ioRut = "18610420-k";

            return persona;
        }

        public Persona buscarPorId(int id)
        {
            Persona persona = new Persona();

            //Ir a buscar los datos de la persona a la base
            persona.nombre = "Cesar";
            persona.apellidoPaterno = "Gomez";
            persona.apellidoMaterno = "Betancur";
            persona.ioRut = "18610420-k";

            return persona;
        }
    }
}
