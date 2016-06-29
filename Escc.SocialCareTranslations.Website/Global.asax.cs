using System.Web.Mvc;
using System.Web.Routing;

namespace Escc.SocialCareTranslations.Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
