using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Agenda
    {
        private int id;
        private int turno_id;
        private int doctor_id;
        private int es_sobrecupo;
        private DateTime dia;
        private DateTime fecha_creacion;
        private Turno Turno;
        private Doctor Doctor;
        private List<Reserva> Reservas;

        public Agenda()
        {

        }

        public int ioId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public int ioTurnoId
        {
            set { this.turno_id = value; }
            get { return this.turno_id; }
        }

        public int ioDoctorId
        {
            set { this.doctor_id = value; }
            get { return this.doctor_id; }
        }

        public int ioEsSobrecupo
        {
            set { this.es_sobrecupo = value; }
            get { return this.es_sobrecupo; }
        }

        public DateTime ioDia
        {
            set { this.dia = value; }
            get { return this.dia; }
        }

        public DateTime ioFechaCreacion
        {
            set { this.fecha_creacion = value; }
            get { return this.fecha_creacion; }
        }

        public Turno ioTurno
        {
            set { this.Turno = value; }
            get { return this.Turno; }
        }

        public Doctor ioDoctor
        {
            set { this.Doctor = value; }
            get { return this.Doctor; }
        }

        public List<Reserva> ioReservas
        {
            set { this.Reservas = value; }
            get { return this.Reservas; }
        }

        public List<Agenda> buscarTodas(int doctorId = 0, DateTime? fecha = null, Boolean incluirTurno = false)
        {
            List<Agenda> agendas = new List<Agenda>();
            Agenda agenda;
            Conexion conexion = new Conexion();
            string formato = "yyyy-MM-dd";

            string query = "select * from agenda";
            if (!doctorId.Equals(0)) {
                query += " where doctor_id = " + doctorId;
                if (fecha != null)
                {
                    DateTime f = (DateTime) fecha;
                    query += " and dia = DATE '" + f.ToString(formato) + "'";
                }
            } else
            {
                DateTime f = (DateTime)fecha;
                query += " where dia = DATE '" + f.ToString(formato) + "'";
            }

            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read()) {
                agenda = new Agenda();
                agenda.ioId = Int32.Parse(dr["id"].ToString());
                agenda.ioTurnoId = Int32.Parse(dr["turno_id"].ToString());
                agenda.ioDia = Convert.ToDateTime(dr["dia"].ToString());
                agenda.ioDoctorId = Int32.Parse(dr["doctor_id"].ToString());
                agenda.ioEsSobrecupo = Int32.Parse(dr["es_sobrecupo"].ToString());
                if (incluirTurno)
                {
                    agenda.Turno = new Turno().buscarPorId(agenda.ioTurnoId);
                    agenda.Reservas = new Reserva().buscarTodos(agenda.ioId);
                }
                agendas.Add(agenda);
            }
            conexion.cerrarConexion();
            return agendas;
        }

        public Boolean guardar(Agenda agenda)
        {
            string formato = "yyyy-MM-dd";
            Conexion conexion = new Conexion();
            bool guardo = false;
            int id = conexion.getSequenceValor("SEQ_AGENDA", 1);
            conexion.cerrarConexion();

            string query = "insert into agenda (id, turno_id, dia, doctor_id, es_sobrecupo, fecha_creacion) values (";
            query += id + ",";
            query += agenda.ioTurnoId + ",";
            query += "DATE '" + agenda.ioDia.Date.ToString(formato) + "',";
            query += agenda.ioDoctorId + ",";
            query += agenda.ioEsSobrecupo + ",";
            query += "TO_TIMESTAMP('" + agenda.ioFechaCreacion.ToString("yyyy-MM-dd H:mm:ss") + "','YYYY-MM-DD HH24:MI:SS'))";
            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();

            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }

        public Boolean eliminar(Agenda agenda)
        {
            bool eliminado = false;
            Conexion conexion = new Conexion();
            string query = "delete from agenda where id = " + agenda.ioId;
            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                eliminado = true;
            }
            return eliminado;
        }

        public Boolean guardarTodos(List<Agenda> agendas)
        {
            bool guarda = false;
            foreach(Agenda agenda in agendas)
            {
                guarda = this.guardar(agenda);
            }
            return guarda;
        }

        public Boolean eliminarTodos(List<Agenda> agendas)
        {
            Conexion conexion = new Conexion();
            bool eliminados = false;
            foreach(Agenda agenda in agendas)
            {
                eliminados = this.eliminar(agenda);
            }
            return eliminados;
        }

        public Agenda buscarPorId(int id, Boolean fullData = false)
        {
            Agenda agenda = new Agenda();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from agenda where id = " + id);
            if (dr.Read())
            {
                agenda.ioId = Int32.Parse(dr["id"].ToString());
                agenda.ioTurnoId = Int32.Parse(dr["turno_id"].ToString());
                agenda.ioDia = Convert.ToDateTime(dr["dia"].ToString());
                agenda.ioDoctorId = Int32.Parse(dr["doctor_id"].ToString());
                agenda.ioEsSobrecupo = Int32.Parse(dr["es_sobrecupo"].ToString());
                agenda.ioFechaCreacion = Convert.ToDateTime(dr["fecha_creacion"].ToString());
                if (fullData)
                {
                    agenda.Turno = new Turno().buscarPorId(agenda.ioTurnoId);
                    agenda.ioDoctor = new Doctor().buscarPorId(agenda.ioDoctorId);
                }
            }
            conexion.cerrarConexion();
            return agenda;
        }
    }
}
