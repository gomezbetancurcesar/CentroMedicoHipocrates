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
    public partial class ListadoEnfermedades : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoEnfermedades()
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

        private void dibujarGrid()
        {
            GridEnfermedades.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List <Enfermedad> enfermedades = new Enfermedad().buscarTodos();
            GridEnfermedades.Rows.Clear();
            foreach (Enfermedad enfermedad in enfermedades)
            {
                int indice = GridEnfermedades.Rows.Add();
                DataGridViewRow fila = GridEnfermedades.Rows[indice];
                fila.Cells[0].Value = enfermedad.ioId;
                fila.Cells[1].Value = enfermedad.ioNombre;
            }
            GridEnfermedades.Refresh();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridEnfermedades.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridEnfermedades.SelectedRows[0];

                txtId.Text = row.Cells["Id"].Value.ToString();
                isEdit.Text = "1";
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtId.ReadOnly = true;
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
            txtId.Text = "";
            txtNombre.Text = "";
            isEdit.Text = "0";
            txtId.ReadOnly = false;
            btnCancelar.Visible = false;
            this.limpiarErrores();
        }

        private bool validarFormulario()
        {
            this.limpiarErrores();
            if (txtNombre.Text.Equals("")){
                validaciones.marcarError(txtNombre);
                return false;
            } 

            if(txtId.Text.Equals("")){
                validaciones.marcarError(txtId);
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Enfermedad enfermedad = new Enfermedad();
            bool guardo = false;

            if (this.validarFormulario())
            {
                enfermedad.ioNombre = txtNombre.Text;
                enfermedad.ioId = txtId.Text;

                if (isEdit.Text.Equals("0"))
                {
                    guardo = enfermedad.guardar(enfermedad);
                }else
                {
                    guardo = enfermedad.actualizar(enfermedad);
                }
            }
            if (guardo)
            {
                this.dibujarGrid();
                this.limpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
    }
}
