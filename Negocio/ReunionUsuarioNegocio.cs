using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReunionUsuarioNegocio
    {
        static readonly string defaultURL = "http://localhost:5275/api/ReunionUsuario/";
        public async static Task<IEnumerable<ReunionUsuario>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<ReunionUsuario>>(response);
            return data;
        }

        public async static Task<IEnumerable<ReunionUsuario>> GetbyReunion(int reunionId)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + "reuniones/" + reunionId);
            var data = JsonConvert.DeserializeObject<List<ReunionUsuario>>(response);
            return data;
        }

        public async static Task<Boolean> Delete(ReunionUsuario reunionusuario)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + reunionusuario.Id);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(ReunionUsuario reunionusuario)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, reunionusuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(ReunionUsuario reunionusuario)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + reunionusuario.Id, reunionusuario);
            return response.IsSuccessStatusCode;
        }

        public async static Task<ReunionUsuario> GetById(long id)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + id);
            var data = JsonConvert.DeserializeObject<ReunionUsuario>(response);
            return data;
        }
    }
}
