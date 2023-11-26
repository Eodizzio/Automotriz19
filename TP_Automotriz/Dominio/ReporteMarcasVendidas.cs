using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class ReporteMarcasVendidas
    {
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Facturacion { get; set; }
        public int CantidadVentas { get; set; }

        public ReporteMarcasVendidas()
        {
            Codigo = 0;
            Producto = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Facturacion = 0;
            CantidadVentas = 0;
        }
    }
}
