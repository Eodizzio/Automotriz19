using DDL.Datos.Implementación;
using DDL.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Servicios
{
    public class ModeloFactory : AbstractFactory
    {
        private static ModeloFactory? instancia;

        public static ModeloFactory ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ModeloFactory();
            return instancia;

        }

        public override object CreaObjeto(string tipo, List<Object>? lista_parametros = default)
        {
            switch (tipo)
            {
                case "producto":
                    return new Productos();
                case "tipo_producto":
                    return new Tipo_producto();
                case "color":
                    return new Colores();
                case "modelo":
                    return new Modelo();
                case "cliente":
                    return new Clientes();
                case "tipo_movimiento":
                    return new Tipo_movimiento();
                case "marca":
                    return new Marca();
                case "pais":
                    return new Pais();
                case "provincia":
                    return new Provincia();
                case "barrio":
                    return new Barrio();
                case "tipo_identificacion":
                    return new Tipo_identificacion();
                case "tipo_cliente":
                    return new Tipo_cliente();
                case "detalle_factura":
                    return new Detalle_factura();
                case "contacto":
                    return new Contactos();
                case "tipo_contacto":
                    return new Tipo_contacto();
                case "factura":
                    return new Facturas();
                case "forma_pago":
                    return new Forma_Pago();
                case "DaoCliente":
                    return new DaoCliente();
                case "DaoFactura":
                    return new DaoFactura();
                case "DaoProducto":
                    return new DaoProducto();
                case "pass":
                    return new Pass();
                case "DaoHash":
                    return new DaoHash();
                case "DaoReportes":
                    return new DaoReportes();
                case "ReporteMarcasVendidas":
                    return new ReporteMarcasVendidas();
                case "ReporteFacturasCliente":
                    return new ReporteFacturasCliente();
                case "ReporteFacturasFechas":
                    return new ReporteFacturasFechas();
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }
}
