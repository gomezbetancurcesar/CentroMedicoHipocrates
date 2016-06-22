namespace CentroMedicoHipocrates
{
    partial class AdminTurnos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.MenuContexto = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHorarios = new System.Windows.Forms.Panel();
            this.lblValueFechaBuscada = new System.Windows.Forms.Label();
            this.btnAvanzarDia = new System.Windows.Forms.Button();
            this.btnRetrocederDia = new System.Windows.Forms.Button();
            this.lblFechaBuscada = new System.Windows.Forms.Label();
            this.GridHorarios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDatosMedico = new System.Windows.Forms.Panel();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTurnoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.MenuContexto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).BeginInit();
            this.panelDatosMedico.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 7;
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
            // MenuContexto
            // 
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(911, 24);
            this.MenuContexto.TabIndex = 8;
            this.MenuContexto.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.txtRut);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 128);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = "dd/MM/yyyy";
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(157, 60);
            this.txtFecha.MinDate = new System.DateTime(2016, 1, 12, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 10;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(157, 37);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(128, 20);
            this.txtRut.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut Médico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // panelHorarios
            // 
            this.panelHorarios.Controls.Add(this.button5);
            this.panelHorarios.Controls.Add(this.button4);
            this.panelHorarios.Controls.Add(this.button3);
            this.panelHorarios.Controls.Add(this.button2);
            this.panelHorarios.Controls.Add(this.lblValueFechaBuscada);
            this.panelHorarios.Controls.Add(this.btnAvanzarDia);
            this.panelHorarios.Controls.Add(this.btnRetrocederDia);
            this.panelHorarios.Controls.Add(this.lblFechaBuscada);
            this.panelHorarios.Controls.Add(this.GridHorarios);
            this.panelHorarios.Controls.Add(this.label4);
            this.panelHorarios.Location = new System.Drawing.Point(382, 133);
            this.panelHorarios.Name = "panelHorarios";
            this.panelHorarios.Size = new System.Drawing.Size(467, 401);
            this.panelHorarios.TabIndex = 10;
            this.panelHorarios.Visible = false;
            // 
            // lblValueFechaBuscada
            // 
            this.lblValueFechaBuscada.AutoSize = true;
            this.lblValueFechaBuscada.Location = new System.Drawing.Point(132, 66);
            this.lblValueFechaBuscada.Name = "lblValueFechaBuscada";
            this.lblValueFechaBuscada.Size = new System.Drawing.Size(35, 13);
            this.lblValueFechaBuscada.TabIndex = 5;
            this.lblValueFechaBuscada.Text = "label6";
            this.lblValueFechaBuscada.Visible = false;
            // 
            // btnAvanzarDia
            // 
            this.btnAvanzarDia.Location = new System.Drawing.Point(283, 39);
            this.btnAvanzarDia.Name = "btnAvanzarDia";
            this.btnAvanzarDia.Size = new System.Drawing.Size(44, 23);
            this.btnAvanzarDia.TabIndex = 4;
            this.btnAvanzarDia.Text = ">>";
            this.btnAvanzarDia.UseVisualStyleBackColor = true;
            this.btnAvanzarDia.Click += new System.EventHandler(this.btnAvanzarDia_Click);
            // 
            // btnRetrocederDia
            // 
            this.btnRetrocederDia.Location = new System.Drawing.Point(32, 39);
            this.btnRetrocederDia.Name = "btnRetrocederDia";
            this.btnRetrocederDia.Size = new System.Drawing.Size(44, 23);
            this.btnRetrocederDia.TabIndex = 3;
            this.btnRetrocederDia.Text = "<<";
            this.btnRetrocederDia.UseVisualStyleBackColor = true;
            this.btnRetrocederDia.Click += new System.EventHandler(this.btnRetrocederDia_Click);
            // 
            // lblFechaBuscada
            // 
            this.lblFechaBuscada.AutoSize = true;
            this.lblFechaBuscada.Location = new System.Drawing.Point(129, 44);
            this.lblFechaBuscada.Name = "lblFechaBuscada";
            this.lblFechaBuscada.Size = new System.Drawing.Size(35, 13);
            this.lblFechaBuscada.TabIndex = 2;
            this.lblFechaBuscada.Text = "label6";
            // 
            // GridHorarios
            // 
            this.GridHorarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdTurnoMedico,
            this.HoraInicio,
            this.HoraFin,
            this.Estado});
            this.GridHorarios.Location = new System.Drawing.Point(22, 87);
            this.GridHorarios.Name = "GridHorarios";
            this.GridHorarios.RowHeadersVisible = false;
            this.GridHorarios.Size = new System.Drawing.Size(305, 301);
            this.GridHorarios.TabIndex = 1;
            this.GridHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horarios";
            // 
            // panelDatosMedico
            // 
            this.panelDatosMedico.Controls.Add(this.lblRut);
            this.panelDatosMedico.Controls.Add(this.label15);
            this.panelDatosMedico.Controls.Add(this.lblEspecialidad);
            this.panelDatosMedico.Controls.Add(this.lblApellidoMaterno);
            this.panelDatosMedico.Controls.Add(this.lblApellidoPaterno);
            this.panelDatosMedico.Controls.Add(this.lblNombre);
            this.panelDatosMedico.Controls.Add(this.label10);
            this.panelDatosMedico.Controls.Add(this.label9);
            this.panelDatosMedico.Controls.Add(this.label8);
            this.panelDatosMedico.Controls.Add(this.label7);
            this.panelDatosMedico.Controls.Add(this.label5);
            this.panelDatosMedico.Location = new System.Drawing.Point(3, 267);
            this.panelDatosMedico.Name = "panelDatosMedico";
            this.panelDatosMedico.Size = new System.Drawing.Size(373, 207);
            this.panelDatosMedico.TabIndex = 11;
            this.panelDatosMedico.Visible = false;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(157, 140);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(41, 13);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "label13";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(157, 115);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(41, 13);
            this.lblApellidoMaterno.TabIndex = 7;
            this.lblApellidoMaterno.Text = "label12";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(157, 87);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(41, 13);
            this.lblApellidoPaterno.TabIndex = 6;
            this.lblApellidoPaterno.Text = "label11";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(157, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "label6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Especialidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datos Médico";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Rut";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(157, 35);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(31, 13);
            this.lblRut.TabIndex = 10;
            this.lblRut.Text = "laalal";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Habilitar Todos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Inhabilitar Todos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IdTurnoMedico
            // 
            this.IdTurnoMedico.HeaderText = "IdTurnoMedico";
            this.IdTurnoMedico.Name = "IdTurnoMedico";
            this.IdTurnoMedico.Visible = false;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AdminTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 612);
            this.Controls.Add(this.panelDatosMedico);
            this.Controls.Add(this.panelHorarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuContexto);
            this.Controls.Add(this.panel1);
            this.Name = "AdminTurnos";
            this.Text = "AdminTurnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelHorarios.ResumeLayout(false);
            this.panelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).EndInit();
            this.panelDatosMedico.ResumeLayout(false);
            this.panelDatosMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHorarios;
        private System.Windows.Forms.DataGridView GridHorarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDatosMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaBuscada;
        private System.Windows.Forms.Button btnAvanzarDia;
        private System.Windows.Forms.Button btnRetrocederDia;
        private System.Windows.Forms.Label lblValueFechaBuscada;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTurnoMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewButtonColumn Estado;
    }
}