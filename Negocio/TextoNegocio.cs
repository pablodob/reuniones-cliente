using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TextoNegocio
    {
        static readonly string defaultURL = "http://localhost:5275/api/Texto/";

        public async static Task<IEnumerable<Texto>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Texto>>(response);
            return data;
        }

        public async static Task<List<Texto>> GetbyReunionId(int reunionId)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + "reunion/" + reunionId);
            var data = JsonConvert.DeserializeObject<List<Texto>>(response);
            return data;
        }

        public async static Task<Boolean> Delete(Texto texto)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + texto.Id);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(Texto texto)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, texto);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Texto texto)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + texto.Id, texto);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Texto> GetTexto(int id)
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL + id);
            var data = JsonConvert.DeserializeObject<Texto>(response);
            return data;
        }
    }
}