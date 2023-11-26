using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class ReporteFacturasFechas
    {
        public int Factura { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public int Total { get; set; }

        public ReporteFacturasFechas()
        {
            Factura = 0;
            Fecha = string.Empty;
            Cliente = string.Empty;
            Total = 0;
        }
    }
}
