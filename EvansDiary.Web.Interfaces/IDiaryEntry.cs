using System.Collections.Generic;

namespace EvansDiary.Web.Interfaces
{
    public interface IDiaryEntry
    {
        string EntryOne { get; set; }

        string EntryTag { get; set; }

        string EntryTwo { get; set; }

        List<IAssociatedImage> ImagesForEntry { get; set; }
    }
}