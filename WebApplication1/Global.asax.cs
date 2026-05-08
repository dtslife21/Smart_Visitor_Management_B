using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using WebApplication1.DataAccess;
using WebApplication1.Interfaces;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AreaRegistration.RegisterAllAreas();
            UnityContainer container = new UnityContainer();
            UnityConfig.RegisterComponents();

            //container.RegisterType<ITest, DATest>();
        }


        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Get the origin of the request
            var origin = HttpContext.Current.Request.Headers["Origin"];

            // Allow only specific domains
            if (!string.IsNullOrEmpty(origin) &&
              (origin == "https://secureguest.dtselife.com"
               || origin == "http://localhost:3000"
              ))
            {
                HttpContext.Current.Response.Headers.Set("Access-Control-Allow-Origin", origin);
                HttpContext.Current.Response.Headers.Set("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                HttpContext.Current.Response.Headers.Set("Access-Control-Allow-Headers", "Content-Type, Authorization");
            }

            // Handle OPTIONS preflight request
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.StatusCode = 200;
                HttpContext.Current.Response.End();
            }
        }
    }
}