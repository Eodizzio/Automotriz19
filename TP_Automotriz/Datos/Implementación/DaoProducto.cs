using DDL.Datos.Helper;
using DDL.Dominio;
using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Datos.Interfaces;

namespace DDL.Datos.Implementación
{
    public class DaoProducto : IObjsDAO
    {
        AbstractFactory factory = new ModeloFactory();
        public object BuscaRegistro(int registro)
        {
            Productos producto_buscado = (Productos)factory.CreaObjeto("producto");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            lista_parametros.Add(new SqlParameter("@cod_producto", registro));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTablaEnTransaccion("SP_TRAER_PRODUCTOS_CODIGO", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                // ID
                producto_buscado.cod_producto = Convert.ToInt32(fila["cod_producto"].ToString());

                producto_buscado.tipo_producto.id_tipo_producto = Convert.ToInt32(fila["id_tipo_producto"].ToString());
                producto_buscado.tipo_producto.tipo_producto = (string)fila["tipo_producto"];

                producto_buscado.Marca.id_marca = Convert.ToInt32(fila["id_marca"].ToString());
                producto_buscado.Marca.marca = (string)fila["marca"];

                producto_buscado.Modelo.id_modelo = Convert.ToInt32(fila["id_modelo"].ToString());
                producto_buscado.Modelo.modelo = (string)fila["modelo"];

                producto_buscado.Origen.id_pais = Convert.ToInt32(fila["id_pais"].ToString());
                producto_buscado.Origen.pais = (string)fila["pais"];

                producto_buscado.Descripcion = (string)fila["descripcion"];

                producto_buscado.PrecioUnitario = Convert.ToInt32(fila["precio_unitario"].ToString());

                producto_buscado.Color.id_color = Convert.ToInt32(fila["id_color"].ToString());
                producto_buscado.Color.color = (string)fila["color"];
            }
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return producto_buscado;
        }

