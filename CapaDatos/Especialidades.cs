using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Especialidades
    {
        private int id;
        private string nombre;
        private Conexion conexion = new Conexion();

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioNombre{
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public Especialidades buscarPorId(int id)
        {
            Especialidades especialidad = new Especialidades();
            //IR a buscar a la base

            especialidad.id = 1;
            especialidad.nombre = "Pediatría";
            return especialidad;
        }
    }
}
