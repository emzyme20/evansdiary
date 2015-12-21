using System.Collections.Generic;
using System.Linq;

using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class TimelineViewModel
    {
        private readonly List<IDiaryEntry> _diaryEntries;

        public TimelineViewModel(int year, List<IDiaryEntry> diaryEntries)
        {
            Year = year;
            _diaryEntries = diaryEntries;
            Tag = diaryEntries.First().Tag;
        }

        public string Tag { get; set; }

        public int Year { get; set; }

        public IEnumerable<IDiaryEntry> GetEntries()
        {
            foreach (var diaryEntry in _diaryEntries)
            {
                yield return diaryEntry;
            }
        }
    }
}
