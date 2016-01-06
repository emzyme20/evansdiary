using System.Collections.Generic;

namespace EvansDiary.Interfaces
{
    public interface ITimeLineEntry
    {
        string Entry { get; set; }

        IAssociatedImage SingleImage { get; set; }

        List<IAssociatedImage> Images { get; set; }

        string Subheading { get; set; }

        bool SwitchImageBlockPosition { get; set; }

        IAssociatedImage GetImage(int index);
    }
}
