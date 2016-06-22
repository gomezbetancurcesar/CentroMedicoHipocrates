using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Oficina
    {
        private int id;
        private int piso;
        private string numero;

        public Oficina()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioPiso
        {
            set { this.piso = value; }
            get { return this.piso; }
        }

        public string ioNumero
        {
            set { this.numero = value; }
            get { return this.numero; }
        }

        public List<Oficina> buscarTodos()
        {
            List<Oficina> oficinas = new List<Oficina>();
            Oficina oficina;
            //ir a la base
            oficina = new Oficina();


            oficinas.Add(oficina);
            return oficinas;
        }

        public Oficina buscarPorId(int id)
        {
            Oficina oficina = new Oficina();
            //ir a la base
            return oficina;
        }
    }
}
