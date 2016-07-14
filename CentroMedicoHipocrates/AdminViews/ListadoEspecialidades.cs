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
    public partial class ListadoEspecialidades : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoEspecialidades()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarGrid();
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

        private bool validarFormulario()
        {
            this.limpiarErrores();
            if (txtNombre.Text.Equals(""))
            {
                validaciones.marcarError(txtNombre);
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.ioLaboratorio = "0";
            bool guardo = false;

            if (this.validarFormulario())
            {
                especialidad.ioNombre = txtNombre.Text;
                if (txtId.Text.Equals("0"))
                {
                    guardo = especialidad.guardar(especialidad);
                }
                else
                {
                    especialidad.ioId = Int32.Parse(txtId.Text);
                    guardo = especialidad.actualizar(especialidad);
                }
            }

            if (guardo)
            {
                this.dibujarGrid();
                this.limpiarFormulario();
            }
        }

        public void dibujarGrid()
        {
            GridEspecialidades.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Especialidad> especialidades = new Especialidad().buscarTodos();
            GridEspecialidades.Rows.Clear();
            foreach (var especialidad in especialidades)
            {
                int indice = GridEspecialidades.Rows.Add();
                DataGridViewRow fila = GridEspecialidades.Rows[indice];
                fila.Cells[0].Value = especialidad.ioId;
                fila.Cells[1].Value = especialidad.ioNombre;
            }
            GridEspecialidades.Refresh();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridEspecialidades.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridEspecialidades.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                btnCancelar.Visible = true;
            }
        }

        private void limpiarErrores()
        {
            validaciones.marcarError(txtId, Color.White);
            validaciones.marcarError(txtNombre, Color.White);
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            btnCancelar.Visible = false;
            this.limpiarErrores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
    }
}
