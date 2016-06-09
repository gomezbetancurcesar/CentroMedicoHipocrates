using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedicoHipocrates
{
    class MenuCreator
    {
        private ToolStripMenuItem item = new ToolStripMenuItem();
        private ToolStripMenuItem subItem = new ToolStripMenuItem();

        public void generarMenu(MenuStrip menu, string rolUsuario)
        {
            //Limpiamos las opciones existentes en el menu
            menu.Items.Clear();
            switch (rolUsuario)
            {
                case "administrador":
                    this.menuAdministrador(menu);
                break;
                case "medico":
                    this.menuMedico(menu);
                break;
                case "recepcion":
                    this.menuRecepcion(menu);
                break;
            }
            //Actualizamos las opciones del menu
            menu.Refresh();
        }

        //Generamos el menu para el administrador
        private void menuAdministrador(MenuStrip menu)
        {
            item = new ToolStripMenuItem();
            item.Name = "DashBoard";
            item.Text = "Inicio";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opConfiguraciones";
            item.Text = "Configuraciones";
                subItem = new ToolStripMenuItem();
                subItem.Name = "opTurnos";
                subItem.Text = "Turnos";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opMantenedores";
            item.Text = "Mantenedores";
                subItem = new ToolStripMenuItem();
                subItem.Name = "ListadoMedicos";
                subItem.Text = "Medicos";
                subItem.Click += new EventHandler(ItemClicked);
            //item.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);
        }

        //Generamos el menu para el medico
        private void menuMedico(MenuStrip menu)
        {
            item = new ToolStripMenuItem();
            item.Name = "opInicio";
            item.Text = "Inicio";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opMisTurnos";
            item.Text = "Mis turnos";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);
        }

        //Generamos el menu para la recepcion
        private void menuRecepcion(MenuStrip menu)
        {
            item = new ToolStripMenuItem();
            item.Name = "opInicio";
            item.Text = "Inicio";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opBusquedas";
            item.Text = "Busquedas";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opAsistencia";
            item.Text = "Asistencia";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);
        }

        protected void ItemClicked(Object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            var className = clickedItem.Name;
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().First(t => t.Name == className);
            
            FormCollection formAbiertos = Application.OpenForms;
            foreach (Form frm in formAbiertos)
            {
                frm.Hide();
            }

            Form vista = (Form)Activator.CreateInstance(type);
            vista.Show();
        }
    }
}
