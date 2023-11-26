using Microsoft.AspNetCore.Mvc;
using DDL.Datos;
using DDL.Dominio;
using DDL.Servicios;
using DDL.Datos.Implementación;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosAPI : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();

        public ProductosAPI() { }

        [HttpGet, Route("Obtener_Lista_Simple")]
        public IList<KeyValuePair<int, string>> ObtenerListaSimple()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.ListaSimpleRegistros();
        }

        [HttpGet, Route("ObtenerProductoPorID/{id}")]
        public Productos GetProductosByID(int id)
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return (Productos)dao.BuscaRegistro(id);
        }

        [HttpGet, Route("ObtenerProductos")]
        public IEnumerable<Productos> GetProductos()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.BuscarProductos();
        }

        [HttpGet, Route("ObtenerTipoProducto")]
        public IEnumerable<Tipo_producto> GetTipo_Productos()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.Obtiene_Tipo_Articulo(factory);
        }

        [HttpGet, Route("ObtenerMarca")]
        public IEnumerable<Marca> GetMarca()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.Obtiene_Marca(factory);
        }

        [HttpGet, Route("ObtenerModelo")]
        public IEnumerable<Modelo> GetModelo()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.Obtiene_Modelo(factory);
        }

        [HttpGet, Route("ObtenerPais")]
        public IEnumerable<Pais> GetPais()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.Obtiene_Pais(factory);
        }

        [HttpGet, Route("ObtenerColor")]
        public IEnumerable<Colores> GetColor()
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            return dao.Obtiene_Color(factory);
        }


        [HttpDelete, Route("BorrarProductoPorID/{id}")]
        public IActionResult DeleteProducto(int id)
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            if (dao.EliminarRegistro(id) == 0)
                return Ok();
            else
                return BadRequest();
        }



        [HttpPost, Route("InsertarProducto")]
        public IActionResult PostProductos(Productos nuevo_producto)
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            if (dao.InsertarRegistro(nuevo_producto) == 0)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut, Route("ModificarProducto")]
        public IActionResult PutProductos(Productos nuevo_producto)
        {
            DaoProducto dao = (DaoProducto)factory.CreaObjeto("DaoProducto");
            if (dao.ModificarRegistro(nuevo_producto) == 0)
                return Ok();
            else
                return BadRequest();
        }

    }
}