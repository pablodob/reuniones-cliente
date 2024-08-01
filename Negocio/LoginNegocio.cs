using Entidades;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Diagnostics;

namespace Negocio
{
    public class LoginNegocio
    {
        static readonly string defaultURL = "http://localhost:5275/api/Login/login"; 

        public async static Task<String?> Send(UsuarioLogin usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, usuario);
            string? token;
            try
            {
                response.EnsureSuccessStatusCode();
                var tokenResponse = await response.Content.ReadAsStringAsync();
                token = JsonDocument.Parse(tokenResponse).RootElement.GetProperty("token").GetString();
                Conexion.UpdateToken(token);
                //Conexion.Instancia._Cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                //Conexion.Instancia.Cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                //Conexion.token = token;
            } catch
            {
                token = null;
            }
            return token;
        }


    }
}