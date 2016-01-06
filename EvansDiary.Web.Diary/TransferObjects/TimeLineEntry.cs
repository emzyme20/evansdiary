using System.Collections.Generic;
using System.Linq;
using EvansDiary.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class TimeLineEntry : ITimeLineEntry
    {
        public TimeLineEntry()
        {
            Images = new List<IAssociatedImage>();
        }

        public string Entry { get; set; }
        public IAssociatedImage SingleImage { get; set; }
        public List<IAssociatedImage> Images { get; set; }
        public string Subheading { get; set; }
        public bool SwitchImageBlockPosition { get; set; }
        
        public IAssociatedImage GetImage(int index)
        {
            return Images.ElementAtOrDefault(index) ?? new AssociatedImage(string.Empty, string.Empty);
        }
    }
}