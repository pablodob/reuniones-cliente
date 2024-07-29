using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ReunionNegocio //venia x default con internal, la puse public como la de usuario
    {
        static readonly string defaultURL = "http://localhost:5275/api/Reunion/";
        public async static Task<IEnumerable<Reunion>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(defaultURL);
            var data = JsonConvert.DeserializeObject<List<Reunion>>(response);
            return data;
        }

        public async static Task<Boolean> Delete(Reunion reunion)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync(defaultURL + reunion.Id);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(Reunion reunion)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(defaultURL, reunion);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Reunion reunion)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync(defaultURL + reunion.Id, reunion);
            return response.IsSuccessStatusCode;
        }
    }
}
