using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Assets20241_CamiloR.Services
{
    public static class WebAPIConnection
    {

        /*
            Aca definimos la ruta raiz del URL del servicio WEB (API Rest).
            A esta raiz le llamaremos prefijo ,se le debe adjuntar el resto de la ruta
            url, que llamaremos sufijo para cada end point que vayamos a usar.
            Ademas es importante indicar que normalmente los APIs trabajan en 2 versiones:
            Pruebas y produccion. 
         */

        public static string ProductionURLPrefix = "http://192.168.0.2:45455/api/";

        public static string TestingURLPrefix = "http://192.168.0.2:45455/api/";

        //Ademas de la raiz de URL aca vamos a indicar cual es la API Key que deberia usarpara consumir end points

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "KmiloRP6ApiK123454321abc";
        

    }
}
