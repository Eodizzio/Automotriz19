using DDL.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    internal class GestorProductos : IGestorProductos
    {
        public async Task<List<Colores>> GetColor()
        {
            List<Colores> lista_colores = new List<Colores>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerColor");
            if (contenido != null)
                lista_colores = JsonConvert.DeserializeObject<List<Colores>>(contenido);
            return lista_colores;
        }

        public async Task<List<Tipo_producto>> GetTiposProductos()
        {
            List<Tipo_producto> lista_tipos_productos = new List<Tipo_producto>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerTipoProducto");
            if (contenido != null)
                lista_tipos_productos = JsonConvert.DeserializeObject<List<Tipo_producto>>(contenido);
            return lista_tipos_productos;
        }

        public async Task<List<Marca>> GetMarcas()
        {
            List<Marca> lista_marcas = new List<Marca>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerMarca");
            if (contenido != null)
                lista_marcas = JsonConvert.DeserializeObject<List<Marca>>(contenido);
            return lista_marcas;
        }

        public async Task<List<Modelo>> GetModelos()
        {
            List<Modelo> lista_modelos = new List<Modelo>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerModelo");
            if (contenido != null)
                lista_modelos = JsonConvert.DeserializeObject<List<Modelo>>(contenido);
            return lista_modelos;
        }

        
        public async Task<List<Pais>> GetPaises()
        {
            List<Pais> lista_paises = new List<Pais>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerPais");
            if (contenido != null)
                lista_paises = JsonConvert.DeserializeObject<List<Pais>>(contenido);
            return lista_paises;
        }

        public async Task<List<Productos>> GetTodosProductos()
        {
            List<Productos> lista_productos = new List<Productos>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerProductos");
            if (contenido != null)
                lista_productos = JsonConvert.DeserializeObject<List<Productos>>(contenido);
            return lista_productos;
        }

        public async Task<Productos> GetProductosID(int cod_producto)
        {
            Productos producto = new Productos();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ProductosAPI/ObtenerProductos/" + cod_producto);
            if (contenido != null)
                producto = JsonConvert.DeserializeObject<Productos>(contenido);
            return producto;
        }

        public async Task<string> BorrarProducto(int cod_producto)
        {
            string response = await ClientSingleton.GetInstance().DeleteAsync("api/ProductosAPI/BorrarProductoPorID/" + cod_producto);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<bool?> InsertarProducto(Productos nuevo_producto)
        {
            string pro = JsonConvert.SerializeObject(nuevo_producto, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("api/ProductosAPI/InsertarProducto", pro);
            if(response != null)
            {
                response = response.Trim();
                if (response.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return null;
        }
    }
}
