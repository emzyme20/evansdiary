using System.Collections.Generic;

using EvansDiary.Web.Diary.Resources;
using EvansDiary.Web.Diary.TransferObjects;
using EvansDiary.Web.Interfaces;

namespace EvansDiary.Web.Diary
{
    public class StaticContentDelivery : IStaticContentDelivery
    {
        protected Dictionary<string, IDiaryEntry> _diaryEntries = new Dictionary<string, IDiaryEntry>();

        public IDiaryEntry GetEntry(string key)
        {
            if (_diaryEntries.ContainsKey(key))
            {
                return _diaryEntries[key];
            }
            return new DiaryEntry();
        }

        public void InitialiseStaticContent()
        {
            var year2005 = new DiaryEntry
            {
                EntryTag = "0",
                EntryOne = Year2005.w0One,
                EntryTwo = Year2005.w0Two
            };

            _diaryEntries.Add("2005-0", year2005);
        }
    }
}