        public int EliminarRegistro(int codigo)
        {
            List<SqlParameter> param_cliente = new List<SqlParameter>();
            param_cliente.Add(new SqlParameter("@cod_producto ", codigo));
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_BORRAR_PRODUCTO", param_cliente, null);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public int InsertarRegistro(object objeto)
        {
            //Inserta Modelo
            Productos NuevoProducto = (Productos)objeto;
            string modelo = NuevoProducto.Modelo.modelo;
            List<SqlParameter> param_modelo = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            param_modelo.Add(new SqlParameter("@modelo", modelo));
            SqlParameter salida = new SqlParameter();
            salida.Direction = ParameterDirection.Output;
            salida.SqlDbType = SqlDbType.Int;
            salida.ParameterName = "@id_modelo";
            int idModelo = HelperDB.ObtenerInstancia().EjecutaComando("SP_ALTA_MODELO", param_modelo, salida);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            //Inserta Producto
            List<SqlParameter> param_producto = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            param_producto.Add(new SqlParameter("@id_tipo_producto", NuevoProducto.tipo_producto.id_tipo_producto));
            param_producto.Add(new SqlParameter("@id_marca", NuevoProducto.Marca.id_marca));
            param_producto.Add(new SqlParameter("@id_modelo", idModelo));
            param_producto.Add(new SqlParameter("@id_origen", NuevoProducto.Origen.id_pais));
            param_producto.Add(new SqlParameter("@descripcion", NuevoProducto.Descripcion));
            param_producto.Add(new SqlParameter("@precio_unitario", NuevoProducto.PrecioUnitario));
            param_producto.Add(new SqlParameter("@id_color", NuevoProducto.Color.id_color));
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_ALTA_PRODUCTO", param_producto, null);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }
        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_BUSCA_SIMPLE_PRODUCOTS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["cod_producto"].ToString()), (string)fila["descripcion"]));
            }
            return NuevaListaPares;
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        public List<Productos> BuscarProductos()
        {
            List<Productos> lista_productos = new List<Productos>();
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_PRODUCTOS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Productos producto_buscado = (Productos)factory.CreaObjeto("producto");
                producto_buscado.cod_producto = Convert.ToInt32(fila["cod_producto"].ToString());

                producto_buscado.tipo_producto.id_tipo_producto = Convert.ToInt32(fila["id_tipo_producto"].ToString());
                producto_buscado.tipo_producto.tipo_producto = (string)fila["tipo_producto"];

                producto_buscado.Marca.id_marca = Convert.ToInt32(fila["id_marca"].ToString());
                producto_buscado.Marca.marca = (string)fila["marca"];

                producto_buscado.Modelo.id_modelo = Convert.ToInt32(fila["id_modelo"].ToString());
                producto_buscado.Modelo.modelo = (string)fila["modelo"];

                producto_buscado.Origen.id_pais = Convert.ToInt32(fila["id_pais"].ToString());
                producto_buscado.Origen.pais = (string)fila["pais"];

                producto_buscado.Descripcion = (string)fila["descripcion"];

                producto_buscado.PrecioUnitario = Convert.ToInt32(fila["precio_unitario"].ToString());

                producto_buscado.Color.id_color = Convert.ToInt32(fila["id_color"].ToString());
                producto_buscado.Color.color = (string)fila["color"];
                lista_productos.Add(producto_buscado);
            }
            return lista_productos;
        }

        public List<Tipo_producto> Obtiene_Tipo_Articulo(AbstractFactory factory)
        {
            List<Tipo_producto> nueva_lista = new List<Tipo_producto>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_TIPO_PRODUCTO");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Tipo_producto nuevo_tipo = (Tipo_producto)factory.CreaObjeto("tipo_producto");
                nuevo_tipo.id_tipo_producto = Convert.ToInt32(fila["id"].ToString());
                nuevo_tipo.tipo_producto = fila["descripcion"].ToString();
                nueva_lista.Add(nuevo_tipo);
            }
            return nueva_lista;
        }

        public List<Marca> Obtiene_Marca(AbstractFactory factory)
        {
            List<Marca> nueva_lista = new List<Marca>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_MARCAS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Marca nuevo_Marca = (Marca)factory.CreaObjeto("marca");
                nuevo_Marca.id_marca = Convert.ToInt32(fila["id"].ToString());
                nuevo_Marca.marca = fila["descripcion"].ToString();
                nueva_lista.Add(nuevo_Marca);
            }
            return nueva_lista;
        }

        public List<Modelo> Obtiene_Modelo(AbstractFactory factory)
        {
            List<Modelo> nueva_lista = new List<Modelo>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_MODELOS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Modelo nuevo_Modelo = (Modelo)factory.CreaObjeto("modelo");
                nuevo_Modelo.id_modelo = Convert.ToInt32(fila["id"].ToString());
                nuevo_Modelo.modelo = (string)fila["descripcion"];
                nueva_lista.Add(nuevo_Modelo);
            }
            return nueva_lista;
        }

        public List<Pais> Obtiene_Pais(AbstractFactory factory)
        {
            List<Pais> nueva_lista = new List<Pais>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_PAISES");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Pais nuevo_Pais = (Pais)factory.CreaObjeto("pais");
                nuevo_Pais.id_pais = Convert.ToInt32(fila["id"].ToString());
                nuevo_Pais.pais = fila["descripcion"].ToString();
                nueva_lista.Add(nuevo_Pais);
            }
            return nueva_lista;
        }

        public List<Colores> Obtiene_Color(AbstractFactory factory)
        {
            List<Colores> nueva_lista = new List<Colores>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_COLORES");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Colores nuevo_Color = (Colores)factory.CreaObjeto("color");
                nuevo_Color.id_color = Convert.ToInt32(fila["id"].ToString());
                nuevo_Color.color = fila["descripcion"].ToString();
                nueva_lista.Add(nuevo_Color);
            }
            return nueva_lista;
        }
    }
}
