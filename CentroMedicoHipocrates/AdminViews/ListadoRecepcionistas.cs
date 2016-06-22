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
    public partial class ListadoRecepcionistas : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoRecepcionistas()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();

            List<Recepcionista> recepcionistas = new Recepcionista().buscarTodos();
            foreach (var recepcionista in recepcionistas)
            {
                DataGridViewRow fila = (DataGridViewRow)GridOperadores.Rows[0].Clone();
                fila.Cells[0].Value = recepcionista.ioPersona.ioRut;
                fila.Cells[1].Value = recepcionista.ioPersona.ioNombre;
                fila.Cells[2].Value = recepcionista.ioPersona.ioApellidoPaterno;
                fila.Cells[3].Value = recepcionista.ioPersona.ioApellidoMaterno;
                fila.Cells[4].Value = recepcionista.ioPersona.ioFechaNacimento.ToString();
                GridOperadores.Rows.Add(fila);
            }
            GridOperadores.Refresh();
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
