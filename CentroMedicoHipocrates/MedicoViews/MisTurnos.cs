﻿using System;
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
    public partial class MisTurnos : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public MisTurnos()
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
            panel1.Location = new Point(0, 24);
            lblBottom.Width = ventana.Width;

            lblUsuario.Text = session.AuthField("usuario");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = dateBuscar.Value.Date.ToString("yyyy-MM-dd");
            string fechaBuscada = dateBuscar.Value.ToLongDateString().ToString();
            this.buscarAgendas(fecha, fechaBuscada);
        }

        private void buscarAgendas(string fecha, string fechaBuscada)
        {
            DateTime formatDate = DateTime.ParseExact(fecha, "yyyy-MM-dd", null);
            lblFechaBuscada.Text = fechaBuscada;
            lblValueFechaBuscada.Text = fecha;

            DataGridViewButtonCell btnFila;
            int id = session.getUser().ioDoctor.ioId;
            Doctor doctor = new Doctor().buscarPorId(id);
            
            GridHorarios.Rows.Clear();
            List<Agenda> agendas = new Agenda().buscarTodas(doctor.ioId, formatDate, true);

            foreach (var agenda in agendas)
            {
                //fila = (DataGridViewRow)GridHorarios.Rows[0].Clone();
                int index = GridHorarios.Rows.Add();
                DataGridViewRow fila = GridHorarios.Rows[index];
                fila.Cells[0].Value = agenda.ioId;
                fila.Cells[2].Value = agenda.ioTurno.ioHoraInicio;
                fila.Cells[3].Value = agenda.ioTurno.ioHoraFin;
                switch (agenda.ioEstadoAgendaId)
                {
                    case 1:
                        //Agenda disponible
                        btnFila = (DataGridViewButtonCell)fila.Cells[4];
                        btnFila.FlatStyle = FlatStyle.Flat;
                        btnFila.Value = "No reservada";
                        btnFila.Style.BackColor = Color.FromArgb(45, 180, 35);

                        btnFila = (DataGridViewButtonCell)fila.Cells[5];
                        btnFila.FlatStyle = FlatStyle.Flat;
                        btnFila.Value = "Bloquear";
                        btnFila.Style.BackColor = Color.FromArgb(220,0,0);
                        break;
                    case 2:
                        //Agenda Bloqueada
                        btnFila = (DataGridViewButtonCell)fila.Cells[4];
                        btnFila.FlatStyle = FlatStyle.Flat;
                        btnFila.Value = "Bloqueada";
                        btnFila.Style.BackColor = Color.FromArgb(165, 165, 165);

                        btnFila = (DataGridViewButtonCell)fila.Cells[5];
                        btnFila.FlatStyle = FlatStyle.Flat;
                        btnFila.Value = "Desbloquear";
                        btnFila.Style.BackColor = Color.FromArgb(45, 180, 35);
                        break;
                    case 3:
                        // La agenda ha sido reservada
                        btnFila = (DataGridViewButtonCell)fila.Cells[4];
                        btnFila.FlatStyle = FlatStyle.Flat;
                        btnFila.Value = "Reservada";
                        btnFila.Style.BackColor = Color.FromArgb(240, 140, 50);
                        break;
                }
            }
            //Redibujamos la tabla de los medicos
            GridHorarios.Refresh();
            panelHorarios.Visible = true;
        }

        private void btnRetrocederDia_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            if (fecha.Equals(dateBuscar.MinDate))
            {
                btnRetrocederDia.Visible = false;
            }
            else
            {
                fecha = fecha.AddDays(-1);
                dateBuscar.Value = fecha.Date;
                string strfecha = fecha.Date.ToString("yyyy-MM-dd");
                string fechaBuscada = fecha.ToLongDateString().ToString();
                this.buscarAgendas(strfecha, fechaBuscada);
            }
        }

        private void btnAvanzarDia_Click(object sender, EventArgs e)
        {
            btnRetrocederDia.Visible = true;
            DateTime fecha = DateTime.ParseExact(lblValueFechaBuscada.Text, "yyyy-MM-dd", null);
            fecha = fecha.AddDays(1);

            dateBuscar.Value = fecha.Date;
            string strfecha = fecha.Date.ToString("yyyy-MM-dd");
            string fechaBuscada = fecha.ToLongDateString().ToString();

            this.buscarAgendas(strfecha, fechaBuscada);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelHorarios.Visible = false;
            dateBuscar.Text = "";
            this.panelReservas.Visible = false;
        }

        private void GridHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0){
                DataGridViewRow fila = GridHorarios.Rows[e.RowIndex];

                //Click en btn bloquear
                if (e.ColumnIndex == GridHorarios.Columns["Bloquear"].Index)
                {
                    Agenda agenda = new Agenda();
                    agenda.ioId = Int32.Parse(fila.Cells["Id"].Value.ToString());

                    if (fila.Cells[5].Value.ToString().Equals("Bloquear"))
                    {
                        //Estado bloqueado(2)
                        agenda.ioEstadoAgendaId = 2;
                    }

                    if (fila.Cells[5].Value.ToString().Equals("Desbloquear"))
                    {
                        //Estado desbloqueado(1)
                        agenda.ioEstadoAgendaId = 1;
                    }

                    if (agenda.actualizar(agenda))
                    {
                        string fecha = dateBuscar.Value.Date.ToString("yyyy-MM-dd");
                        string fechaBuscada = dateBuscar.Value.ToLongDateString().ToString();
                        this.buscarAgendas(fecha, fechaBuscada);
                    }
                }

                //Click para ver el detalle del estado
                if (e.ColumnIndex == GridHorarios.Columns["Estado"].Index)
                {
                    this.panelReservas.Controls.Clear();
                    string estado = fila.Cells["Estado"].Value.ToString();
                    if (estado.Equals("Reservada"))
                    {
                        int agendaId = Int32.Parse(fila.Cells["Id"].Value.ToString());
                        List<Reserva> reservas = new Reserva().buscarTodos(agendaId, 0, true);

                        Label label = new Label();
                        if (reservas.Count > 0)
                        {
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, 0);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Datos Reserva";
                            //label.Font.Size = 15;
                            this.panelReservas.Controls.Add(label);
                        }

                        int cordenadaY = 30;
                        foreach (Reserva reserva in reservas)
                        {
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(0, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Nombre:";
                            this.panelReservas.Controls.Add(label);

                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            string nombre = reserva.ioPaciente.ioUsuario.ioNombre + " ";
                            nombre += reserva.ioPaciente.ioUsuario.ioApellidoPaterno + " ";
                            nombre += reserva.ioPaciente.ioUsuario.ioApellidoMaterno + " ";
                            label.Text = nombre;
                            this.panelReservas.Controls.Add(label);

                            cordenadaY += 20;
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(0, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Rut:";
                            this.panelReservas.Controls.Add(label);

                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = reserva.ioPaciente.ioUsuario.ioRut;
                            this.panelReservas.Controls.Add(label);

                            cordenadaY += 20;
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(0, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Isapre:";
                            this.panelReservas.Controls.Add(label);

                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = reserva.ioPaciente.ioIsapre.ioNombre;
                            this.panelReservas.Controls.Add(label);

                            cordenadaY += 20;
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(0, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Fecha Reserva:";
                            this.panelReservas.Controls.Add(label);

                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = reserva.ioFechaReserva.ToString("dd/MM/yyyy HH:ss");
                            this.panelReservas.Controls.Add(label);

                            cordenadaY += 20;
                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(0, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = "Estado Reserva:";
                            this.panelReservas.Controls.Add(label);

                            label = new Label();
                            label.AutoSize = true;
                            label.Location = new System.Drawing.Point(90, cordenadaY);
                            label.Name = "label50";
                            label.Size = new System.Drawing.Size(37, 50);
                            label.TabIndex = 18;
                            label.Text = reserva.ioEstadoReserva.ioNombre;
                            //label.Font.Size = 14;
                            switch (reserva.ioEstadoReserva.ioNombre)
                            {
                                case "Asistencia":
                                    label.ForeColor = Color.Orange;
                                    break;
                                case "Reservada":
                                    label.ForeColor = Color.YellowGreen;
                                    break;
                                case "Anulada":
                                    label.ForeColor = Color.DarkGray;
                                    break;
                                case "Confirmada":
                                    label.ForeColor = Color.DarkGreen;
                                    break;
                            }
                            this.panelReservas.Controls.Add(label);
                            cordenadaY += 30;
                        }
                        this.panelReservas.Visible = true;
                    }
                    else
                    {
                        this.panelReservas.Visible = false;
                    }
                }
            }
        }
    }
}
