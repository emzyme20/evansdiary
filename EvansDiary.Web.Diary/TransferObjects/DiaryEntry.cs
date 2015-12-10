using System.Collections.Generic;

using EvansDiary.Web.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class DiaryEntry : IDiaryEntry
    {
        public DiaryEntry()
        {
            ImagesForEntry = new List<IAssociatedImage>();
        }

        public string EntryOne { get; set; }

        public string EntryTag { get; set; }

        public string EntryTwo { get; set; }

        public List<IAssociatedImage> ImagesForEntry { get; set; }
    }
}
