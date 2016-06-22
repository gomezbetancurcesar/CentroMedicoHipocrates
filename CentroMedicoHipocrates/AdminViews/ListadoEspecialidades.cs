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
    public partial class ListadoEspecialidades : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoEspecialidades()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();

            List<Especialidad> especialidades = new Especialidad().buscarTodos();

            GridEspecialidades.Rows.Clear();
            foreach (var especialidad in especialidades)
            {
                DataGridViewRow fila = (DataGridViewRow)GridEspecialidades.Rows[0].Clone();
                fila.Cells[0].Value = especialidad.ioId;
                fila.Cells[1].Value = especialidad.ioNombre;
                GridEspecialidades.Rows.Add(fila);
            }
            GridEspecialidades.Refresh();
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
    }
}
