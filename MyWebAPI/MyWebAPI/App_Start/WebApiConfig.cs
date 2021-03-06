using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name:"School",
                routeTemplate:"api/myschool/{id}",
                defaults: new { controller="school", id = RouteParameter.Optional },
                constraints: new { id="/d+" }
                
                );;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
