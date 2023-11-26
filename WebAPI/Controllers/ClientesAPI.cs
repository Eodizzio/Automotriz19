using DDL.Datos.Implementación;
using DDL.Dominio;
using DDL.Servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesAPI : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();

        public ClientesAPI() { }

        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.ListaSimpleRegistros();
        }

        [HttpGet, Route("ObtenerClientePorID/{id}")]
        public Clientes GetClienteByID(int id)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return (Clientes)dao.BuscaRegistro(id);
        }

        [HttpGet, Route("ObtenerClientes")]
        public IEnumerable<Clientes> GetClientes()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.ObtenerClientes();
        }

        [HttpPost, Route("CargarCliente")]
        public IActionResult PostCliente(Clientes nuevo_cliente)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            if (dao.InsertarRegistro(nuevo_cliente) == 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut, Route("ModificarClientes")]
        public IActionResult PutCliente(Clientes nuevo_cliente)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            if (dao.ModificarRegistro(nuevo_cliente) == 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete, Route("BorrarClientePorID/{id}")]
        public IActionResult DeleteCliente(int id)
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            if (dao.EliminarRegistro(id) == 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet, Route("ObtenerTipoCliente")]
        public IEnumerable<Tipo_cliente> GetTipoCliente()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.TraerTiposClientes(factory);
        }

        [HttpGet, Route("ObtenerTipoIdentificacion")]
        public IEnumerable<Tipo_identificacion> GetTipoIdentificacion()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.TraerTiposIdentificaciones();
        }

        [HttpGet, Route("ObtenerBarrios")]
        public IEnumerable<Barrio> GetBarrio()
        {
            DaoCliente dao = (DaoCliente)factory.CreaObjeto("DaoCliente");
            return dao.TraerBarrios();
        }
    }
}