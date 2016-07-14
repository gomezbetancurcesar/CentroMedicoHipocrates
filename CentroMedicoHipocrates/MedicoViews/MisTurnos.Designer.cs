namespace CentroMedicoHipocrates
{
    partial class MisTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateBuscar = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelHorarios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValueFechaBuscada = new System.Windows.Forms.Label();
            this.btnAvanzarDia = new System.Windows.Forms.Button();
            this.btnRetrocederDia = new System.Windows.Forms.Button();
            this.lblFechaBuscada = new System.Windows.Forms.Label();
            this.GridHorarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bloquear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelReservas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuContexto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContexto
            // 
            this.MenuContexto.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(847, 24);
            this.MenuContexto.TabIndex = 9;
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
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBottom);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha";
            // 
            // dateBuscar
            // 
            this.dateBuscar.CustomFormat = "dd-MM-yyyy";
            this.dateBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBuscar.Location = new System.Drawing.Point(84, 39);
            this.dateBuscar.Name = "dateBuscar";
            this.dateBuscar.Size = new System.Drawing.Size(200, 20);
            this.dateBuscar.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(84, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelHorarios
            // 
            this.panelHorarios.Controls.Add(this.label3);
            this.panelHorarios.Controls.Add(this.btnCancelar);
            this.panelHorarios.Controls.Add(this.lblValueFechaBuscada);
            this.panelHorarios.Controls.Add(this.btnAvanzarDia);
            this.panelHorarios.Controls.Add(this.btnRetrocederDia);
            this.panelHorarios.Controls.Add(this.lblFechaBuscada);
            this.panelHorarios.Controls.Add(this.GridHorarios);
            this.panelHorarios.Location = new System.Drawing.Point(0, 264);
            this.panelHorarios.Name = "panelHorarios";
            this.panelHorarios.Size = new System.Drawing.Size(445, 389);
            this.panelHorarios.TabIndex = 14;
            this.panelHorarios.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Horarios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(356, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblValueFechaBuscada
            // 
            this.lblValueFechaBuscada.AutoSize = true;
            this.lblValueFechaBuscada.Location = new System.Drawing.Point(132, 88);
            this.lblValueFechaBuscada.Name = "lblValueFechaBuscada";
            this.lblValueFechaBuscada.Size = new System.Drawing.Size(35, 13);
            this.lblValueFechaBuscada.TabIndex = 5;
            this.lblValueFechaBuscada.Text = "label6";
            this.lblValueFechaBuscada.Visible = false;
            // 
            // btnAvanzarDia
            // 
            this.btnAvanzarDia.Location = new System.Drawing.Point(283, 61);
            this.btnAvanzarDia.Name = "btnAvanzarDia";
            this.btnAvanzarDia.Size = new System.Drawing.Size(44, 23);
            this.btnAvanzarDia.TabIndex = 4;
            this.btnAvanzarDia.Text = ">>";
            this.btnAvanzarDia.UseVisualStyleBackColor = true;
            this.btnAvanzarDia.Click += new System.EventHandler(this.btnAvanzarDia_Click);
            // 
            // btnRetrocederDia
            // 
            this.btnRetrocederDia.Location = new System.Drawing.Point(32, 61);
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
            this.lblFechaBuscada.Location = new System.Drawing.Point(129, 66);
            this.lblFechaBuscada.Name = "lblFechaBuscada";
            this.lblFechaBuscada.Size = new System.Drawing.Size(35, 13);
            this.lblFechaBuscada.TabIndex = 2;
            this.lblFechaBuscada.Text = "label6";
            // 
            // GridHorarios
            // 
            this.GridHorarios.AllowUserToAddRows = false;
            this.GridHorarios.BackgroundColor = System.Drawing.Color.White;
            this.GridHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdAgenda,
            this.HoraInicio,
            this.HoraFin,
            this.Estado,
            this.Bloquear});
            this.GridHorarios.Location = new System.Drawing.Point(22, 109);
            this.GridHorarios.Name = "GridHorarios";
            this.GridHorarios.ReadOnly = true;
            this.GridHorarios.RowHeadersVisible = false;
            this.GridHorarios.Size = new System.Drawing.Size(409, 301);
            this.GridHorarios.TabIndex = 1;
            this.GridHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHorarios_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdAgenda
            // 
            this.IdAgenda.HeaderText = "IdAgenda";
            this.IdAgenda.Name = "IdAgenda";
            this.IdAgenda.ReadOnly = true;
            this.IdAgenda.Visible = false;
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
            // Bloquear
            // 
            this.Bloquear.HeaderText = "Bloquear";
            this.Bloquear.Name = "Bloquear";
            this.Bloquear.ReadOnly = true;
            this.Bloquear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bloquear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelReservas
            // 
            this.panelReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReservas.Location = new System.Drawing.Point(451, 143);
            this.panelReservas.Name = "panelReservas";
            this.panelReservas.Size = new System.Drawing.Size(336, 510);
            this.panelReservas.TabIndex = 15;
            this.panelReservas.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateBuscar);
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 114);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscador";
            // 
            // MisTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelReservas);
            this.Controls.Add(this.panelHorarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MisTurnos";
            this.Text = "MisTurnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHorarios.ResumeLayout(false);
            this.panelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHorarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelHorarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValueFechaBuscada;
        private System.Windows.Forms.Button btnAvanzarDia;
        private System.Windows.Forms.Button btnRetrocederDia;
        private System.Windows.Forms.Label lblFechaBuscada;
        private System.Windows.Forms.DataGridView GridHorarios;
        private System.Windows.Forms.Panel panelReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewButtonColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Bloquear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}