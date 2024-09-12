using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        static readonly string defaultURL = "http://localhost:5275/api/Usuario/";
        public async static Task<IEnumerable<Usuario>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Usuario>>(response);
            return data;
        }

        public async static Task<Boolean> Delete(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + usuario.Id);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, usuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Usuario usuario)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + usuario.Id, usuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Usuario> GetUser(int id)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + id);
            var data = JsonConvert.DeserializeObject<Usuario>(response);
            return data;
        }

        public async static Task<Usuario> GetMyUser()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + "my");
            var data = JsonConvert.DeserializeObject<Usuario>(response);
            return data;
        }
    }
}