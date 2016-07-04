using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Turno
    {
        private int id;
        private string hora_inicio;
        private string hora_fin;
        private int estado_turno_id;
        private EstadoTurno EstadoTurno;

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string ioHoraInicio
        {
            set { this.hora_inicio = value; }
            get { return this.hora_inicio; }
        }

        public string ioHoraFin
        {
            set { this.hora_fin = value; }
            get { return this.hora_fin; }
        }

        public int ioEstadoTurnoId
        {
            set { this.estado_turno_id = value; }
            get { return this.estado_turno_id; }
        }

        public EstadoTurno ioEstadoTurno
        {
            set { this.EstadoTurno = value; }
            get { return this.EstadoTurno; }
        }

        public Turno buscarPorId(int id)
        {
            Turno turno = new Turno();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from turnos where id = "+ id);
            if (dr.Read())
            {
                turno.ioId = Int32.Parse(dr["id"].ToString());
                turno.ioEstadoTurnoId = Int32.Parse(dr["estado_turno_id"].ToString());
                turno.ioHoraInicio = dr["hora_inicio"].ToString();
                turno.ioHoraFin = dr["hora_fin"].ToString();
                turno.EstadoTurno = new EstadoTurno().buscarPorId(turno.ioEstadoTurnoId);
            }
            conexion.cerrarConexion();
            return turno;
        }

        public List<Turno> buscarTodos(int estado = 0, string order = "ASC")
        {
            List<Turno> turnos = new List<Turno>();
            Turno turno;
            Conexion conexion = new Conexion();
            string query = "select * from turnos";
            if (!estado.Equals(0))
            {
                query += " where estado_turno_id = " + estado;
            }
            query += " order by hora_inicio "+order;

            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                turno = new Turno();
                turno.ioId = Int32.Parse(dr["id"].ToString());
                turno.ioEstadoTurnoId = Int32.Parse(dr["estado_turno_id"].ToString());
                turno.ioHoraInicio = dr["hora_inicio"].ToString();
                turno.ioHoraFin = dr["hora_fin"].ToString();
                turno.EstadoTurno = new EstadoTurno().buscarPorId(turno.ioEstadoTurnoId);
                turnos.Add(turno);
            }
            conexion.cerrarConexion();
            return turnos;
        }

        public bool guardar(Turno turno)
        {
            Conexion conexion = new Conexion();
            bool almaceno = false;
            int id = conexion.getSequenceValor("SEQ_TURNOS", 1);
            conexion.cerrarConexion();

            string query = "insert into TURNOS (id, estado_turno_id, hora_inicio, hora_fin) values (";
            query += id + ",";
            query += turno.ioEstadoTurnoId.ToString()+",";
            query += "'" + turno.ioHoraInicio + "',";
            query += "'" + turno.ioHoraFin + "')";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if(filasIngresadas > 0)
            {
                almaceno = true;
            }
            return almaceno;
        }

        public Boolean actualizar(Turno turno)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            string query = "update TURNOS set";
            query += " id=" + turno.ioId.ToString() + ",";
            query += " estado_turno_id=" + turno.ioEstadoTurnoId.ToString() + ",";
            query += " hora_inicio='" + turno.ioHoraInicio + "',";
            query += " hora_fin='" + turno.ioHoraFin + "'";
            query += " where id=" + turno.ioId.ToString();

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