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
                            new AssociatedImage("w2_resting_ao0kl8", "Both of us having a rest")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-3",
                    new DiaryEntry
                    {
                        Title = "9th - 15th January 2005",
                        Tag = "3",
                        EntryOne = md.Transform(Year2005.y1w3One),
                        EntryTwo = md.Transform(Year2005.y1w3Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w3_zonked_sekjad", "Completely zonked out! Too much boob! :-)"),
                            new AssociatedImage("w3_matching_socks_inodja", "Outfit includes matching socks"),
                            new AssociatedImage("w3_playgym_uv93jb", "A rare moment amusing himself on the play gym"),
                            new AssociatedImage("w3_wind_struggles_pihf4z", "Practicing different winding techniques")
                        }
                    });


            _diaryEntries
                .Add(
                    "2005-4",
                    new DiaryEntry
                    {
                        Title = "16th - 22nd January 2005",
                        Tag = "4",
                        EntryOne = md.Transform(Year2005.y1w4One),
                        EntryTwo = md.Transform(Year2005.y1w4Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w4_keep_rocking_boo6gx", "Evan letting Grandma know that she'll need to rock him for longer!"),
                            new AssociatedImage("w4_right_mitt_lgnu1a", "Have you seen my left mitt?"),
                            new AssociatedImage("w4_mindy_awckvt", "Emma's mums dog Mindy is very intrigued by this new creature!"),
                            new AssociatedImage("w4_left_mitt_yelxko", "Where's my right mitt now?!?")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-5",
                    new DiaryEntry
                    {
                        Title = "23rd - 29th January 2005",
                        Tag = "5",
                        EntryOne = md.Transform(Year2005.y1w5One),
                        EntryTwo = md.Transform(Year2005.y1w5Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w5_smiling_now_icxvs3", "Look Mummy, I can smile now"),
                            new AssociatedImage("w5_sofa_snooze_mmnknc", "No trouble sleeping on the sofa"),
                            new AssociatedImage("w5_baldy_s19zos", "I know you're looking at my bald patch, stop it!"),
                            new AssociatedImage("w5_nice_and_warm_f1sreg", "All nice and warm in here")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-6",
                    new DiaryEntry
                    {
                        Title = "30th January - 5th February 2005",
                        Tag = "6",
                        EntryOne = md.Transform(Year2005.y1w6One),
                        EntryTwo = md.Transform(Year2005.y1w6Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w6_giggles_uyubtv", "Evan likes his change mat a lot for some reason!"),
                            new AssociatedImage("w6_jazz_hands_yrqdum", "Evan doing his 'Jazz Hands'"),
                            new AssociatedImage("w6_tootsies_o96rio", "Thumbs Up! Oh no, that's tootsies!"),
                            new AssociatedImage("w6_cutest_sleeper_ymiern", "Just the cutest little sleeper")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-7",
                    new DiaryEntry
                    {
                        Title = "6th - 12th February 2005",
                        Tag = "7",
                        EntryOne = md.Transform(Year2005.y1w7One),
                        EntryTwo = md.Transform(Year2005.y1w7Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w7_whats_this_tgq4zu", "hmmm... what's this?"),
                            new AssociatedImage("w7_cute_with_tears_lrhjcn", "So cute, even with tears!"),
                            new AssociatedImage("w7_smiling_for_nan_oyz3gu", "Yep, I can hold it Mum!"),
                            new AssociatedImage("w7_holding_bottle_qdmcu5", "Evan smiling at Caroline's Mum")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-8",
                    new DiaryEntry
                    {
                        Title = "13th - 19th February 2005",
                        Tag = "8",
                        EntryOne = md.Transform(Year2005.y1w8One),
                        EntryTwo = md.Transform(Year2005.y1w8Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w8_are_you_sure_co5zvs", "Are you sure you want me to pick you up?"),
                            new AssociatedImage("w8_yes_i_am_sure_mrakwh", "Yes, I'm sure!"),
                            new AssociatedImage("w8_tummy_time_e1kkre", "Evan, demonstrating the benefits of tummy time"),
                            new AssociatedImage("w8_stuffed_i2nrmd", "Stuffed from a good feed")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-9",
                    new DiaryEntry
                    {
                        Title = "20th - 26th February 2005",
                        Tag = "9",
                        EntryOne = md.Transform(Year2005.y1w9One),
                        EntryTwo = md.Transform(Year2005.y1w9Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w9_getting_stronger_uktkk6", "Getting stronger"),
                            new AssociatedImage("w9_peekaboo_dx59ff", "Peek-a-boo"),
                            new AssociatedImage("w9_hello_billy_wcbpep", "Hello Billy, my name's Evan!"), 
                            new AssociatedImage("w9_all_smiles_mtztcb", "All smiles")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-10",
                    new DiaryEntry
                    {
                        Title = "27th February - 5th March 2005",
                        Tag = "10",
                        EntryOne = md.Transform(Year2005.y1w10One),
                        EntryTwo = md.Transform(Year2005.y1w10Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w10_tight_trousers_suiujs", "Yes, my trousers are far too tight, and No, I'm not happy about it!"),
                            new AssociatedImage("w10_lovely_eyes_a4yh6m", "Lovely eyes with long lashes"),
                            new AssociatedImage("w10_new_hat_g1wahu", "Do you like my new hat?"),
                            new AssociatedImage("w10_double_tummy_time_bvmitx", "Double tummy time")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-11",
                    new DiaryEntry
                    {
                        Title = "6th - 12th March 2005",
                        Tag = "11",
                        EntryOne = md.Transform(Year2005.y1w11One),
                        EntryTwo = md.Transform(Year2005.y1w11Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w11_bath_time_z5heur", "Evan, showing his happy face during bath time"),
                            new AssociatedImage("w11_grumpy_face_jgckvx", "Evan, doing his best impression of Emma with his grumpy face!"),
                            new AssociatedImage("w11_munching_molly_ihbt63", "Evan about to munch on Molly Moo Moo (a toy cow!)"),
                            new AssociatedImage("w11_less_sick_iqgjbk", "Finally, the milk reflux has subsided")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-12",
                    new DiaryEntry
                    {
                        Title = "13th - 19th March 2005",
                        Tag = "12",
                        EntryOne = md.Transform(Year2005.y1w12One),
                        EntryTwo = md.Transform(Year2005.y1w12Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w12_chewing_fist_cwrcel", "Evan demonstrating his new fist-chewing ability"),
                            new AssociatedImage("w12_frown_glysqn", "Loving the frown"),
                            new AssociatedImage("w12_holding_billy_noce4r", "Evan likes to carry his toys around with him these days"),
                            new AssociatedImage("w12_just_hanging_ogacsw", "Just hanging...")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-13",
                    new DiaryEntry
                    {
                        Title = "20th - 26th March 2005",
                        Tag = "13",
                        EntryOne = md.Transform(Year2005.y1w13One),
                        EntryTwo = md.Transform(Year2005.y1w13Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w13_examining_fish_ogyeq0", "Hmmm, interesting species of fish!"),
                            new AssociatedImage("w13_wee_protection_dp1ygk", "Protection from wee!"),
                            new AssociatedImage("w13_muslin_eswwzj", "I'm hiding, you can't see me :)"),
                            new AssociatedImage("w13_lick_g5dha9", "Tasty!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-14",
                    new DiaryEntry
                    {
                        Title = "27th March - 2nd April 2005",
                        Tag = "14",
                        EntryOne = md.Transform(Year2005.y1w14One),
                        EntryTwo = md.Transform(Year2005.y1w14Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w14_new_cap_hk67gt", "Ok, I do like my new cap after all..."),
                            new AssociatedImage("w14_sleep_shoulder_ssjkhi", "Oh, it's a hard life!"),
                            new AssociatedImage("w14_bath_robe_perdyo", "Showing a bit of leg :)"),
                            new AssociatedImage("w14_hide_seek_hcspuy", "Pillow Den")
                        }
                    });
            
            _diaryEntries
                .Add(
                    "2005-15",
                    new DiaryEntry
                    {
                        Title = "3rd - 9th April 2005",
                        Tag = "15",
                        EntryOne = md.Transform(Year2005.y1w15One),
                        EntryTwo = md.Transform(Year2005.y1w15Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w15_sleeping_beauty_hhqwdv", "Sleeping Beauty?"),
                            new AssociatedImage("w15_splish_splash_xrayyn", "Splish! Splash!"),
                            new AssociatedImage("w15_teddies_vgopcb", "Teddy zone"), 
                            new AssociatedImage("w15_baby_hidden_jsbymt", "There's a baby in there")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-16",
                    new DiaryEntry
                    {
                        Title = "10th - 16th April 2005",
                        Tag = "16",
                        EntryOne = md.Transform(Year2005.y1w16One),
                        EntryTwo = md.Transform(Year2005.y1w16Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w16_sunday_best_u9gro7", "Evan looking all smart"),
                            new AssociatedImage("w16_grandmas_swing_r2pd47", "I still like my swing Grandma"), 
                            new AssociatedImage("w16_commando_iucohe", "Practicing for the Commandos!"),
                            new AssociatedImage("w16_best_seller_sgifxh", "Reading the latest best seller")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-17",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "17",
                        EntryOne = md.Transform(Year2005.y1w17One),
                        EntryTwo = md.Transform(Year2005.y1w17Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-18",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "18",
                        EntryOne = md.Transform(Year2005.y1w18One),
                        EntryTwo = md.Transform(Year2005.y1w18Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-19",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "19",
                        EntryOne = md.Transform(Year2005.y1w19One),
                        EntryTwo = md.Transform(Year2005.y1w19Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-20",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "20",
                        EntryOne = md.Transform(Year2005.y1w20One),
                        EntryTwo = md.Transform(Year2005.y1w20Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-21",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "21",
                        EntryOne = md.Transform(Year2005.y1w21One),
                        EntryTwo = md.Transform(Year2005.y1w21Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-22",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "22",
                        EntryOne = md.Transform(Year2005.y1w22One),
                        EntryTwo = md.Transform(Year2005.y1w22Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-23",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "23",
                        EntryOne = md.Transform(Year2005.y1w23One),
                        EntryTwo = md.Transform(Year2005.y1w23Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });
            
            _diaryEntries
                .Add(
                    "2005-24",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "24",
                        EntryOne = md.Transform(Year2005.y1w24One),
                        EntryTwo = md.Transform(Year2005.y1w24Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""),
                            new AssociatedImage("", ""),
                            new AssociatedImage("", ""),
                            new AssociatedImage("", "")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "",
                        EntryOne = md.Transform(Year2005.y1w14One),
                        EntryTwo = md.Transform(Year2005.y1w14Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", ""), 
                            new AssociatedImage("", "")
                        }
                    });
        }
    }
}
