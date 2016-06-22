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
    public partial class ListadoAdministradores : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoAdministradores()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();

            List<Administrador> administradores = new Administrador().buscarTodos();

            foreach (var administrador in administradores)
            {
                DataGridViewRow fila = (DataGridViewRow)GridAdministradores.Rows[0].Clone();
                fila.Cells[0].Value = administrador.ioPersona.ioRut;
                fila.Cells[1].Value = administrador.ioPersona.ioNombre;
                fila.Cells[2].Value = administrador.ioPersona.ioApellidoPaterno;
                fila.Cells[3].Value = administrador.ioPersona.ioApellidoMaterno;
                fila.Cells[4].Value = administrador.ioPersona.ioFechaNacimento.ToString();
                GridAdministradores.Rows.Add(fila);
            }
            GridAdministradores.Refresh();
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

        private void GridMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
