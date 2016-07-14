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
    public partial class ListadoDoctores : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoDoctores()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
            MenuContexto.ForeColor = Color.White;
            this.fullWidth();
            this.dibujarGrid();
            this.dibujarCombos();
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

        private void dibujarGrid()
        {
            GridMedicos.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            GridMedicos.Rows.Clear();
            List<Doctor> doctores = new Doctor().buscarTodos();
            foreach (Doctor doctor in doctores)
            {
                int indice = GridMedicos.Rows.Add();
                DataGridViewRow fila = GridMedicos.Rows[indice];
                fila.Cells[0].Value = doctor.ioId;
                fila.Cells[1].Value = doctor.ioUsuario.ioRut;
                fila.Cells[2].Value = doctor.ioUsuario.ioNombre;
                fila.Cells[3].Value = doctor.ioUsuario.ioApellidoPaterno;
                fila.Cells[4].Value = doctor.ioUsuario.ioApellidoMaterno;
                fila.Cells[5].Value = doctor.ioEspecialidad.ioNombre;
                fila.Cells[6].Value = doctor.ioUsuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
            }
            //Redibujamos la tabla de los medicos
            GridMedicos.Refresh();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.limpiarFormulario();
            if (GridMedicos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridMedicos.SelectedRows[0];
                int id = Int32.Parse(row.Cells["Id"].Value.ToString());
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
                txtEmail.Text = doctor.ioUsuario.ioEmail;
                txtTelefono.Text = doctor.ioUsuario.ioTelefono;

                comboGenero.Text = (doctor.ioUsuario.ioGenero.Equals("M") ? "Masculino" : "Femenino");
                comboRegion.Text = doctor.ioUsuario.ioComuna.ioProvincia.ioRegion.ioNombre;
                this.dibujarProvincias(doctor.ioUsuario.ioComuna.ioProvincia.ioRegionId);
                comboProvincia.Text = doctor.ioUsuario.ioComuna.ioProvincia.ioNombre;

                this.dibujarComunas(doctor.ioUsuario.ioComuna.ioProvinciaId);
                comboComuna.Text = doctor.ioUsuario.ioComuna.ioNombre;

                comboEspecialidad.Text = doctor.ioEspecialidad.ioNombre;
                comboOficina.Text = doctor.ioOficina.ioNumero;
                btnCancelar.Visible = true;
            }
        }

        private void limpiarErrores()
        {
            validaciones.marcarError(txtId, Color.White);
            validaciones.marcarError(txtRut, Color.White);
            validaciones.marcarError(txtNombre, Color.White);
            validaciones.marcarError(txtApellidoPaterno, Color.White);
            validaciones.marcarError(txtApellidoMaterno, Color.White);
            validaciones.marcarError(txtEmail, Color.White);
            validaciones.marcarError(txtDireccion, Color.White);
            validaciones.marcarError(txtTelefono, Color.White);
            validaciones.marcarError(txtPassword, Color.White);
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtUsuarioId.Text = "0";

            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDireccion.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            dateFechaNac.Text = "";

            comboComuna.Text = "";
            comboComuna.SelectedIndex = -1;
            comboProvincia.Text = "";
            comboProvincia.SelectedIndex = -1;
            comboRegion.Text = "";
            comboRegion.SelectedIndex = -1;
            comboGenero.Text = "";
            comboGenero.SelectedIndex = -1;

            comboEspecialidad.Text = "";
            comboEspecialidad.SelectedIndex = -1;
            comboOficina.Text = "";
            comboOficina.SelectedIndex = -1;
            btnCancelar.Visible = false;
            this.limpiarErrores();
        }

        private Boolean validarDatosDoctor()
        {
            this.limpiarErrores();
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
            this.limpiarErrores();
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
                validaciones.marcarError(txtApellidoMaterno);
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

        private void dibujarCombos()
        {
            //Regiones
            List<CapaDatos.Region> regiones = new CapaDatos.Region().buscarTodos();
            comboRegion.Items.Clear();
            foreach (CapaDatos.Region region in regiones)
            {
                comboRegion.Items.Add(region.ioNombre);
            }
            comboRegion.Refresh();

            this.dibujarProvincias();
            this.dibujarComunas();

            //Especialidades
            List<Especialidad> especialidades = new Especialidad().buscarTodos();
            comboEspecialidad.Items.Clear();
            foreach (var especialidad in especialidades)
            {
                comboEspecialidad.Items.Add(especialidad.ioNombre);
            }
            comboEspecialidad.Refresh();

            //Oficinas
            List<Oficina> oficinas = new Oficina().buscarTodos();
            comboOficina.Items.Clear();
            foreach (var oficina in oficinas)
            {
                comboOficina.Items.Add(oficina.ioNumero);
            }
            comboOficina.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validarDatosPersona() && this.validarDatosDoctor())
            {
                Doctor doctor = new Doctor();                
                doctor.ioEspecialidadId = new Especialidad().buscarPorNombre(comboEspecialidad.Text).ioId;
                doctor.ioOficinaId = new Oficina().buscarPorNumero(comboOficina.Text).ioId;

                doctor.ioUsuario = new Usuario();
                doctor.ioUsuario.ioComunaId = new Comuna().buscarPorNombre(comboComuna.Text).ioId;
                doctor.ioUsuario.ioNombre = txtNombre.Text;
                doctor.ioUsuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                doctor.ioUsuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                doctor.ioUsuario.ioRut = txtRut.Text;
                doctor.ioUsuario.ioDireccion = txtDireccion.Text;
                doctor.ioUsuario.ioPassword = txtPassword.Text;
                doctor.ioUsuario.ioFechaNacimento = dateFechaNac.Value.Date;
                doctor.ioUsuario.ioEmail = txtEmail.Text;
                doctor.ioUsuario.ioTelefono = txtTelefono.Text;
                doctor.ioUsuario.ioGenero = (comboGenero.Text.Equals("Masculino") ? "M" : "F");

                bool guarda = false;
                if (txtId.Text.Equals("0"))
                {
                    //Rol de doctor
                    doctor.ioUsuario.ioUsuarioRoles = new UsuarioRoles();
                    doctor.ioUsuario.ioUsuarioRoles.ioRolId = 2;
                    guarda = doctor.guardar(doctor);
                }
                else
                {
                    doctor.ioId = Int32.Parse(txtId.Text);
                    doctor.ioUsuario.ioId = Int32.Parse(txtUsuarioId.Text);
                    guarda = doctor.actualizar(doctor);
                }

                if (guarda)
                {
                    this.dibujarGrid();
                    this.limpiarFormulario();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
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