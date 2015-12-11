using System.Web.Mvc;
using System.Web.Routing;

namespace EvansDiary.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Diary",
                "diary",
                new { controller = "Diary", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                "Years",
                "diary/year/{year}",
                new { controller = "Diary", action = "Year", id = UrlParameter.Optional });

            routes.MapRoute(
                "Weeks",
                "diary/year/{year}/week/{week}",
                new { controller = "Diary", action = "Week", id = UrlParameter.Optional });

            routes.MapRoute(
                "Months",
                "diary/year/{year}/{month}",
                new { controller = "Diary", action = "Month", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
