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
            dateFechaNac.Text = usuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
            comboComuna.Text = usuario.ioComuna.ioNombre;
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

        private void dibujarCombos()
        {
            List<Comuna> comunas = new Comuna().buscarTodos();
            comboComuna.Items.Clear();
            foreach (var comuna in comunas)
            {
                comboComuna.Items.Add(comuna.ioNombre);
            }
            comboComuna.Refresh();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
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
                usuario.ioFechaNacimento = dateFechaNac.Value.Date;

                if (usuario.actualizar(usuario))
                {
                    MisDatosRecepcion view = new MisDatosRecepcion();
                    this.Hide();
                    view.Show();
                }
            }
        }
    }
}
