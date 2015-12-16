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

        public ActionResult Day(int day)
        {
            var diaryEntry = _contentDelivery.GetEntry(day);

            return View(new HospitalDiaryEntryViewModel(day == 1, diaryEntry));
        }
    }
}
