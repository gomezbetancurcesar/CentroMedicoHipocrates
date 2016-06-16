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
    public partial class AdminTurnos : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public AdminTurnos()
        {
            InitializeComponent();

            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               // MessageBox.Show("click en boton!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Value.Date.ToString("yyyy-MM-dd");
            this.buscarHorarios(txtRut.Text, fecha);
            panelHorarios.Visible = true;
            panelDatosMedico.Visible = true;
        }

        private void buscarHorarios(string rut, string fecha)
        {
            DataGridViewButtonCell btnFila;
            DataGridViewRow fila;

            Medicos medico = new CapaDatos.Medicos().buscarPorRut(rut);
            lblNombre.Text = medico.ioPersona.ioNombre;
            lblApellidoPaterno.Text = medico.ioPersona.ioApellidoPaterno;
            lblApellidoMaterno.Text = medico.ioPersona.ioApellidoMaterno;
            lblEspecialidad.Text = medico.ioEspecialidad.ioNombre;

            GridHorarios.Rows.Clear();
            List<Turnos> turnos = new CapaDatos.Turnos().turnosDisponibles();
            foreach (var turno in turnos)
            {
                fila = (DataGridViewRow)GridHorarios.Rows[0].Clone();
                fila.Cells[0].Value = turno.ioHoraInicio;
                btnFila = (DataGridViewButtonCell)fila.Cells[1];
                btnFila.FlatStyle = FlatStyle.Popup;
                btnFila.Value = turno.ioEstado.ioNombre;
                //Habilitado
                if (turno.ioEstadoId.Equals(1)){
                    btnFila.Style.BackColor = System.Drawing.Color.Green;
                }else{
                    btnFila.Style.BackColor = System.Drawing.Color.Red;
                }
                GridHorarios.Rows.Add(fila);
            }
            //Redibujamos la tabla de los medicos
            GridHorarios.Refresh();
        }
    }
}
