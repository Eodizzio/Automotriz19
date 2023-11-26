using DDL.Dominio;
using DDL.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    public class GestorCliente
    {
        public async Task<Clientes> ObtenerClientePorID(int codigo_cliente)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/ClientesAPI/ObtenerClientePorID/" + codigo_cliente);
            if (contenido != string.Empty)
                return JsonConvert.DeserializeObject<Clientes>(contenido);
            else
                return (Clientes)ModeloFactory.ObtenerInstancia().CreaObjeto("cliente");
        }

        public async Task<List<Clientes>> GetTodosClientes()
        {
            List<Clientes> lista_clientes = new List<Clientes>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("api/ClientesAPI/ObtenerClientes");
            if (contenido != null)
                lista_clientes = JsonConvert.DeserializeObject<List<Clientes>>(contenido);
            return lista_clientes;
        }

        public async Task<List<Tipo_identificacion>> ObtenerTipoIdentificacion()
        {
            List<Tipo_identificacion> lista_tipos = new List<Tipo_identificacion>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/ClientesAPI/ObtenerTipoIdentificacion");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Tipo_identificacion>>(contenido);
            return lista_tipos;
        }

        public async Task<List<Tipo_cliente>> GetTipoCliente()
        {
            List<Tipo_cliente> lista_tipos = new List<Tipo_cliente>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/ClientesAPI/ObtenerTipoCliente");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Tipo_cliente>>(contenido);
            return lista_tipos;
        }

        //public async Task<string> IngresarCliente(Clientes nuevo_cliente)
        //{
        //    string cli = JsonConvert.SerializeObject(nuevo_cliente, Formatting.Indented);
        //    string response = await ClientSingleton.GetInstance().PostAsync("/api/ClientesAPI/CargarCliente", cli);
        //    if (response != string.Empty)
        //        return response;
        //    else
        //        return string.Empty;
        //}
        public async Task<bool?> IngresarCliente(Clientes nuevo_cliente)
        {
            string cli = JsonConvert.SerializeObject(nuevo_cliente, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("/api/ClientesAPI/CargarCliente", cli);

            // Verificar si la respuesta contiene "true", "false" o es nula
            if (response != null)
            {
                response = response.Trim();
                if (response.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Si la respuesta es nula o no es "true" ni "false", devolver null
            return null;
        }


        public async Task<string> ModificarCliente(Clientes cliente)
        {
            string cli = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PutAsync("/api/ClientesAPI/ModificarClientes", cli);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<string> BorrarCliente(int codigo_cliente)
        {
            //string cli = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().DeleteAsync("/api/ClientesAPI/BorrarClientePorID/" + codigo_cliente);
            if (response != string.Empty)
                return response;
            else
                return string.Empty;
        }

        public async Task<List<Barrio>> GetBarrios()
        {
            List<Barrio> lista_tipos = new List<Barrio>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/ClientesAPI/ObtenerBarrios");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Barrio>>(contenido);
            return lista_tipos;
        }

    }
}