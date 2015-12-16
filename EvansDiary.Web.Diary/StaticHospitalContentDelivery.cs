using System.Collections.Generic;

using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.Resources;
using EvansDiary.Web.Diary.TransferObjects;

using MarkdownDeep;

namespace EvansDiary.Web.Diary
{
    public class StaticHospitalContentDelivery : IStaticHospitalContentDelivery
    {
        public StaticHospitalContentDelivery()
        {
            InitialiseStaticContent();
        }

        protected Dictionary<int, IHospitalEntry> _diaryEntries = new Dictionary<int, IHospitalEntry>();

        public IHospitalEntry GetEntry(int key)
        {
            if (_diaryEntries.ContainsKey(key))
            {
                return _diaryEntries[key];
            }
            return new HospitalEntry();
        }

        public void InitialiseStaticContent()
        {
            var md = new Markdown { ExtraMode = true, SafeMode = false };

            _diaryEntries
                .Add(
                    1,
                    new HospitalEntry
                    {
                        Title = "Day 1 - A & E (Thursday 7th July 2005)",
                        Day = 1,
                        Entry = md.Transform(Hospital.DayOne)
                    });

            _diaryEntries
                .Add(
                    2,
                    new HospitalEntry
                    {
                        Title = "Day 2 - Gyny (Friday 8th)",
                        Day = 2,
                        Entry = md.Transform(Hospital.DayTwo)
                    });
        }
    }
}