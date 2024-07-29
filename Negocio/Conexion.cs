using System.Net.Http;
using System.Net.Http.Headers;

namespace Negocio
{
    public sealed class Conexion
    {
        private Conexion() { }
        private static Conexion? instancia;
        private HttpClient _Cliente = new HttpClient();
        public static string? mytoken;

        public HttpClient Cliente
        {

            get { return _Cliente; }
        }
        public static Conexion Instancia { get
            { if (instancia == null)
                {
                    instancia = new Conexion();
                    instancia._Cliente.DefaultRequestHeaders.Accept.Clear();
                    instancia._Cliente.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    if (mytoken != null) { 
                        instancia._Cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + mytoken);
                    }
                }
                return instancia;
            }
        }

        public static void UpdateToken (string token)
        {
            mytoken = token;
            if (instancia != null)
            {
                instancia._Cliente.DefaultRequestHeaders.Remove("Authorization");
                instancia._Cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            }
        }
    }
}
