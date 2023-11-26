namespace Frontend.Presentación
{
    partial class FrmProductos
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
            dgvProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colOrigen = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colBorrar = new DataGridViewButtonColumn();
            cboTipoProd = new ComboBox();
            cboMarca = new ComboBox();
            lblTipoProd = new Label();
            lblMarcas = new Label();
            cboPais = new ComboBox();
            lblPaises = new Label();
            txtModelos = new TextBox();
            lblModelos = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblColores = new Label();
            cboColores = new ComboBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnInsertar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1150, 30);
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
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colTipo, colMarca, colModelo, colOrigen, colDescripcion, colPrecio, colColor, colBorrar });
            dgvProductos.Location = new Point(14, 247);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(1120, 507);
            dgvProductos.TabIndex = 9;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo de Producto";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            // 
            // colOrigen
            // 
            colOrigen.HeaderText = "Orígen";
            colOrigen.MinimumWidth = 6;
            colOrigen.Name = "colOrigen";
            colOrigen.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colBorrar
            // 
            colBorrar.HeaderText = "Borrar";
            colBorrar.MinimumWidth = 6;
            colBorrar.Name = "colBorrar";
            colBorrar.ReadOnly = true;
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            // 
            // cboTipoProd
            // 
            cboTipoProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProd.FormattingEnabled = true;
            cboTipoProd.Location = new Point(64, 96);
            cboTipoProd.Margin = new Padding(3, 4, 3, 4);
            cboTipoProd.Name = "cboTipoProd";
            cboTipoProd.Size = new Size(250, 28);
            cboTipoProd.TabIndex = 1;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(351, 96);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(250, 28);
            cboMarca.TabIndex = 3;
            // 
            // lblTipoProd
            // 
            lblTipoProd.AutoSize = true;
            lblTipoProd.Location = new Point(66, 72);
            lblTipoProd.Name = "lblTipoProd";
            lblTipoProd.Size = new Size(124, 20);
            lblTipoProd.TabIndex = 4;
            lblTipoProd.Text = "Tipo de Producto";
            // 
            // lblMarcas
            // 
            lblMarcas.AutoSize = true;
            lblMarcas.Location = new Point(349, 72);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(56, 20);
            lblMarcas.TabIndex = 5;
            lblMarcas.Text = "Marcas";
            // 
            // cboPais
            // 
            cboPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(66, 180);
            cboPais.Margin = new Padding(3, 4, 3, 4);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(250, 28);
            cboPais.TabIndex = 2;
            // 
            // lblPaises
            // 
            lblPaises.AutoSize = true;
            lblPaises.Location = new Point(66, 156);
            lblPaises.Name = "lblPaises";
            lblPaises.Size = new Size(48, 20);
            lblPaises.TabIndex = 7;
            lblPaises.Text = "Paises";
            // 
            // txtModelos
            // 
            txtModelos.Location = new Point(349, 180);
            txtModelos.Margin = new Padding(3, 4, 3, 4);
            txtModelos.Name = "txtModelos";
            txtModelos.Size = new Size(250, 27);
            txtModelos.TabIndex = 4;
            // 
            // lblModelos
            // 
            lblModelos.AutoSize = true;
            lblModelos.Location = new Point(349, 156);
            lblModelos.Name = "lblModelos";
            lblModelos.Size = new Size(67, 20);
            lblModelos.TabIndex = 9;
            lblModelos.Text = "Modelos";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(631, 72);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(631, 96);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // lblColores
            // 
            lblColores.AutoSize = true;
            lblColores.Location = new Point(631, 156);
            lblColores.Name = "lblColores";
            lblColores.Size = new Size(59, 20);
            lblColores.TabIndex = 13;
            lblColores.Text = "Colores";
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(631, 180);
            cboColores.Margin = new Padding(3, 4, 3, 4);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(250, 28);
            cboColores.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(927, 72);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(107, 20);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(927, 96);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(163, 27);
            txtPrecio.TabIndex = 7;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(927, 179);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(163, 31);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 769);
            Controls.Add(btnInsertar);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblColores);
            Controls.Add(cboColores);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblModelos);
            Controls.Add(txtModelos);
            Controls.Add(lblPaises);
            Controls.Add(cboPais);
            Controls.Add(lblMarcas);
            Controls.Add(lblTipoProd);
            Controls.Add(cboMarca);
            Controls.Add(cboTipoProd);
            Controls.Add(dgvProductos);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgvProductos;
        private ComboBox cboTipoProd;
        private ComboBox cboMarca;
        private Label lblTipoProd;
        private Label lblMarcas;
        private ComboBox cboPais;
        private Label lblPaises;
        private TextBox txtModelos;
        private Label lblModelos;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblColores;
        private ComboBox cboColores;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnInsertar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colOrigen;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewButtonColumn colBorrar;
    }
}