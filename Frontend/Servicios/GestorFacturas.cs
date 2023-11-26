using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Dominio;
using DDL.Servicios;
using Newtonsoft.Json;

namespace Frontend.Servicios
{
    public class GestorFactura
    {
        public async Task<IList<KeyValuePair<int, string>>> ObtenerListaSimple()
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/FacturasAPI/ObtenerListaSimple");

            if (!string.IsNullOrEmpty(contenido))
            {
                return JsonConvert.DeserializeObject<IList<KeyValuePair<int, string>>>(contenido);
            }
            else
            {
                // Puedes manejar la lógica específica si la lista no se encuentra
                return new List<KeyValuePair<int, string>>();
            }
        }
        public async Task<Facturas> ObtenerFacturaPorID(int codigo_cliente)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/FacturasAPI/ObtenerFacturaPorID/" + codigo_cliente);
            if (contenido != string.Empty)
                return JsonConvert.DeserializeObject<Facturas>(contenido);
            else
                return (Facturas)ModeloFactory.ObtenerInstancia().CreaObjeto("factura");
        }

        public async Task<bool?> IngresarFactura(Facturas nueva_factura)
        {
            string cli = JsonConvert.SerializeObject(nueva_factura, Formatting.Indented);
            string response = await ClientSingleton.GetInstance().PostAsync("/api/FacturasAPI/IngresarFactura", cli);
            if (response != null)
            {
                response = response.Trim();
                if (response.Equals("Ok", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return null;
        }

        public async Task<List<Forma_Pago>> GetFormasPago()
        {
            List<Forma_Pago> lista_tipos = new List<Forma_Pago>();
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/FacturasAPI/ObtenerFormasPago");
            if (contenido != string.Empty)
                lista_tipos = JsonConvert.DeserializeObject<List<Forma_Pago>>(contenido);
            return lista_tipos;
        }

    }

}