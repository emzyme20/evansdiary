using EvansDiary.Web.Interfaces;

namespace EvansDiary.Web.ViewModels
{
    public class DiaryEntryViewModel
    {
        private readonly IDiaryEntry _diaryEntry;

        public DiaryEntryViewModel(IDiaryEntry diaryEntry)
        {
            _diaryEntry = diaryEntry;
        }

        public string EntryOne
        {
            get
            {
                return _diaryEntry.EntryOne;
            }
        }

        public string EntryTwo
        {
            get
            {
                return _diaryEntry.EntryTwo;
            }
        }

    }
}
