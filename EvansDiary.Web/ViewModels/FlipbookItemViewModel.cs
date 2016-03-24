using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class FlipbookItemViewModel
    {
        public FlipbookItemViewModel(IAssociatedImage image, string crop = null)
        {
            Image = image;
            Crop = crop;
        }

        public string Crop { get; set; }

        public IAssociatedImage Image { get; set; }
    }
}