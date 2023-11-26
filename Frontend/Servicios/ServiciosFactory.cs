using DDL.Servicios;
using Frontend.Presentación;
using Frontend.Presentación.Reportes.FacturasFechas;
using Frontend.Presentación.Reportes.FacturaTipoCli;
using Frontend.Presentación.Reportes.MarcasVendidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    public class ServiciosFactory : AbstractFactory
    {
        private static ServiciosFactory instancia;
        
        public static ServiciosFactory ObtenerInstancia()
        {
            if(instancia == null)
                instancia = new ServiciosFactory();
            return instancia;
        }

        public override object CreaObjeto(string tipo, List<object>? lista_parametros = null)
        {
            switch (tipo)
            {
                case "GestorCliente":
                    return new GestorCliente();
                case "GestorFacturas":
                    return new GestorFactura();
                case "GestorHash":
                    return new GestorHash();
                case "GestorProductos":
                    return new GestorProductos();
                case "GestorReportes":
                    return new GestorReportes();
                case "FrmPrincipal":
                    return new FrmPrincipal(this);
                case "FrmAcercaDe":
                    return new FrmAcercaDe(this);
                case "FrmClientesCRUD":
                    return new FrmClientesCRUD(this);
                case "FrmInsertarFacturas":
                    return new FrmInsertarFacturas(this);
                case "FrmProductos":
                    return new FrmProductos(this);
                case "FrmFacturasFechas":
                    return new FrmFacturasFechas(this);
                case "FrmReporteTPCli":
                    return new FrmReporteTPCli(this);
                case "FrmReporteMarcas":
                    return new FrmReporteMarcas(this);

                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }
}
