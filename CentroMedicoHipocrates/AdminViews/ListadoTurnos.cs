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
    public partial class ListadoTurnos : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoTurnos()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();

            List<Turno> turnos = new Turno().buscarTodos();
            GridTurnos.Rows.Clear();
            foreach (var turno in turnos)
            {
                DataGridViewRow fila = (DataGridViewRow)GridTurnos.Rows[0].Clone();
                fila.Cells[0].Value = turno.ioId;
                fila.Cells[1].Value = turno.ioHoraInicio;
                fila.Cells[2].Value = turno.ioHoraFin;
                fila.Cells[3].Value = turno.ioEstadoTurnoId;
                GridTurnos.Rows.Add(fila);
            }
            GridTurnos.Refresh();

            List<Estado> estados = new Estado().buscarTodos();
            comboEstados.Items.Clear();
            foreach(var estado in estados)
            {
                comboEstados.Items.Insert(estado.ioId, estado.ioNombre);
            }
            comboEstados.Refresh();

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

        private void GridTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
