namespace Frontend.Presentación
{
    partial class FrmClientesCRUD
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgvClientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoCliente = new DataGridViewTextBoxColumn();
            colTipoIden = new DataGridViewTextBoxColumn();
            colIdentificacion = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colBarrio = new DataGridViewTextBoxColumn();
            BtnModificar = new DataGridViewButtonColumn();
            btnBorrar = new DataGridViewButtonColumn();
            cboTipoCliente = new ComboBox();
            lblTipoCliente = new Label();
            lblTipoIden = new Label();
            cboTipoIden = new ComboBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblBarrio = new Label();
            cboBarrio = new ComboBox();
            lblIdentificación = new Label();
            txtIden = new TextBox();
            gpbModificar = new GroupBox();
            btnInsertar = new Button();
            cbxNuevoCliente = new CheckBox();
            lblNuevo = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gpbModificar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1232, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colTipoCliente, colTipoIden, colIdentificacion, colDireccion, colBarrio, BtnModificar, btnBorrar });
            dgvClientes.Location = new Point(30, 291);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(1179, 377);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 125;
            // 
            // colTipoCliente
            // 
            colTipoCliente.HeaderText = "Tipo de Cliente";
            colTipoCliente.MinimumWidth = 6;
            colTipoCliente.Name = "colTipoCliente";
            colTipoCliente.ReadOnly = true;
            colTipoCliente.Width = 125;
            // 
            // colTipoIden
            // 
            colTipoIden.HeaderText = "Tipo de Identificación";
            colTipoIden.MinimumWidth = 6;
            colTipoIden.Name = "colTipoIden";
            colTipoIden.ReadOnly = true;
            colTipoIden.Width = 125;
            // 
            // colIdentificacion
            // 
            colIdentificacion.HeaderText = "Identificación";
            colIdentificacion.MinimumWidth = 6;
            colIdentificacion.Name = "colIdentificacion";
            colIdentificacion.ReadOnly = true;
            colIdentificacion.Width = 125;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 125;
            // 
            // colBarrio
            // 
            colBarrio.HeaderText = "Barrio";
            colBarrio.MinimumWidth = 6;
            colBarrio.Name = "colBarrio";
            colBarrio.ReadOnly = true;
            colBarrio.Width = 125;
            // 
            // BtnModificar
            // 
            BtnModificar.HeaderText = "Modificar";
            BtnModificar.MinimumWidth = 6;
            BtnModificar.Name = "BtnModificar";
            BtnModificar.ReadOnly = true;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseColumnTextForButtonValue = true;
            BtnModificar.Width = 125;
            // 
            // btnBorrar
            // 
            btnBorrar.HeaderText = "Borrar";
            btnBorrar.MinimumWidth = 6;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.ReadOnly = true;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;
            btnBorrar.Width = 125;
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(31, 140);
            cboTipoCliente.Margin = new Padding(3, 4, 3, 4);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(246, 28);
            cboTipoCliente.TabIndex = 2;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(31, 116);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(110, 20);
            lblTipoCliente.TabIndex = 3;
            lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // lblTipoIden
            // 
            lblTipoIden.AutoSize = true;
            lblTipoIden.Location = new Point(361, 43);
            lblTipoIden.Name = "lblTipoIden";
            lblTipoIden.Size = new Size(154, 20);
            lblTipoIden.TabIndex = 5;
            lblTipoIden.Text = "Tipo de Identificación";
            // 
            // cboTipoIden
            // 
            cboTipoIden.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoIden.FormattingEnabled = true;
            cboTipoIden.Location = new Point(361, 67);
            cboTipoIden.Margin = new Padding(3, 4, 3, 4);
            cboTipoIden.Name = "cboTipoIden";
            cboTipoIden.Size = new Size(246, 28);
            cboTipoIden.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 67);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(155, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre/Razón Social";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(677, 43);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(677, 67);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(246, 27);
            txtDireccion.TabIndex = 8;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(677, 116);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(49, 20);
            lblBarrio.TabIndex = 11;
            lblBarrio.Text = "Barrio";
            // 
            // cboBarrio
            // 
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(677, 140);
            cboBarrio.Margin = new Padding(3, 4, 3, 4);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(246, 28);
            cboBarrio.TabIndex = 10;
            // 
            // lblIdentificación
            // 
            lblIdentificación.AutoSize = true;
            lblIdentificación.Location = new Point(361, 116);
            lblIdentificación.Name = "lblIdentificación";
            lblIdentificación.Size = new Size(99, 20);
            lblIdentificación.TabIndex = 13;
            lblIdentificación.Text = "Identificación";
            // 
            // txtIden
            // 
            txtIden.Location = new Point(361, 140);
            txtIden.Margin = new Padding(3, 4, 3, 4);
            txtIden.Name = "txtIden";
            txtIden.Size = new Size(246, 27);
            txtIden.TabIndex = 14;
            txtIden.KeyPress += txtIden_KeyPress;
            // 
            // gpbModificar
            // 
            gpbModificar.Controls.Add(btnInsertar);
            gpbModificar.Controls.Add(cbxNuevoCliente);
            gpbModificar.Controls.Add(lblNuevo);
            gpbModificar.Controls.Add(txtNombre);
            gpbModificar.Controls.Add(txtIden);
            gpbModificar.Controls.Add(cboTipoCliente);
            gpbModificar.Controls.Add(lblIdentificación);
            gpbModificar.Controls.Add(lblTipoCliente);
            gpbModificar.Controls.Add(lblBarrio);
            gpbModificar.Controls.Add(cboTipoIden);
            gpbModificar.Controls.Add(cboBarrio);
            gpbModificar.Controls.Add(lblTipoIden);
            gpbModificar.Controls.Add(lblDireccion);
            gpbModificar.Controls.Add(lblNombre);
            gpbModificar.Controls.Add(txtDireccion);
            gpbModificar.Location = new Point(30, 56);
            gpbModificar.Margin = new Padding(3, 4, 3, 4);
            gpbModificar.Name = "gpbModificar";
            gpbModificar.Padding = new Padding(3, 4, 3, 4);
            gpbModificar.Size = new Size(1179, 203);
            gpbModificar.TabIndex = 15;
            gpbModificar.TabStop = false;
            gpbModificar.Text = "Datos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1002, 139);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(158, 31);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // cbxNuevoCliente
            // 
            cbxNuevoCliente.AutoSize = true;
            cbxNuevoCliente.Location = new Point(1125, 95);
            cbxNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            cbxNuevoCliente.Name = "cbxNuevoCliente";
            cbxNuevoCliente.Size = new Size(18, 17);
            cbxNuevoCliente.TabIndex = 11;
            cbxNuevoCliente.UseVisualStyleBackColor = true;
            cbxNuevoCliente.CheckedChanged += cbxNuevoCliente_CheckedChanged;
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(1024, 95);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(105, 20);
            lblNuevo.TabIndex = 15;
            lblNuevo.Text = "Nuevo Cliente:";
            // 
            // FrmClientesCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 696);
            Controls.Add(gpbModificar);
            Controls.Add(dgvClientes);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientesCRUD";
            Text = "Clientes";
            Load += FrmClientesCRUD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gpbModificar.ResumeLayout(false);
            gpbModificar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgvClientes;
        private ComboBox cboTipoCliente;
        private Label lblTipoCliente;
        private Label lblTipoIden;
        private ComboBox cboTipoIden;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblBarrio;
        private ComboBox cboBarrio;
        private Label lblIdentificación;
        private TextBox txtIden;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipoCliente;
        private DataGridViewTextBoxColumn colTipoIden;
        private DataGridViewTextBoxColumn colIdentificacion;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colBarrio;
        private DataGridViewButtonColumn BtnModificar;
        private DataGridViewButtonColumn btnBorrar;
        private GroupBox gpbModificar;
        private Button btnInsertar;
        private CheckBox cbxNuevoCliente;
        private Label lblNuevo;
    }
}