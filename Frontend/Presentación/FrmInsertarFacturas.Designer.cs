namespace Frontend.Presentación
{
    partial class FrmInsertarFacturas
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
            dgvDetallesFacturas = new DataGridView();
            colIDProducto = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            cboProductos = new ComboBox();
            lblProductos = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            cboCliente = new ComboBox();
            lblCliente = new Label();
            cboFormaPago = new ComboBox();
            lblFormaPago = new Label();
            btnGenerar = new Button();
            btnCancelar = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnAgregar = new Button();
            txtTotal = new TextBox();
            lblTotalFac = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFacturas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDetallesFacturas
            // 
            dgvDetallesFacturas.AllowUserToAddRows = false;
            dgvDetallesFacturas.AllowUserToDeleteRows = false;
            dgvDetallesFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesFacturas.Columns.AddRange(new DataGridViewColumn[] { colIDProducto, colMarca, colModelo, colColor, colCantidad, colPrecio, colTotal });
            dgvDetallesFacturas.Location = new Point(14, 372);
            dgvDetallesFacturas.Margin = new Padding(3, 4, 3, 4);
            dgvDetallesFacturas.Name = "dgvDetallesFacturas";
            dgvDetallesFacturas.ReadOnly = true;
            dgvDetallesFacturas.RowHeadersWidth = 51;
            dgvDetallesFacturas.RowTemplate.Height = 25;
            dgvDetallesFacturas.Size = new Size(1107, 351);
            dgvDetallesFacturas.TabIndex = 0;
            // 
            // colIDProducto
            // 
            colIDProducto.HeaderText = "ID";
            colIDProducto.MinimumWidth = 6;
            colIDProducto.Name = "colIDProducto";
            colIDProducto.ReadOnly = true;
            colIDProducto.Visible = false;
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
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(14, 333);
            cboProductos.Margin = new Padding(3, 4, 3, 4);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(247, 28);
            cboProductos.TabIndex = 3;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(14, 309);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(78, 20);
            lblProductos.TabIndex = 2;
            lblProductos.Text = "Productos:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(269, 333);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(66, 27);
            txtCantidad.TabIndex = 4;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(269, 309);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(807, 333);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(157, 27);
            txtPrecio.TabIndex = 5;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(807, 309);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(893, 53);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 27);
            dtpFecha.TabIndex = 9;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(839, 61);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(14, 131);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(321, 28);
            cboCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(14, 107);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(14, 207);
            cboFormaPago.Margin = new Padding(3, 4, 3, 4);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(321, 28);
            cboFormaPago.TabIndex = 2;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(14, 183);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(112, 20);
            lblFormaPago.TabIndex = 14;
            lblFormaPago.Text = "Forma de Pago:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(590, 789);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(147, 31);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(383, 789);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1135, 30);
            menuStrip1.TabIndex = 15;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(971, 332);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(147, 31);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(1005, 731);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(114, 27);
            txtTotal.TabIndex = 17;
            // 
            // lblTotalFac
            // 
            lblTotalFac.AutoSize = true;
            lblTotalFac.Location = new Point(909, 735);
            lblTotalFac.Name = "lblTotalFac";
            lblTotalFac.Size = new Size(96, 20);
            lblTotalFac.TabIndex = 18;
            lblTotalFac.Text = "Total Factura:";
            // 
            // FrmInsertarFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 836);
            Controls.Add(lblTotalFac);
            Controls.Add(txtTotal);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenerar);
            Controls.Add(lblFormaPago);
            Controls.Add(cboFormaPago);
            Controls.Add(lblCliente);
            Controls.Add(cboCliente);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblProductos);
            Controls.Add(cboProductos);
            Controls.Add(dgvDetallesFacturas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmInsertarFacturas";
            Text = "Insertar Facturas";
            Load += FrmInsertarFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesFacturas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetallesFacturas;
        private ComboBox cboProductos;
        private Label lblProductos;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private ComboBox cboCliente;
        private Label lblCliente;
        private ComboBox cboFormaPago;
        private Label lblFormaPago;
        private Button btnGenerar;
        private Button btnCancelar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn colIDProducto;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colTotal;
        private TextBox txtTotal;
        private Label lblTotalFac;
    }
}