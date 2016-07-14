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
    public partial class Confirmaciones : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public Confirmaciones()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mostrarPaneles(Boolean visibilidad)
        {
            panelDoctor.Visible = visibilidad;
            panelPaciente.Visible = visibilidad;
            panelReserva.Visible = visibilidad;
            panelCambioEstado.Visible = visibilidad;
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
        }

        private void llenarCombos(Boolean especial = false)
        {
            List<EstadoReserva> estados = new EstadoReserva().buscarTodos();
            comboEstados.Items.Clear();
            foreach (EstadoReserva estado in estados)
            {
                if (especial)
                {
                    if (estado.ioNombre.Equals("Reservada") || estado.ioNombre.Equals("Anulada") || estado.ioNombre.Equals("Confirmada"))
                    {
                        comboEstados.Items.Add(estado.ioNombre);
                    }
                }
                else
                {
                    comboEstados.Items.Add(estado.ioNombre);
                }
            }
            comboEstados.Refresh();
            comboEstados.Enabled = true;
        }

        private void llenarGrilla()
        {
            String rutDoctor = txtRutDoctor.Text;
            DateTime fecha = dateFechaBuscada.Value.Date;

            gridReservas.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Reserva> reservas = new Reserva().datosParaConfirmar(fecha, rutDoctor);
            gridReservas.Rows.Clear();
            foreach (Reserva reserva in reservas)
            {
                int index = gridReservas.Rows.Add();
                DataGridViewRow fila = gridReservas.Rows[index];
                fila.Cells[0].Value = reserva.ioId;
                fila.Cells[1].Value = reserva.ioPacienteId;

                String nombreCompleto = reserva.ioAgenda.ioDoctor.ioUsuario.ioNombre + " ";
                nombreCompleto += reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoPaterno + " ";
                nombreCompleto += reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoMaterno;
                fila.Cells[2].Value = nombreCompleto;
                fila.Cells[3].Value = reserva.ioAgenda.ioDoctor.ioEspecialidad.ioNombre;

                fila.Cells[4].Value = reserva.ioAgenda.ioTurno.ioHoraInicio + " - " + reserva.ioAgenda.ioTurno.ioHoraFin;

                nombreCompleto = reserva.ioPaciente.ioUsuario.ioNombre + " ";
                nombreCompleto += reserva.ioPaciente.ioUsuario.ioApellidoPaterno + " ";
                nombreCompleto += reserva.ioPaciente.ioUsuario.ioApellidoMaterno;
                fila.Cells[5].Value = nombreCompleto;
                fila.Cells[6].Value = reserva.ioEstadoReserva.ioNombre;
            }
            gridReservas.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.llenarGrilla();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridReservas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridReservas.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string estadoReservaSeleccionada = row.Cells["Estado"].Value.ToString();

                Reserva reserva = new Reserva().buscarPorId(id, true);

                bool especial = false;
                if (estadoReservaSeleccionada.Equals("Reservada"))
                {
                    especial = true;
                }

                this.llenarCombos(especial);
                lblIdReserva.Text = reserva.ioId.ToString();
                String nombreCompleto = reserva.ioPaciente.ioUsuario.ioNombre + " ";
                nombreCompleto += reserva.ioPaciente.ioUsuario.ioApellidoPaterno;
                lblPacNombre.Text = nombreCompleto;
                lblPacRut.Text = reserva.ioPaciente.ioUsuario.ioRut;
                lblPacEmail.Text = reserva.ioPaciente.ioUsuario.ioEmail;
                lblPacTelefono.Text = reserva.ioPaciente.ioUsuario.ioTelefono;
                lblIsapre.Text = reserva.ioPaciente.ioIsapre.ioNombre;

                nombreCompleto = reserva.ioAgenda.ioDoctor.ioUsuario.ioNombre + " ";
                nombreCompleto += reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoPaterno;
                lblDocNombre.Text = nombreCompleto;
                lblDocRut.Text = reserva.ioAgenda.ioDoctor.ioUsuario.ioRut;
                lblEspecialidad.Text = reserva.ioAgenda.ioDoctor.ioEspecialidad.ioNombre;
                lblOficina.Text = reserva.ioAgenda.ioDoctor.ioOficina.ioNumero;

                lblResHoraInicio.Text = reserva.ioAgenda.ioTurno.ioHoraInicio;
                lblResHoraFin.Text = reserva.ioAgenda.ioTurno.ioHoraFin;
                lblResFecha.Text = reserva.ioAgenda.ioDia.Date.ToString("dd/MM/yyyy");
                lblResFechaCreacion.Text = reserva.ioFechaReserva.ToString("dd/MM/yyyy hh:mm");
                this.mostrarPaneles(true);

                comboEstados.Text = reserva.ioEstadoReserva.ioNombre;
                //Si está anulada, se bloquea el combo
                if (!reserva.ioEstadoReserva.ioId.Equals(1))
                {
                    comboEstados.Enabled = false;
                    btnCancelar.Visible = false;
                    btnGuardar.Visible = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.mostrarPaneles(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!comboEstados.SelectedIndex.Equals(-1))
            {
                Reserva reserva = new Reserva();
                reserva.ioId = Int32.Parse(lblIdReserva.Text);
                reserva.ioEstadoReservaId = new EstadoReserva().buscarPorNombre(comboEstados.Text).ioId;
                if (reserva.actualizar(reserva))
                {
                    //Si se está anulando reserva
                    if (reserva.ioEstadoReservaId.Equals(2))
                    {
                        Agenda agenda = new Agenda();
                        agenda.ioId = new Reserva().buscarPorId(reserva.ioId).ioAgendaId;
                        //Se marca la agenda como disponible
                        agenda.ioEstadoAgendaId = 1;
                        agenda.actualizar(agenda);
                    }
                    this.mostrarPaneles(false);
                    this.llenarGrilla();
                }
            }
        }
    }
}
