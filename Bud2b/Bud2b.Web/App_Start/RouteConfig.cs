using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace Bud2b
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/{resource}.axd/{*pathInfo}");

            // This will add the parameter "subdomain" to the route parameters
            routes.Add(new SubdomainRoute());

            routes.MapMvcAttributeRoutes();
        }

        public class SubdomainRoute : RouteBase
        {
            public override RouteData GetRouteData(HttpContextBase httpContext)
            {
                if (httpContext.Request == null || httpContext.Request.Url == null)
                {
                    return null;
                }

                var host = httpContext.Request.Url.Host;
                var index = host.IndexOf(".");
                string[] segments = httpContext.Request.Url.PathAndQuery.TrimStart('/').Split('/');

                if (index < 0)
                {
                    return null;
                }

                var subdomain = host.Substring(0, index);
                string[] blacklist = { "www", "yourdomain", "mail" };

                if (blacklist.Contains(subdomain))
                {
                    return null;
                }

                return null;
            }
            public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
            {
                //Implement your formating Url formating here
                return null;
            }
        }
    }
}