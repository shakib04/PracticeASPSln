using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //place before default route
            routes.MapRoute(
                "MovieByReleaseDate",
                "movie/released/{year}/{month}",
                new {controller = "Movie", action = "ByReleaseDate" },
                new {year = @"2015|2016", month = @"\d{2}"} //d=digit, @=escape sequence, {4} max and min 4 digit
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
