using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Servicios
{
    class ClientSingleton
    {
        private static ClientSingleton? instancia;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7243");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static ClientSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClientSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = string.Empty;
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<bool> GetAsyncLogin(string url)
        {
            var result = await client.GetAsync(url);
            if (result.IsSuccessStatusCode)
            {
                string content = await result.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(content))
                {
                    return true;
                }
            }
            return false;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            var response = string.Empty;
            if (result.IsSuccessStatusCode)
                response = "OK";
            return response;
        }

        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = string.Empty;
            if (result.IsSuccessStatusCode)
                response = "OK";
            return response;
        }

        public async Task<string> PostAsyncFile(string url, HttpContent contenido)
        {
            var result = await client.PostAsync(url, contenido);
            var response = string.Empty;
            if (result.IsSuccessStatusCode)
                response = "OK";
            return response;
        }

        public async Task<Stream?> GetAsyncFile(string url)
        {
            var result = await client.GetAsync(url);
            var content = string.Empty;
            if (result.IsSuccessStatusCode)
            {
                content = await result.Content.ReadAsStringAsync();
                return result.Content.ReadAsStream();
            }
            return null;
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var response = string.Empty;
            if (result.IsSuccessStatusCode)
                response = "OK";
            return response;
        }
    }
}


