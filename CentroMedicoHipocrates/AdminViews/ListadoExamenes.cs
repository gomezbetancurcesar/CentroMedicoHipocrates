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
    public partial class ListadoExamenes : Form
    {
        private MenuCreator menuCreator = new MenuCreator();
        private LoginService session = new LoginService();

        public ListadoExamenes()
        {
            InitializeComponent();
            //Dibujamos el menu correspondiente a cada rol!
            menuCreator.generarMenu(MenuContexto, session.AuthField("rol"));

            this.fullWidth();
            this.dibujarGrid();
            this.dibujarCombos();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void dibujarCombos()
        {
            //Oficinas
            List<Oficina> oficinas = new Oficina().buscarTodos();
            comboOficina.Items.Clear();
            foreach (var oficina in oficinas)
            {
                comboOficina.Items.Add(oficina.ioNumero);
            }
            comboOficina.Refresh();
        }

        public void dibujarGrid()
        {
            GridEspecialidades.CellClick += new DataGridViewCellEventHandler(this.OnCellClick);
            List<Especialidad> especialidades = new Especialidad().buscarTodos(true);
            GridEspecialidades.Rows.Clear();
            foreach (var especialidad in especialidades)
            {
                int indice = GridEspecialidades.Rows.Add();
                DataGridViewRow fila = GridEspecialidades.Rows[indice];
                fila.Cells[0].Value = especialidad.ioId;
                fila.Cells[1].Value = especialidad.ioNombre;
                fila.Cells[2].Value = especialidad.ioDoctor.ioOficina.ioNumero;
            }
            GridEspecialidades.Refresh();
        }

        private void limpiarFormulario()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtLimite.Text = "";
            comboOficina.Text = "";
            comboOficina.SelectedIndex = -1;
            btnCancelar.Visible = false;
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridEspecialidades.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridEspecialidades.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                btnCancelar.Visible = true;
            }
        }

        public Boolean validarDatos()
        {
            Console.WriteLine("valor nombre: "+txtNombre.Text);
            if (txtNombre.Text.Equals(""))
            {
                return false;
            }
            Console.WriteLine("valor limite: "+txtLimite.Text);
            if (txtLimite.Text.Equals(""))
            {
                return false;
            }
            Console.WriteLine("seleccionado: "+comboOficina.SelectedIndex.ToString());
            if (comboOficina.SelectedIndex.Equals(-1))
            {
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            if (this.validarDatos())
            {
                bool guardo = false;
                especialidad.ioLaboratorio = "1";
                especialidad.ioLimite = Int32.Parse(txtLimite.Text);
                especialidad.ioNombre = txtNombre.Text;
                if (txtId.Text.Equals("0"))
                {
                    if (especialidad.guardar(especialidad))
                    {
                        especialidad = new Especialidad().buscarPorNombre(especialidad.ioNombre);
                        Doctor doctor = new Doctor();
                        doctor.ioEspecialidadId = especialidad.ioId;
                        doctor.ioOficinaId = new Oficina().buscarPorNumero(comboOficina.Text).ioId;
                        guardo = doctor.guardar(doctor, false);
                    }
                }
                else
                {

                    especialidad.ioId = Int32.Parse(txtId.Text);
                    guardo = especialidad.actualizar(especialidad);
                }

                if (guardo)
                {
                    this.dibujarGrid();
                    this.limpiarFormulario();
                }
            }
        }
    }
}
