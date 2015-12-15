using System.Collections.Generic;

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

        public string Tag { get; set; }

        public string Title { get; set; }
    }
}
