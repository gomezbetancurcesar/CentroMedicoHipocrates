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
    public partial class ListadoAdministradores : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoAdministradores()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarCombos();
            this.dibujarDataGrid();
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

        private void dibujarDataGrid()
        {
            GridAdministradores.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Usuario> usuarios = new Usuario().buscarPorRol("Administrador");
            GridAdministradores.Rows.Clear();
            foreach (var administrador in usuarios)
            {
                int index = GridAdministradores.Rows.Add();
                DataGridViewRow fila = GridAdministradores.Rows[index];
                fila.Cells[0].Value = administrador.ioId;
                fila.Cells[1].Value = administrador.ioRut;
                fila.Cells[2].Value = administrador.ioNombre;
                fila.Cells[3].Value = administrador.ioApellidoPaterno;
                fila.Cells[4].Value = administrador.ioApellidoMaterno;
                fila.Cells[5].Value = administrador.ioFechaNacimento.Date.ToString("dd/MM/yyyy");
            }
            GridAdministradores.Refresh();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridAdministradores.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridAdministradores.SelectedRows[0];
                this.limpiarFormulario();
                txtId.Text = row.Cells["Id"].Value.ToString();
                Usuario usuario = new Usuario().buscarPorId(Int32.Parse(txtId.Text));
                txtId.Text = usuario.ioId.ToString();
                txtRut.Text = usuario.ioRut;
                txtNombre.Text = usuario.ioNombre;
                txtApellidoPaterno.Text = usuario.ioApellidoPaterno;
                txtApellidoMaterno.Text = usuario.ioApellidoMaterno;
                txtEmail.Text = usuario.ioEmail;
                txtDireccion.Text = usuario.ioDireccion;
                txtTelefono.Text = usuario.ioTelefono;
                txtPassword.Text = usuario.ioPassword;
                comboGenero.Text = (usuario.ioGenero.Equals("M") ? "Masculino" : "Femenino");
                dateFechaNac.Text = usuario.ioFechaNacimento.Date.ToString("dd/MM/yyyy");

                comboRegion.Text = usuario.ioComuna.ioProvincia.ioRegion.ioNombre;
                this.dibujarProvincias(usuario.ioComuna.ioProvincia.ioRegionId);
                comboProvincia.Text = usuario.ioComuna.ioProvincia.ioNombre;

                this.dibujarComunas(usuario.ioComuna.ioProvinciaId);
                comboComuna.Text = usuario.ioComuna.ioNombre;

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
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtPassword.Text = "";
            dateFechaNac.Text = "";
            comboComuna.Text = "";
            comboComuna.SelectedIndex = -1;
            comboProvincia.Text = "";
            comboProvincia.SelectedIndex = -1;
            comboRegion.Text = "";
            comboRegion.SelectedIndex = -1;
            comboGenero.Text = "";
            comboGenero.SelectedIndex = -1;
            btnCancelar.Visible = false;
            this.limpiarErrores();
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
        }

        private Boolean validarDatosPersona()
        {
            this.limpiarErrores();
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

            if (txtDireccion.Text.Equals(""))
            {
                validaciones.marcarError(txtDireccion);
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

            if (txtTelefono.Text.Equals(""))
            {
                validaciones.marcarError(txtTelefono);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validarDatosPersona())
            {
                Usuario usuario = new Usuario();
                usuario.ioComunaId = new Comuna().buscarPorNombre(comboComuna.Text).ioId;
                usuario.ioNombre = txtNombre.Text;
                usuario.ioApellidoPaterno = txtApellidoPaterno.Text;
                usuario.ioApellidoMaterno = txtApellidoMaterno.Text;
                usuario.ioRut = txtRut.Text;
                usuario.ioDireccion = txtDireccion.Text;
                usuario.ioPassword = txtPassword.Text;
                usuario.ioFechaNacimento = dateFechaNac.Value.Date;
                usuario.ioEmail = txtEmail.Text;
                usuario.ioTelefono = txtTelefono.Text;
                usuario.ioGenero = (comboGenero.Text.Equals("Masculino") ? "M" : "F");

                bool guardo = false;
                if (txtId.Text.Equals("0"))
                {
                    //Rol de Administrador
                    usuario.ioUsuarioRoles = new UsuarioRoles();
                    usuario.ioUsuarioRoles.ioRolId = 4;
                    int usuarioGuardado = usuario.guardar(usuario);
                    if(usuarioGuardado > 0)
                    {
                        guardo = true;
                    }
                }
                else
                {
                    usuario.ioId = Int32.Parse(txtId.Text);
                    guardo = usuario.actualizar(usuario);
                }
                
                if (guardo)
                {
                    this.dibujarDataGrid();
                    this.limpiarFormulario();
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
