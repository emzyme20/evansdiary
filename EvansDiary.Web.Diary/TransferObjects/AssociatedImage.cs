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
        public string GetUrl(double? width, int? quality)
        {
            var options = new StringBuilder(",w_");
            if (width.HasValue)
            {
                options.Append(width);
            }
            else
            {
                options.Append("285");
            }

            if (quality.HasValue)
            {
                options.Append(",q_");
                options.Append(quality);
            }
            else
            {
                options.Append(",q_90");
            }
            options.Append("/");

            return "http://res.cloudinary.com/dqg9nkccw/image/upload/c_fill" + options + Source + ".jpg";
        }
    }
}
