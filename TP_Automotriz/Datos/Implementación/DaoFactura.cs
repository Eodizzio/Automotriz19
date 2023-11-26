using DDL.Datos.Helper;
using DDL.Datos.Interfaces;
using DDL.Dominio;
using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Datos.Implementación
{
    public class DaoFactura : IObjsDAO
    {
        AbstractFactory factory = new ModeloFactory();
        public object BuscaRegistro(int registro)
        {
            Facturas factura_buscada = (Facturas)factory.CreaObjeto("factura");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            lista_parametros.Add(new SqlParameter("@id_factura", registro));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTablaEnTransaccion("SP QUE BUSQUE FACTURA POR ID", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                factura_buscada.id_factura = Convert.ToInt32(fila["id_factura"].ToString());

                factura_buscada.Fecha = Convert.ToDateTime(fila["fecha"]);

                factura_buscada.Cliente.id_cliente = Convert.ToInt32(fila["id_cliente"].ToString());

                factura_buscada.FormaPago.id_forma_pago = Convert.ToInt32(fila["id_forma_pago"].ToString());
                factura_buscada.FormaPago.forma_pago = (string)fila["forma_pago"];

                HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
                DaoCliente dao = (DaoCliente)ModeloFactory.ObtenerInstancia().CreaObjeto("DaoCliente");
                factura_buscada.Cliente = (Clientes)dao.BuscaRegistro(factura_buscada.Cliente.id_cliente);

            }
            return factura_buscada;
        }
        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarRegistro(object objeto)
        {
            Facturas NuevaFactura = (Facturas)objeto;
            List<SqlParameter> param_factura = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@id_factura";
            param_factura.Add(new SqlParameter("@fecha", NuevaFactura.Fecha));
            param_factura.Add(new SqlParameter("@id_cliente", NuevaFactura.Cliente.id_cliente));
            param_factura.Add(new SqlParameter("@id_forma_pago", NuevaFactura.FormaPago.id_forma_pago));
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_INSERTAR_FACTURA", param_factura, salida);//Modificar SP para que no pida orden por parámetro
            foreach (Detalle_factura detalle in NuevaFactura.Detalle)
            {
                List<SqlParameter> param_detalle = new List<SqlParameter>();
                param_detalle.Add(new SqlParameter("@id_factura", resultado));
                param_detalle.Add(new SqlParameter("@cod_producto", detalle.producto.cod_producto));
                param_detalle.Add(new SqlParameter("@cantidad", detalle.cantidad));
                param_detalle.Add(new SqlParameter("@pre_unitario", detalle.pre_unitario));
                detalle.id_detalle_factura = HelperDB.ObtenerInstancia().EjecutaComando("SP_INSERTAR_DETALLE_FACTURA", param_detalle, null);
            }

            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }
        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("A CARGO DEL NEGRO DEL NORTE");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["id_factura"].ToString()), (string)fila["total"]));
            }
            return NuevaListaPares;
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        public List<Forma_Pago> ObtieneFormasPago()
        {
            List<Forma_Pago> nueva_lista = new List<Forma_Pago>();
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_FORMAS_PAGO");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Forma_Pago nueva_fp = (Forma_Pago)ModeloFactory.ObtenerInstancia().CreaObjeto("forma_pago");
                nueva_fp.id_forma_pago = Convert.ToInt32(fila["id"].ToString());
                nueva_fp.forma_pago = (string)fila["descripcion"];
                nueva_lista.Add(nueva_fp);
            }
            return nueva_lista;
        }
    }
}

