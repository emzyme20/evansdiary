using System.Collections.Generic;

using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.Resources;
using EvansDiary.Web.Diary.TransferObjects;

using MarkdownDeep;

namespace EvansDiary.Web.Diary
{
    public class StaticContentDelivery : IStaticContentDelivery
    {
        protected Dictionary<string, IDiaryEntry> _diaryEntries = new Dictionary<string, IDiaryEntry>();

        public StaticContentDelivery()
        {
            InitialiseYearOneContent();
            InitialiseYearTwoContent();
            InitialiseYearThreeContent();
        }

        public IDiaryEntry GetEntry(string key)
        {
            if (_diaryEntries.ContainsKey(key))
            {
                return _diaryEntries[key];
            }
            return new DiaryEntry();
        }

        protected void InitialiseYearOneContent()
        {
            var md = new Markdown { ExtraMode = true, SafeMode = false };

            _diaryEntries
                .Add(
                    "2005-0",
                    new DiaryEntry
                    {
                        Tag = "The Birth!",
                        Headline = "26th December 2004",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w0One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w0Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w0-emma-first-hold_n1knip", "Emma holding Evan for the first time"),
                                    new AssociatedImage("w0_midwife_gpdp3v", "Our wonderful midwife, Valeska"),
                                    new AssociatedImage("w0_before_birth_qzqa9r", "Emma in the labour ward, before the birth"),
                                    new AssociatedImage("w0_caroline_first_hold_mgodvl", "Caroline with Evan a few minutes after the birth")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-1",
                    new DiaryEntry
                    {
                        Headline = "26th December 2004 - 1st January 2005",
                        Tag = "Week 1",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w1One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w1Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w1_evan_peaceful_hqreul", "Caroline's first view of Evan in hospital, just a few hours old"),
                                    new AssociatedImage("w1_emmas_mum_psbo4x", "Emma's mum with Evan"),
                                    new AssociatedImage("w1_emma_evan_bed_s7904r", "Emma and Evan, peaceful in hospital"),
                                    new AssociatedImage("w1_evans_foot_a5kkre", "What a cute footsie!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-2",
                    new DiaryEntry
                    {
                        Headline = "2nd - 8th January 2005",
                        Tag = "Week 2",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w2One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w2Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w2_sleepy_baby_vvnnrh", "Such a hard life"),
                                    new AssociatedImage("w2_ooh_looking_at_emma_jzyu66", "One of Evan's cute little expressions! 'Hello mummy!'"),
                                    new AssociatedImage("w2_being_changed_ctnjl4", "Evan grumbling at having his nappy changed"),
                                    new AssociatedImage("w2_resting_ao0kl8", "Both of us having a rest")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-3",
                    new DiaryEntry
                    {
                        Headline = "9th - 15th January 2005",
                        Tag = "Week 3",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w3One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w3Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w3_zonked_sekjad", "Completely zonked out! Too much boob! :-)"),
                                    new AssociatedImage("w3_matching_socks_inodja", "Outfit includes matching socks"),
                                    new AssociatedImage("w3_playgym_uv93jb",
                                        "A rare moment amusing himself on the play gym"),
                                    new AssociatedImage("w3_wind_struggles_pihf4z",
                                        "Practicing different winding techniques")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-4",
                    new DiaryEntry
                    {
                        Headline = "16th - 22nd January 2005",
                        Tag = "Week 4",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w4One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w4Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w4_keep_rocking_boo6gx",
                                        "Evan letting Grandma know that she'll need to rock him for longer!"),
                                    new AssociatedImage("w4_right_mitt_lgnu1a", "Have you seen my left mitt?"),
                                    new AssociatedImage("w4_mindy_awckvt",
                                        "Emma's mums dog Mindy is very intrigued by this new creature!"),
                                    new AssociatedImage("w4_left_mitt_yelxko", "Where's my right mitt now?!?")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-5",
                    new DiaryEntry
                    {
                        Headline = "23rd - 29th January 2005",
                        Tag = "Week 5",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w5One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w5Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w5_smiling_now_icxvs3", "Look Mummy, I can smile now"),
                                    new AssociatedImage("w5_sofa_snooze_mmnknc", "No trouble sleeping on the sofa"),
                                    new AssociatedImage("w5_baldy_s19zos",
                                        "I know you're looking at my bald patch, stop it!"),
                                    new AssociatedImage("w5_nice_and_warm_f1sreg", "All nice and warm in here")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-6",
                    new DiaryEntry
                    {
                        Headline = "30th January - 5th February 2005",
                        Tag = "Week 6",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w6One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w6Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w6_giggles_uyubtv",
                                        "Evan likes his change mat a lot for some reason!"),
                                    new AssociatedImage("w6_jazz_hands_yrqdum", "Evan doing his 'Jazz Hands'"),
                                    new AssociatedImage("w6_tootsies_o96rio", "Thumbs Up! Oh no, that's tootsies!"),
                                    new AssociatedImage("w6_cutest_sleeper_ymiern", "Just the cutest little sleeper")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-7",
                    new DiaryEntry
                    {
                        Headline = "6th - 12th February 2005",
                        Tag = "Week 7",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w7One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w7Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w7_whats_this_tgq4zu", "hmmm... what's this?"),
                                    new AssociatedImage("w7_cute_with_tears_lrhjcn", "So cute, even with tears!"),
                                    new AssociatedImage("w7_smiling_for_nan_oyz3gu", "Yep, I can hold it Mum!"),
                                    new AssociatedImage("w7_holding_bottle_qdmcu5", "Evan smiling at Caroline's mum")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-8",
                    new DiaryEntry
                    {
                        Headline = "13th - 19th February 2005",
                        Tag = "Week 8",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w8One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w8Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w8_are_you_sure_co5zvs",
                                        "Are you sure you want me to pick you up?"),
                                    new AssociatedImage("w8_yes_i_am_sure_mrakwh", "Yes, I'm sure!"),
                                    new AssociatedImage("w8_tummy_time_e1kkre",
                                        "Evan, demonstrating the benefits of tummy time"),
                                    new AssociatedImage("w8_stuffed_i2nrmd", "Stuffed from a good feed")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-9",
                    new DiaryEntry
                    {
                        Headline = "20th - 26th February 2005",
                        Tag = "Week 9",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w9One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w9Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w9_getting_stronger_uktkk6", "Getting stronger"),
                                    new AssociatedImage("w9_peekaboo_dx59ff", "Peek-a-boo"),
                                    new AssociatedImage("w9_hello_billy_wcbpep", "Hello Billy, my name's Evan!"),
                                    new AssociatedImage("w9_all_smiles_mtztcb", "All smiles")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-10",
                    new DiaryEntry
                    {
                        Headline = "27th February - 5th March 2005",
                        Tag = "Week 10",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w10One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w10Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w10_tight_trousers_suiujs",
                                        "Yes, my trousers are far too tight, and No, I'm not happy about it!"),
                                    new AssociatedImage("w10_lovely_eyes_a4yh6m", "Lovely eyes with long lashes"),
                                    new AssociatedImage("w10_new_hat_g1wahu", "Do you like my new hat?"),
                                    new AssociatedImage("w10_double_tummy_time_bvmitx", "Double tummy time")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-11",
                    new DiaryEntry
                    {
                        Headline = "6th - 12th March 2005",
                        Tag = "Week 11",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w11One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w11Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w11_bath_time_z5heur",
                                        "Evan, showing his happy face during bath time"),
                                    new AssociatedImage("w11_grumpy_face_jgckvx",
                                        "Evan, doing his best impression of Emma with his grumpy face!"),
                                    new AssociatedImage("w11_munching_molly_ihbt63",
                                        "Evan about to munch on Molly Moo Moo (a toy cow!)"),
                                    new AssociatedImage("w11_less_sick_iqgjbk", "Finally, the milk reflux has subsided")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-12",
                    new DiaryEntry
                    {
                        Headline = "13th - 19th March 2005",
                        Tag = "Week 12",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w12One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w12Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w12_chewing_fist_cwrcel",
                                        "Evan demonstrating his new fist-chewing ability"),
                                    new AssociatedImage("w12_frown_glysqn", "Loving the frown"),
                                    new AssociatedImage("w12_holding_billy_noce4r",
                                        "Evan likes to carry his toys around with him these days"),
                                    new AssociatedImage("w12_just_hanging_ogacsw", "Just hanging...")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-13",
                    new DiaryEntry
                    {
                        Headline = "20th - 26th March 2005",
                        Tag = "Week 13",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w13One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w13Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w13_examining_fish_ogyeq0",
                                        "Hmmm, interesting species of fish!"),
                                    new AssociatedImage("w13_wee_protection_dp1ygk", "Protection from wee!"),
                                    new AssociatedImage("w13_muslin_eswwzj", "I'm hiding, you can't see me :)"),
                                    new AssociatedImage("w13_lick_g5dha9", "Tasty!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-14",
                    new DiaryEntry
                    {
                        Headline = "27th March - 2nd April 2005",
                        Tag = "Week 14",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w14One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w14Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w14_new_cap_hk67gt", "Ok, I do like my new cap after all..."),
                                    new AssociatedImage("w14_sleep_shoulder_ssjkhi", "Oh, it's a hard life!"),
                                    new AssociatedImage("w14_bath_robe_perdyo", "Showing a bit of leg :)"),
                                    new AssociatedImage("w14_hide_seek_hcspuy", "Pillow Den")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-15",
                    new DiaryEntry
                    {
                        Headline = "3rd - 9th April 2005",
                        Tag = "Week 15",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w15One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w15Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w15_sleeping_beauty_hhqwdv", "Sleeping Beauty?"),
                                    new AssociatedImage("w15_splish_splash_xrayyn", "Splish! Splash!"),
                                    new AssociatedImage("w15_teddies_vgopcb", "Teddy zone"),
                                    new AssociatedImage("w15_baby_hidden_jsbymt", "There's a baby in there")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-16",
                    new DiaryEntry
                    {
                        Headline = "10th - 16th April 2005",
                        Tag = "Week 16",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w16One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w16Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w16_sunday_best_u9gro7", "Evan looking all smart"),
                                    new AssociatedImage("w16_grandmas_swing_r2pd47", "I still like my swing Grandma"),
                                    new AssociatedImage("w16_commando_iucohe", "Practicing for the Commandos!"),
                                    new AssociatedImage("w16_best_seller_sgifxh", "Reading the latest best seller")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-17",
                    new DiaryEntry
                    {
                        Headline = "17th - 23rd April 2005",
                        Tag = "Week 17",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w17One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w17Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w17_look_dillon_kufrlr", "Evan watching Dillon Donkey"),
                                    new AssociatedImage("w17_very_happy_n8obt8", "Happy Baby"),
                                    new AssociatedImage("w17_cot_cry_oto9v3", "Evan didn't like his cot at first..."),
                                    new AssociatedImage("w17_zonko_tytzud", "... but he likes his cot now :)")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-18",
                    new DiaryEntry
                    {
                        Headline = "24th - 30th April 2005",
                        Tag = "Week 18",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w18One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w18Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w18_ooh_whassat_knacas", "Evan with his curious expression"),
                                    new AssociatedImage("w18_sitting_strong_vv7q7o", "How does that Tottenham song go?"),
                                    new AssociatedImage("w18_sitting_grass_n0iesr", "Sitting on the grass with Mummy"),
                                    new AssociatedImage("w18_chubby_chops_nch5nc", "Look at his cute chubby cheeks!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-19",
                    new DiaryEntry
                    {
                        Headline = "1st - 7th May 2005",
                        Tag = "Week 19",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w19One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w19Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w19_baby_banz_vkuvma", "Evan in his cool new baby banz"),
                                    new AssociatedImage("w19_book_ktfben", "Story time :)"),
                                    new AssociatedImage("w19_tummy_batn3n", "Look at this tummy strength!"),
                                    new AssociatedImage("w19_fist_emluef", "Oh wait!? There's my fist.")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-20",
                    new DiaryEntry
                    {
                        Headline = "8th - 14th May 2005",
                        Tag = "Week 20",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w20One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w20Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w20_gorgeous_e1ic6v", "Gorgeous Mummy and baby"),
                                    new AssociatedImage("w20_standing_wb05ej", "Look Mum! I'm standing up!"),
                                    new AssociatedImage("w20_cats_agynzg", "Evan playing with the cats"),
                                    new AssociatedImage("w20_cats_unsure_jkisxh", "Poppy thinks twice")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-21",
                    new DiaryEntry
                    {
                        Headline = "15th - 21st May 2005",
                        Tag = "Week 21",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w21One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w21Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w21_uncle_neil_zw7sq6", "Evan and his Uncle Neil"),
                                    new AssociatedImage("w21_foot_or_toy_nnrdhh", "Toy or Foot?.... It's a hard life"),
                                    new AssociatedImage("w21_cup_drinking_cmtiso", "Evan learning to drink from a cup"),
                                    new AssociatedImage("w21_yes_its_me_cvqbl3", "Yes, you keep looking at me")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-22",
                    new DiaryEntry
                    {
                        Headline = "22nd - 28th May 2005",
                        Tag = "Week 22",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w22One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w22Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w22_swim_trunks_xjz012", "hmm... now what do I play with?"),
                                    new AssociatedImage("w22_bumbo_yq6rid",
                                        "Oooh what's this? - Evan in his new 'Bumbo Seat'"),
                                    new AssociatedImage("w22_nekkid_xx4ip1", "Evan letting it all hang out"),
                                    new AssociatedImage("w22_baby_rice_uy0nyu", "Mmmmm, baby rice & formula :/")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-23",
                    new DiaryEntry
                    {
                        Headline = "29th May - 4th June 2005",
                        Tag = "Week 23",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w23One),
                                SingleImage = new AssociatedImage("w23_the_party_u8scfn", "The Party"),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w23_cheeky_bottom_bmu0br", "I can see that bottom!"),
                                    new AssociatedImage("w23_great_grandmother_wimpnn", "This is my great nanny!"),
                                    new AssociatedImage("w23_carrot_gkqncr",
                                        "Evan even managed to get carrot on his nose!"),
                                    new AssociatedImage("w23_computer_anr207", "Quiet please, I'm concentrating!")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w23Two)
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-24",
                    new DiaryEntry
                    {
                        Headline = "5th - 11th June 2005",
                        Tag = "Week 24",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w24One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w24Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w24_happy_baby_ng0web", "Yes... the grass tickles my toes!"),
                                    new AssociatedImage("w24_big_cuddles_unbchl",
                                        "Evan sharing a big cuddle with Grandma"),
                                    new AssociatedImage("w24_mel_smzrqq", "Evan with Caroline's best friend Mel"),
                                    new AssociatedImage("w24_vicky_n1s1zh", "Evan asleep on Vicky's shoulder")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-25",
                    new DiaryEntry
                    {
                        Headline = "12th - 18th June 2005",
                        Tag = "Week 25",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w25One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w25_pushchair_lspemu",
                                        "Mmm tasty pushchair, it gets the 'Toes-Up' from me Mum!"),
                                    new AssociatedImage("w25_trendy_cd6ogm", "Trendy boy"),
                                    new AssociatedImage("w25_car_arudgn", "Still prefers to eat his toys"),
                                    new AssociatedImage("w25_asleep_at_dinner_xrarxa",
                                        "Boob or bottle, both seem to send him to sleep")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-26",
                    new DiaryEntry
                    {
                        Headline = "19th - 25th June 2005",
                        Tag = "Week 26",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w26One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w26Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w26_lazy_sunday_cf7yyf", "Lazy Sunday morning..."),
                                    new AssociatedImage("w26_lazy_sunday2_yojgye", "...LOVE..."),
                                    new AssociatedImage("w26_lazy_sunday4_qxibmn", "...him..."),
                                    new AssociatedImage("w26_lazy_sunday3_cvua3k", "...SO MUCH!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-27",
                    new DiaryEntry
                    {
                        Headline = "26th June - 2nd July 2005",
                        Tag = "Week 27",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w27One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w27_carolines_new_hair_pybyio",
                                        "Caroline has a hair cut - 'Bout time we had a pic of her again!"),
                                    new AssociatedImage("w27_zonked_qyvx2a", "It's a hard life"),
                                    new AssociatedImage("w27_sitting_up_rxcgde", "I don't need Mummy's support"),
                                    new AssociatedImage("w27_ice-cream_rmuye6", "Gimme dat ice-cream!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-28",
                    new DiaryEntry
                    {
                        Headline = "3rd - 9th July 2005",
                        Tag = "Week 28",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w28One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w28_hair_style_hatwjl",
                                        "Yes! Mummy has put stuff in my hair..."),
                                    new AssociatedImage("w28_cool_dude_d6c1du",
                                        "Evan showing how well he sits up. He'll sit and play for ages now"),
                                    new AssociatedImage("w28_how_many_fingers_lflgva", "How mny fingers?"),
                                    new AssociatedImage("w28_lush_baby_xhua1l",
                                        "Fluffy blonde hair and gorgeous blue eyes")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-29",
                    new DiaryEntry
                    {
                        Headline = "10th - 16th July 2005",
                        Tag = "Week 29",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w29One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w29Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w29_heat_wave_ngftvr",
                                        "Amidst all the horror - Evan enjoys the heat wave"),
                                    new AssociatedImage("w29_new_toys_kcmuqv", "Evan enjoying his new big boy toys"),
                                    new AssociatedImage("w29_any_resemblance_h0ybcw", "Any resemblance?"),
                                    new AssociatedImage("w29_power_nap_sempgs", "Power nap")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-30",
                    new DiaryEntry
                    {
                        Headline = "17th - 23rd July 2005",
                        Tag = "Week 30",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "Emma's Entry",
                                Entry = md.Transform(Year2005.y1w30One)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "Caroline's Entry",
                                Entry = md.Transform(Year2005.y1w30Two),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w30_high_chair_zui889", "hmmm... definitely room to grow"),
                                    new AssociatedImage("w30_stacking_cups_nw83vy",
                                        "Evan getting psyched up for the collapse"),
                                    new AssociatedImage("w30_tower_crash_m44ihu", "...Boom!"),
                                    new AssociatedImage("w30_always_happy_m0vpfh", "Love how happy he is.")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-31",
                    new DiaryEntry
                    {
                        Headline = "24th - 30th July 2005",
                        Tag = "Week 31",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w31One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w31_dribble_kiss_v1lb7o", "Kiss?"),
                                    new AssociatedImage("w31_euuw_dribble_lmnqf9",
                                        "I show my affection to mummy with lots of dribble"),
                                    new AssociatedImage("w31_got_you_mqwo2u", "Got you..."),
                                    new AssociatedImage("w31_want_one_s96t4l", "Now you!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-32",
                    new DiaryEntry
                    {
                        Headline = "31st July - 6th August 2005",
                        Tag = "Week 32",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w32One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w32_bottle_feed_nrtgjv",
                                        "Evan is self-sufficient when it comes to the bottle"),
                                    new AssociatedImage("w32_team_mascot_cn9m4k", "So... is this team any good Mum?"),
                                    new AssociatedImage("w32_all_fall_down_yidzjx", "eep! here they come!"),
                                    new AssociatedImage("w32_scrambled_egg_t4pm66", "Evan is not a fan of scrambled egg")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-33",
                    new DiaryEntry
                    {
                        Headline = "7th - 13th August 2005",
                        Tag = "Week 33",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w33One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w33_evan_and_friends_uzmyhc",
                                        "Evan enjoying a fun afternoon with his friends"),
                                    new AssociatedImage("w33_sucking_toast_ftgyye",
                                        "Evan having a good suck on his first ever piece of toast"),
                                    new AssociatedImage("w33_biceps_wknqsk", "Look at those biceps!"),
                                    new AssociatedImage("w33_funny_boy_pggzmj", "Funny boy")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-34",
                    new DiaryEntry
                    {
                        Headline = "14th - 20th August 2005",
                        Tag = "Week 34",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w34One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w34_cheeky_chappy_wj2nlc",
                                        "Evan is eyeing up the camera for dinner"),
                                    new AssociatedImage("w34_hello_fluffy_emky6d", "Hello fluffy cat"),
                                    new AssociatedImage("w34_hello_vwlpvf", "Hello!"),
                                    new AssociatedImage("w34_tongue_hvlflr", "Evan can stick out his tongue")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-35",
                    new DiaryEntry
                    {
                        Headline = "21st - 27th August 2005",
                        Tag = "Week 35",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w35One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w35_professional_pose_lfm62g",
                                        "Evan posing for the camera, or is he eyeing up a sleeping cat?"),
                                    new AssociatedImage("w35_nice_n_clean_qkvuku",
                                        "Evan showing an increasing desire to grab the camera"),
                                    new AssociatedImage("w35_hiding_pjaeo8", "I'm hiding"),
                                    new AssociatedImage("w35_big_boy_ltjyw8", "35 weeks and he's almost as big as Emma")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-36",
                    new DiaryEntry
                    {
                        Headline = "28th August - 3rd September 2005",
                        Tag = "Week 36",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w36One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w36_where_are_we_xizm58", "Where are we?"),
                                    new AssociatedImage("w36_what_is_this_u0kvtn", "What is this?"),
                                    new AssociatedImage("w36_strange_feeling_pt8twn",
                                        "The sand feels cold on Evan's toes"),
                                    new AssociatedImage("w36_sand_feels_good_nd9v2f", "Evan loves it")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-37",
                    new DiaryEntry
                    {
                        Headline = "4th - 10th September 2005",
                        Tag = "Week 37",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w37One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w37_tickle_time_zwaq1u", "It's tickle time"),
                                    new AssociatedImage("w37_choosing_toys_jvjujr", "Let me choose the toys today"),
                                    new AssociatedImage("w37_yummy_bath_water_zlugqo", "Yummy bath water"),
                                    new AssociatedImage("w37_all_fours_ctlk6z", "Almost ready to crawl")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-38",
                    new DiaryEntry
                    {
                        Headline = "11th - 17th September 2005",
                        Tag = "Week 38",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w38One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w38_new_seat_oormsl", "Evan sprawling out in his new seat"),
                                    new AssociatedImage("w38_dintons_pastures_qpqyxj",
                                        "Having a break from picking blackberries"),
                                    new AssociatedImage("w38_cutest_foot_xbg42k", "I could just eat his feet"),
                                    new AssociatedImage("w38_play_pen_dn51mb", "Staying safe in the play pen")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-39",
                    new DiaryEntry
                    {
                        Headline = "18th - 24th September 2005",
                        Tag = "Week 39",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w39One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w39_crawling_v14frs", "I can crawl!"),
                                    new AssociatedImage("w39_camera_hunt_bkxsza",
                                        "Taking pictures is tricky now he crawls"),
                                    new AssociatedImage("w39_my_seat_wyssfe", "It's my seat now"),
                                    new AssociatedImage("w39_where_is_on_kgozrx", "How do I turn this back on?")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-40",
                    new DiaryEntry
                    {
                        Headline = "25th September - 1st October 2005",
                        Tag = "Week 40",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w40One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w40_new_toys_hftsfo", "But I want these toys mummy..."),
                                    new AssociatedImage("w40_finger_foods_scd7hi",
                                        "Teaching Evan how to eat finger foods - this was before he mashed them everywhere!"),
                                    new AssociatedImage("w40_finger_foods2_if3sk0", "This biscuit is as big as him"),
                                    new AssociatedImage("w40_tears_jkqy78", "Tears of freedom?")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-41",
                    new DiaryEntry
                    {
                        Headline = "2nd - 8th October 2005",
                        Tag = "Week 41",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w41One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w41_standing_alone_lw9vke", "Woohoo - Look at him now"),
                                    new AssociatedImage("w41_activity_table_f8nsb2",
                                        "Evan enjoying his new found freedom at his new activity table"),
                                    new AssociatedImage("w41_keys_st6umh", "So, that's where my keys are"),
                                    new AssociatedImage("w41_picture_for_mummy_bepmwe",
                                        "Our first picture that Evan made at nursery (pasta shapes glued to paper) ")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-42",
                    new DiaryEntry
                    {
                        Headline = "9th - 15th October 2005",
                        Tag = "Week 42",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w42One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w42_evan_impression_skoa4q", "My impression of Evan"),
                                    new AssociatedImage("w42_play_biting_wv7jjb", "Play biting or fighting?"),
                                    new AssociatedImage("w42_mischievious_ceqpqe", "What are you up to?"),
                                    new AssociatedImage("w42_ball_pit_r70zbv", "Playing with friends")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-43",
                    new DiaryEntry
                    {
                        Headline = "16th - 22nd October 2005",
                        Tag = "Week 43",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w43One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w43_first_shoes_osqu8g", "First pair of shoes"),
                                    new AssociatedImage("w43_first_shoes_closeup_podqjj", "So cute!"),
                                    new AssociatedImage("w43_need_a_haircut_kkisqy", "Someone needs a hair cut"),
                                    new AssociatedImage("w43_tired_baby_eh8lcd", "Aww bless him")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-44",
                    new DiaryEntry
                    {
                        Headline = "23rd - 29th October 2005",
                        Tag = "Week 44",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w44One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w44_sept_filler_image2_rfjglh", "Healthy baby"),
                                    new AssociatedImage("w44_poorly_baby_tjdx4i", "Poorly baby"),
                                    new AssociatedImage("w44_double_poorly_aj2k4o", "Everyone is ill this week"),
                                    new AssociatedImage("w44_sept_filler_image_lqajad", "A lot of baths this week")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-45",
                    new DiaryEntry
                    {
                        Headline = "30th October - 5th November 2005",
                        Tag = "Week 45",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w45One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w45_is_this_bath_lrvv5l", "Is this bath for me?"),
                                    new AssociatedImage("w45_for_me_zayvh1",
                                        "Evan loves to peer into the bath as it is filling up"),
                                    new AssociatedImage("w45_new_trick_j2p3jd",
                                        "Evan's new trick is to drink from the cups as the water trickles through!"),
                                    new AssociatedImage("w45_loves_a_bath_pnx3it", "Delightful :)")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-46",
                    new DiaryEntry
                    {
                        Headline = "6th - 12th November 2005",
                        Tag = "Week 46",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w46One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w46_camera_fascination_g336ah",
                                        "Evan proving how difficult it is to photograph him these days"),
                                    new AssociatedImage("w46_prebath_play_time_ykp6n7", "Pre-bath play time"),
                                    new AssociatedImage("w46_what_ya_doing_oqbptf",
                                        "Evan is interested in everything we do"),
                                    new AssociatedImage("w46_hurry_up_gdhtbu", "Hurry up bath!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-47",
                    new DiaryEntry
                    {
                        Headline = "13th - 19th November 2005",
                        Tag = "Week 47",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w47One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w47_before_haircut_qpvsrj", "Before hair cut"),
                                    new AssociatedImage("w47_after_haircut_rp8ntl", "After hair cut"),
                                    new AssociatedImage("w47_wax_weciuo", "Showing interest in some product"),
                                    new AssociatedImage("w47_lush_xpbspn", "Just beautiful")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-48",
                    new DiaryEntry
                    {
                        Headline = "20th - 26th November 2005",
                        Tag = "Week 48",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w48One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w48_inquisitive_toilet_zqubt8",
                                        "A toilet lock is now a necessity"),
                                    new AssociatedImage("w48_cheeky_hlo7ri", "Cheeky look"),
                                    new AssociatedImage("w48_dribbler_v81hyc", "Dribbletastic"),
                                    new AssociatedImage("w48_not_a_toy_bnpgvj", "Obsessed much with the camera Evan?")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-49",
                    new DiaryEntry
                    {
                        Headline = "27th November - 3rd December 2005",
                        Tag = "Week 49",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w49One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w49_strong_legs_kqhxmb", "Strong legs"),
                                    new AssociatedImage("w49_stocky_chap_kcrkxk", "Stocky chappy"),
                                    new AssociatedImage("w49_peek-a-boo_dsiiiv", "Playing peek-a-boo"),
                                    new AssociatedImage("w49_shopping_pdsjvf",
                                        "Helping to unpack, does not mean eat it first!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-50",
                    new DiaryEntry
                    {
                        Headline = "4th - 10th December 2005",
                        Tag = "Week 50",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w50One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w50_introducing_nneldz",
                                        "Introducing Noodle, the new addition to our growing family"),
                                    new AssociatedImage("w50_first_nativity_o74tfp",
                                        "Getting ready for Evan's first nativity performance"),
                                    new AssociatedImage("w50_first_nativity2_ubugj2",
                                        "Evan is the second one in from the left on the front row"),
                                    new AssociatedImage("w50_noodle_fmwilp", "Settling in very well")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-51",
                    new DiaryEntry
                    {
                        Headline = "11th - 17th December 2005",
                        Tag = "Week 51",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w51One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w51_swings_d3rhkt", "Loves the swings in the park"),
                                    new AssociatedImage("w51_matching_hair_fss2zx",
                                        "Evan's new haircut gets styled like Mummy's"),
                                    new AssociatedImage("w51_grandma_babysits_adsgxu",
                                        "Evan loves it when Grandma feeds him"),
                                    new AssociatedImage("w51_bathroom_fun_lqcbex", "Evan loves bathroom time")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-52",
                    new DiaryEntry
                    {
                        Headline = "18th - 25th December 2005",
                        Tag = "Week 52",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2005.y1w52One),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w52_first_christmas_u0u9z1",
                                        "Evan gets his hands on his presents"),
                                    new AssociatedImage("w52_noisy_toys_mlb0pt", "New toys seem to be going down well"),
                                    new AssociatedImage("w52_christmas_dinner_rjveug",
                                        "Evan is not sure about the crackers and hats"),
                                    new AssociatedImage("w52_it_snows_mphjz5", "It snows at Christmas!"),
                                    new AssociatedImage("w52_happy_birthday_s115yz", "Happy 1st Birthday Evan"),
                                    new AssociatedImage("w52_end_of_the_year_tapbny", "Birthday hug"),
                                    new AssociatedImage("w52_birthday_presents_xv4b6l",
                                        "You are supposed to push it Evan, not climb it"),
                                    new AssociatedImage("w52_still_loves_camera_e7dxmy",
                                        "Yes, Yes, we all know you still love the camera")
                                }
                            }
                        }
                    });
        }

        protected void InitialiseYearTwoContent()
        {
            var md = new Markdown { ExtraMode = true, SafeMode = false };

            _diaryEntries
                .Add(
                    "2006-january",
                    new DiaryEntry
                    {
                        Tag = "January (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Jan),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("jan_sleepy_jzhlg8", "Tired Mummy and Baby"),
                                    new AssociatedImage("jan_scary_funny_bxnmmm", "Scary? No... funny"),
                                    new AssociatedImage("jan_quiet_time_kuqcs8",
                                        "Red cheeks evidence of Evan's new teeth coming through"),
                                    new AssociatedImage("jan_cheeky_chappy_xsqflo", "Adorable cheeky chappy")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-february",
                    new DiaryEntry
                    {
                        Tag = "February (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Feb),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_watching_outside_fc2kmb",
                                        "More interested in the dogs outside"),
                                    new AssociatedImage("feb_retro_toys_srwv4d",
                                        "Evan has found Caroline's Commodore 64 joy sticks!"),
                                    new AssociatedImage("feb_pillow_play_rppadc",
                                        "Creature Comforts! Evan likes to have his pillows near by"),
                                    new AssociatedImage("feb_feeding_himself_doktg7",
                                        "Evan sitting on his stool demonstrating self-service"),
                                    new AssociatedImage("feb_gorgeous_ligjbj", "Evan with his mummy"),
                                    new AssociatedImage("feb_cat_play_cz16fy", "Noodle play??"),
                                    new AssociatedImage("feb_camera_oezvfg",
                                        "Evan is still clearly obssessed with the camera"),
                                    new AssociatedImage("feb_playing_olgrm5",
                                        "Catching a sneaky picture of Evan whilst he is unaware")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-march",
                    new DiaryEntry
                    {
                        Tag = "March (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Mar),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("mar_bed_hair_xcmrd3", "Good morning scruffy head!"),
                                    new AssociatedImage(
                                        "mar_feeds_himself_bxo8hr",
                                        "Evan likes to feed himself when he is not being lazy"),
                                    new AssociatedImage("mar_domesticated_mzth6a", "Now where did I put that washing?"),
                                    new AssociatedImage("mar_food_tasting_ueslch", "Evan is very keen to try new foods"),
                                    new AssociatedImage("mar_indoor_car_gpbppv", "Getting the car ready"),
                                    new AssociatedImage("mar_congestion_fqunat", "Congestion ahead"),
                                    new AssociatedImage("mar_winding_ckbbyb", "Getting the burps out!"),
                                    new AssociatedImage("mar_pants_pxhyk4", "You are supposed to hang out the washing, not wear it!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-april",
                    new DiaryEntry
                    {
                        Tag = "April (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Apr),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("apr_england_hat_xnsst7", "Start them supporting young"),
                                    new AssociatedImage("apr_odds_farm_e5pwwp", "Evan enjoying a ride about at Odds Farm Park"),
                                    new AssociatedImage("apr_stacking_bricks_aj9gkv",
                                        "Evan showing off his stacking skills - his max is 10 so far!"),
                                    new AssociatedImage("apr_piggy_back_kifssv", "Evan loves Mummy's piggy back ride"),
                                    new AssociatedImage("apr_tower_mhruu7", "Evan needs help to complete his duplo towers"),
                                    new AssociatedImage("apr_collecting_stones_b28vrc", "Collecting stones in the garden"),
                                    new AssociatedImage("apr_climbing_frame_gjwf0i", "The swing doubles up as a climbing frame"),
                                    new AssociatedImage("apr_swing_high_ziughk", "A trip to the park swing is necessary for maximum height")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-may",
                    new DiaryEntry
                    {
                        Tag = "May (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2May),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("may_pink_hair_jfk9bz",
                                        "Maybe he wants to be patriotic by dying his hair!"),
                                    new AssociatedImage("may_sleepy_lunch_nqrz4h",
                                        "Oh such a hard life! Evan couldn't even wait for pudding this day..."),
                                    new AssociatedImage("may_world_cup_ready_rbt1dc", "Evan's all ready for the World Cup!"),
                                    new AssociatedImage("may_plane_spotting_kful3h", "Spotting some planes (Evan says pwane)"),
                                    new AssociatedImage("may_make_shift_chair_lwviam", "Our makeshift chair for Evan"),
                                    new AssociatedImage("may_new_car_yc3cn9", "Evan finally gets out in his new car"),
                                    new AssociatedImage("may_happy_in_car_qbumwz", "Beep! Beep!"),
                                    new AssociatedImage("may_play_for_country_vsdcvn", "Love a baby in a football kit")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-june",
                    new DiaryEntry
                    {
                        Tag = "June (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Jun),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("jun_lovely_smile_hnyiew", "Evan being just a happy chappy!"),
                                    new AssociatedImage("jun_wellplace_zoo_njrvo6",
                                        "Evan loved his trip to see all the animals at the Zoo!"),
                                    new AssociatedImage("jun_beach_ball_ozvt4w",
                                        "The beach ball was a huge success at the beach"),
                                    new AssociatedImage("jun_seaside_otmnzs", "Playing against the waves"),
                                    new AssociatedImage("jun_road_trip_wlms6r", "Going on a road trip"),
                                    new AssociatedImage("jun_rice_krispies_u292ln", "That's one way to eat your cereal"),
                                    new AssociatedImage("jun_gardener_x7tq7z", "Checking on the strawberries"),
                                    new AssociatedImage("jun_football_skills_hl0e6i", "Football skills!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-july",
                    new DiaryEntry
                    {
                        Tag = "July (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Jul),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("jul_trampoline_fkiuhs", "Evan loves his new trampoline"),
                                    new AssociatedImage("july_booster_n61rho", "Evan loves eating at the table with us"),
                                    new AssociatedImage("july_slide_c3ijt0", "'Wow!' was Evan's reaction to his new slide"),
                                    new AssociatedImage("jul_legoland_tarjvl", "Oooh! look at this Mummy"),
                                    new AssociatedImage("jul_slide_done_fd30gj", "Little rest after sliding"),
                                    new AssociatedImage("jul_queue_entertainment_ud6t2j", "Keeping a child entertained in a queue is a challenge"),
                                    new AssociatedImage("jul_paddling_pool_pvcxcg", "This is more fun than swimming!"),
                                    new AssociatedImage("jul_legoland_ride_h1okgq", "Enjoying the train ride")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-august",
                    new DiaryEntry
                    {
                        Tag = "August (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Aug),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("aug_doggy_kiss_fve16x", "errghh yuk... Doggy kiss!"),
                                    new AssociatedImage("aug_flying_closeup_kwuunw",
                                        "Evan decides to launch himself on Mummy whilst she's not looking!"),
                                    new AssociatedImage("aug_group_photo_prxlhp",
                                        "Evan and his friends - this scene took only one attempt"),
                                    new AssociatedImage("aug_water_feature_eprop8", "Playing with the water feature at Nanny's"),
                                    new AssociatedImage("aug_new_tower_gp39ft", "A new way to build a tower"),
                                    new AssociatedImage("aug_model_pose_xfyllo", "Always has such a cheeky look"),
                                    new AssociatedImage("aug_concentration_unmbjm", "His little tongue sneaks out when he is concentrating"),
                                    new AssociatedImage("aug_ball_on_slide_umjjv2", "Even balls can have fun on the slide")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-september",
                    new DiaryEntry
                    {
                        Tag = "September (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Sep),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("sept_ikea_chair_tszca5", "At last! we have a chair"),
                                    new AssociatedImage("sept_slippers_u2vmtm", "See Mum, I told you these were the right size"),
                                    new AssociatedImage("sept_legoland_ommape", "Come on, you know you want to get closer..."),
                                    new AssociatedImage("sept_hello_dog_mzv1gc", "Evan likes to watch Holly the dog next door")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-october",
                    new DiaryEntry
                    {
                        Tag = "October (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Oct),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("oct_ball_play_bzpuep", "Isn't he just adorable?!?!"),
                                    new AssociatedImage("oct_who_needs_toys_kpwdhv",
                                        "Who needs toys, when we have Nanny's potatoes and spoons?"),
                                    new AssociatedImage("oct_serious_oze2j5", "Evan enjoying a rare sit down moment...."),
                                    new AssociatedImage("oct_nanny_smiles_rfuwm3", "....always ends up laughing")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-november",
                    new DiaryEntry
                    {
                        Tag = "November (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Nov),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("nov_bin_pose_yneutu", "Ignore the bin mummy, just look at me!"),
                                    new AssociatedImage("nov_cute_hair_sk4ev7", "Mummy always finds Evan when he is hiding"),
                                    new AssociatedImage("nov_ice_cream_wiajqy", "Sharing some ice-cream"),
                                    new AssociatedImage("nov_casual_lcxpck", "Hello cutie")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2006-december",
                    new DiaryEntry
                    {
                        Tag = "December (2006)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2006.y2Dec),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_cooking_aqkbfl",
                                        "Alex, I really think we're missing the point here"),
                                    new AssociatedImage("dec_xmas_dinner_nschli",
                                        "Don't think we're wearing these hats all day!"),
                                    new AssociatedImage("dec_xmas_presents_vhhquw", "I don't need any help this year"),
                                    new AssociatedImage("dec_together_cdlhbx", "Another amazing year"),
                                    new AssociatedImage("dec_pudding_bbrqlo", "Evan loves a pudding!"),
                                    new AssociatedImage("dec_neil_look_v4njvg", "Discussing presents with Neil"),
                                    new AssociatedImage("dec_computer_ofmkbg", "Playing on the computer"),
                                    new AssociatedImage("dec_birthday_ow1hy8", "Grandma helping Evan open presents")
                                }
                            }
                        }
                    });
        }

        protected void InitialiseYearThreeContent()
        {
            var md = new Markdown { ExtraMode = true, SafeMode = false };

            _diaryEntries
                .Add(
                    "2007-january",
                    new DiaryEntry
                    {
                        Tag = "January (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2007.y3Jan),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("jan_train_play_g0yxef",
                                        "Mummy helps build it, but only Evan gets to play!"),
                                    new AssociatedImage("jan_play_watching_buhgti", "Evan finally notices he's being watched"),
                                    new AssociatedImage("jan_tv_gneum1", "Catching up on some TV before bed time"),
                                    new AssociatedImage("jan_noodle_cuddle_skcpkx", "Having a cuddle with Noodle")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-february",
                    new DiaryEntry
                    {
                        Tag = "February (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2007.y3Feb),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_wellies_indoors",
                                        "Can you spot the other obsession?... Wellies indoors!?"),
                                    new AssociatedImage("feb_well_done",
                                        "Evan always congratulates himself with a clap and a 'Well Done'"),
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", "")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-march",
                    new DiaryEntry
                    {
                        Tag = "March (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2007.y3Mar),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("mar_beale_park", "Evan enjoys a picnic at Beale Park"),
                                    new AssociatedImage("mar_long_grass",
                                        "Evan experiences the fun of playing in long grass"),
                                    new AssociatedImage("mar_closeup",
                                        "As you can see Evan's lip is recovering well - still a cutie!"),
                                    new AssociatedImage("", "")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-april",
                    new DiaryEntry
                    {
                        Tag = "April (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2007.y3Apr),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("apr_fridge_magnets",
                                        "Evan's favourite toy at Nanny's is her fridge magnets!"),
                                    new AssociatedImage("apr_lego_castle", "Can you see us?"),
                                    new AssociatedImage("apr_lego_jeep", "We've just been spotting dinosaurs"),
                                    new AssociatedImage("", "")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-may",
                    new DiaryEntry
                    {
                        Tag = "May (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Entry = md.Transform(Year2007.y3May),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("may_footy_skills",
                                        "Evan demonstrating his much improved football skills"),
                                    new AssociatedImage("may_head_first",
                                        "This way is much more fun for Evan, and more scary for me!"),
                                    new AssociatedImage("may_sore_thumb",
                                        "Evan's experience with a plaster for the bit of finger nail he pulled off"),
                                    new AssociatedImage("", "")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-june",
                    new DiaryEntry
                    {
                        Tag = "June (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "1st June 2007 - Family Reunion BBQ",
                                Entry = md.Transform(Year2007.y3Jun_1st),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", "")
                                }
                                
                            },
                            new TimeLineEntry
                            {
                                Subheading = "10th June 2007 - Marwell Zoo",
                                Entry = md.Transform(Year2007.y3Jun_10th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", ""),
                                    new AssociatedImage("", "")
                                }
                                
                            }
                        }
                    });

        }   
    }
}
