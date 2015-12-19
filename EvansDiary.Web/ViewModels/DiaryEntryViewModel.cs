using System.Linq;
using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.TransferObjects;

namespace EvansDiary.Web.ViewModels
{
    public class DiaryEntryViewModel
    {
        public int Year { get; set; }
        private readonly IDiaryEntry _diaryEntry;

        public DiaryEntryViewModel(int year, IDiaryEntry diaryEntry)
        {
            Year = year;
            _diaryEntry = diaryEntry;
            ImageBlocks = diaryEntry.Images.Count/4;
        }

        public string EntryOne
        {
            get { return _diaryEntry.EntryOne; }
        }

        public int ImageBlocks { get; set; }

        public IAssociatedImage EntryOneAdditionalImage
        {
            get { return _diaryEntry.EntryOneAdditionalImage; }
        }

        public string EntryTwo
        {
            get { return _diaryEntry.EntryTwo; }
        }

        public string Tag
        {
            get { return _diaryEntry.Tag; }
        }

        public string Title
        {
            get { return _diaryEntry.Title; }
        }

        public IAssociatedImage GetImage(int index)
        {
            var image = _diaryEntry.Images.ElementAtOrDefault(index);
            return image ?? new AssociatedImage(string.Empty, string.Empty);
        }
    }
}