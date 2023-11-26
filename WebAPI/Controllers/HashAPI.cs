using Microsoft.AspNetCore.Mvc;
using DDL.Datos.Implementación;
using DDL.Dominio;
using DDL.Servicios;
using DDL.Datos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashAPI : ControllerBase
    {
        ModeloFactory factory = new ModeloFactory();


        // GET: /api/Clientes/Obtener_Lista_Simple
        [HttpGet, Route("CompararHash/{password}/{usuario}")]
        public bool CompararHash(string password, string usuario)
        {
            DaoHash dao = (DaoHash)factory.CreaObjeto("DaoHash");
            return dao.VerifyPassword(password, usuario);
        }

        // GET: /api/Clientes/Obtener_Lista_Simple
        [HttpGet, Route("HacerHash/{password}")]
        public string CrearHash(string password)
        {
            DaoHash dao = (DaoHash)factory.CreaObjeto("DaoHash");
            return dao.HashPassword(password);
        }

        [HttpGet, Route("ComparacionSimple/{password}/{password2}")]
        public bool ComparacionSimple(string password, string password2)
        {
            DaoHash dao = (DaoHash)factory.CreaObjeto("DaoHash");
            return dao.VerifySPass(password, password2);
        }

    }
}