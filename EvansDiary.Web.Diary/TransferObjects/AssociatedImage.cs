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

        public AssociatedImage(string source, string caption, string width = null)
        {
            Source = source;
            Caption = caption;
            Width = width;
        }

        public string Height { get; set; }
        
        public string Width { get; set; }

        public string Caption { get; set; }

        public string Source { get; set; }
    }
}