using System.Collections.Generic;
using System.Web.Mvc;
using EvansDiary.Web.Diary.TransferObjects;
using EvansDiary.Web.ViewModels;

namespace EvansDiary.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IEnumerable<FlipbookItemViewModel> _flipbook = new[]
        {
            new FlipbookItemViewModel(new AssociatedImage("w1_evan_peaceful_n7d6jq", "1 week"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("w5_smiling_now_kukeoj", "5 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w16_commando_bsghhv", "16 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w18_ooh_whassat_jittzh", "18 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w28_cool_dude_rulh6a", "28 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w36_sand_feels_good_j7aiut", "36 weeks")),
            new FlipbookItemViewModel(new AssociatedImage("w47_after_haircut_xx0jno", "47 weeks"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("mar_bed_hair_okw5lp", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("jun_lovely_smile_wpgwv8", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("aug_flying_closeup_pb8c59", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("nov_cute_hair_bypigp", "Age 1")),
            new FlipbookItemViewModel(new AssociatedImage("apr_scar_smile_uvwdy9", "Age 2"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("sept_swing_divjqo", "Age 2")),
            new FlipbookItemViewModel(new AssociatedImage("nov_growing_up_drs1cb", "Age 2")),
            new FlipbookItemViewModel(new AssociatedImage("feb_messy_face_g1hzs4", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_04_nbcahx", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_06_nph3bd", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2008_08_oksixb", "Age 3")),
            new FlipbookItemViewModel(new AssociatedImage("2009_03_s1lt5d", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_07_ywt7uy", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_07_1_y0iinc", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_09_uvq9cy", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_09_1_b70ulq", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2009_10_sza2ol", "Age 4")),
            new FlipbookItemViewModel(new AssociatedImage("2010_06_rdcfoq", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_08_sqw3zn", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_12_jkxx8a", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2010_12_1_blztzb", "Age 5")),
            new FlipbookItemViewModel(new AssociatedImage("2011_03_ja2ozr", "Age 6")),
            new FlipbookItemViewModel(new AssociatedImage("2011_09_mhmgxx", "Age 6")),
            new FlipbookItemViewModel(new AssociatedImage("2012_03_zkysra", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_05_rcuakv", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_07_cthmxk", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2012_09_cwt76e", "Age 7")),
            new FlipbookItemViewModel(new AssociatedImage("2013_02_qtavlm", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2013_05_rnc7rw", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2013_10_oiuk7y", "Age 8")),
            new FlipbookItemViewModel(new AssociatedImage("2014_04_ekopsd", "Age 9"), "north"),
            new FlipbookItemViewModel(new AssociatedImage("2014_05_fibdcz", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2014_11_lmgyha", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2014_12_czyq0w", "Age 9")),
            new FlipbookItemViewModel(new AssociatedImage("2015_05_icmzpl", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_08_rqdexp", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_10_rqpipx", "Age 10")),
            new FlipbookItemViewModel(new AssociatedImage("2015_12_fxd97d", "Age 10"))
        };

        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                FlipbookItems = _flipbook
            };

            return View(viewModel);
        }
    }
}
