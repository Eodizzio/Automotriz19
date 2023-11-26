using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Datos.Interfaces;
using DDL.Dominio;
using DDL.Servicios;
using DDL.Datos.Helper;

namespace DDL.Datos.Implementación
{
    public class DaoCliente : IObjsDAO
    {
        AbstractFactory factory = new ModeloFactory();
        public object BuscaRegistro(int registro)
        {
            Clientes cliente_buscado = (Clientes)factory.CreaObjeto("cliente");
            List<SqlParameter> lista_parametros = new List<SqlParameter>();
            lista_parametros.Add(new SqlParameter("@id_cliente", registro));
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("//////", lista_parametros);
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                // ID
                cliente_buscado.id_cliente = Convert.ToInt32(fila["id_cliente"].ToString());
                // TIPO CLIENTE
                cliente_buscado.tipos_cliente.id_tipo_cliente = Convert.ToInt32(fila["id_tipo_cliente"].ToString());
                cliente_buscado.tipos_cliente.tipo_cliente = (string)fila["tipo_cliente"];
                // TIPO IDENTIFICACION
                cliente_buscado.tipos_Identificacion.id_tipo_identificacion = Convert.ToInt32(fila["id_tipo_identificacion"].ToString());
                cliente_buscado.tipos_Identificacion.tipo_identificacion = (string)fila["tipo_identificacion"];
                // IDENTIFICACION
                cliente_buscado.identificacion = Convert.ToInt32(fila["identificaion"].ToString());
                // NOMBRE RAZON SOCIAL
                cliente_buscado.nombre_raz_social = (string)fila["nombre_raz_social"];
                // DIRECCION
                cliente_buscado.Direccion = (string)fila["direccion"];
                // BARRIO
                cliente_buscado.barrio.id_barrio = Convert.ToInt32(fila["id_barrio"].ToString());
                cliente_buscado.barrio.nom_barrio = (string)fila["barrio"];
                cliente_buscado.barrio.provincia.id_provincia = Convert.ToInt32(fila["id_provincia"].ToString());
                cliente_buscado.barrio.provincia.provincia = (string)fila["provincia"];
                cliente_buscado.barrio.provincia.pais.id_pais = Convert.ToInt32(fila["id_pais"].ToString());
                cliente_buscado.barrio.provincia.pais.pais = (string)fila["pais"];
            }
            return cliente_buscado;
        }
        
        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> lista_clientes = new List<Clientes>();
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_CLIENTES_TODOS");
            foreach(DataRow fila in nueva_tabla.Rows)
            {
                Clientes cliente_buscado = (Clientes)factory.CreaObjeto("cliente");
                //ID
                cliente_buscado.id_cliente = Convert.ToInt32(fila["id_cliente"].ToString());
                //NOMBRE
                cliente_buscado.nombre_raz_social = (string)fila["nombre"];
                // TIPO CLIENTE
                cliente_buscado.tipos_cliente.tipo_cliente = (string)fila["tipo_cliente"];
                // TIPO IDENTIFICACION
                cliente_buscado.tipos_Identificacion.tipo_identificacion = (string)fila["tipo_identificacion"];
                // IDENTIFICACION
                cliente_buscado.identificacion = Convert.ToInt32(fila["identificación"].ToString());
                // DIRECCION
                cliente_buscado.Direccion = (string)fila["dirección"];
                // BARRIO
                cliente_buscado.barrio.nom_barrio = (string)fila["barrio"];
                lista_clientes.Add(cliente_buscado);
            }
            return lista_clientes;
        }
        public int EliminarRegistro(int codigo)
        {
            List<SqlParameter> param_cliente = new List<SqlParameter>();
            param_cliente.Add(new SqlParameter("@id_cliente", codigo));
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_BORRAR_CLIENTES", param_cliente,null);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }

        public int InsertarRegistro(object objeto)
        {
            Clientes NuevoCliente = (Clientes)objeto;
            List<SqlParameter> param_cliente = new List<SqlParameter>();
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            //TIPO CLIENTE
            param_cliente.Add(new SqlParameter("@id_tipo_cliente", NuevoCliente.tipos_cliente.id_tipo_cliente));
            // TIPO IDENTIFICACION
            param_cliente.Add(new SqlParameter("@id_tipo_identificacion", NuevoCliente.tipos_Identificacion.id_tipo_identificacion));
            //IDENTIFICACION
            param_cliente.Add(new SqlParameter("@identificacion", NuevoCliente.identificacion)); //COMPROBAR QUE SE HAYA AGREGADO EL CAMPO EN LA BASE DE DATOS
            //NOMBRE
            param_cliente.Add(new SqlParameter("@nombre_raz_social", NuevoCliente.nombre_raz_social));
            //DIRECCION
            param_cliente.Add(new SqlParameter("@direccion", NuevoCliente.Direccion));
            //BARRIO
            param_cliente.Add(new SqlParameter("@id_barrio", NuevoCliente.barrio.id_barrio));
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_DAR_ALTA_CLIENTE", param_cliente, null);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado; ;
        }
        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            List<KeyValuePair<int, string>> NuevaListaPares = new List<KeyValuePair<int, string>>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_BUSCAR_CLIENTES_SIMPLE");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                NuevaListaPares.Add(new KeyValuePair<int, string>(Convert.ToInt32(fila["id_cliente"].ToString()), (string)fila["nombre_raz_social"]));
            }
            return NuevaListaPares;
        }

        //HICE UNA PRUEBA
        public List<Tipo_cliente> TraerTiposClientes(AbstractFactory factory)
        {
            List<Tipo_cliente> lista_tipos_clientes = new List<Tipo_cliente>();
            DataTable tabla_tipos_clientes = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_TIPO_CLIENTE");
            foreach(DataRow row in tabla_tipos_clientes.Rows)
            {
                Tipo_cliente tp = (Tipo_cliente)factory.CreaObjeto("tipo_cliente");
                tp.id_tipo_cliente = Convert.ToInt32(row["id_tipo_cliente"].ToString());
                tp.tipo_cliente = row["descripcion"].ToString();
                lista_tipos_clientes.Add(tp);
            }
            return lista_tipos_clientes;
        }

        public List<Tipo_identificacion> TraerTiposIdentificaciones()
        {
            List<Tipo_identificacion> lista_tipos_identificacion = new List<Tipo_identificacion>();
            DataTable tabla_tipos_ident = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_TIPO_IDENT");
            foreach (DataRow row in tabla_tipos_ident.Rows)
            {
                Tipo_identificacion tp = (Tipo_identificacion)factory.CreaObjeto("tipo_identificacion");
                tp.id_tipo_identificacion = Convert.ToInt32(row["id_tipo_identificación"].ToString());
                tp.tipo_identificacion = row["descripcion"].ToString();
                lista_tipos_identificacion.Add(tp);
            }
            return lista_tipos_identificacion;
        }

        public List<Barrio> TraerBarrios()
        {
            List<Barrio> lista_barrios = new List<Barrio>();
            DataTable tabla_lista_barrios = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_BARRIOS"); //SOLAMENTE EL ID Y LA DESCRIPCIÓN
            foreach(DataRow row in tabla_lista_barrios.Rows)
            {
                Barrio barrio = (Barrio)factory.CreaObjeto("barrio");
                barrio.id_barrio = Convert.ToInt32(row["id_barrio"].ToString());
                barrio.nom_barrio = row["descripcion"].ToString();
                lista_barrios.Add(barrio);
            }
            return lista_barrios;
        }

        public int ModificarRegistro(object objeto)
        {
            Clientes NuevoCliente = (Clientes)objeto;
            List<SqlParameter> param_cliente = new List<SqlParameter>();
            //TIPO CLIENTE
            param_cliente.Add(new SqlParameter("@id_tipo_cliente", NuevoCliente.tipos_cliente.id_tipo_cliente));
            // TIPO IDENTIFICACION
            param_cliente.Add(new SqlParameter("@id_tipo_identificacion", NuevoCliente.tipos_Identificacion.id_tipo_identificacion));
            //IDENTIFICACION
            param_cliente.Add(new SqlParameter("@nro_identificacion", NuevoCliente.identificacion));
            //NOMBRE
            param_cliente.Add(new SqlParameter("@nombre_raz_social", NuevoCliente.nombre_raz_social));
            //DIRECCION
            param_cliente.Add(new SqlParameter("@direccion", NuevoCliente.Direccion));
            //BARRIO
            param_cliente.Add(new SqlParameter("@id_barrio", NuevoCliente.barrio.id_barrio));
            //ID CLIENTE
            param_cliente.Add(new SqlParameter("@id_cliente", NuevoCliente.id_cliente));
            HelperDB.ObtenerInstancia().AbreConexionConTransaccion();
            int resultado = HelperDB.ObtenerInstancia().EjecutaComando("SP_UPDATE_CLIENTES", param_cliente, null);
            HelperDB.ObtenerInstancia().CierraConexionConTransaccion();
            return resultado;
        }
    }
}
