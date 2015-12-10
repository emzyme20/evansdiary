using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using EvansDiary.Web.Bootstrap;

using SimpleInjector;

namespace EvansDiary.Web
{
    public class MvcApplication : HttpApplication
    {
        private static Container _container;

        protected void Application_Start()
        {
            _container = this.InitBootstrap();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
