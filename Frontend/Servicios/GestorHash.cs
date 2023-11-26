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
    public class GestorHash
    {
        public async Task<bool> ComparacionHash(string password, string usuario)
        {
            string result = await ClientSingleton.GetInstance().GetAsync("/api/HashAPI/CompararHash/" + password +"/"+ usuario);
            return result == "true";
        }

        public async Task<string> HacerHash(string password)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/HashAPI/HacerHash/" + password);
            return JsonConvert.DeserializeObject<string>(contenido);

        }

        public async Task<string> ComparaSimple(string password, string password2)
        {
            string contenido = await ClientSingleton.GetInstance().GetAsync("/api/HashAPI/ComparacionSimple/" + password + password2);
            return JsonConvert.DeserializeObject<string>(contenido);

        }


    }
}
