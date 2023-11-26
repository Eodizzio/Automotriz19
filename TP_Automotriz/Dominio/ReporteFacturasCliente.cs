using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class ReporteFacturasCliente
    {
        public int idCliente { get; set; }
        public int nroIden { get; set; }
        public string nombre { get; set; }
        public string tipoCli { get; set; }
        public string direccion { get; set; }
        public string tipoContacto { get; set; }
        public string contacto { get; set; }
        public int CantidadFacturas { get; set; }

        public ReporteFacturasCliente()
        {
            idCliente = 0;
            nroIden = 0;
            nombre = string.Empty;
            tipoCli = string.Empty;
            direccion = string.Empty;
            tipoContacto = string.Empty;
            contacto = string.Empty;
            CantidadFacturas = 0;
        }
    }
}
