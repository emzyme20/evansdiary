﻿using EvansDiary.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class HospitalDiaryEntryViewModel
    {
        public HospitalDiaryEntryViewModel(IHospitalEntry entry)
        {
            Entry = entry.Entry;
            Day = entry.Day;
            Title = entry.Title;
        }

        public int Day { get; set; }

        public string Entry { get; set; }

        public string Title { get; set; }
    }
}
