namespace CentroMedicoHipocrates
{
    partial class ListadoEnfermedades
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
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.isEdit = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.GridEnfermedades = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.MenuContexto.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnfermedades)).BeginInit();
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
            this.panel1.TabIndex = 13;
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
            this.MenuContexto.Size = new System.Drawing.Size(874, 24);
            this.MenuContexto.TabIndex = 12;
            this.MenuContexto.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Controls.Add(this.isEdit);
            this.panelAgregar.Controls.Add(this.txtId);
            this.panelAgregar.Controls.Add(this.label2);
            this.panelAgregar.Controls.Add(this.btnCancelar);
            this.panelAgregar.Controls.Add(this.btnAgregar);
            this.panelAgregar.Controls.Add(this.txtNombre);
            this.panelAgregar.Controls.Add(this.lblNombre);
            this.panelAgregar.Location = new System.Drawing.Point(488, 130);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(374, 133);
            this.panelAgregar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos";
            // 
            // isEdit
            // 
            this.isEdit.AutoSize = true;
            this.isEdit.Location = new System.Drawing.Point(32, 82);
            this.isEdit.Name = "isEdit";
            this.isEdit.Size = new System.Drawing.Size(13, 13);
            this.isEdit.TabIndex = 8;
            this.isEdit.Text = "0";
            this.isEdit.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(235, 20);
            this.txtId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(96, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // GridEnfermedades
            // 
            this.GridEnfermedades.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GridEnfermedades.AllowUserToAddRows = false;
            this.GridEnfermedades.BackgroundColor = System.Drawing.Color.White;
            this.GridEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEnfermedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            this.GridEnfermedades.Location = new System.Drawing.Point(0, 130);
            this.GridEnfermedades.MultiSelect = false;
            this.GridEnfermedades.Name = "GridEnfermedades";
            this.GridEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEnfermedades.Size = new System.Drawing.Size(482, 308);
            this.GridEnfermedades.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 250;
            // 
            // ListadoEnfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 516);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.GridEnfermedades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuContexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoEnfermedades";
            this.Text = "ListadoEnfermedades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuContexto.ResumeLayout(false);
            this.MenuContexto.PerformLayout();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnfermedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.MenuStrip MenuContexto;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView GridEnfermedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label isEdit;
        private System.Windows.Forms.Label label1;
    }
}