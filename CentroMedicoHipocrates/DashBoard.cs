using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedicoHipocrates
{
    public partial class DashBoard : Form
    {
        LoginService session = new LoginService();
        MenuCreator menuCreator = new MenuCreator();

        public DashBoard()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
        }

        protected override void OnFormClosing(FormClosingEventArgs e){
                Application.Exit();
        }
    }
}