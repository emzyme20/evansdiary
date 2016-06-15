using System.Web.Mvc;
using EvansDiary.Web.Diary.TransferObjects;
using EvansDiary.Web.ViewModels;

namespace EvansDiary.Web.Controllers
{
    public class FamilyController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new FamilyViewModel
            {
                Images = new[]
                {
                    new AssociatedImage("sand_dune_jumping_jk1all", "Leap of Faith", "175"),
                    new AssociatedImage("beach_r7zxeb", "Exmouth 2011", "250"),
                    new AssociatedImage("camping_bokp4f", "Watching the Red Arrows", "250"),
                    new AssociatedImage("torch_hxqf13", "2012 London Olympics", "300"),
                    new AssociatedImage("prior-park-lake_lvnkwn", "Prior Park Lake", "300"),
                    new AssociatedImage("prior-park-selfie_pyrxw7", "Prior Park Selfie", "225"),
                    new AssociatedImage("prior-park-swings_w8bkxd", "Double Swing", "275"),
                    new AssociatedImage("sand_drawing_jldnzm", "New Quay 2016", "175")
                }
            };
            return View(viewModel);
        }
    }
}