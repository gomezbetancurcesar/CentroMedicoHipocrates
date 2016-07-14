using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CentroMedicoHipocrates
{
    public class TestColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(206,216,246); }
        }
        /*
        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Green; }
        }
        */
    }

    class MenuCreator
    {
        private ToolStripMenuItem item = new ToolStripMenuItem();
        private ToolStripMenuItem subItem = new ToolStripMenuItem();
        private static int anchoVentana;

        public void generarMenu(MenuStrip menu, string rolUsuario)
        {
            menu.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());

            FormCollection formAbiertos = Application.OpenForms;
            Form form = new Form();
            foreach (Form frm in formAbiertos)
            {
                form = frm;
            }
            Screen pantalla = Screen.FromControl(form);
            System.Drawing.Rectangle ventana = pantalla.WorkingArea;
            anchoVentana = ventana.Width;

            //Limpiamos las opciones existentes en el menu
            menu.Items.Clear();
            switch (rolUsuario)
            {
                case "Administrador":
                    this.menuAdministrador(menu);
                break;
                case "Medico":
                    this.menuMedico(menu);
                break;
                case "Recepcion":
                    this.menuRecepcion(menu);
                break;
            }
            //Actualizamos las opciones del menu
            menu.BackColor = System.Drawing.Color.FromArgb(25, 25, 112);
            menu.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
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
            subItem.Name = "AdminTurnos";
            subItem.Text = "Turnos";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opMantenedores";
            item.Text = "Funcionarios";
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoDoctores";
            subItem.Text = "Doctores";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoAdministradores";
            subItem.Text = "Administradores";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoRecepcionistas";
            subItem.Text = "Operadores";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opMantenedores";
            item.Text = "Mantenedores";
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoTurnos";
            subItem.Text = "Turnos";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoEspecialidades";
            subItem.Text = "Especialidades";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            /*
                subItem = new ToolStripMenuItem();
                subItem.Name = "ListadoExamenes";
                subItem.Text = "Examenes";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            */
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoIsapres";
            subItem.Text = "Isapres";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoOficinas";
            subItem.Text = "Oficinas";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            subItem = new ToolStripMenuItem();
            subItem.Name = "ListadoEnfermedades";
            subItem.Text = "Enfermedades";
            subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Salir";
            item.Text = "Salir";
            item.Margin = new Padding((anchoVentana- 400), 0,0,0);
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);
        }

        //Generamos el menu para el medico
        private void menuMedico(MenuStrip menu)
        {
            ToolStripMenuItem item;
            item = new ToolStripMenuItem();
            item.Name = "DashBoard";
            item.Text = "Inicio";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Agendas";
            item.Text = "Agenda";
                subItem = new ToolStripMenuItem();
                subItem.Name = "MisTurnos";
                subItem.Text = "Ver Agenda";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
                subItem = new ToolStripMenuItem();
                subItem.Name = "AgendaDiaria";
                subItem.Text = "Ver hoy";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "IngresarFichas";
            item.Text = "Fichas";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "MisDatosMedico";
            item.Text = "Mi Perfil";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Salir";
            item.Text = "Salir";
            item.Margin = new Padding((anchoVentana - 290), 0, 0, 0);
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);
        }

        //Generamos el menu para la recepcion
        private void menuRecepcion(MenuStrip menu)
        {
            item = new ToolStripMenuItem();
            item.Name = "DashBoard";
            item.Text = "Inicio";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Busquedas";
            item.Text = "Busquedas";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Confirmaciones";
            item.Text = "Confirmaciones";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "opMantenedores";
            item.Text = "Reservas";
                subItem = new ToolStripMenuItem();
                subItem.Name = "Reservar";
                subItem.Text = "Reservar";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
                subItem = new ToolStripMenuItem();
                subItem.Name = "SobreCupos";
                subItem.Text = "Sobre Cupos";
                subItem.Click += new EventHandler(ItemClicked);
            item.DropDownItems.Add(subItem);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "MisDatosRecepcion";
            item.Text = "Mi Perfil";
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Name = "Salir";
            item.Text = "Salir";
            item.Margin = new Padding((anchoVentana - 425), 0, 0, 0);
            item.Click += new EventHandler(ItemClicked);
            menu.Items.Add(item);
        }

        protected void ItemClicked(Object sender, EventArgs e)
        {
            FormCollection formAbiertos = Application.OpenForms;
            ToolStripMenuItem clickedItem = (ToolStripMenuItem) sender;
            if (clickedItem.Name.Equals("Salir"))
            {
                Form login = new Login();
                foreach (Form frm in formAbiertos)
                {
                    frm.Hide();
                }
                login.Show();
            }
            else
            {
                var className = clickedItem.Name;
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == className);

                Form vista = (Form)Activator.CreateInstance(type);
                foreach (Form frm in formAbiertos)
                {
                    frm.Hide();
                }
                vista.Show();
            }
        }
    }
}