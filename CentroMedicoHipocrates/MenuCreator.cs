using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedicoHipocrates
{
    class MenuCreator
    {
        private ToolStripMenuItem item = new ToolStripMenuItem();

        public void generarMenu(MenuStrip menu, string rolUsuario)
        {
            item.Name = "opInicio";
            item.Text = "Inicio";
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opConfiguraciones";
            item.Text = "Configuraciones";
            menu.Items.Add(item);
        }
    }
}
