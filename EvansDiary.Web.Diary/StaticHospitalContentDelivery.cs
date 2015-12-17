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

            _diaryEntries
                .Add(
                    3,
                    new HospitalEntry
                    {
                        Title = "Day 3 - Intensive Care (Saturday 9th)",
                        Day = 3,
                        Entry = md.Transform(Hospital.DayThree)
                    });

            _diaryEntries
                .Add(
                    4,
                    new HospitalEntry
                    {
                        Title = "Day 4 - Intensive Care (Sunday 10th)",
                        Day = 4,
                        Entry = md.Transform(Hospital.DayFour)
                    });

            _diaryEntries
                .Add(
                    5,
                    new HospitalEntry
                    {
                        Title = "Day 5 - Intensive Care (Monday 11th)",
                        Day = 5,
                        Entry = md.Transform(Hospital.DayFive)
                    });

            _diaryEntries
                .Add(
                    6,
                    new HospitalEntry
                    {
                        Title = "Day 6 - Intensive Care (Tuesday 12th)",
                        Day = 6,
                        Entry = md.Transform(Hospital.DaySix)
                    });

            _diaryEntries
                .Add(
                    7,
                    new HospitalEntry
                    {
                        Title = "Day 7 - Intensive Care (Wednesday 13th)",
                        Day = 7,
                        Entry = md.Transform(Hospital.DaySeven)
                    });

            _diaryEntries
                .Add(
                    8,
                    new HospitalEntry
                    {
                        Title = "Day 8 - Intensive Care (Thursday 14th)",
                        Day = 8,
                        Entry = md.Transform(Hospital.DayEight)
                    });

            _diaryEntries
                .Add(
                    9,
                    new HospitalEntry
                    {
                        Title = "Day 9 - Gyny Ward (Friday 15th)",
                        Day = 9,
                        Entry = md.Transform(Hospital.DayNine)
                    });

            _diaryEntries
                .Add(
                    10,
                    new HospitalEntry
                    {
                        Title = "Day 10 - Gyny Ward (Saturday 16th)",
                        Day = 10,
                        Entry = md.Transform(Hospital.DayTen)
                    });

            _diaryEntries
                .Add(
                    11,
                    new HospitalEntry
                    {
                        Title = "Day 11 - Gyny Ward (Sunday 17th)",
                        Day = 11,
                        Entry = md.Transform(Hospital.DayEleven)
                    });
        }
    }
}