using System.Web.Http;
using System.Web.Http.Cors;

namespace Ophelia.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute(
            origins: "*",
            headers: "*",
            methods: "*");
            config.EnableCors(cors);
            //Configuracion Response JSon
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
