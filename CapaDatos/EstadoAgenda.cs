using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class EstadoAgenda
    {
        private int id;
        private string nombre;

        public EstadoAgenda()
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

        public List<EstadoAgenda> buscarTodos()
        {
            List<EstadoAgenda> estados = new List<EstadoAgenda>();
            EstadoAgenda esatadoAgenda;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_agenda");
            while (dr.Read())
            {
                esatadoAgenda = new EstadoAgenda();
                esatadoAgenda.id = Int32.Parse(dr["id"].ToString());
                esatadoAgenda.nombre = dr["nombre"].ToString();
                estados.Add(esatadoAgenda);
            }
            conexion.cerrarConexion();
            return estados;
        }

        public EstadoAgenda buscarPorId(int id)
        {
            EstadoAgenda esatadoAgenda = new EstadoAgenda();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_agenda where id = " + id);
            if (dr.Read())
            {
                esatadoAgenda.id = Int32.Parse(dr["id"].ToString());
                esatadoAgenda.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return esatadoAgenda;
        }

        public EstadoAgenda buscarPorNombre(string nombre)
        {
            EstadoAgenda esatadoAgenda = new EstadoAgenda();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_agenda where nombre = '" + nombre + "'");
            if (dr.Read())
            {
                esatadoAgenda.id = Int32.Parse(dr["id"].ToString());
                esatadoAgenda.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return esatadoAgenda;
        }
    }
}
