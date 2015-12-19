using System.Web.Mvc;

using EvansDiary.Interfaces;
using EvansDiary.Web.ViewModels;

namespace EvansDiary.Web.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IStaticContentDelivery _contentDelivery;

        public DiaryController(IStaticContentDelivery contentDelivery) 
        {
            _contentDelivery = contentDelivery;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Month(int year, string month)
        {
            return View();
        }

        public ActionResult Week(int year, int week)
        {
            var diaryEntry = _contentDelivery.GetEntry(string.Format("{0}-{1}", year, week));

            return View(new DiaryEntryViewModel(1, diaryEntry));
        }

        public ActionResult Year(int year)
        {
            return View(new YearViewModel(year));
        }
    }
}
