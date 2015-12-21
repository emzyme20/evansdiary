using System.Collections.Generic;
using System.Linq;

using EvansDiary.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class DiaryEntry : IDiaryEntry
    {
        public DiaryEntry()
        {
            Images = new List<IAssociatedImage>();
        }

        public string EntryOne { get; set; }

        public IAssociatedImage EntryOneAdditionalImage { get; set; }

        public string EntryTwo { get; set; }

        public List<IAssociatedImage> Images { get; set; }

        public List<IDiaryEntry> Timeline { get; set; }

        public string Tag { get; set; }

        public string Title { get; set; }

        public IAssociatedImage GetImage(int index)
        {
            return Images.ElementAtOrDefault(index) ?? new AssociatedImage(string.Empty, string.Empty);
        }
    }
}
