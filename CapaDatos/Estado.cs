using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Estado
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

        public Estado buscarPorId(int id)
        {
            Estado estado = new Estado();
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

        public List<Estado> buscarTodos()
        {
            List<Estado> estados = new List<Estado>();
            Estado estado;

            //Ir a buscar a la base
            estado = new Estado();
            estado.id = 1;
            estado.nombre = "Habilitado";
            estados.Add(estado);

            estado = new Estado();
            estado.id = 2;
            estado.nombre = "Inhabilitado";
            estados.Add(estado);

            return estados;
        }
    }
}
