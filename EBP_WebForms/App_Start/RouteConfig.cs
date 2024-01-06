using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace EBP_WebForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();
        }
    }
}
