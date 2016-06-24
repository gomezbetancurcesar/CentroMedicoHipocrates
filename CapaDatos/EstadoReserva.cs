using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class EstadoReserva
    {
        private int id;
        private string nombre;
        private string descripcion;

        public EstadoReserva()
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

        public string ioDescripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public List<EstadoReserva> buscarTodos()
        {
            List<EstadoReserva> estados = new List<EstadoReserva>();
            EstadoReserva estadoTurno;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_reservas");
            while (dr.Read())
            {
                estadoTurno = new EstadoReserva();
                estadoTurno.id = Int32.Parse(dr["id"].ToString());
                estadoTurno.nombre = dr["nombre"].ToString();
                estados.Add(estadoTurno);
            }
            conexion.cerrarConexion();
            return estados;
        }

        public EstadoReserva buscarPorId(int id)
        {
            EstadoReserva estadoTurno = new EstadoReserva();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_reservas where id = " + id);
            if (dr.Read())
            {
                estadoTurno.id = Int32.Parse(dr["id"].ToString());
                estadoTurno.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return estadoTurno;
        }

        public EstadoReserva buscarPorNombre(string nombre)
        {
            EstadoReserva estadoTurno = new EstadoReserva();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from estado_reservas where nombre = '" + nombre + "'");
            if (dr.Read())
            {
                estadoTurno.id = Int32.Parse(dr["id"].ToString());
                estadoTurno.nombre = dr["nombre"].ToString();
            }
            conexion.cerrarConexion();
            return estadoTurno;
        }
    }
}
