namespace CentroMedicoHipocrates
{
    partial class AgendaDiaria
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
            this.MenuContexto = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridHorarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDatosPaciente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsapre = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFicha = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFichaId = new System.Windows.Forms.Label();
            this.txtReservaId = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTratamientos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MenuContexto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).BeginInit();
            this.panelDatosPaciente.SuspendLayout();
            this.panelFicha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBottom);
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
            // MenuContexto
            // 
            this.MenuContexto.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(980, 24);
            this.MenuContexto.TabIndex = 11;
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
            this.panel2.Controls.Add(this.GridHorarios);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 392);
            this.panel2.TabIndex = 13;
            // 
            // GridHorarios
            // 
            this.GridHorarios.AllowUserToAddRows = false;
            this.GridHorarios.BackgroundColor = System.Drawing.Color.White;
            this.GridHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdReserva,
            this.HoraInicio,
            this.HoraFin,
            this.Paciente,
            this.Tipo,
            this.Estado});
            this.GridHorarios.Location = new System.Drawing.Point(3, 3);
            this.GridHorarios.Name = "GridHorarios";
            this.GridHorarios.ReadOnly = true;
            this.GridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHorarios.Size = new System.Drawing.Size(564, 378);
            this.GridHorarios.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdReserva
            // 
            this.IdReserva.HeaderText = "IdReserva";
            this.IdReserva.Name = "IdReserva";
            this.IdReserva.ReadOnly = true;
            this.IdReserva.Visible = false;
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
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // panelDatosPaciente
            // 
            this.panelDatosPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelDatosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosPaciente.Controls.Add(this.label1);
            this.panelDatosPaciente.Controls.Add(this.txtIsapre);
            this.panelDatosPaciente.Controls.Add(this.txtFechaNacimiento);
            this.panelDatosPaciente.Controls.Add(this.txtGenero);
            this.panelDatosPaciente.Controls.Add(this.txtNombre);
            this.panelDatosPaciente.Controls.Add(this.txtRut);
            this.panelDatosPaciente.Controls.Add(this.label6);
            this.panelDatosPaciente.Controls.Add(this.label5);
            this.panelDatosPaciente.Controls.Add(this.label4);
            this.panelDatosPaciente.Controls.Add(this.label3);
            this.panelDatosPaciente.Controls.Add(this.label2);
            this.panelDatosPaciente.Location = new System.Drawing.Point(586, 136);
            this.panelDatosPaciente.Name = "panelDatosPaciente";
            this.panelDatosPaciente.Size = new System.Drawing.Size(394, 166);
            this.panelDatosPaciente.TabIndex = 14;
            this.panelDatosPaciente.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datos";
            // 
            // txtIsapre
            // 
            this.txtIsapre.AutoSize = true;
            this.txtIsapre.Location = new System.Drawing.Point(141, 132);
            this.txtIsapre.Name = "txtIsapre";
            this.txtIsapre.Size = new System.Drawing.Size(41, 13);
            this.txtIsapre.TabIndex = 12;
            this.txtIsapre.Text = "label14";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSize = true;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(141, 108);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(41, 13);
            this.txtFechaNacimiento.TabIndex = 11;
            this.txtFechaNacimiento.Text = "label13";
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.Location = new System.Drawing.Point(141, 84);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(41, 13);
            this.txtGenero.TabIndex = 10;
            this.txtGenero.Text = "label12";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(141, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(41, 13);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "label11";
            // 
            // txtRut
            // 
            this.txtRut.AutoSize = true;
            this.txtRut.Location = new System.Drawing.Point(141, 37);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(41, 13);
            this.txtRut.TabIndex = 8;
            this.txtRut.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Isapre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rut";
            // 
            // panelFicha
            // 
            this.panelFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFicha.Controls.Add(this.btnCancelar);
            this.panelFicha.Controls.Add(this.btnGuardar);
            this.panelFicha.Controls.Add(this.txtFichaId);
            this.panelFicha.Controls.Add(this.txtReservaId);
            this.panelFicha.Controls.Add(this.txtObservaciones);
            this.panelFicha.Controls.Add(this.txtTratamientos);
            this.panelFicha.Controls.Add(this.label9);
            this.panelFicha.Controls.Add(this.label8);
            this.panelFicha.Controls.Add(this.label7);
            this.panelFicha.Location = new System.Drawing.Point(586, 309);
            this.panelFicha.Name = "panelFicha";
            this.panelFicha.Size = new System.Drawing.Size(394, 257);
            this.panelFicha.TabIndex = 15;
            this.panelFicha.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(32, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Atendido";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFichaId
            // 
            this.txtFichaId.AutoSize = true;
            this.txtFichaId.Location = new System.Drawing.Point(369, 11);
            this.txtFichaId.Name = "txtFichaId";
            this.txtFichaId.Size = new System.Drawing.Size(13, 13);
            this.txtFichaId.TabIndex = 13;
            this.txtFichaId.Text = "0";
            this.txtFichaId.Visible = false;
            // 
            // txtReservaId
            // 
            this.txtReservaId.AutoSize = true;
            this.txtReservaId.Location = new System.Drawing.Point(350, 11);
            this.txtReservaId.Name = "txtReservaId";
            this.txtReservaId.Size = new System.Drawing.Size(13, 13);
            this.txtReservaId.TabIndex = 12;
            this.txtReservaId.Text = "0";
            this.txtReservaId.Visible = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(32, 140);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(350, 64);
            this.txtObservaciones.TabIndex = 11;
            // 
            // txtTratamientos
            // 
            this.txtTratamientos.Location = new System.Drawing.Point(32, 46);
            this.txtTratamientos.Multiline = true;
            this.txtTratamientos.Name = "txtTratamientos";
            this.txtTratamientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTratamientos.Size = new System.Drawing.Size(350, 64);
            this.txtTratamientos.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Observaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tratamientos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datos Ficha";
            // 
            // AgendaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 597);
            this.Controls.Add(this.panelFicha);
            this.Controls.Add(this.panelDatosPaciente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgendaDiaria";
            this.Text = "AgendaDiaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).EndInit();
            this.panelDatosPaciente.ResumeLayout(false);
            this.panelDatosPaciente.PerformLayout();
            this.panelFicha.ResumeLayout(false);
            this.panelFicha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridHorarios;
        private System.Windows.Forms.Panel panelDatosPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFicha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtTratamientos;
        private System.Windows.Forms.Label txtIsapre;
        private System.Windows.Forms.Label txtFechaNacimiento;
        private System.Windows.Forms.Label txtGenero;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtRut;
        private System.Windows.Forms.Label txtReservaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label txtFichaId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}