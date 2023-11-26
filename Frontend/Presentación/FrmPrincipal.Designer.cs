namespace Frontend.Presentación
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            submenuReportes = new Panel();
            panel8 = new Panel();
            btnFFechas = new Button();
            panel6 = new Panel();
            btnMVendidas = new Button();
            panel7 = new Panel();
            btnFTICli = new Button();
            panel5 = new Panel();
            btnInfo = new Button();
            panel4 = new Panel();
            btnReportes = new Button();
            panel3 = new Panel();
            btnTransacciones = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClientes = new Button();
            btnProductos = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            submenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1486, 51);
            BarraTitulo.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1394, 9);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(29, 33);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1343, 9);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 33);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1394, 9);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(29, 33);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1443, 9);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 33);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(submenuReportes);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btnInfo);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnReportes);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnTransacciones);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 51);
            MenuVertical.Margin = new Padding(3, 4, 3, 4);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(251, 816);
            MenuVertical.TabIndex = 1;
            // 
            // submenuReportes
            // 
            submenuReportes.Controls.Add(panel8);
            submenuReportes.Controls.Add(btnFFechas);
            submenuReportes.Controls.Add(panel6);
            submenuReportes.Controls.Add(btnMVendidas);
            submenuReportes.Controls.Add(panel7);
            submenuReportes.Controls.Add(btnFTICli);
            submenuReportes.Location = new Point(43, 522);
            submenuReportes.Name = "submenuReportes";
            submenuReportes.Size = new Size(211, 139);
            submenuReportes.TabIndex = 11;
            submenuReportes.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(3, 101);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 28);
            panel8.TabIndex = 14;
            // 
            // btnFFechas
            // 
            btnFFechas.BackColor = Color.FromArgb(26, 32, 40);
            btnFFechas.FlatAppearance.BorderSize = 0;
            btnFFechas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFFechas.FlatStyle = FlatStyle.Flat;
            btnFFechas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFFechas.ForeColor = Color.White;
            btnFFechas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFFechas.Location = new Point(7, 101);
            btnFFechas.Margin = new Padding(3, 4, 3, 4);
            btnFFechas.Name = "btnFFechas";
            btnFFechas.Size = new Size(207, 28);
            btnFFechas.TabIndex = 13;
            btnFFechas.Text = "Facturas por Fecha";
            btnFFechas.UseVisualStyleBackColor = false;
            btnFFechas.Click += btnFFechas_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(3, 7);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 28);
            panel6.TabIndex = 10;
            // 
            // btnMVendidas
            // 
            btnMVendidas.BackColor = Color.FromArgb(26, 32, 40);
            btnMVendidas.FlatAppearance.BorderSize = 0;
            btnMVendidas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnMVendidas.FlatStyle = FlatStyle.Flat;
            btnMVendidas.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMVendidas.ForeColor = Color.White;
            btnMVendidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMVendidas.Location = new Point(7, 7);
            btnMVendidas.Margin = new Padding(3, 4, 3, 4);
            btnMVendidas.Name = "btnMVendidas";
            btnMVendidas.Size = new Size(207, 28);
            btnMVendidas.TabIndex = 9;
            btnMVendidas.Text = "Marcas Vendidas";
            btnMVendidas.UseVisualStyleBackColor = false;
            btnMVendidas.Click += btnMVendidas_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 80, 200);
            panel7.Location = new Point(3, 54);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 28);
            panel7.TabIndex = 12;
            // 
            // btnFTICli
            // 
            btnFTICli.BackColor = Color.FromArgb(26, 32, 40);
            btnFTICli.FlatAppearance.BorderSize = 0;
            btnFTICli.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnFTICli.FlatStyle = FlatStyle.Flat;
            btnFTICli.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFTICli.ForeColor = Color.White;
            btnFTICli.ImageAlign = ContentAlignment.MiddleLeft;
            btnFTICli.Location = new Point(7, 54);
            btnFTICli.Margin = new Padding(3, 4, 3, 4);
            btnFTICli.Name = "btnFTICli";
            btnFTICli.Size = new Size(207, 28);
            btnFTICli.TabIndex = 11;
            btnFTICli.Text = "Facturas Tipo Cliente";
            btnFTICli.UseVisualStyleBackColor = false;
            btnFTICli.Click += btnFTICli_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(1, 694);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(6, 43);
            panel5.TabIndex = 10;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(26, 32, 40);
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.White;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(5, 694);
            btnInfo.Margin = new Padding(3, 4, 3, 4);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(247, 43);
            btnInfo.TabIndex = 9;
            btnInfo.Text = "Acerca de";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(1, 478);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 43);
            panel4.TabIndex = 8;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(26, 32, 40);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(5, 478);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(247, 43);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(1, 381);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 43);
            panel3.TabIndex = 6;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.FromArgb(26, 32, 40);
            btnTransacciones.FlatAppearance.BorderSize = 0;
            btnTransacciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnTransacciones.FlatStyle = FlatStyle.Flat;
            btnTransacciones.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransacciones.ForeColor = Color.White;
            btnTransacciones.Image = (Image)resources.GetObject("btnTransacciones.Image");
            btnTransacciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransacciones.Location = new Point(4, 381);
            btnTransacciones.Margin = new Padding(3, 4, 3, 4);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(247, 43);
            btnTransacciones.TabIndex = 5;
            btnTransacciones.Text = "Transacciones";
            btnTransacciones.UseVisualStyleBackColor = false;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(1, 298);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 43);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(1, 213);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 43);
            panel1.TabIndex = 2;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(5, 298);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(247, 43);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(26, 32, 40);
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(5, 213);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(247, 43);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(251, 51);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1235, 816);
            panelContenedor.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 867);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            submenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox pictureBox1;
        private Button btnProductos;
        private Panel panel1;
        private Panel panel5;
        private Button btnInfo;
        private Panel panel4;
        private Button btnReportes;
        private Panel panel3;
        private Button btnTransacciones;
        private Panel panel2;
        private Button btnClientes;
        private Panel panel6;
        private Button btnMVendidas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel submenuReportes;
        private Panel panel7;
        private Button btnFTICli;
        private Panel panel8;
        private Button btnFFechas;
    }
}