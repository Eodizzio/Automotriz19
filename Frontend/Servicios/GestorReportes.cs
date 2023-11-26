using DDL.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    public class GestorReportes
    {
        public async Task<List<ReporteMarcasVendidas>> GetMarcasVendidasID(int id)
        {
            List<ReporteMarcasVendidas> lista_reportes = new List<ReporteMarcasVendidas>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ReporteAPI/ObtenerMarcasVendidas/" + id);
            if (contenido != null)
                lista_reportes = JsonConvert.DeserializeObject<List<ReporteMarcasVendidas>>(contenido);
            return lista_reportes;
        }

        public async Task<List<ReporteFacturasCliente>> GetFacturasClienteID(int id)
        {
            List<ReporteFacturasCliente> lista_reportes = new List<ReporteFacturasCliente>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ReporteApi/ObtenerNroFacturasCliente/" + id);
            if (contenido != null)
                lista_reportes = JsonConvert.DeserializeObject<List<ReporteFacturasCliente>>(contenido);
            return lista_reportes;
        }

        public async Task<List<ReporteFacturasFechas>> GetFacturasFecha(DateTime desde, DateTime hasta)
        {
            string fechaD = desde.ToString("yyyy-MM-ddTHH:mm:ss");
            string fechaH = hasta.ToString("yyyy-MM-ddTHH:mm:ss");
            List<ReporteFacturasFechas> reporte = new List<ReporteFacturasFechas>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ReporteAPI/ObtenerFacturaFecha/"+ fechaD + "/" + fechaH);
            if(contenido != null)
                reporte = JsonConvert.DeserializeObject<List<ReporteFacturasFechas>>(contenido);
            return reporte;
        }
    }
}
