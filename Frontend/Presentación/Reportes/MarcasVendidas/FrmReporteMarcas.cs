using DDL.Dominio;
using Frontend.Servicios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Frontend.Presentación.Reportes.MarcasVendidas
{
    public partial class FrmReporteMarcas : Form
    {
        GestorProductos gestor_productos;
        GestorReportes gestor_reportes;
        ServiciosFactory factoria;

        int id;
        public FrmReporteMarcas(ServiciosFactory fact)
        {
            InitializeComponent();
            CenterToParent();
            factoria = fact;
            gestor_productos = (GestorProductos)factoria.CreaObjeto("GestorProductos");
            gestor_reportes = (GestorReportes)factoria.CreaObjeto("GestorReportes");
        }

        private void FrmReporteMarcas_Load(object sender, EventArgs e)
        {
            rvMarcas.LocalReport.ReportEmbeddedResource = "Frontend.Presentación.Reportes.MarcasVendidas.ReportMarcas.rdlc";
            rvMarcas.RefreshReport();
            CargarCombo();
            id = 1;
            CargarReporte(id);

        }

        private async void CargarCombo()
        {
            List<Marca> lista_marca = await gestor_productos.GetMarcas();
            cboMarca.DataSource = lista_marca;
            cboMarca.SelectedIndex = 0;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarReporte(id);
        }

        private async void CargarReporte(int id)
        {
            List<ReporteMarcasVendidas> repo = await gestor_reportes.GetMarcasVendidasID(id);
            DataTable dt = ToDataTable(repo);
            rvMarcas.LocalReport.DataSources.Clear();
            rvMarcas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetMarcas", dt));
            rvMarcas.RefreshReport();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = ((Marca)cboMarca.SelectedItem).id_marca;
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
