using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CentroMedicoHipocrates
{
    public partial class AgendaDiaria : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public AgendaDiaria()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarGrid();
        }

        private void fullWidth()
        {
            Form form = this;
            Screen pantalla = Screen.FromControl(form);
            Rectangle ventana = pantalla.WorkingArea;
            panel1.Width = ventana.Width;
            panel1.Location = new Point(0, 24);
            lblBottom.Width = ventana.Width;

            lblUsuario.Text = session.AuthField("usuario");
        }

        private void limpiarFormularios()
        {
            panelDatosPaciente.Visible = false;
            panelFicha.Visible = false;
            txtFichaId.Text = "0";
            txtReservaId.Text = "0";
            txtTratamientos.Text = "";
            txtObservaciones.Text = "";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void dibujarGrid()
        {
            List<Agenda> agendas = new Agenda().buscarTodas(session.getUser().ioDoctor.ioId, DateTime.Now, true, false, true);
            GridHorarios.Rows.Clear();
            GridHorarios.CellClick += new DataGridViewCellEventHandler(this.HorariosCellClick);
            foreach (var agenda in agendas)
            {
                //fila = (DataGridViewRow)GridHorarios.Rows[0].Clone();
                foreach(Reserva reserva in agenda.ioReservas)
                {
                    int index = GridHorarios.Rows.Add();
                    DataGridViewRow fila = GridHorarios.Rows[index];
                    //Reserva reserva = agenda.ioReservas.Last();

                    fila.Cells[0].Value = agenda.ioId;
                    fila.Cells[1].Value = reserva.ioId;
                    fila.Cells[2].Value = agenda.ioTurno.ioHoraInicio;
                    fila.Cells[3].Value = agenda.ioTurno.ioHoraFin;
                    string nombre = reserva.ioPaciente.ioUsuario.ioNombre + " ";
                    nombre += reserva.ioPaciente.ioUsuario.ioApellidoPaterno;
                    fila.Cells[4].Value = nombre;
                    fila.Cells[5].Value = reserva.ioEsSobrecupo.Equals(0) ? "Normal" : "Sobrecupo";
                    fila.Cells[6].Value = reserva.ioEstadoReserva.ioNombre;
                }
            }
            //Redibujamos la tabla de los medicos
            GridHorarios.Refresh();
        }

        private void HorariosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.limpiarFormularios();
            if (GridHorarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridHorarios.SelectedRows[0];
                int idReserva = Int32.Parse(row.Cells["IdReserva"].Value.ToString());

                Reserva reserva = new Reserva().buscarPorId(idReserva, true);
                txtReservaId.Text = idReserva.ToString();

                Console.WriteLine(reserva.ioFicha.ioId);

                txtRut.Text = reserva.ioPaciente.ioUsuario.ioRut;
                txtNombre.Text = reserva.ioPaciente.ioUsuario.ioNombre;
                txtIsapre.Text = reserva.ioPaciente.ioIsapre.ioNombre;
                txtGenero.Text = reserva.ioPaciente.ioUsuario.ioGenero.Equals("M") ? "Masculino" : "Femenino";
                txtFechaNacimiento.Text = reserva.ioPaciente.ioUsuario.ioFechaNacimento.ToString("dd/MM/yyyy");

                if (!reserva.ioFicha.ioId.Equals(0))
                {
                    txtFichaId.Text = reserva.ioFicha.ioId.ToString();
                    txtTratamientos.Text = reserva.ioFicha.ioTratamientos;
                    txtObservaciones.Text = reserva.ioFicha.ioObservacion;
                }
                panelDatosPaciente.Visible = true;
                panelFicha.Visible = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            Fichas ficha = new Fichas();

            reserva.ioId = ficha.ioReservaId = Int32.Parse(txtReservaId.Text);
            //Estado Atendido en la reserva
            reserva.ioEstadoReservaId = 5;

            ficha.ioTratamientos = txtTratamientos.Text;
            ficha.ioObservacion = txtObservaciones.Text;

            bool guarda = false;
            if (txtFichaId.Text.Equals("0"))
            {
                guarda = ficha.guardar(ficha);
                if (guarda) { reserva.actualizar(reserva); }
            }else
            {
                ficha.ioId = Int32.Parse(txtFichaId.Text);
                guarda = ficha.actualizar(ficha);
            }

            if (guarda)
            {
                this.limpiarFormularios();
                this.dibujarGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormularios();
        }
    }
}
