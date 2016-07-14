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
    public partial class Login : Form
    {
        private Validaciones validaciones = new Validaciones();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cambiarColorTextbox(Color.White);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            cambiarColorTextbox(Color.White);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            LoginService login = new LoginService();
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            if (login.Autenticar(username, password)) {
                DashBoard nuevaVentana = new DashBoard();
                nuevaVentana.Show();
                this.Hide();
            }
            else
            {
                validaciones.marcarError(txtPassword);
                validaciones.marcarError(txtUsuario);
            }
        }

        private void cambiarColorTextbox(Color color)
        {
            validaciones.marcarError(txtPassword, Color.White);
            validaciones.marcarError(txtUsuario, Color.White);
        }
    }
}
