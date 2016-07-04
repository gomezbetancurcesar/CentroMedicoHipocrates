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

            txtFechaBuscada.MinDate = DateTime.Today;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = txtFechaBuscada.Value.Date.ToString("yyyy-MM-dd");
            string fechaBuscada = txtFechaBuscada.Value.ToLongDateString().ToString();
            this.buscarHorarios(txtRutBuscado.Text, fecha, fechaBuscada);
        }

        private void buscarHorarios(string rut, string fecha, string fechaBuscada)
        {
            DateTime formatDate = DateTime.ParseExact(fecha, "yyyy-MM-dd", null);
            lblFechaBuscada.Text = fechaBuscada;
            lblValueFechaBuscada.Text = fecha;

            DataGridViewButtonCell btnFila;
            Doctor doctor = new Doctor().buscarPorRut(rut, true);
            if(!doctor.ioId.Equals(0))
            {
                panelHorarios.Visible = true;
                panelDatosMedico.Visible = true;

                lblId.Text = doctor.ioId.ToString();
                lblNombre.Text = doctor.ioUsuario.ioNombre;
                lblApellidoPaterno.Text = doctor.ioUsuario.ioApellidoPaterno;
                lblApellidoMaterno.Text = doctor.ioUsuario.ioApellidoMaterno;
                lblEspecialidad.Text = doctor.ioEspecialidad.ioNombre;
                lblRut.Text = doctor.ioUsuario.ioRut;

                GridHorarios.Rows.Clear();

                List<Agenda> agendas = new Agenda().buscarTodas(doctor.ioId, formatDate);
                List<Turno> turnos = new Turno().buscarTodos(1);

                foreach (var turno in turnos)
                {
                    //fila = (DataGridViewRow)GridHorarios.Rows[0].Clone();
                    Agenda agenda = agendas.Find(x => x.ioTurnoId == turno.ioId);
                    int index = GridHorarios.Rows.Add();
                    DataGridViewRow fila = GridHorarios.Rows[index];
                    fila.Cells[0].Value = turno.ioId;

                    bool agendaConfigurada = false;
                    if (agenda == null)
                    {
                        fila.Cells[1].Value = 0;
                    }
                    else
                    {
                        fila.Cells[1].Value = agenda.ioId;
                        agendaConfigurada = true;
                    }

                    fila.Cells[2].Value = turno.ioHoraInicio;
                    fila.Cells[3].Value = turno.ioHoraFin;
                    btnFila = (DataGridViewButtonCell)fila.Cells[4];
                    btnFila.FlatStyle = FlatStyle.Popup;
                    
                    //Agenda configurada
                    if (agendaConfigurada)
                    {
                        btnFila.Value = "Habilitado";
                        btnFila.Style.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        btnFila.Value = "Sin Configurar";
                        btnFila.Style.BackColor = System.Drawing.Color.Gray;
                    }
                }
                //Redibujamos la tabla de los medicos
                GridHorarios.Refresh();
            }
            else
            {
                panelHorarios.Visible = false;
                panelDatosMedico.Visible = false;
            }
        }

        private void btnRetrocederDia_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            if (fecha.Equals(txtFechaBuscada.MinDate))
            {
                btnRetrocederDia.Visible = false;
            }else
            {
                fecha = fecha.AddDays(-1);
                txtFechaBuscada.Value = fecha.Date;
                string strfecha = fecha.Date.ToString("yyyy-MM-dd");
                string fechaBuscada = fecha.ToLongDateString().ToString();
                this.buscarHorarios(txtRutBuscado.Text, strfecha, fechaBuscada);
            }
        }

        private void btnAvanzarDia_Click(object sender, EventArgs e)
        {
            btnRetrocederDia.Visible = true;
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            fecha = fecha.AddDays(1);

            txtFechaBuscada.Value = fecha.Date;
            string strfecha = fecha.Date.ToString("yyyy-MM-dd");
            string fechaBuscada = fecha.ToLongDateString().ToString();

            this.buscarHorarios(txtRutBuscado.Text, strfecha, fechaBuscada);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelHorarios.Visible = false;
            panelDatosMedico.Visible = false;
            txtRutBuscado.Text = "";
            txtFechaBuscada.Text = "";
        }

        private void GridHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridHorarios.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = GridHorarios.Rows[e.RowIndex];
                Agenda agenda = new Agenda();
                agenda.ioTurnoId = Int32.Parse(fila.Cells["Id"].Value.ToString());
                agenda.ioDia = txtFechaBuscada.Value;
                agenda.ioDoctorId = Int32.Parse(lblId.Text);
                agenda.ioEsSobrecupo = 0;
                agenda.ioFechaCreacion = DateTime.Now;

                bool realizaAccion = false;
                if (fila.Cells["IdAgenda"].Value.ToString().Equals("0"))
                {
                    if (agenda.guardar(agenda))
                    {
                        realizaAccion = true;
                    }
                }
                else
                {
                    agenda.ioId = Int32.Parse(fila.Cells["IdAgenda"].Value.ToString());
                    if (agenda.eliminar(agenda)){
                        realizaAccion = true;
                    }
                }
                if (realizaAccion)
                {
                    string fecha = txtFechaBuscada.Value.Date.ToString("yyyy-MM-dd");
                    string fechaBuscada = txtFechaBuscada.Value.ToLongDateString().ToString();
                    this.buscarHorarios(txtRutBuscado.Text, fecha, fechaBuscada);
                }
            }
        }

        private void btnHabilitarTodos_Click(object sender, EventArgs e)
        {
            List<Agenda> agendas = new List<Agenda>();
            Agenda agenda = new Agenda();
            foreach (DataGridViewRow fila in GridHorarios.Rows)
            {
                //No tiene agenda configurada
                if (fila.Cells["IdAgenda"].Value.ToString().Equals("0"))
                {
                    agenda = new Agenda();
                    agenda.ioTurnoId = Int32.Parse(fila.Cells["Id"].Value.ToString());
                    agenda.ioDia = txtFechaBuscada.Value;
                    agenda.ioDoctorId = Int32.Parse(lblId.Text);
                    agenda.ioEsSobrecupo = 0;
                    agenda.ioFechaCreacion = DateTime.Now;
                    agendas.Add(agenda);
                }
            }

            if (agenda.guardarTodos(agendas))
            {
                string fecha = txtFechaBuscada.Value.Date.ToString("yyyy-MM-dd");
                string fechaBuscada = txtFechaBuscada.Value.ToLongDateString().ToString();
                this.buscarHorarios(txtRutBuscado.Text, fecha, fechaBuscada);
            }
        }

        private void btnInhabilitarTodos_Click(object sender, EventArgs e)
        {
            List<Agenda> agendas = new List<Agenda>();
            Agenda agenda = new Agenda();
            foreach (DataGridViewRow fila in GridHorarios.Rows)
            {
                //Tiene agenda configurada
                if (!fila.Cells["IdAgenda"].Value.ToString().Equals("0"))
                {
                    agenda = new Agenda();
                    agenda.ioId = Int32.Parse(fila.Cells["IdAgenda"].Value.ToString());
                    agendas.Add(agenda);
                }
            }

            if (agenda.eliminarTodos(agendas))
            {
                string fecha = txtFechaBuscada.Value.Date.ToString("yyyy-MM-dd");
                string fechaBuscada = txtFechaBuscada.Value.ToLongDateString().ToString();
                this.buscarHorarios(txtRutBuscado.Text, fecha, fechaBuscada);
            }
        }
    }
}
