using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace P6Assets20241_CamiloR.Models
{
    public class UserRole
    {
        //Cuando queremos comunicarnos con el api hay 2 formas mas usadas
        //1. Con las librerias Nativas de .NET
        //2. Usando Herramientas de terceros. 
        //En lo personal he encontrado mas facil y eficientes el uso de restSharp.

        public RestRequest? Request { get; set; }

        public int UserRoleId { get; set; }

        public string UserRoleDescription { get; set; } = null!;

        //Funciones

        //Cargar todos lo roles de usuarios.

        public async Task<List<UserRole>> GetAllUserRolesAsync()
        {
            try
            {
                //Tenemos que armar la ruta completa de consumo del API
                //Para eso tenemos en WebAPIConnection la ruta base del API
                //Y aca la completamos 

                string RouteSufix = string.Format("UserRoles");

                //Y ahora armamos la ruta de uso completa del API 

                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouteSufix;
                //Ahora tenemos la ruta completa lista
                //Configuramos el request 

                RestClient Client = new RestClient(URL);

                Request = new RestRequest(URL);

                Request = new RestRequest(URL, Method.Get);

                //Agregamos el metodo de seguridad, en este caso tenemos APIKEY

                Request.AddHeader(Services.WebAPIConnection.ApiKeyName, 
                                  Services.WebAPIConnection.ApiKeyValue);

                //Y ahora ejecutamos la llamada al API 

                RestResponse response = await Client.ExecuteAsync(Request);

                //AHora validamos que todo haya salido bien 

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK) 
                {
                    //Si obtuvimos respuesta positiva desde el API 
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }
        }




    }
}
