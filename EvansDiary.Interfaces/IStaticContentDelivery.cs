using System.Collections.Generic;

namespace EvansDiary.Interfaces
{
    public interface IStaticContentDelivery
    {
        IDiaryEntry GetEntry(string key);

        IEnumerable<IAssociatedImage> GetImages(int year);
    }
}