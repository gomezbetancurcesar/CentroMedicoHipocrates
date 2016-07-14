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
    public partial class Busquedas : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public Busquedas()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Paciente().buscarPorRut(txtRutPaciente.Text, false);

            if (!usuario.ioId.Equals(0))
            {
                Paciente paciente = new Paciente().buscarPorUsuarioId(usuario.ioId, true);
                if (!paciente.ioId.Equals(0))
                {
                    lblRut.Text = paciente.ioUsuario.ioRut;
                    lblNombre.Text = paciente.ioUsuario.ioNombre;
                    lblApellidoPaterno.Text = paciente.ioUsuario.ioApellidoPaterno;
                    lblApellidoMaterno.Text = paciente.ioUsuario.ioApellidoMaterno;
                    lblGenero.Text = paciente.ioUsuario.ioGenero.Equals("M") ? "Masculino" : "Femenino";
                    lblFechaNacimiento.Text = paciente.ioUsuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
                    lblSalud.Text = paciente.ioIsapre.ioNombre;
                    lblEmail.Text = paciente.ioUsuario.ioEmail;
                    lblTelefono.Text = paciente.ioUsuario.ioTelefono;
                    lblDireccion.Text = paciente.ioUsuario.ioDireccion;
                    lblRegion.Text = paciente.ioUsuario.ioComuna.ioProvincia.ioRegion.ioNombre;
                    lblProvincia.Text = paciente.ioUsuario.ioComuna.ioProvincia.ioNombre;
                    lblComuna.Text = paciente.ioUsuario.ioComuna.ioNombre;
                    panelDatosPaciente.Visible = true;

                    List<Reserva> reservas = new Reserva().buscarPorAgendaPaciente(dateFechaBuscada.Value.Date, paciente.ioId);
                    if (reservas.Count > 0)
                    {
                        foreach (Reserva reserva in reservas)
                        {
                            lblReservaId.Text = reserva.ioId.ToString();
                            lblRutMedico.Text = reserva.ioAgenda.ioDoctor.ioUsuario.ioRut;
                            string nombre = reserva.ioAgenda.ioDoctor.ioUsuario.ioNombre + " ";
                            nombre += reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoPaterno + " ";
                            nombre += reserva.ioAgenda.ioDoctor.ioUsuario.ioApellidoMaterno;
                            lblNombreMedico.Text = nombre;
                            lblGeneroMedico.Text = reserva.ioAgenda.ioDoctor.ioUsuario.ioGenero.Equals("M") ? "Masculino" : "Femenino";
                            lblEspecialidadMedico.Text = reserva.ioAgenda.ioDoctor.ioEspecialidad.ioNombre;
                            lblHorarioReserva.Text = reserva.ioAgenda.ioTurno.ioHoraInicio + " - " + reserva.ioAgenda.ioTurno.ioHoraFin;
                            lblOficina.Text = reserva.ioAgenda.ioDoctor.ioOficina.ioNumero;
                            if (!reserva.ioEstadoReservaId.Equals(3))
                            {
                                lblEstado.Visible = true;
                                lblEstado.Text = reserva.ioEstadoReserva.ioNombre;
                                btnMarcarAsistencia.Visible = false;
                            }else
                            {
                                btnMarcarAsistencia.Visible = true;
                                lblEstado.Visible = false;
                            }
                        }
                        panelDatosReserva.Visible = true;
                    }
                    else
                    {
                        panelDatosReserva.Visible = false;
                    }
                }
            }else
            {
                panelDatosPaciente.Visible = false;
            }
        }

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.ioId = Int32.Parse(lblReservaId.Text);

            //Se marca reserva como asistida
            reserva.ioEstadoReservaId = 4;

            reserva.actualizar(reserva);
            panelDatosReserva.Visible = false;
            panelDatosPaciente.Visible = false;
        }
    }
}
