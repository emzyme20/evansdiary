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
                            new AssociatedImage("w0-emma-first-hold_n1knip", "Emma holding Evan for the first time"),
                            new AssociatedImage("w0_midwife_gpdp3v", "Our wonderful midwife, Valeska"),
                            new AssociatedImage("w0_before_birth_qzqa9r", "Emma in the labour ward, before the birth"),
                            new AssociatedImage("w0_caroline_first_hold_mgodvl", "Caroline with Evan a few minutes after the birth")
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
                            new AssociatedImage("w1_evan_peaceful_hqreul", "Caroline's first view of Evan in hospital, just a few hours old"),
                            new AssociatedImage("w1_emmas_mum_psbo4x", "Emma's Mum with Evan"),
                            new AssociatedImage("w1_emma_evan_bed_s7904r", "Emma and Evan, peaceful in hospital"),
                            new AssociatedImage("w1_evans_foot_a5kkre", "What a cute footsie!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-2",
                    new DiaryEntry
                    {
                        Title = "2nd - 8th January 2005",
                        Tag = "2",
                        EntryOne = md.Transform(Year2005.y1w2One),
                        EntryTwo = md.Transform(Year2005.y1w2Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w2_sleepy_baby_vvnnrh", "Such a hard life"),
                            new AssociatedImage("w2_ooh_looking_at_emma_jzyu66", "One of Evan's cute little expressions! 'Hello mummy!'"),
                            new AssociatedImage("w2_being_changed_ctnjl4", "Evan grumbling at having his nappy changed"),
                            new AssociatedImage("w2_hard_life_jxyqgs", "Sleepy baby")
                        }
                    });
        }
    }
}
