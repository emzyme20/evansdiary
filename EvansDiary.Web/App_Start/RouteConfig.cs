using System.Web.Mvc;
using System.Web.Routing;
using EvansDiary.Web.Controllers;
using EvansDiary.Web.Diary.Extensions;

namespace EvansDiary.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute<AthleticsController>(c => c.Index(), "athletics");
            routes.MapRoute<DiaryController>(c => c.Index(), "diary");
            routes.MapRoute<DiaryController>(c => c.Year(0), "diary/year/{year}");
            routes.MapRoute<DiaryController>(c => c.Week(0, 0), "diary/year/{year}/week/{week}");
            routes.MapRoute<DiaryController>(c => c.Month(0, string.Empty), "diary/year/{year}/{month}");
            routes.MapRoute<HospitalController>(c => c.Day(0), "hospital/day/{day}");
            routes.MapRoute<HomeController>(c => c.Index(), "");
        }
    }
}
