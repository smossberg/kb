using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Category",
            //    url: "KB/Articles/{category}",
            //    defaults: new { controller = "Article", action = "Articles", category = UrlParameter.Optional }
            //    ); 

            //routes.MapRoute(
            //    name: "KB",
            //    url: "KB/{action}/{id}",
            //    defaults: new { controller = "Article", action = "Articles", id = UrlParameter.Optional }
            //    ); 
                

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Article", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}