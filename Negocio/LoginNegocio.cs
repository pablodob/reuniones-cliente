﻿using Entidades;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Diagnostics;

namespace Negocio
{
    public class LoginNegocio
    {
        static readonly string defaultURL = "http://localhost:5275/api/Login/";

        public async static Task<Boolean> ChangePass(UsuarioLogin usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + "changepassword/", usuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<String?> Send(UsuarioLogin usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + "login/", usuario);
            string? token;
            try
            {
                response.EnsureSuccessStatusCode();
                var tokenResponse = await response.Content.ReadAsStringAsync();
                token = JsonDocument.Parse(tokenResponse).RootElement.GetProperty("token").GetString();
                Conexion.UpdateToken(token);
            } catch
            {
                token = null;
            }
            return token;
        }

        public async static Task<Boolean> Add(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL + "signup/", usuario);
            return response.IsSuccessStatusCode;
        }


    }
}