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
                new { controller = "Diary", action = "Index" });

            routes.MapRoute(
                "Years",
                "diary/year/{year}",
                new { controller = "Diary", action = "Year" });

            routes.MapRoute(
                "Weeks",
                "diary/year/{year}/week/{week}",
                new { controller = "Diary", action = "Week" });

            routes.MapRoute(
                "Months",
                "diary/year/{year}/{month}",
                new { controller = "Diary", action = "Month" });

            routes.MapRoute(
                "Hospital-Diary",
                "hospital/day/{day}",
                new { controller = "Hospital", action = "Day" });

            routes.MapRoute(
                "Home",
                "",
                new { controller = "Home", action = "Index" });
        }
    }
}
