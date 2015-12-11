using System.Collections.Generic;

using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.Resources;
using EvansDiary.Web.Diary.TransferObjects;

using MarkdownDeep;

namespace EvansDiary.Web.Diary
{
    public class StaticContentDelivery : IStaticContentDelivery
    {
        public StaticContentDelivery()
        {
            InitialiseStaticContent();
        }

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
            var md = new Markdown { ExtraMode = true, SafeMode = false };

            _diaryEntries
                .Add(
                    "2005-0",
                    new DiaryEntry
                    {
                        Title = "26th December 2004",
                        Tag = "0",
                        EntryOne = md.Transform(Year2005.y1w0One),
                        EntryTwo = md.Transform(Year2005.y1w0Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("/Content/images/diary/years/2005/w0-main.jpg", "Emma holding Evan for the first time"),
                            new AssociatedImage("/Content/images/diary/years/2005/w0_midwife.jpg", "Our wonderful midwife, Valeska"),
                            new AssociatedImage("/Content/images/diary/years/2005/w0_before_birth.jpg", "Emma in the labour ward, before the birth"),
                            new AssociatedImage("/Content/images/diary/years/2005/w0_caroline_first_hold.jpg", "Caroline with Evan a few minutes after the birth")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-1",
                    new DiaryEntry
                    {
                        Title = "26th December 2004 - 1st January 2005",
                        Tag = "1",
                        EntryOne = md.Transform(Year2005.y1w1One),
                        EntryTwo = md.Transform(Year2005.y1w1Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("/Content/images/diary/years/2005/w1-main.jpg", "Caroline's first view of Evan in hospital, just a few hours old"),
                            new AssociatedImage("/Content/images/diary/years/2005/w1_emmas_mum.jpg", "Emma's Mum with Evan"),
                            new AssociatedImage("/Content/images/diary/years/2005/w1_emma_evan_bed.jpg", "Emma and Evan, peaceful in hospital"),
                            new AssociatedImage("/Content/images/diary/years/2005/w1_evans_foot.jpg", "What a cute footsie!")
                        }
                    });
        }
    }
}
