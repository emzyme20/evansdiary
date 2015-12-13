using EvansDiary.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class AssociatedImage : IAssociatedImage
    {
        public AssociatedImage(string source, string caption)
        {
            Source = source;
            Caption = caption;
        }

        public string Caption { get; set; }

        public string Source { get; set; }
        public string GetUrl()
        {
            return "http://res.cloudinary.com/dqg9nkccw/image/upload/c_fill,w_260/" + Source + ".png";
        }
    }
}
