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

namespace Frontend.Presentación.Reportes.FacturasFechas
{
    public partial class FrmFacturasFechas : Form
    {
        GestorReportes gestor_reportes;
        ServiciosFactory factoria;
        public FrmFacturasFechas(ServiciosFactory fact)
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

        private void FrmFacturasFechas_Load(object sender, EventArgs e)
        {
            rvFechas.LocalReport.ReportEmbeddedResource = "Frontend.Presentación.Reportes.FacturasFechas.ReportFFechas.rdlc";
            rvFechas.RefreshReport();
            dtpDesde.Value = new DateTime(2013, 03, 10);
            dtpHasta.Value = DateTime.Now;
            CargarReporte(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private async void CargarReporte(DateTime desde, DateTime hasta)
        {
            rvFechas.LocalReport.DataSources.Clear();
            List<ReporteFacturasFechas> repo = await gestor_reportes.GetFacturasFecha(desde, hasta);
            DataTable dt = ToDataTable(repo); ;
            rvFechas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFacturasFechas", dt));
            rvFechas.RefreshReport();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde debe ser menor a la fecha hasta", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDesde.Value = dtpHasta.Value.AddDays(-1);
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value)
            {
                MessageBox.Show("La fecha hasta debe ser mayor a la fecha desde", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpHasta.Value = dtpDesde.Value.AddDays(1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarReporte(dtpDesde.Value.Date, dtpHasta.Value.Date);
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
