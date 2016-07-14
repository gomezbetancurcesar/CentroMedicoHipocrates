using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Fichas
    {
        private int id;
        private int reserva_id;
        private DateTime fecha_creacion;
        private DateTime fecha_modificacion;
        private string tratamientos;
        private string observacion;
        private Reserva Reserva;

        public Fichas()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioReservaId
        {
            set { this.reserva_id = value; }
            get { return this.reserva_id; }
        }

        public DateTime ioFechaCreacion
        {
            set { this.fecha_creacion = value; }
            get { return this.fecha_creacion; }
        }

        public DateTime ioFechaModificacion
        {
            set { this.fecha_modificacion = value; }
            get { return this.fecha_modificacion; }
        }

        public string ioTratamientos
        {
            set { this.tratamientos = value; }
            get { return this.tratamientos; }
        }

        public string ioObservacion
        {
            set { this.observacion = value; }
            get { return this.observacion; }
        }

        public Reserva ioReserva
        {
            set { this.Reserva = value; }
            get { return this.Reserva; }
        }

        public Fichas buscarPorId(int id, Boolean fullData = false)
        {
            Fichas ficha = new Fichas();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from fichas where id = " + id);
            if (dr.Read())
            {
                ficha.ioId = Int32.Parse(dr["id"].ToString());
                ficha.ioReservaId = Int32.Parse(dr["reserva_id"].ToString());
                ficha.ioFechaCreacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                ficha.ioFechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"].ToString());
                ficha.ioTratamientos = dr["tratamientos"].ToString();
                ficha.ioObservacion = dr["observacion"].ToString();
                if (fullData)
                {
                    ficha.ioReserva = new Reserva().buscarPorId(ficha.ioReservaId, true);
                }
            }
            conexion.cerrarConexion();
            return ficha;
        }

        public Fichas buscarPorReservaId(int reservaId, Boolean fullData = false)
        {
            Fichas ficha = new Fichas();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from fichas where reserva_id = " + reservaId);
            if (dr.Read())
            {
                ficha.ioId = Int32.Parse(dr["id"].ToString());
                ficha.ioReservaId = Int32.Parse(dr["reserva_id"].ToString());
                ficha.ioFechaCreacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                ficha.ioFechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"].ToString());
                ficha.ioTratamientos = dr["tratamientos"].ToString();
                ficha.ioObservacion = dr["observacion"].ToString();
                if (fullData)
                {
                    ficha.ioReserva = new Reserva().buscarPorId(ficha.ioReservaId, true);
                }
            }
            conexion.cerrarConexion();
            return ficha;
        }

        public List<Fichas> buscarTodos(Boolean fullData = false)
        {
            List<Fichas> fichas = new List<Fichas>();
            Fichas ficha;
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from fichas");
            while (dr.Read())
            {
                ficha = new Fichas();
                ficha.ioId = Int32.Parse(dr["id"].ToString());
                ficha.ioReservaId = Int32.Parse(dr["reserva_id"].ToString());
                ficha.ioFechaCreacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                ficha.ioFechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"].ToString());
                ficha.ioTratamientos = dr["tratamientos"].ToString();
                ficha.ioObservacion = dr["observacion"].ToString();
                if (fullData)
                {
                    ficha.ioReserva = new Reserva().buscarPorId(ficha.ioReservaId, true);
                }
                fichas.Add(ficha);
            }
            conexion.cerrarConexion();
            return fichas;
        }

        public Boolean guardar(Fichas fichas)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            int id = conexion.getSequenceValor("SEQ_FICHAS", 1);
            conexion.cerrarConexion();

            string query = "insert into fichas (id, reserva_id, fecha_creacion, fecha_modificacion, tratamientos, observacion) values (";
            query += id + ",";
            query += fichas.ioReservaId + ",";
            query += " TO_TIMESTAMP('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "','YYYY-MM-DD HH24:MI:SS'),";
            query += " TO_TIMESTAMP('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "','YYYY-MM-DD HH24:MI:SS'),";
            query += "'" + fichas.ioTratamientos + "',";
            query += "'" + fichas.ioObservacion + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean actualizar(Fichas fichas)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update fichas set";
            query += " reserva_id=" + fichas.ioReservaId + ",";
            query += " fecha_modificacion = TO_TIMESTAMP('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "','YYYY-MM-DD HH24:MI:SS'),";
            query += " tratamientos='" + fichas.ioTratamientos + "',";
            query += " observacion='" + fichas.ioObservacion + "'";
            query += " where id=" + fichas.ioId.ToString();

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }
    }
}
