using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Persona
    {
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string rut;
        private DateTime fechaNacimento;
        private int comunaId;
        private int provinciaId;
        private int regionId;

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

        public int ioComuna
        {
            set { this.comunaId = value; }
            get { return this.comunaId; }
        }

        public int ioProvincia
        {
            set { this.provinciaId = value; }
            get { return this.provinciaId; }
        }

        public int ioRegion
        {
            set { this.regionId = value; }
            get { return this.regionId; }
        }
    }
}
