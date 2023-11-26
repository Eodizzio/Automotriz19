namespace Frontend.Presentación.Reportes.MarcasVendidas
{
    partial class FrmReporteMarcas
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
            rvMarcas = new Microsoft.Reporting.WinForms.ReportViewer();
            lblMarca = new Label();
            cboMarca = new ComboBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnBuscar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rvMarcas
            // 
            rvMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvMarcas.Location = new Point(20, 100);
            rvMarcas.Name = "ReportViewer";
            rvMarcas.ServerReport.BearerToken = null;
            rvMarcas.Size = new Size(1010, 933);
            rvMarcas.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(18, 51);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(128, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Seleccione Marca:";
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(152, 48);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(212, 28);
            cboMarca.TabIndex = 2;
            cboMarca.SelectedIndexChanged += cboMarca_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1060, 28);
            menuStrip1.TabIndex = 3;
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(385, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(132, 28);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmReporteMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 1033);
            Controls.Add(btnBuscar);
            Controls.Add(cboMarca);
            Controls.Add(lblMarca);
            Controls.Add(rvMarcas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmReporteMarcas";
            Text = "Reporte Marcas Vendidas";
            Load += FrmReporteMarcas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMarcas;
        private Label lblMarca;
        private ComboBox cboMarca;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnBuscar;
    }
}