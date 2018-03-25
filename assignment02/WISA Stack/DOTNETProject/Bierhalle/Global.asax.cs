using Bierhalle.Models.DAL;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Bierhalle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           new BierhalleContext().Database.Initialize(true);

        }
    }
}
