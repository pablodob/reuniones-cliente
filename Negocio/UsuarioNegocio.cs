using Entidades;
using Newtonsoft.Json;

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
    }
}