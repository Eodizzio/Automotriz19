using DDL.Dominio;
using Frontend.Presentación.Reportes.MarcasVendidas;
using Frontend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Presentación.Reportes.FacturaTipoCli
{
    public partial class FrmReporteTPCli : Form
    {
        GestorReportes gestor_reportes;
        ServiciosFactory factoria;
        int id_tipo = 1;
        public FrmReporteTPCli(ServiciosFactory fact)
        {
            InitializeComponent();
            CenterToParent();
            factoria = fact;
            gestor_reportes = (GestorReportes)factoria.CreaObjeto("GestorReportes");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmReporteTPCli_Load(object sender, EventArgs e)
        {
            rvTipoCli.LocalReport.ReportEmbeddedResource = "Frontend.Presentación.Reportes.FacturaTipoCli.ReportFTCli.rdlc";
            rvTipoCli.RefreshReport();
            rbtConsFinal.Checked = true;
            if (rbtConsFinal.Checked == true)
                id_tipo = 1;
            if (rbtEmpresa.Checked == true)
                id_tipo = 2;
            CargarReporte(id_tipo);
        }

        private async void CargarReporte(int id_tipo)
        {
            List<ReporteFacturasCliente> repo = await gestor_reportes.GetFacturasClienteID(id_tipo);
            DataTable dt = ToDataTable(repo);
            rvTipoCli.LocalReport.DataSources.Clear();
            rvTipoCli.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFacturasTipoCli", dt));
            rvTipoCli.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtConsFinal.Checked == true)
                id_tipo = 1;
            if (rbtEmpresa.Checked == true)
                id_tipo = 2;
            CargarReporte(id_tipo);
        }

        private DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
