namespace Frontend.Presentación.Reportes.FacturaTipoCli
{
    partial class FrmReporteTPCli
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
            rvTipoCli = new Microsoft.Reporting.WinForms.ReportViewer();
            rbtEmpresa = new RadioButton();
            rbtConsFinal = new RadioButton();
            btnBuscar = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rvTipoCli
            // 
            rvTipoCli.Location = new Point(20, 100);
            rvTipoCli.Name = "ReportViewer";
            rvTipoCli.ServerReport.BearerToken = null;
            rvTipoCli.Size = new Size(1100, 933);
            rvTipoCli.TabIndex = 0;
            // 
            // rbtEmpresa
            // 
            rbtEmpresa.AutoSize = true;
            rbtEmpresa.Location = new Point(497, 53);
            rbtEmpresa.Name = "rbtEmpresa";
            rbtEmpresa.Size = new Size(87, 24);
            rbtEmpresa.TabIndex = 1;
            rbtEmpresa.TabStop = true;
            rbtEmpresa.Text = "Empresa";
            rbtEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbtConsFinal
            // 
            rbtConsFinal.AutoSize = true;
            rbtConsFinal.Location = new Point(302, 53);
            rbtConsFinal.Name = "rbtConsFinal";
            rbtConsFinal.Size = new Size(145, 24);
            rbtConsFinal.TabIndex = 2;
            rbtConsFinal.TabStop = true;
            rbtConsFinal.Text = "Consumidor Final";
            rbtConsFinal.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(630, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(133, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1140, 28);
            menuStrip1.TabIndex = 4;
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
            // FrmReporteTPCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 986);
            Controls.Add(btnBuscar);
            Controls.Add(rbtConsFinal);
            Controls.Add(rbtEmpresa);
            Controls.Add(rvTipoCli);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmReporteTPCli";
            Text = "FrmReporteTPCli";
            Load += FrmReporteTPCli_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTipoCli;
        private RadioButton rbtEmpresa;
        private RadioButton rbtConsFinal;
        private Button btnBuscar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}