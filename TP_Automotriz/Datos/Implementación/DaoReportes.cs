using DDL.Datos.Helper;
using DDL.Datos.Interfaces;
using DDL.Dominio;
using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Datos.Implementación
{
    public class DaoReportes : IObjsDAO
    {
        AbstractFactory factoria = new ModeloFactory();
        public List<ReporteMarcasVendidas> BuscaRegistro(int registro)
        {
            List<ReporteMarcasVendidas> lista_reportes = new List<ReporteMarcasVendidas>();
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            //HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            lista_parametros.Add(new SqlParameter("@id_marca", registro));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_MARCAS_VENDIDAS_2", lista_parametros);
            foreach(DataRow fila in nueva_tabla.Rows)
            {
                ReporteMarcasVendidas reporte_buscado = (ReporteMarcasVendidas)factoria.CreaObjeto("ReporteMarcasVendidas");
                reporte_buscado.Codigo = Convert.ToInt32(fila["Codigo"].ToString());
                reporte_buscado.Producto = fila["Producto"].ToString();
                reporte_buscado.Marca = fila["Marca"].ToString();
                reporte_buscado.Modelo = fila["Modelo"].ToString();
                reporte_buscado.Color = fila["Color"].ToString();
                reporte_buscado.Facturacion = Convert.ToInt32(fila["Facturacion"].ToString());
                reporte_buscado.CantidadVentas = Convert.ToInt32(fila["CantidadVentas"].ToString());
                lista_reportes.Add(reporte_buscado);
            }
            //HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return lista_reportes;
        }

        public List<ReporteFacturasCliente> BuscarReporteFacturas(int registro)
        {
            List<ReporteFacturasCliente> lista_facturas = new List<ReporteFacturasCliente>();
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            lista_parametros.Add(new SqlParameter("@id_tipo_cliente", registro));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTablaEnTransaccion("SP_CONTACTO_NO_NULO", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                ReporteFacturasCliente reporte_buscado = (ReporteFacturasCliente)factoria.CreaObjeto("ReporteFacturasCliente");
                reporte_buscado.idCliente = Convert.ToInt32(fila["idCliente"].ToString());
                reporte_buscado.nroIden = Convert.ToInt32(fila["nroIden"].ToString());
                reporte_buscado.nombre = fila["nombre"].ToString();
                reporte_buscado.tipoCli = fila["tipoCli"].ToString();
                reporte_buscado.direccion = fila["direccion"].ToString();
                reporte_buscado.tipoContacto = fila["tipoContacto"].ToString();
                reporte_buscado.contacto = (fila["contacto"] != DBNull.Value) ? fila["contacto"].ToString() : string.Empty;
                reporte_buscado.CantidadFacturas = Convert.ToInt32(fila["CantidadFacturas"].ToString());
                lista_facturas.Add(reporte_buscado);
            }
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return lista_facturas;
        }

        public List<ReporteFacturasFechas> BuscarReporteFecha(DateTime desde, DateTime hasta)
        {
            List<ReporteFacturasFechas> lista_facturas = new List<ReporteFacturasFechas>();
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            lista_parametros.Add(new SqlParameter("@fechaDesde", desde));
            lista_parametros.Add(new SqlParameter("@fechaHasta", hasta));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_FACTURAS_POR_FECHA", lista_parametros);
            foreach(DataRow fila in nueva_tabla.Rows)
            {
                ReporteFacturasFechas reporte = (ReporteFacturasFechas)factoria.CreaObjeto("ReporteFacturasFechas");
                reporte.Factura = Convert.ToInt32(fila["Factura"].ToString());
                reporte.Fecha = fila["Fecha"].ToString();
                reporte.Cliente = fila["Cliente"].ToString();
                reporte.Total = Convert.ToInt32(fila["Total"].ToString());
                lista_facturas.Add(reporte);
            }
            return lista_facturas;
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            throw new NotImplementedException();
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        object IObjsDAO.BuscaRegistro(int registro)
        {
            throw new NotImplementedException();
        }
    }
}
