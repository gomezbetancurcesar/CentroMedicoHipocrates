using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace CapaDatos
{
    public class Reserva
    {
        private int id;
        private int agenda_id;
        private int paciente_id;
        private int estado_reserva_id;
        private int es_sobrecupo;
        private DateTime fecha_reserva;
        private Agenda Agenda;
        private Paciente Paciente;
        private EstadoReserva EstadoReserva;
        private Fichas Fichas;

        public Reserva()
        {

        }

        public int ioId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int ioAgendaId
        {
            set { this.agenda_id = value; }
            get { return this.agenda_id; }
        }

        public int ioPacienteId
        {
            set { this.paciente_id = value; }
            get { return this.paciente_id; }
        }

        public int ioEstadoReservaId
        {
            set { this.estado_reserva_id = value; }
            get { return this.estado_reserva_id; }
        }

        public int ioEsSobrecupo
        {
            set { this.es_sobrecupo = value; }
            get { return this.es_sobrecupo; }
        }

        public DateTime ioFechaReserva
        {
            set { this.fecha_reserva = value; }
            get { return this.fecha_reserva; }
        }

        public Agenda ioAgenda
        {
            set { this.Agenda = value; }
            get { return this.Agenda; }
        }

        public Paciente ioPaciente
        {
            set { this.Paciente = value; }
            get { return this.Paciente; }
        }

        public EstadoReserva ioEstadoReserva
        {
            set { this.EstadoReserva = value; }
            get { return this.EstadoReserva; }
        }

        public Fichas ioFicha
        {
            set { this.Fichas = value; }
            get { return this.Fichas; }
        }

        public List<Reserva> buscarTodos(int agendaId = 0, int pacienteId = 0, Boolean fullData = false, Boolean containAgenda = false)
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            Conexion conexion = new Conexion();
            string query = "select * from reservas";
            if (!agendaId.Equals(0))
            {
                query += " where agenda_id=" + agendaId;
                if (!pacienteId.Equals(0))
                {
                    query += " and paciente_id=" + pacienteId;
                }
            }
            else
            {
                if (!pacienteId.Equals(0))
                {
                    query += " where paciente_id=" + pacienteId;
                }
            }
            Console.WriteLine(query);
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                reserva = new Reserva();
                reserva.ioId = Int32.Parse(dr["id"].ToString());
                reserva.ioAgendaId = Int32.Parse(dr["agenda_id"].ToString());
                reserva.ioPacienteId = Int32.Parse(dr["paciente_id"].ToString());
                reserva.ioEstadoReservaId = Int32.Parse(dr["estado_reserva_id"].ToString());
                reserva.ioFechaReserva = Convert.ToDateTime(dr["fecha_reserva"].ToString());
                reserva.ioEsSobrecupo = Int32.Parse(dr["es_sobrecupo"].ToString());
                if (fullData)
                {
                    reserva.ioPaciente = new Paciente().buscarPorId(reserva.ioPacienteId, true);
                    reserva.ioEstadoReserva = new EstadoReserva().buscarPorId(reserva.ioEstadoReservaId);
                }
                if (containAgenda)
                {
                    reserva.ioAgenda = new Agenda().buscarPorId(reserva.ioAgendaId, true);
                }
                reservas.Add(reserva);
            }
            conexion.cerrarConexion();
            return reservas;
        }

        public List<Reserva> datosParaConfirmar(DateTime fecha, String rutMedico = ""){
            Conexion conexion = new Conexion();
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;

            String query = "select re.id as IdReserva, re.es_sobrecupo as sobreCupo, pa.id as IdPaciente,";
            query += "usu_doc.nombres as DocNombre, usu_doc.apellido_paterno as DocPaterno, usu_doc.apellido_materno as DocMaterno,";
            query += "tur.hora_inicio, tur.hora_fin,";
            query += "usu_pac.nombres as PacNombre, usu_pac.apellido_paterno as PacPaterno, usu_pac.apellido_materno as PacMaterno,";
            query += "es_re.nombre as NombreEstado,";
            query += "esp.nombre as NombreEspecialidad ";
            query += "from reservas re ";
            query += "inner join agenda ag on re.agenda_id = ag.id ";
            query += "inner join pacientes pa on re.paciente_id = pa.id ";
            query += "inner join estado_reservas es_re on re.estado_reserva_id = es_re.id ";
            query += "inner join turnos tur on ag.turno_id = tur.id ";
            query += "inner join usuarios usu_pac on pa.usuario_id = usu_pac.id ";
            query += "inner join doctores doc on ag.doctor_id = doc.id ";
            query += "inner join usuarios usu_doc on doc.usuario_id = usu_doc.id ";
            query += "inner join especialidades esp on doc.especialidad_id = esp.id ";
            query += "where ag.dia = DATE '"+ fecha.Date.ToString("yyyy-MM-dd") +"'";

            if (!rutMedico.Equals(""))
            {
                query += "and usu_doc.rut = '"+rutMedico+"'";
            }

            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                reserva = new Reserva();
                reserva.ioId = Int32.Parse(dr["IdReserva"].ToString());
                reserva.ioPacienteId = Int32.Parse(dr["IdPaciente"].ToString());
                reserva.ioEsSobrecupo = Int32.Parse(dr["sobreCupo"].ToString());
                reserva.ioPaciente = new Paciente();
                reserva.ioPaciente.ioUsuario = new Usuario();
                reserva.ioPaciente.ioUsuario.ioNombre = dr["PacNombre"].ToString();
                reserva.ioPaciente.ioUsuario.ioApellidoPaterno = dr["PacPaterno"].ToString();
                reserva.ioPaciente.ioUsuario.ioApellidoMaterno = dr["PacMaterno"].ToString();
                reserva.ioAgenda = new Agenda();
                reserva.ioAgenda.ioTurno = new Turno();
                reserva.ioAgenda.ioTurno.ioHoraInicio = dr["hora_inicio"].ToString();
                reserva.ioAgenda.ioTurno.ioHoraFin = dr["hora_fin"].ToString();
                reserva.ioAgenda.ioDoctor = new Doctor();
                reserva.ioAgenda.ioDoctor.ioUsuario = new Usuario();
                reserva.ioAgenda.ioDoctor.ioUsuario.ioNombre = dr["DocNombre"].ToString();
                reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoPaterno = dr["DocPaterno"].ToString();
                reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoMaterno = dr["DocMaterno"].ToString();
                reserva.ioAgenda.ioDoctor.ioEspecialidad = new Especialidad();
                reserva.ioAgenda.ioDoctor.ioEspecialidad.ioNombre = dr["NombreEspecialidad"].ToString();
                reserva.ioEstadoReserva = new EstadoReserva();
                reserva.ioEstadoReserva.ioNombre = dr["NombreEstado"].ToString();
                reservas.Add(reserva);
            }
            conexion.cerrarConexion();
            return reservas;
        }

        public List<Reserva> buscarPorAgendaPaciente(DateTime fecha, int pacienteId)
        {
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            Conexion conexion = new Conexion();
            string query = "select R.* from RESERVAS R ";
            query += "INNER JOIN AGENDA AG on AG.id = R.AGENDA_ID ";
            query += "INNER JOIN PACIENTES PA on PA.id = R.paciente_id ";
            query += "where AG.DIA = date '"+fecha.Date.ToString("yyyy-MM-dd") +"' ";
            query += "and r.PACIENTE_ID = " + pacienteId;
            OracleDataReader dr = conexion.consultar(query);
            while (dr.Read())
            {
                reserva = new Reserva();
                reserva.ioId = Int32.Parse(dr["id"].ToString());
                reserva.ioAgendaId = Int32.Parse(dr["agenda_id"].ToString());
                reserva.ioPacienteId = Int32.Parse(dr["paciente_id"].ToString());
                reserva.ioEstadoReservaId = Int32.Parse(dr["estado_reserva_id"].ToString());
                reserva.ioFechaReserva = Convert.ToDateTime(dr["fecha_reserva"].ToString());
                reserva.ioEsSobrecupo = Int32.Parse(dr["es_sobrecupo"].ToString());
                //reserva.ioPaciente = new Paciente().buscarPorId(reserva.ioPacienteId, true);
                //reserva.ioEstadoReserva = new EstadoReserva().buscarPorId(reserva.ioEstadoReservaId);
                reserva.ioAgenda = new Agenda().buscarPorId(reserva.ioAgendaId, true);
                reserva.ioEstadoReserva = new EstadoReserva().buscarPorId(reserva.ioEstadoReservaId);

                reservas.Add(reserva);
            }
            conexion.cerrarConexion();
            return reservas;
        }

        public Reserva buscarPorId(int id, Boolean fullData = false)
        {
            Reserva reserva = new Reserva();
            Conexion conexion = new Conexion();
            OracleDataReader dr = conexion.consultar("select * from reservas where id ="+id);
            if (dr.Read())
            {
                reserva.ioId = Int32.Parse(dr["id"].ToString());
                reserva.ioAgendaId = Int32.Parse(dr["agenda_id"].ToString()); ;
                reserva.ioPacienteId = Int32.Parse(dr["paciente_id"].ToString()); ; ;
                reserva.ioEstadoReservaId = Int32.Parse(dr["estado_reserva_id"].ToString()); ; ;
                reserva.ioFechaReserva = Convert.ToDateTime(dr["fecha_reserva"].ToString());
                reserva.ioEsSobrecupo = Int32.Parse(dr["es_sobrecupo"].ToString());
                if (fullData)
                {
                    reserva.ioPaciente = new Paciente().buscarPorId(reserva.ioPacienteId, true);
                    reserva.ioEstadoReserva = new EstadoReserva().buscarPorId(reserva.ioEstadoReservaId);
                    reserva.ioAgenda = new Agenda().buscarPorId(reserva.ioAgendaId, true);
                    reserva.ioFicha = new Fichas().buscarPorReservaId(reserva.ioId);
                }
            }
            conexion.cerrarConexion();
            return reserva;
        }

        public Boolean actualizar(Reserva reserva)
        {
            bool guarda = false;
            Conexion conexion = new Conexion();
            String query = "update reservas set ";
            query += "estado_reserva_id = "+reserva.ioEstadoReservaId;
            query += " where id = " + reserva.ioId;

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guarda = true;
            }
            return guarda;
        }

        public Boolean guardar(Reserva reserva)
        {
            bool guardo = false;
            Conexion conexion = new Conexion();

            int id = conexion.getSequenceValor("SEQ_RESERVAS", 1);
            conexion.cerrarConexion();

            string query = "insert into reservas (id, agenda_id, paciente_id, estado_reserva_id, es_sobrecupo, fecha_reserva) values (";
            query += id + ",";
            query += reserva.ioAgendaId + ",";
            query += reserva.ioPacienteId + ",";
            query += reserva.ioEstadoReservaId + ",";
            query += reserva.ioEsSobrecupo + ",";
            query += " TO_TIMESTAMP('" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "','YYYY-MM-DD HH24:MI:SS'))";

            int filasIngresadas = conexion.ingresar(query);
            conexion.cerrarConexion();
            if (filasIngresadas > 0)
            {
                guardo = true;
            }
            return guardo;
        }
    }
}
