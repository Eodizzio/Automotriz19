using DDL.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    public interface IGestorProductos
    {
        Task<List<Productos>> GetTodosProductos();
        Task<List<Marca>> GetMarcas();
        Task<List<Modelo>> GetModelos();
        Task<List<Pais>> GetPaises();
        Task<List<Colores>> GetColor();
        Task<Productos> GetProductosID(int codProducto);
    }
}
