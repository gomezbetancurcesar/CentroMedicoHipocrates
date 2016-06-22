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
    public partial class ListadoMedicos : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoMedicos()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
            this.fullWidth();
            List<Doctor> doctores = new Doctor().buscarTodos();

            foreach (var doctor in doctores)
            {
                DataGridViewRow fila = (DataGridViewRow)GridMedicos.Rows[0].Clone();
                fila.Cells[0].Value = doctor.ioUsuario.ioRut;
                fila.Cells[1].Value = doctor.ioUsuario.ioNombre;
                fila.Cells[2].Value = doctor.ioUsuario.ioApellidoPaterno;
                fila.Cells[3].Value = doctor.ioUsuario.ioApellidoMaterno;
                fila.Cells[4].Value = doctor.ioEspecialidad.ioNombre;
                fila.Cells[5].Value = doctor.ioUsuario.ioFechaNacimento.ToString();
                GridMedicos.Rows.Add(fila);
            }
            //Redibujamos la tabla de los medicos
            GridMedicos.Refresh();
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

        private void GridMedicos_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            MessageBox.Show("lo seleccione!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMedico vistaAgregar = new AgregarMedico();
            vistaAgregar.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarMedico vistaModificar = new ModificarMedico();
            vistaModificar.Show();
            this.Hide();
        }
    }
}