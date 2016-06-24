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
    public partial class ModificarMedico : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ModificarMedico(int id)
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarCombos();

            Doctor doctor = new Doctor().buscarPorId(id);
            txtId.Text = doctor.ioId.ToString();
            txtUsuarioId.Text = doctor.ioUsuario.ioId.ToString();

            txtRut.Text = doctor.ioUsuario.ioRut;
            txtNombre.Text = doctor.ioUsuario.ioNombre;
            txtApellidoPaterno.Text = doctor.ioUsuario.ioApellidoPaterno;
            txtApellidoMaterno.Text = doctor.ioUsuario.ioApellidoMaterno;
            txtDireccion.Text = doctor.ioUsuario.ioDireccion;
            txtPassword.Text = doctor.ioUsuario.ioPassword;
            dateFechaNac.Text = doctor.ioUsuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");

            comboComuna.Text = doctor.ioUsuario.ioComuna.ioNombre;
            comboEspecialidad.Text = doctor.ioEspecialidad.ioNombre;
            comboOficina.Text = doctor.ioOficina.ioNumero;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ListadoDoctores listadoView = new ListadoDoctores();
            listadoView.Show();
            this.Hide();
        }

        private void dibujarCombos()
        {
            List<Comuna> comunas = new Comuna().buscarTodos();
            comboComuna.Items.Clear();
            foreach (var comuna in comunas)
            {
                comboComuna.Items.Add(comuna.ioNombre);
            }
            comboComuna.Refresh();

            List<Especialidad> especialidades = new Especialidad().buscarTodos();
            comboEspecialidad.Items.Clear();
            foreach (var especialidad in especialidades)
            {
                comboEspecialidad.Items.Add(especialidad.ioNombre);
            }
            comboEspecialidad.Refresh();

            List<Oficina> oficinas = new Oficina().buscarTodos();
            comboOficina.Items.Clear();
            foreach (var oficina in oficinas)
            {
                comboOficina.Items.Add(oficina.ioNumero);
            }
            comboOficina.Refresh();
        }

        private Boolean validarDatosDoctor()
        {
            bool validado = false;
            if (!comboEspecialidad.SelectedIndex.Equals(-1) && !comboOficina.SelectedIndex.Equals(-1))
            {
                validado = true;
            }
            return validado;
        }

        private Boolean validarDatosPersona()
        {
            bool validado = false;
            if (!txtRut.Text.Equals("") && !txtNombre.Text.Equals("") && !txtApellidoPaterno.Text.Equals("") && !txtApellidoMaterno.Text.Equals(""))
            {
                if (!txtDireccion.Text.Equals("") && !comboComuna.SelectedIndex.Equals(-1))
                {
                    validado = true;
                }
            }
            return validado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validarDatosPersona() && this.validarDatosDoctor())
            {
                Doctor doctor = new Doctor();
                doctor.ioId = Int32.Parse(txtId.Text);
                doctor.ioEspecialidadId = new Especialidad().buscarPorNombre(comboEspecialidad.Text).ioId;
                doctor.ioOficinaId = new Oficina().buscarPorNumero(comboOficina.Text).ioId;

                doctor.ioUsuario.ioId = Int32.Parse(txtUsuarioId.Text);
                doctor.ioUsuario.ioComunaId = new Comuna().buscarPorNombre(comboComuna.Text).ioId;
                doctor.ioUsuario.ioNombre = txtNombre.Text;
                doctor.ioUsuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                doctor.ioUsuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                doctor.ioUsuario.ioRut = txtRut.Text;
                doctor.ioUsuario.ioDireccion = txtDireccion.Text;
                doctor.ioUsuario.ioPassword = txtPassword.Text;
                doctor.ioUsuario.ioFechaNacimento = dateFechaNac.Value.Date;
                if (doctor.actualizar(doctor))
                {
                    ListadoDoctores listadoView = new ListadoDoctores();
                    listadoView.Show();
                    this.Hide();
                }
            }
        }
    }
}
