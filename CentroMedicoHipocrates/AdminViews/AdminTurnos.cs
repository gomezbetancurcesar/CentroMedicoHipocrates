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

            txtFecha.MinDate = DateTime.Today;
            GridHorarios.RowHeadersVisible = false;
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
            string fechaBuscada = txtFecha.Value.ToLongDateString().ToString();
            this.buscarHorarios(txtRut.Text, fecha, fechaBuscada);

            panelHorarios.Visible = true;
            panelDatosMedico.Visible = true;
        }

        private void buscarHorarios(string rut, string fecha, string fechaBuscada)
        {
            DateTime formatDate = DateTime.ParseExact(fecha, "yyyy-MM-dd", null);
            lblFechaBuscada.Text = fechaBuscada;
            lblValueFechaBuscada.Text = fecha;

            DataGridViewButtonCell btnFila;
            DataGridViewRow fila;

            Doctor doctor = new CapaDatos.Doctor().buscarPorRut(rut);
            lblNombre.Text = doctor.ioUsuario.ioNombre;
            lblApellidoPaterno.Text = doctor.ioUsuario.ioApellidoPaterno;
            lblApellidoMaterno.Text = doctor.ioUsuario.ioApellidoMaterno;
            lblEspecialidad.Text = doctor.ioEspecialidad.ioNombre;
            lblRut.Text = doctor.ioUsuario.ioRut;

            GridHorarios.Rows.Clear();
            List<Turno> turnos = new CapaDatos.Turno().buscarTodos();

            foreach (var turno in turnos)
            {
                fila = (DataGridViewRow)GridHorarios.Rows[0].Clone();
                fila.Cells[0].Value = turno.ioId;
                fila.Cells[1].Value = turno.ioId;
                fila.Cells[2].Value = turno.ioHoraInicio;
                fila.Cells[3].Value = turno.ioHoraFin;
                btnFila = (DataGridViewButtonCell)fila.Cells[4];
                btnFila.FlatStyle = FlatStyle.Popup;
                btnFila.Value = turno.ioEstadoTurno.ioNombre;
                //Habilitado
                if (turno.ioEstadoTurnoId.Equals(1)){
                    btnFila.Style.BackColor = System.Drawing.Color.Green;
                }else{
                    btnFila.Style.BackColor = System.Drawing.Color.Red;
                }
                GridHorarios.Rows.Add(fila);
            }
            //Redibujamos la tabla de los medicos
            GridHorarios.Refresh();
        }

        private void btnRetrocederDia_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            if (fecha.Equals(txtFecha.MinDate))
            {
                btnRetrocederDia.Visible = false;
            }else
            {
                fecha = fecha.AddDays(-1);
                txtFecha.Value = fecha.Date;
                string strfecha = fecha.Date.ToString("yyyy-MM-dd");
                string fechaBuscada = fecha.ToLongDateString().ToString();
                this.buscarHorarios(txtRut.Text, strfecha, fechaBuscada);
            }
            
        }

        private void btnAvanzarDia_Click(object sender, EventArgs e)
        {
            btnRetrocederDia.Visible = true;
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            fecha = fecha.AddDays(1);

            txtFecha.Value = fecha.Date;
            string strfecha = fecha.Date.ToString("yyyy-MM-dd");
            string fechaBuscada = fecha.ToLongDateString().ToString();

            this.buscarHorarios(txtRut.Text, strfecha, fechaBuscada);
        }
    }
}
