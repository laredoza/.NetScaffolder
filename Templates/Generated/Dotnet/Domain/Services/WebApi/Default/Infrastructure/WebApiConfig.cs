//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RepositoryEFDotnet.Services.WebApi.Default.Infrastructure
//{
//    public class WebApiConfig
//    {
//        public static void Register(HttpConfiguration config)
//        {
//            // Attribute routing.
//            config.MapHttpAttributeRoutes();

//            // Convention-based routing.
//            config.Routes.MapHttpRoute(
//                name: "DefaultApi",
//                routeTemplate: "api/{controller}/{id}",
//                defaults: new { id = RouteParameter.Optional }
//            );
//        }
//    }
//}
