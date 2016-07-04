namespace CentroMedicoHipocrates
{
    partial class ListadoAdministradores
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
            this.GridAdministradores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboComuna = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MenuContexto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdministradores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContexto
            // 
            this.MenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MenuContexto.Location = new System.Drawing.Point(0, 0);
            this.MenuContexto.Name = "MenuContexto";
            this.MenuContexto.Size = new System.Drawing.Size(913, 24);
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
            this.panel1.TabIndex = 10;
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
            // GridAdministradores
            // 
            this.GridAdministradores.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridAdministradores.AllowUserToAddRows = false;
            this.GridAdministradores.BackgroundColor = System.Drawing.Color.Silver;
            this.GridAdministradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdministradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rut,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.FechaNacimiento});
            this.GridAdministradores.Location = new System.Drawing.Point(0, 125);
            this.GridAdministradores.MultiSelect = false;
            this.GridAdministradores.Name = "GridAdministradores";
            this.GridAdministradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAdministradores.Size = new System.Drawing.Size(522, 179);
            this.GridAdministradores.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboComuna);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboProvincia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDireccion);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.comboRegion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateFechaNac);
            this.panel2.Controls.Add(this.txtApellidoMaterno);
            this.panel2.Controls.Add(this.txtApellidoPaterno);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtRut);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(541, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 386);
            this.panel2.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(307, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 22;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // comboRegion
            // 
            this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(157, 224);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(151, 21);
            this.comboRegion.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Region";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(157, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 300);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaNac.Location = new System.Drawing.Point(157, 129);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(128, 20);
            this.dateFechaNac.TabIndex = 10;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(157, 106);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(128, 20);
            this.txtApellidoMaterno.TabIndex = 9;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(157, 83);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(128, 20);
            this.txtApellidoPaterno.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(157, 37);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(128, 20);
            this.txtRut.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Médico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(157, 177);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(128, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(157, 200);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(128, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // comboProvincia
            // 
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(157, 250);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(151, 21);
            this.comboProvincia.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Provincia";
            // 
            // comboComuna
            // 
            this.comboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboComuna.FormattingEnabled = true;
            this.comboComuna.Location = new System.Drawing.Point(157, 274);
            this.comboComuna.Name = "comboComuna";
            this.comboComuna.Size = new System.Drawing.Size(151, 21);
            this.comboComuna.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Comuna";
            // 
            // ListadoAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GridAdministradores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.Name = "ListadoAdministradores";
            this.Text = "ListadoAdministradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdministradores)).EndInit();
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
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView GridAdministradores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFechaNac;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboComuna;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.Label label12;
    }
}