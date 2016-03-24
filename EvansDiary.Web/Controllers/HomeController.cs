using System.Collections.Generic;
using System.Web.Mvc;
using EvansDiary.Web.Diary.TransferObjects;
using EvansDiary.Web.ViewModels;

namespace EvansDiary.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IEnumerable<FlipbookItemViewModel> Flipbook = new[]
        {
            new FlipbookItemViewModel(new AssociatedImage("w1_evan_peaceful_hqreul", "1 week"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("w5_smiling_now_icxvs3", "5 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w16_commando_iucohe", "16 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w18_ooh_whassat_knacas", "18 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w28_cool_dude_d6c1du", "28 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w36_sand_feels_good_nd9v2f", "36 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w47_after_haircut_rp8ntl", "47 weeks"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("mar_bed_hair_xcmrd3", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("jun_lovely_smile_hnyiew", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("aug_flying_closeup_kwuunw", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("nov_cute_hair_sk4ev7", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("apr_scar_smile_mse9by", "Age 2"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("sept_swing_ocn7bq", "Age 2")),
            new FlipbookItemViewModel(new AssociatedImage("nov_growing_up_zxwyzx", "Age 2")),
            new FlipbookItemViewModel(new AssociatedImage("feb_messy_face_dh4a6a", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_04_f7ywgv", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_06_ainqi8", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_08_y5qxgh", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2009_03_zr4fvo", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_07_eovhtg", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_07_1_s9vcgc", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_09_vcok2t", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_09_1_pys8wk", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_10_syb2oy", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2010_06_cgvkv0", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_08_wfyg6x", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_12_ll2lmd", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_12_1_ccb4xh", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2011_03_pilu4k", "Age 6")),
            new FlipbookItemViewModel(new AssociatedImage("2011_09_mjkbhf", "Age 6")),
            new FlipbookItemViewModel(new AssociatedImage("2012_03_sffbbp", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_05_ptxejx", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_07_zv4xaa", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_09_idvdmz", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2013_02_slwhhw", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2013_05_xynzm8", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2013_10_ishhhq", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2014_04_azb964", "Age 9"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("2014_05_znjgdo", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2014_11_lbwfd1", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2014_12_oo2z5p", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2015_05_gt5hpx", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_08_bakmxq", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_10_tymnze", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_12_m0huh7", "Age 10"))
        };

        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                FlipbookItems = Flipbook
            };

            return View(viewModel);
        }
    }
}
