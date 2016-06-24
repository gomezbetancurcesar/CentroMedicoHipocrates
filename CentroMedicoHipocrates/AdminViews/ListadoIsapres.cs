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
    public partial class ListadoIsapres : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoIsapres()
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
            lblTop.Width = ventana.Width;
            lblBottom.Width = ventana.Width;

            lblUsuario.Text = session.AuthField("usuario");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dibujarDataGrid()
        {
            GridIsapres.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Isapre> isapres = new Isapre().buscarTodos();
            GridIsapres.Rows.Clear();
            foreach (var isapre in isapres)
            {
                int indice = GridIsapres.Rows.Add();
                DataGridViewRow fila = GridIsapres.Rows[indice];
                fila.Cells[0].Value = isapre.ioId;
                fila.Cells[1].Value = isapre.ioNombre;
            }
            GridIsapres.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Isapre isapre = new Isapre();
            bool guardo = false;
            if (!txtNombre.Text.Equals(""))
            {
                isapre.ioNombre = txtNombre.Text;
                if (txtId.Text.Equals("0"))
                {
                    guardo = isapre.guardar(isapre);
                }else
                {
                    isapre.ioId = Int32.Parse(txtId.Text);
                    guardo = isapre.actualizar(isapre);
                }
            }
            
            if (guardo)
            {
                this.dibujarDataGrid();
                this.limpiarFormulario();
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridIsapres.SelectedRows[0];

            txtId.Text = row.Cells["Id"].Value.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();

            btnCancelar.Visible = true;
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
    }
}
