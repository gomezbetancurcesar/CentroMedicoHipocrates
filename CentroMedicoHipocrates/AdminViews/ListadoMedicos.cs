using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Aqui deberiamos obtener los datos de los medicos reales del sistema
            DataGridViewRow fila = (DataGridViewRow) GridMedicos.Rows[0].Clone();
            fila.Cells[0].Value = 1;
            fila.Cells[1].Value = 1;
            fila.Cells[2].Value = 1;
            fila.Cells[3].Value = 1;
            GridMedicos.Rows.Add(fila);

            //otra fila para la tabla donde definimos los mediocos del sistema
            fila = (DataGridViewRow) GridMedicos.Rows[0].Clone();
            fila.Cells[0].Value = 2;
            fila.Cells[1].Value = 3;
            fila.Cells[2].Value = 2;
            fila.Cells[3].Value = 2;
            GridMedicos.Rows.Add(fila);

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