using System.Web.Mvc;

using EvansDiary.Interfaces;
using EvansDiary.Web.ViewModels;

namespace EvansDiary.Web.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IStaticHospitalContentDelivery _contentDelivery;

        public HospitalController(IStaticHospitalContentDelivery contentDelivery)
        {
            _contentDelivery = contentDelivery;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Day(int day)
        {
            if (day == 0)
            {
                return RedirectToAction(nameof(Day), new { day = 1 });
            }

            var diaryEntry = _contentDelivery.GetEntry(day);
            return View(new HospitalDiaryEntryViewModel(diaryEntry));
        }
    }
}
