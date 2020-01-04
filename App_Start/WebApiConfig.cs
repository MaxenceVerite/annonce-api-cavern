using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using AnnonceAPI.DAL;

namespace AnnonceAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Annonce_DAO>("Annonce_DAO");
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());

            ////Configuration et services API Web

            //Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }


    }   
}
