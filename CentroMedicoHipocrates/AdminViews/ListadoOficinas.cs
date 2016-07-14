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
    public partial class ListadoOficinas : Form
    {
        private Validaciones validaciones = new Validaciones();
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoOficinas()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
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
            GridOficinas.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);

            List<Oficina> oficinas = new Oficina().buscarTodos();
            GridOficinas.Rows.Clear();
            foreach (var oficina in oficinas)
            {
                int indice = GridOficinas.Rows.Add();
                DataGridViewRow fila = GridOficinas.Rows[indice];
                fila.Cells[0].Value = oficina.ioId;
                fila.Cells[1].Value = oficina.ioPiso;
                fila.Cells[2].Value = oficina.ioNumero;
            }
            GridOficinas.Refresh();
        }

        private void limpiarErrores()
        {
            validaciones.marcarError(txtId, Color.White);
            validaciones.marcarError(txtPiso, Color.White);
            validaciones.marcarError(txtNumero, Color.White);
        }

        private bool validarFormulario()
        {
            this.limpiarErrores();
            if (txtPiso.Text.Equals("")) {
                validaciones.marcarError(txtPiso);
                return false;
            }
            if (txtNumero.Text.Equals("")) {
                validaciones.marcarError(txtNumero);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Oficina oficina = new Oficina();
            bool guarda = false;

            if(this.validarFormulario())
            {
                oficina.ioPiso = Int32.Parse(txtPiso.Text);
                oficina.ioNumero = txtNumero.Text;

                if (txtId.Text.Equals("0"))
                {
                    guarda = oficina.guardar(oficina);
                }
                else
                {
                    oficina.ioId = Int32.Parse(txtId.Text);
                    guarda = oficina.actualizar(oficina);
                }
            }
            if (guarda)
            {
                this.dibujarDataGrid();
                this.limpiarFormulario();
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridOficinas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridOficinas.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtPiso.Text = row.Cells["Piso"].Value.ToString();
                txtNumero.Text = row.Cells["Numero"].Value.ToString();
                btnCancelar.Visible = true;
            }
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtPiso.Text = "";
            txtNumero.Text = "";
            btnCancelar.Visible = false;
            this.limpiarErrores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
    }
}
