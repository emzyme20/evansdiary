using System.Collections.Generic;

using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class TimelineViewModel
    {
        private readonly List<ITimeLineEntry> _timeline;

        public TimelineViewModel(int year, IDiaryEntry diaryEntry)
        {
            Year = year;
            _timeline = diaryEntry.Timeline;
            Tag = diaryEntry.Tag;
            Headline = diaryEntry.Headline;
        }

        public string Tag { get; set; }
        public string Headline { get; set; }

        public int Year { get; set; }

        public IEnumerable<ITimeLineEntry> GetEntries()
        {
            foreach (var entry in _timeline)
            {
                yield return entry;
            }
        }
    }
}
