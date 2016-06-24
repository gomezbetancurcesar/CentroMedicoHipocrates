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
            this.dibujarDataGrid();
            this.dibujarCombo();
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

        private void dibujarCombo()
        {
            List<Estado> estados = new Estado().buscarTodos();
            comboEstados.Items.Clear();
            foreach (var estado in estados)
            {
                comboEstados.Items.Add(estado.ioNombre);
            }
            comboEstados.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            bool guardo = false;
            
            if (!comboEstados.Text.Equals(""))
            {
                turno.ioEstadoTurnoId = new EstadoTurno().buscarPorNombre(comboEstados.Text).ioId;
                //Validar Horas!
                turno.ioHoraInicio = txtHoraInicio.Value.ToString("HH:mm");
                turno.ioHoraFin = txtHoraFin.Value.ToString("HH:mm");
                if (txtId.Text.Equals("0"))
                {
                    guardo = turno.guardar(turno);
                }else
                {
                    turno.ioId = Int32.Parse(txtId.Text);
                    guardo = turno.actualizar(turno);
                }
            }
            if (guardo)
            {
                this.dibujarDataGrid();
                this.limpiarFormulario();
            }
        }

        private void dibujarDataGrid()
        {
            GridTurnos.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Turno> turnos = new Turno().buscarTodos();
            GridTurnos.Rows.Clear();
            foreach (var turno in turnos)
            {
                int indice = GridTurnos.Rows.Add();
                DataGridViewRow fila = GridTurnos.Rows[indice];
                fila.Cells[0].Value = turno.ioId;
                fila.Cells[1].Value = turno.ioEstadoTurnoId;
                fila.Cells[2].Value = turno.ioHoraInicio;
                fila.Cells[3].Value = turno.ioHoraFin;
                fila.Cells[4].Value = turno.ioEstadoTurno.ioNombre;
            }
            GridTurnos.Refresh();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridTurnos.SelectedRows[0];
            this.limpiarFormulario();

            txtId.Text = row.Cells["Id"].Value.ToString();
            txtHoraInicio.Text = row.Cells["HoraInicio"].Value.ToString();
            txtHoraFin.Text = row.Cells["HoraFin"].Value.ToString();
            comboEstados.SelectedText = row.Cells["Estado"].Value.ToString();

            btnCancelar.Visible = true;
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtHoraInicio.Text = "";
            txtHoraFin.Text = "";
            btnCancelar.Visible = false;
            comboEstados.SelectedIndex = -1;
            comboEstados.SelectedValue = null;
            comboEstados.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }
    }
}
