using Entidades;
using Newtonsoft.Json;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public async static Task<IEnumerable<Usuario>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("http://localhost:5275/api/Usuario/");
            var data = JsonConvert.DeserializeObject<List<Usuario>>(response);
            return data;
        }
    }
}
