using Microsoft.AspNetCore.Mvc;
using DDL.Datos;
using DDL.Dominio;
using DDL.Servicios;
using DDL.Datos.Implementación;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasAPI : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();


        // GET: /api/Clientes/Obtener_Lista_Simple
        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoFactura dao = (DaoFactura)factory.CreaObjeto("DaoFactura");
            return dao.ListaSimpleRegistros();
        }

        // GET /api/Factura/ObtenerFacturaPorID/5
        [HttpGet, Route("ObtenerFacturaPorID/{id}")]
        public Facturas GetFacturaByID(int id)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            return (Facturas)dao.BuscaRegistro(id);
        }


        // POST /api/Factura/IngresarFactura
        [HttpPost, Route("IngresarFactura")]
        public IActionResult PostFactura(Facturas nueva_factura)
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            if (dao.InsertarRegistro(nueva_factura) == 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet, Route("ObtenerFormasPago")]
        public IEnumerable<Forma_Pago> GetFormasPago()
        {
            DaoFactura dao = (DaoFactura)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoFactura");
            return dao.ObtieneFormasPago();
        }
    }
}