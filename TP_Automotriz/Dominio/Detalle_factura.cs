using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Detalle_factura
    {
        public int id_detalle_factura { get; set; }
        public Productos producto { get; set; }
        public int cantidad { get; set; }
        public int pre_unitario { get; set; }

        public Detalle_factura()
        {
            id_detalle_factura = 0;
            producto = (Productos)ModeloFactory.ObtenerInstancia().CreaObjeto("producto");
            cantidad = 0;
            pre_unitario = 0;
        }

    }
}
