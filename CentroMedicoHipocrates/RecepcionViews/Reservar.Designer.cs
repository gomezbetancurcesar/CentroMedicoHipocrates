namespace CentroMedicoHipocrates
{
    partial class Reservar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuContexto = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutBuscado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelDatosPersona = new System.Windows.Forms.Panel();
            this.lblPacienteId = new System.Windows.Forms.Label();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.comboComuna = new System.Windows.Forms.ComboBox();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.comboIsapre = new System.Windows.Forms.ComboBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRutDoctor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateFechaBuscada = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnVerAgenda = new System.Windows.Forms.Button();
            this.panelDoctores = new System.Windows.Forms.Panel();
            this.GridMedicos = new System.Windows.Forms.DataGridView();
            this.IdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHorarios = new System.Windows.Forms.Panel();
            this.GridHorarios = new System.Windows.Forms.DataGridView();
            this.IdAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdDoctor = new System.Windows.Forms.Label();
            this.MenuContexto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDatosPersona.SuspendLayout();
            this.panelDoctores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMedicos)).BeginInit();
            this.panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuContexto
            // 
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(915, 24);
            this.MenuContexto.TabIndex = 10;
            this.MenuContexto.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBottom);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblBottom
            // 
            this.lblBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBottom.Location = new System.Drawing.Point(0, 98);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(500, 2);
            this.lblBottom.TabIndex = 3;
            // 
            // lblTop
            // 
            this.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTop.Location = new System.Drawing.Point(3, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(500, 2);
            this.lblTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rut Paciente";
            // 
            // txtRutBuscado
            // 
            this.txtRutBuscado.Location = new System.Drawing.Point(107, 135);
            this.txtRutBuscado.Name = "txtRutBuscado";
            this.txtRutBuscado.Size = new System.Drawing.Size(117, 20);
            this.txtRutBuscado.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(254, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelDatosPersona
            // 
            this.panelDatosPersona.Controls.Add(this.lblPacienteId);
            this.panelDatosPersona.Controls.Add(this.lblUsuarioId);
            this.panelDatosPersona.Controls.Add(this.btnCancelar);
            this.panelDatosPersona.Controls.Add(this.btnReservar);
            this.panelDatosPersona.Controls.Add(this.comboComuna);
            this.panelDatosPersona.Controls.Add(this.comboProvincia);
            this.panelDatosPersona.Controls.Add(this.comboIsapre);
            this.panelDatosPersona.Controls.Add(this.comboRegion);
            this.panelDatosPersona.Controls.Add(this.label6);
            this.panelDatosPersona.Controls.Add(this.txtDireccion);
            this.panelDatosPersona.Controls.Add(this.txtTelefono);
            this.panelDatosPersona.Controls.Add(this.txtEmail);
            this.panelDatosPersona.Controls.Add(this.dateFechaNac);
            this.panelDatosPersona.Controls.Add(this.txtApellidoMaterno);
            this.panelDatosPersona.Controls.Add(this.txtApellidoPaterno);
            this.panelDatosPersona.Controls.Add(this.txtNombre);
            this.panelDatosPersona.Controls.Add(this.txtRut);
            this.panelDatosPersona.Controls.Add(this.label13);
            this.panelDatosPersona.Controls.Add(this.label14);
            this.panelDatosPersona.Controls.Add(this.label15);
            this.panelDatosPersona.Controls.Add(this.label10);
            this.panelDatosPersona.Controls.Add(this.label11);
            this.panelDatosPersona.Controls.Add(this.label12);
            this.panelDatosPersona.Controls.Add(this.label9);
            this.panelDatosPersona.Controls.Add(this.label8);
            this.panelDatosPersona.Controls.Add(this.label7);
            this.panelDatosPersona.Controls.Add(this.label5);
            this.panelDatosPersona.Controls.Add(this.label3);
            this.panelDatosPersona.Controls.Add(this.label2);
            this.panelDatosPersona.Location = new System.Drawing.Point(15, 169);
            this.panelDatosPersona.Name = "panelDatosPersona";
            this.panelDatosPersona.Size = new System.Drawing.Size(314, 396);
            this.panelDatosPersona.TabIndex = 16;
            // 
            // lblPacienteId
            // 
            this.lblPacienteId.AutoSize = true;
            this.lblPacienteId.Location = new System.Drawing.Point(10, 366);
            this.lblPacienteId.Name = "lblPacienteId";
            this.lblPacienteId.Size = new System.Drawing.Size(13, 13);
            this.lblPacienteId.TabIndex = 29;
            this.lblPacienteId.Text = "0";
            this.lblPacienteId.Visible = false;
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Location = new System.Drawing.Point(8, 342);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(13, 13);
            this.lblUsuarioId.TabIndex = 28;
            this.lblUsuarioId.Text = "0";
            this.lblUsuarioId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(120, 342);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 26;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // comboComuna
            // 
            this.comboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboComuna.FormattingEnabled = true;
            this.comboComuna.Location = new System.Drawing.Point(120, 305);
            this.comboComuna.Name = "comboComuna";
            this.comboComuna.Size = new System.Drawing.Size(191, 21);
            this.comboComuna.TabIndex = 25;
            // 
            // comboProvincia
            // 
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(120, 280);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(191, 21);
            this.comboProvincia.TabIndex = 24;
            // 
            // comboIsapre
            // 
            this.comboIsapre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIsapre.FormattingEnabled = true;
            this.comboIsapre.Location = new System.Drawing.Point(120, 205);
            this.comboIsapre.Name = "comboIsapre";
            this.comboIsapre.Size = new System.Drawing.Size(191, 21);
            this.comboIsapre.TabIndex = 19;
            // 
            // comboRegion
            // 
            this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(120, 255);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(191, 21);
            this.comboRegion.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Isapre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 230);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(191, 20);
            this.txtDireccion.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.CustomFormat = "dd-MM-yyyy";
            this.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaNac.Location = new System.Drawing.Point(120, 130);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(152, 20);
            this.dateFechaNac.TabIndex = 18;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(120, 105);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoMaterno.TabIndex = 17;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(120, 80);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoPaterno.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(120, 30);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(152, 20);
            this.txtRut.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Apellido Materno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Apellido Paterno";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Comuna";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Provincia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Región";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rut Doctor";
            // 
            // txtRutDoctor
            // 
            this.txtRutDoctor.Location = new System.Drawing.Point(492, 135);
            this.txtRutDoctor.Name = "txtRutDoctor";
            this.txtRutDoctor.Size = new System.Drawing.Size(157, 20);
            this.txtRutDoctor.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Fecha";
            // 
            // dateFechaBuscada
            // 
            this.dateFechaBuscada.CustomFormat = "dd-MM-yyyy";
            this.dateFechaBuscada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaBuscada.Location = new System.Drawing.Point(492, 185);
            this.dateFechaBuscada.Name = "dateFechaBuscada";
            this.dateFechaBuscada.Size = new System.Drawing.Size(157, 20);
            this.dateFechaBuscada.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(421, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Especialidad";
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Location = new System.Drawing.Point(492, 160);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(157, 21);
            this.comboEspecialidad.TabIndex = 22;
            // 
            // btnVerAgenda
            // 
            this.btnVerAgenda.Location = new System.Drawing.Point(666, 160);
            this.btnVerAgenda.Name = "btnVerAgenda";
            this.btnVerAgenda.Size = new System.Drawing.Size(75, 20);
            this.btnVerAgenda.TabIndex = 23;
            this.btnVerAgenda.Text = "Buscar";
            this.btnVerAgenda.UseVisualStyleBackColor = true;
            this.btnVerAgenda.Click += new System.EventHandler(this.btnVerAgenda_Click);
            // 
            // panelDoctores
            // 
            this.panelDoctores.Controls.Add(this.GridMedicos);
            this.panelDoctores.Location = new System.Drawing.Point(345, 224);
            this.panelDoctores.Name = "panelDoctores";
            this.panelDoctores.Size = new System.Drawing.Size(269, 167);
            this.panelDoctores.TabIndex = 24;
            this.panelDoctores.Visible = false;
            // 
            // GridMedicos
            // 
            this.GridMedicos.AllowUserToAddRows = false;
            this.GridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedico,
            this.NombreMedico,
            this.RutMedico});
            this.GridMedicos.Location = new System.Drawing.Point(4, 4);
            this.GridMedicos.Name = "GridMedicos";
            this.GridMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMedicos.Size = new System.Drawing.Size(259, 150);
            this.GridMedicos.TabIndex = 0;
            // 
            // IdMedico
            // 
            this.IdMedico.HeaderText = "Id";
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.Visible = false;
            // 
            // NombreMedico
            // 
            this.NombreMedico.HeaderText = "Nombre";
            this.NombreMedico.Name = "NombreMedico";
            this.NombreMedico.ReadOnly = true;
            // 
            // RutMedico
            // 
            this.RutMedico.HeaderText = "Rut";
            this.RutMedico.Name = "RutMedico";
            this.RutMedico.ReadOnly = true;
            // 
            // panelHorarios
            // 
            this.panelHorarios.Controls.Add(this.GridHorarios);
            this.panelHorarios.Location = new System.Drawing.Point(621, 224);
            this.panelHorarios.Name = "panelHorarios";
            this.panelHorarios.Size = new System.Drawing.Size(282, 312);
            this.panelHorarios.TabIndex = 25;
            this.panelHorarios.Visible = false;
            // 
            // GridHorarios
            // 
            this.GridHorarios.AllowUserToAddRows = false;
            this.GridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAgenda,
            this.Horario,
            this.EstadoTurno});
            this.GridHorarios.Location = new System.Drawing.Point(4, 2);
            this.GridHorarios.Name = "GridHorarios";
            this.GridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHorarios.Size = new System.Drawing.Size(269, 264);
            this.GridHorarios.TabIndex = 1;
            // 
            // IdAgenda
            // 
            this.IdAgenda.HeaderText = "IdAgenda";
            this.IdAgenda.Name = "IdAgenda";
            this.IdAgenda.Visible = false;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // EstadoTurno
            // 
            this.EstadoTurno.HeaderText = "Estado";
            this.EstadoTurno.Name = "EstadoTurno";
            this.EstadoTurno.ReadOnly = true;
            // 
            // lblIdDoctor
            // 
            this.lblIdDoctor.AutoSize = true;
            this.lblIdDoctor.Location = new System.Drawing.Point(666, 190);
            this.lblIdDoctor.Name = "lblIdDoctor";
            this.lblIdDoctor.Size = new System.Drawing.Size(13, 13);
            this.lblIdDoctor.TabIndex = 26;
            this.lblIdDoctor.Text = "0";
            this.lblIdDoctor.Visible = false;
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 741);
            this.Controls.Add(this.lblIdDoctor);
            this.Controls.Add(this.panelHorarios);
            this.Controls.Add(this.panelDoctores);
            this.Controls.Add(this.btnVerAgenda);
            this.Controls.Add(this.comboEspecialidad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateFechaBuscada);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRutDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelDatosPersona);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRutBuscado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.Name = "Reservar";
            this.Text = "Reservar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatosPersona.ResumeLayout(false);
            this.panelDatosPersona.PerformLayout();
            this.panelDoctores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMedicos)).EndInit();
            this.panelHorarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutBuscado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelDatosPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboComuna;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboIsapre;
        private System.Windows.Forms.DateTimePicker dateFechaNac;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblPacienteId;
        private System.Windows.Forms.Label lblUsuarioId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRutDoctor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateFechaBuscada;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.Button btnVerAgenda;
        private System.Windows.Forms.Panel panelDoctores;
        private System.Windows.Forms.Panel panelHorarios;
        private System.Windows.Forms.DataGridView GridMedicos;
        private System.Windows.Forms.DataGridView GridHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTurno;
        private System.Windows.Forms.Label lblIdDoctor;
    }
}