namespace CentroMedicoHipocrates
{
    partial class ListadoTurnos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.GridTurnos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.txtHoraFin = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuContexto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTurnos)).BeginInit();
            this.panelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContexto
            // 
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(902, 24);
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
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBottom);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(442, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 62);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "button1";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            // GridTurnos
            // 
            this.GridTurnos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridTurnos.AllowUserToAddRows = false;
            this.GridTurnos.AllowUserToResizeColumns = false;
            this.GridTurnos.AllowUserToResizeRows = false;
            this.GridTurnos.BackgroundColor = System.Drawing.Color.Silver;
            this.GridTurnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EstadoId,
            this.HoraInicio,
            this.HoraFin,
            this.Estado});
            this.GridTurnos.Location = new System.Drawing.Point(0, 125);
            this.GridTurnos.MultiSelect = false;
            this.GridTurnos.Name = "GridTurnos";
            this.GridTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTurnos.Size = new System.Drawing.Size(436, 317);
            this.GridTurnos.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // EstadoId
            // 
            this.EstadoId.HeaderText = "EstadoId";
            this.EstadoId.Name = "EstadoId";
            this.EstadoId.Visible = false;
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
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // panelAgregar
            // 
            this.panelAgregar.Controls.Add(this.txtId);
            this.panelAgregar.Controls.Add(this.btnCancelar);
            this.panelAgregar.Controls.Add(this.comboEstados);
            this.panelAgregar.Controls.Add(this.txtHoraFin);
            this.panelAgregar.Controls.Add(this.btnGuardar);
            this.panelAgregar.Controls.Add(this.txtHoraInicio);
            this.panelAgregar.Controls.Add(this.label4);
            this.panelAgregar.Controls.Add(this.label3);
            this.panelAgregar.Controls.Add(this.label2);
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Location = new System.Drawing.Point(442, 133);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(405, 171);
            this.panelAgregar.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(327, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 10;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboEstados
            // 
            this.comboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Location = new System.Drawing.Point(118, 85);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(136, 21);
            this.comboEstados.TabIndex = 8;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.CustomFormat = "HH:mm";
            this.txtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraFin.Location = new System.Drawing.Point(118, 62);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ShowUpDown = true;
            this.txtHoraFin.Size = new System.Drawing.Size(57, 20);
            this.txtHoraFin.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(118, 127);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.CustomFormat = "HH:mm";
            this.txtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraInicio.Location = new System.Drawing.Point(118, 39);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ShowUpDown = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(57, 20);
            this.txtHoraInicio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // ListadoTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.GridTurnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.Name = "ListadoTurnos";
            this.Text = "ListadoTurnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTurnos)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView GridTurnos;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.DateTimePicker txtHoraFin;
        private System.Windows.Forms.DateTimePicker txtHoraInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}