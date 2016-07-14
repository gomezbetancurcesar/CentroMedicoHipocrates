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
    public partial class Reservar : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public Reservar()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
            this.fullWidth();
            this.llenarCombos();
            dateFechaBuscada.MinDate = DateTime.Today;
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

        private void dibujarProvincias(int regionId = -1)
        {
            //Provincias
            List<Provincia> provincias = new Provincia().buscarTodos(regionId);
            comboProvincia.Items.Clear();
            foreach (Provincia provincia in provincias)
            {
                comboProvincia.Items.Add(provincia.ioNombre);
            }
            comboProvincia.Refresh();
        }

        private void dibujarComunas(int provinciaId = -1)
        {
            //Comunas
            List<Comuna> comunas = new Comuna().buscarTodos(provinciaId);
            comboComuna.Items.Clear();
            foreach (Comuna comuna in comunas)
            {
                comboComuna.Items.Add(comuna.ioNombre);
            }
            comboComuna.Refresh();
        }

        private void llenarCombos()
        {
            //Regiones
            List<CapaDatos.Region> regiones = new CapaDatos.Region().buscarTodos();
            comboRegion.Items.Clear();
            foreach (CapaDatos.Region region in regiones)
            {
                comboRegion.Items.Add(region.ioNombre);
            }
            comboRegion.Refresh();

            this.dibujarComunas();
            this.dibujarProvincias();

            //Isapres
            List<Isapre> isapres = new Isapre().buscarTodos();
            comboIsapre.Items.Clear();
            foreach (Isapre isapre in isapres)
            {
                comboIsapre.Items.Add(isapre.ioNombre);
            }
            comboIsapre.Refresh();

            //Especialidades
            List<Especialidad> especialidades = new Especialidad().buscarTodos();
            comboEspecialidad.Items.Clear();
            foreach (Especialidad especialidad in especialidades)
            {
                comboEspecialidad.Items.Add(especialidad.ioNombre);
            }
            comboEspecialidad.Refresh();
        }

        private void limpiarFormulario(Boolean soloFormPaciente = false)
        {
            this.limpiarErrores();
            if (!soloFormPaciente)
            {
                lblUsuarioId.Text = "0";
                txtRut.Text = "";
                txtNombre.Text = "";
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                dateFechaNac.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                comboComuna.Text = "";
                comboProvincia.Text = "";
                comboRegion.Text = "";
                comboGenero.Text = "";
                comboIsapre.Text = "";
                comboGenero.SelectedIndex = -1;
                comboComuna.SelectedIndex = -1;
                comboProvincia.SelectedIndex = -1;
                comboRegion.SelectedIndex = -1;
                comboIsapre.SelectedIndex = -1;
            }
            lblPacienteId.Text = "0";
            comboIsapre.Text = "";

            panelDoctores.Visible = false;
            panelHorarios.Visible = false;
        }

        private void limpiarErrores()
        {
            validaciones.marcarError(txtRut, Color.White);
            validaciones.marcarError(txtNombre, Color.White);
            validaciones.marcarError(txtApellidoPaterno, Color.White);
            validaciones.marcarError(txtApellidoMaterno, Color.White);
            validaciones.marcarError(txtDireccion, Color.White);
            validaciones.marcarError(txtEmail, Color.White);
            validaciones.marcarError(txtTelefono, Color.White);
        }

        private Boolean validarPersona()
        {
            if (txtRut.Text.Equals(""))
            {
                validaciones.marcarError(txtRut);
                return false;
            }else
            {
                if (!validaciones.validaRut(txtRut.Text))
                {
                    validaciones.marcarError(txtRut);
                    return false;
                }
            }

            if (txtNombre.Text.Equals(""))
            {
                validaciones.marcarError(txtNombre);
                return false;
            }

            if (txtApellidoPaterno.Text.Equals(""))
            {
                validaciones.marcarError(txtApellidoPaterno);
                return false;
            }

            if (txtApellidoMaterno.Text.Equals(""))
            {
                validaciones.marcarError(txtApellidoMaterno);
                return false;
            }

            if (txtEmail.Text.Equals(""))
            {
                validaciones.marcarError(txtEmail);
                return false;
            }else
            {
                if (validaciones.validarEmail(txtEmail.Text))
                {
                    validaciones.marcarError(txtEmail);
                    return false;
                }
            }

            if (txtTelefono.Text.Equals(""))
            {
                validaciones.marcarError(txtTelefono);
                return false;
            }

            if (txtDireccion.Text.Equals(""))
            {
                validaciones.marcarError(txtDireccion);
                return false;
            }

            if (comboComuna.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboProvincia.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboRegion.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboGenero.SelectedIndex.Equals(-1))
            {
                return false;
            }
            return true;
        }

        private Boolean validarPaciente()
        {
            if (comboIsapre.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void buscarAgendaMedico(int doctorId)
        {
            lblIdDoctor.Text = doctorId.ToString();
            DateTime fecha = dateFechaBuscada.Value.Date;
            List<Agenda> agendas = new Agenda().buscarTodas(doctorId, fecha, true, true);

            //GridHorarios.CellClick += new DataGridViewCellEventHandler(this.MedicosCellClick);
            GridHorarios.Rows.Clear();
            foreach(Agenda agenda in agendas)
            {
                int indice = GridHorarios.Rows.Add();
                DataGridViewRow fila = GridHorarios.Rows[indice];
                fila.Cells[0].Value = agenda.ioId;
                fila.Cells[1].Value = agenda.ioTurno.ioHoraInicio + " - " + agenda.ioTurno.ioHoraFin;

                if (agenda.ioEstadoAgendaId.Equals(1))
                {
                    //Agenda disponible
                    DataGridViewButtonCell btnFila;
                    btnFila = (DataGridViewButtonCell)fila.Cells[2];
                    btnFila.FlatStyle = FlatStyle.Flat;
                    btnFila.Value = "Disponible";
                    btnFila.Style.BackColor = Color.FromArgb(45, 180, 35);
                }
                else
                {
                    DataGridViewButtonCell btnFila;
                    btnFila = (DataGridViewButtonCell)fila.Cells[2];
                    btnFila.FlatStyle = FlatStyle.Flat;
                    btnFila.Value = "Agendada";
                    btnFila.Style.BackColor = Color.FromArgb(138, 138, 138);
                }
            }
            GridHorarios.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String rut = txtRutBuscado.Text;
            Usuario usuario = new Paciente().buscarPorRut(rut);
            this.limpiarFormulario();

            if (!usuario.ioId.Equals(0))
            {
                lblUsuarioId.Text = usuario.ioId.ToString();
                txtRut.Text = usuario.ioRut;
                txtNombre.Text = usuario.ioNombre;
                txtApellidoPaterno.Text = usuario.ioApellidoPaterno;
                txtApellidoMaterno.Text = usuario.ioApellidoMaterno;
                dateFechaNac.Value = usuario.ioFechaNacimento.Date;
                txtEmail.Text = usuario.ioEmail;
                txtTelefono.Text = usuario.ioTelefono;
                txtDireccion.Text = usuario.ioDireccion;
                comboGenero.Text = (usuario.ioGenero.Equals("M") ? "Masculino" : "Femenino");

                comboRegion.Text = usuario.ioComuna.ioProvincia.ioRegion.ioNombre;
                this.dibujarProvincias(usuario.ioComuna.ioProvincia.ioRegionId);
                comboProvincia.Text = usuario.ioComuna.ioProvincia.ioNombre;

                this.dibujarComunas(usuario.ioComuna.ioProvinciaId);
                comboComuna.Text = usuario.ioComuna.ioNombre;

                if (!usuario.ioPaciente.ioId.Equals(0))
                {
                    lblPacienteId.Text = usuario.ioPaciente.ioId.ToString();
                    comboIsapre.Text = usuario.ioPaciente.ioIsapre.ioNombre;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }

        private void btnVerAgenda_Click(object sender, EventArgs e)
        {
            string rutMedico = txtRutDoctor.Text;
            string especialidad = comboEspecialidad.Text;

            if (!rutMedico.Equals(""))
            {
                Doctor doctor = new Doctor().buscarPorRut(rutMedico);
                if (!doctor.ioId.Equals(0))
                {
                    panelHorarios.Location = new Point(345, 225);
                    panelHorarios.Visible = true;
                    this.buscarAgendaMedico(doctor.ioId);
                }
            }
            else
            {
                panelDoctores.Visible = true;
                panelHorarios.Visible = false;
                GridMedicos.CellClick += new DataGridViewCellEventHandler(this.MedicosCellClick);
                List<Doctor> doctores = new Doctor().buscarPorEspecialidad(especialidad, true);
                GridMedicos.Rows.Clear();
                foreach (Doctor doctor in doctores)
                {
                    int indice = GridMedicos.Rows.Add();
                    DataGridViewRow fila = GridMedicos.Rows[indice];
                    string nombre = doctor.ioUsuario.ioNombre + " ";
                    nombre += doctor.ioUsuario.ioApellidoPaterno + " ";
                    nombre += doctor.ioUsuario.ioApellidoMaterno + " ";

                    fila.Cells[0].Value = doctor.ioId;
                    fila.Cells[1].Value = nombre;
                    fila.Cells[2].Value = doctor.ioUsuario.ioRut;
                }
                GridMedicos.Refresh();
            }
        }

        private void MedicosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridMedicos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridMedicos.SelectedRows[0];
                int idDoctor = Int32.Parse(row.Cells["IdMedico"].Value.ToString());
                panelHorarios.Visible = true;
                panelHorarios.Location = new Point(685, 250);
                this.buscarAgendaMedico(idDoctor);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if(this.validarPaciente() && this.validarPersona())
            {
                Reserva reserva = new Reserva();
                int IdDoctor = Int32.Parse(lblIdDoctor.Text);
                if (!IdDoctor.Equals(0))
                {
                    if (!GridHorarios.SelectedRows.Count.Equals(0))
                    {
                        Paciente paciente = new Paciente();
                        Isapre isapre = new Isapre().buscarPorNombre(comboIsapre.Text);
                        Comuna comuna = new Comuna().buscarPorNombre(comboComuna.Text);

                        paciente.ioIsapreId = isapre.ioId;
                        paciente.ioUsuario = new Usuario();
                        paciente.ioUsuario.ioId = Int32.Parse(lblUsuarioId.Text);
                        paciente.ioUsuario.ioRut = txtRut.Text;
                        paciente.ioUsuario.ioNombre = txtNombre.Text;
                        paciente.ioUsuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                        paciente.ioUsuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                        paciente.ioUsuario.ioFechaNacimento = dateFechaNac.Value.Date;
                        paciente.ioUsuario.ioEmail = txtEmail.Text;
                        paciente.ioUsuario.ioTelefono = txtTelefono.Text;
                        paciente.ioUsuario.ioDireccion = txtDireccion.Text;
                        paciente.ioUsuario.ioComunaId = comuna.ioId;
                        paciente.ioUsuario.ioGenero = (comboGenero.Text.Equals("Masculino") ? "M" : "F");

                        int pacienteId = 0;
                        if (lblPacienteId.Text.Equals("0"))
                        {
                            pacienteId = paciente.guardar(paciente);
                        }else
                        {
                            paciente.ioId = pacienteId = Int32.Parse(lblPacienteId.Text);
                            paciente.actualizar(paciente);
                        }

                        if(pacienteId > 0)
                        {
                            DataGridViewRow row = GridHorarios.SelectedRows[0];
                            reserva.ioAgendaId = Int32.Parse(row.Cells["IdAgenda"].Value.ToString());
                            //Estado reservado -> 1
                            reserva.ioEstadoReservaId = 1;
                            //No es sobrecupo
                            reserva.ioEsSobrecupo = 0;
                            reserva.ioPacienteId = pacienteId;

                            if (reserva.guardar(reserva))
                            {
                                Agenda agenda = new Agenda();
                                agenda.ioId = reserva.ioAgendaId;
                                //Estado agendada
                                agenda.ioEstadoAgendaId = 3;
                                agenda.actualizar(agenda);
                                this.limpiarFormulario();
                            }
                        }else
                        {
                            MessageBox.Show("Ha ocurrido un error al guardar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar horario");
                    }
                }else
                {
                    MessageBox.Show("Debe asignar Doctor");
                }
            }else
            {
                MessageBox.Show("Verifique los datos del paciente");
            }
        }

        private void comboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = new CapaDatos.Region().buscarPorNombre(comboRegion.Text).ioId;
            this.dibujarProvincias(id);
        }

        private void comboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = new Provincia().buscarPorNombre(comboProvincia.Text).ioId;
            this.dibujarComunas(id);
        }

        private void panelHorarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
