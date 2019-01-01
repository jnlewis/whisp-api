using System.Web.Http;
using Whisp.Api.Resolver;
using Whisp.Api.Resolver.Containers;
using System.Linq;

namespace Whisp.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new UnityResolver(new ApplicationContainer().Get());

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            //Return response as Json
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
