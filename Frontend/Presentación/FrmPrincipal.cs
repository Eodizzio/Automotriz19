using Frontend.Presentación.Reportes.FacturasFechas;
using Frontend.Presentación.Reportes.FacturaTipoCli;
using Frontend.Presentación.Reportes.MarcasVendidas;
using Frontend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Presentación
{
    public partial class FrmPrincipal : Form
    {
        ServiciosFactory factory;
        public FrmPrincipal(ServiciosFactory fact)
        {
            InitializeComponent();
            CenterToScreen();
            factory = fact;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            FrmClientesCRUD frmClientesCrud = (FrmClientesCRUD)factory.CreaObjeto("FrmClientesCRUD");
            Cursor.Current = Cursors.WaitCursor;
            frmClientesCrud.ShowDialog(this);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = (FrmProductos)factory.CreaObjeto("FrmProductos");
            Cursor.Current = Cursors.WaitCursor;
            frmProductos.ShowDialog(this);
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            FrmInsertarFacturas frmFacturas = (FrmInsertarFacturas)factory.CreaObjeto("FrmInsertarFacturas");
            Cursor.Current = Cursors.WaitCursor;
            frmFacturas.ShowDialog(this);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = (FrmAcercaDe)factory.CreaObjeto("FrmAcercaDe");
            Cursor.Current = Cursors.WaitCursor;
            frmAcerca.ShowDialog(this);
        }


        private void btnReportes_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = true;
        }

        private void btnMVendidas_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
            FrmReporteMarcas frmReporteMarcas = (FrmReporteMarcas)factory.CreaObjeto("FrmReporteMarcas");
            Cursor current = Cursors.WaitCursor;
            frmReporteMarcas.ShowDialog(this);
        }

        private void btnFTICli_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
            FrmReporteTPCli frmReporteTPCli = (FrmReporteTPCli)factory.CreaObjeto("FrmReporteTPCli");
            Cursor current = Cursors.WaitCursor;
            frmReporteTPCli.ShowDialog(this);
        }

        private void btnFFechas_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
            FrmFacturasFechas frmFacturasFechas = (FrmFacturasFechas)factory.CreaObjeto("FrmFacturasFechas");
            Cursor current = Cursors.WaitCursor;
            frmFacturasFechas.ShowDialog(this);
        }
    }
}
