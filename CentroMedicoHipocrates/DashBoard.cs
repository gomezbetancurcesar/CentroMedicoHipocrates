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
        Dictionary<string, string> usuario = new Dictionary<string, string>();
        MenuCreator menuCreator = new MenuCreator();

        public DashBoard()
        {
            InitializeComponent();

            MenuContexto.Items.Clear();
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));
            MenuContexto.Refresh();

            //MessageBox.Show(session.AuthField("usuario"));
            //MessageBox.Show(session.AuthField("rol"));
        }

        protected override void OnFormClosing(FormClosingEventArgs e){
                Application.Exit();
        }
    }
}