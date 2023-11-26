namespace Frontend.Presentación.Reportes.FacturasFechas
{
    partial class FrmFacturasFechas
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
            rvFechas = new Microsoft.Reporting.WinForms.ReportViewer();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            btnBuscar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rvFechas
            // 
            rvFechas.Location = new Point(16, 100);
            rvFechas.Name = "ReportViewer";
            rvFechas.ServerReport.BearerToken = null;
            rvFechas.Size = new Size(1010, 933);
            rvFechas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1042, 28);
            menuStrip1.TabIndex = 1;
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
            // dtpDesde
            // 
            dtpDesde.Location = new Point(164, 60);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 2;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(463, 60);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 3;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(229, 39);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(96, 20);
            lblFechaDesde.TabIndex = 4;
            lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(546, 39);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(92, 20);
            lblFechaHasta.TabIndex = 5;
            lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(754, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 27);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmFacturasFechas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 986);
            Controls.Add(btnBuscar);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(rvFechas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmFacturasFechas";
            Text = "Facturas por Fecha";
            Load += FrmFacturasFechas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFechas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private Button btnBuscar;
    }
}