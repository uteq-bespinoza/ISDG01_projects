using JsonBase64.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonBase64.Services
{
    public class UsuariosService
    {
        HttpClient client;
        private readonly string API_USUARIOS = "https://192.168.1.76:44360/api/Usuarios";

        public UsuariosService()
        {
            client = new HttpClient();
        }

        public async Task<string> RegisterAsync(Usuario usuario)
        {
            string result = string.Empty;
            if (usuario != null && !string.IsNullOrEmpty(usuario.Username) && !string.IsNullOrEmpty(usuario.Password))
            {
                result = JsonSerializer.Serialize(usuario);
                //TODO: Call to your own webAPI
                StringContent content = new StringContent(result, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await client.PostAsync(API_USUARIOS, content);
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content;
                    result = await contenido.ReadAsStringAsync();
                }
            }
            return result;
        }
    }
}
