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
    public partial class MisDatosRecepcion : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public MisDatosRecepcion()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarCombos();

            int id = session.getUser().ioId;
            Usuario usuario = new Usuario().buscarPorId(id);
            txtId.Text = usuario.ioId.ToString();
            txtRut.Text = usuario.ioRut;
            txtNombre.Text = usuario.ioNombre;
            txtApellidoPaterno.Text = usuario.ioApellidoPaterno;
            txtApellidoMaterno.Text = usuario.ioApellidoMaterno;
            txtDireccion.Text = usuario.ioDireccion;
            txtEmail.Text = usuario.ioEmail;
            txtTelefono.Text = usuario.ioTelefono;
            dateFechaNac.Text = usuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
            comboGenero.Text = (usuario.ioGenero.Equals("M") ? "Masculino" : "Femenino");

            comboRegion.Text = usuario.ioComuna.ioProvincia.ioRegion.ioNombre;
            this.dibujarProvincias(usuario.ioComuna.ioProvincia.ioRegionId);
            comboProvincia.Text = usuario.ioComuna.ioProvincia.ioNombre;

            this.dibujarComunas(usuario.ioComuna.ioProvinciaId);
            comboComuna.Text = usuario.ioComuna.ioNombre;
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

            this.dibujarComunas();
            this.dibujarProvincias();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
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

        private Boolean validarDatosPersona()
        {
            if (txtRut.Text.Equals("")) {
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

            if (txtNombre.Text.Equals("")) {
                validaciones.marcarError(txtNombre);
                return false;
            }

            if (txtApellidoPaterno.Text.Equals("")) {
                validaciones.marcarError(txtApellidoPaterno);
                return false;
            }

            if (txtApellidoMaterno.Text.Equals(""))
            {
                validaciones.marcarError(txtApellidoMaterno);
                return false;
            }

            if (txtDireccion.Text.Equals("")) {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validarDatosPersona())
            {
                Usuario usuario = new Usuario();
                usuario.ioId = Int32.Parse(txtId.Text);
                usuario.ioComunaId = new Comuna().buscarPorNombre(comboComuna.Text).ioId;
                usuario.ioNombre = txtNombre.Text;
                usuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                usuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                usuario.ioRut = txtRut.Text;
                usuario.ioDireccion = txtDireccion.Text;
                usuario.ioEmail = txtEmail.Text;
                usuario.ioTelefono = txtTelefono.Text;
                usuario.ioFechaNacimento = dateFechaNac.Value.Date;
                usuario.ioGenero = (comboGenero.Text.Equals("Masculino") ? "M" : "F");

                if (usuario.actualizar(usuario))
                {
                    session.setUser(usuario);
                    MisDatosRecepcion view = new MisDatosRecepcion();
                    this.Hide();
                    view.Show();
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
