using DDL.Datos.Implementación;
using DDL.Dominio;
using DDL.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteAPI : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();

        // GET api/<ReporteAPI>/5
        [HttpGet, Route("ObtenerMarcasVendidas/{id}")]
        public IEnumerable<ReporteMarcasVendidas> GetbyId(int id)
        {
            DaoReportes dao = (DaoReportes)factory.CreaObjeto("DaoReportes");
            return dao.BuscaRegistro(id);
        }

        [HttpGet, Route("ObtenerNroFacturasCliente/{id}")]
        public IEnumerable<ReporteFacturasCliente> GetFacturasbyId(int id)
        {
            DaoReportes dao = (DaoReportes)factory.CreaObjeto("DaoReportes");
            return dao.BuscarReporteFacturas(id);
        }

        [HttpGet, Route("ObtenerFacturaFecha/{desde}/{hasta}")]
        public IEnumerable<ReporteFacturasFechas> GetFacturasbyDate(DateTime desde, DateTime hasta)
        {
            DaoReportes dao = (DaoReportes)factory.CreaObjeto("DaoReportes");
            return dao.BuscarReporteFecha(desde, hasta);
        }
    }
}
