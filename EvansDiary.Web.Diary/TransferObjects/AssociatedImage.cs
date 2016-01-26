using System.Text;

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
        public string GetUrl(double? width)
        {
            var options = new StringBuilder(",q_90,w_");
            if (width.HasValue)
            {
                options.Append(width);
            }
            else
            {
                options.Append("285");
            }
            options.Append("/");

            return "http://res.cloudinary.com/dqg9nkccw/image/upload/c_fill" + options + Source + ".jpg";
        }
    }
}
