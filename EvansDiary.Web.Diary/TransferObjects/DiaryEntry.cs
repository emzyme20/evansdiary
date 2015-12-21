using System.Collections.Generic;
using EvansDiary.Interfaces;

namespace EvansDiary.Web.Diary.TransferObjects
{
    public class DiaryEntry : IDiaryEntry
    {
        public List<ITimeLineEntry> Timeline { get; set; }

        public string Tag { get; set; }
        public string Headline { get; set; }
    }
}
