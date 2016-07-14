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
    public partial class MisDatosMedico : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public MisDatosMedico()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
            this.fullWidth();
            this.llenarCombos();

            int id = session.getUser().ioDoctor.ioId;
            Doctor doctor = new Doctor().buscarPorId(id);
            txtId.Text = doctor.ioId.ToString();
            txtUsuarioId.Text = doctor.ioUsuario.ioId.ToString();

            txtRut.Text = doctor.ioUsuario.ioRut;
            txtNombre.Text = doctor.ioUsuario.ioNombre;
            txtApellidoPaterno.Text = doctor.ioUsuario.ioApellidoPaterno;
            txtApellidoMaterno.Text = doctor.ioUsuario.ioApellidoMaterno;
            txtDireccion.Text = doctor.ioUsuario.ioDireccion;
            dateFechaNac.Text = doctor.ioUsuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
            comboGenero.Text = doctor.ioUsuario.ioGenero.Equals("M") ? "Masculino" : "Femenino";

            comboRegion.Text = doctor.ioUsuario.ioComuna.ioProvincia.ioRegion.ioNombre;
            this.dibujarProvincias(doctor.ioUsuario.ioComuna.ioProvincia.ioRegionId);
            comboProvincia.Text = doctor.ioUsuario.ioComuna.ioProvincia.ioNombre;

            this.dibujarComunas(doctor.ioUsuario.ioComuna.ioProvinciaId);
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

        private void limpiarErrores()
        {
            validaciones.marcarError(txtId, Color.White);
            validaciones.marcarError(txtRut, Color.White);
            validaciones.marcarError(txtNombre, Color.White);
            validaciones.marcarError(txtApellidoPaterno, Color.White);
            validaciones.marcarError(txtApellidoMaterno, Color.White);
            validaciones.marcarError(txtDireccion, Color.White);
            validaciones.marcarError(txtEmail, Color.White);
            validaciones.marcarError(txtTelefono, Color.White);
        }

        private Boolean validarDatosDoctor()
        {
            if (comboEspecialidad.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboOficina.SelectedIndex.Equals(-1))
            {
                return false;
            }
            return true;
        }

        private Boolean validarDatosPersona()
        {
            if (txtRut.Text.Equals(""))
            {
                validaciones.marcarError(txtRut);
                return false;
            }
            else
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
                return false;
            }

            if (txtDireccion.Text.Equals(""))
            {
                validaciones.marcarError(txtDireccion);
                return false;
            }

            if (txtTelefono.Text.Equals(""))
            {
                validaciones.marcarError(txtTelefono);
                return false;
            }

            if (txtEmail.Text.Equals(""))
            {
                validaciones.marcarError(txtEmail);
                return false;
            }
            else
            {
                if (!validaciones.validarEmail(txtEmail.Text))
                {
                    validaciones.marcarError(txtEmail);
                    return false;
                }
            }

            if (comboRegion.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboProvincia.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboComuna.SelectedIndex.Equals(-1))
            {
                return false;
            }

            if (comboGenero.SelectedIndex.Equals(-1))
            {
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.limpiarErrores();
            if (this.validarDatosPersona() && this.validarDatosDoctor())
            {
                Doctor doctor = new Doctor();
                doctor.ioId = Int32.Parse(txtId.Text);
                doctor.ioEspecialidadId = new Especialidad().buscarPorNombre(comboEspecialidad.Text).ioId;
                doctor.ioOficinaId = new Oficina().buscarPorNumero(comboOficina.Text).ioId;

                doctor.ioUsuario = new Usuario();
                doctor.ioUsuario.ioId = Int32.Parse(txtUsuarioId.Text);
                doctor.ioUsuario.ioComunaId = new Comuna().buscarPorNombre(comboComuna.Text).ioId;
                doctor.ioUsuario.ioNombre = txtNombre.Text;
                doctor.ioUsuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                doctor.ioUsuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                doctor.ioUsuario.ioRut = txtRut.Text;
                doctor.ioUsuario.ioDireccion = txtDireccion.Text;
                doctor.ioUsuario.ioFechaNacimento = dateFechaNac.Value.Date;
                doctor.ioUsuario.ioGenero = comboGenero.Text.Equals("Masculino") ? "M" : "F";
            
                if (doctor.actualizar(doctor))
                {
                    Usuario usuario = new Usuario().login("", "", doctor.ioUsuario.ioId);
                    usuario.ioDoctor = new Doctor().buscarPorPersonaId(doctor.ioUsuario.ioId);
                    new LoginService().setUser(usuario);

                    MisDatosMedico view = new MisDatosMedico();
                    view.Show();
                    this.Hide();
                }
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
    }
}
