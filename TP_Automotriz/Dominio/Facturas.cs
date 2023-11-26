using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Facturas
    {
        public int id_factura { get; set; }
        public DateTime Fecha { get; set; }
        public Clientes Cliente { get; set; }
        public Forma_Pago FormaPago { get; set; }
        public List<Detalle_factura> Detalle { get; set; }

        public Facturas()
        {
            id_factura = 0;
            Fecha = DateTime.Now;
            Cliente = (Clientes)ModeloFactory.ObtenerInstancia().CreaObjeto("cliente");
            FormaPago = (Forma_Pago)ModeloFactory.ObtenerInstancia().CreaObjeto("forma_pago");
            Detalle = new List<Detalle_factura>();

        }

        public Facturas(DateTime fecha, string tipoCliente, string tipoFormaPago, List<Detalle_factura> detalle)
        {
            Fecha = fecha;
            Cliente = (Clientes)ModeloFactory.ObtenerInstancia().CreaObjeto(tipoCliente);
            FormaPago = (Forma_Pago)ModeloFactory.ObtenerInstancia().CreaObjeto(tipoFormaPago);
            Detalle = detalle;
        }

        public void AgregarDetalles(Detalle_factura oDetalles)
        {
            if (oDetalles != null)
                Detalle.Add(oDetalles);
        }

        public void QuitarDetalles(Detalle_factura oDetalles)
        {
            if (oDetalles != null)
                Detalle.Remove(oDetalles);
        }
    }
}
