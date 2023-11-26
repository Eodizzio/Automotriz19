using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Productos
    {
        public int cod_producto { get; set; }
        public Tipo_producto tipo_producto { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public Pais Origen { get; set; }
        public string Descripcion { get; set; }
        public int PrecioUnitario { get; set; }
        public Colores Color { get; set; }

        public Productos()
        {
            cod_producto = 0;
            tipo_producto = (Tipo_producto)ModeloFactory.ObtenerInstancia().CreaObjeto("tipo_producto");
            Marca = (Marca)ModeloFactory.ObtenerInstancia().CreaObjeto("marca");
            Modelo = (Modelo)ModeloFactory.ObtenerInstancia().CreaObjeto("modelo");
            Origen = (Pais)ModeloFactory.ObtenerInstancia().CreaObjeto("pais");
            Descripcion = string.Empty;
            PrecioUnitario = 0;
            Color = (Colores)ModeloFactory.ObtenerInstancia().CreaObjeto("color");
        }

        public Productos(string tipoProducto, string marca, string modelo, string pais, string descripcion, int precioUnitario, string color)
        {
            tipo_producto = (Tipo_producto)ModeloFactory.ObtenerInstancia().CreaObjeto(tipoProducto);
            Marca = (Marca)ModeloFactory.ObtenerInstancia().CreaObjeto(marca);
            Modelo = (Modelo)ModeloFactory.ObtenerInstancia().CreaObjeto(modelo);
            Origen = (Pais)ModeloFactory.ObtenerInstancia().CreaObjeto(pais);
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
            Color = (Colores)ModeloFactory.ObtenerInstancia().CreaObjeto(color);
        }

        public override string ToString()
        {
            return Marca.marca + " - " + Modelo.modelo + " - " + Color.color;
        }
    }
}
