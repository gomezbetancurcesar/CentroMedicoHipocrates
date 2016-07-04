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
            lblTop.Width = ventana.Width;
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
        }

        private void llenarCombos()
        {
            List<EstadoReserva> estados = new EstadoReserva().buscarTodos();
            comboEstados.Items.Clear();
            foreach (EstadoReserva estado in estados)
            {
                comboEstados.Items.Add(estado.ioNombre);
            }
            comboEstados.Refresh();
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
            DataGridViewRow row = gridReservas.SelectedRows[0];
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            Reserva reserva = new Reserva().buscarPorId(id, true);

            this.llenarCombos();
            lblIdReserva.Text = reserva.ioId.ToString();
            String nombreCompleto = reserva.ioPaciente.ioUsuario.ioNombre+" ";
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
                    this.mostrarPaneles(false);
                    this.llenarGrilla();
                }
            }
        }
    }
}
