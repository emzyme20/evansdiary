using System.Collections.Generic;

namespace EvansDiary.Interfaces
{
    public interface IDiaryEntry
    {
        string EntryOne { get; set; }

        IAssociatedImage EntryOneAdditionalImage { get; set; }

        string EntryTwo { get; set; }

        List<IAssociatedImage> Images { get; set; }

        List<IDiaryEntry> Timeline { get; set; }

        string Tag { get; set; }

        string Title { get; set; }

        IAssociatedImage GetImage(int index);
    }
}
