using System.Linq;

using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.TransferObjects;

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

        public string Tag
        {
            get
            {
                return _diaryEntry.Tag;
            }
        }

        public string Title
        {
            get
            {
                return _diaryEntry.Title;
            }
        }

        public IAssociatedImage GetImage(int index)
        {
            var image = _diaryEntry.Images.ElementAt(index);
            return image ?? new AssociatedImage(string.Empty, string.Empty);
        }
    }
}
