using System.Linq;
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
            var diaryEntry = _contentDelivery.GetEntry(string.Format("{0}-{1}", year, month));

            if (diaryEntry.Timeline != null && diaryEntry.Timeline.Any())
            {
                // This is a different diary view that has dated entries and not just a master entry for the entire month.
                return View("Timeline", new TimelineViewModel(year - 2004, diaryEntry.Timeline));

            }
            return View("Entry", new DiaryEntryViewModel(year - 2004, diaryEntry));
        }

        public ActionResult Week(int year, int week)
        {
            var diaryEntry = _contentDelivery.GetEntry(string.Format("{0}-{1}", year, week));

            return View("Entry", new DiaryEntryViewModel(year - 2004, diaryEntry));
        }

        public ActionResult Year(int year)
        {
            return View(new YearViewModel(year));
        }
    }
}
