using System.Collections.Generic;
using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.Resources;
using EvansDiary.Web.Diary.TransferObjects;
using MarkdownDeep;

namespace EvansDiary.Web.Diary.StaticContent
{
    public class StaticContentDelivery : IStaticContentDelivery
    {
        private readonly Dictionary<int, IEnumerable<IAssociatedImage>> _imageCollection =
            new Dictionary<int, IEnumerable<IAssociatedImage>>();

        protected Dictionary<string, IDiaryEntry> _diaryEntries = new Dictionary<string, IDiaryEntry>();

        public StaticContentDelivery()
        {
            InitialiseYearOneContent();
            InitialiseYearTwoContent();
            InitialiseYearThreeContent();
            InitialiseYearFourContent();
        }

        public IDiaryEntry GetEntry(string key)
        {
            if (_diaryEntries.ContainsKey(key))
            {
                return _diaryEntries[key];
            }

            return new DiaryEntry
            {
                Timeline = new List<ITimeLineEntry>()
            };
        }

        public IEnumerable<IAssociatedImage> GetImages(int year)
        {
            return _imageCollection.ContainsKey(year) ? _imageCollection[year] : null;
        }

        private void InitialiseYearFourContent()
        {
            var md = new Markdown {ExtraMode = true, SafeMode = false};

            _diaryEntries
                .Add(
                    "2008-january",
                    new DiaryEntry
                    {
                        Tag = "January (2008)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "1st Januay - A new start for us!",
                                Entry = md.Transform(Year2008.y4Jan_1st)
                            },
                            new TimeLineEntry
                            {
                                Subheading = "22nd January - Tottenham vs Arsenal Carling Cup Semi Final",
                                Entry = md.Transform(Year2008.y4Jan_22nd)
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2008-february",
                    new DiaryEntry
                    {
                        Tag = "February (2008)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "5th February - Introducing the latest Middlebrook",
                                Entry = md.Transform(Year2008.y4Feb_5th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_ryan_alex_eywe7b", "Introducing Ryan Alex Middlebrook"),
                                    new AssociatedImage("feb_park_rechvc", "Evan loves playing at the park!"),
                                    new AssociatedImage("feb_interesting_hqbqzq",
                                        "Evan contemplates how to get across this new piece of play equipment"),
                                    new AssociatedImage("feb_dog_obsession_cagvyc",
                                        "Evan's love of dogs has not diminished!")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "9th February - Day out feeding the ducks",
                                Entry = md.Transform(Year2008.y4Feb_9th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_ducks_v0fju9", "We love feeding the ducks!"),
                                    new AssociatedImage("feb_swing_craig_f13hr3",
                                        "Finally, someone to give my arms a rest—this boy loves going high!"),
                                    new AssociatedImage("feb_tall_j9sfbc",
                                        "Evan enjoying being the tallest for a change"),
                                    new AssociatedImage("feb_messy_face_g1hzs4", "Chocolate pancakes for breakfast!")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "16th February - Visiting the Beadles",
                                Entry = md.Transform(Year2008.y4Feb_16th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_sam_rgy9ig", "Sam watches on as Evan plays with his toys"),
                                    new AssociatedImage("feb_baby_toys_chp7tm", "Evan playing nicely with Sam's toys"),
                                    new AssociatedImage("feb_mel_james_eyhv13",
                                        "Doesn't James just look like a cool dude!"),
                                    new AssociatedImage("feb_evan_running_bv1ghz", "Mind the slippery patches!")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "17th February - A visit from Caroline",
                                Entry = md.Transform(Year2008.y4Feb_17th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_piano_mat_ueqv5j", "Evan making his music"),
                                    new AssociatedImage("feb_head_injury_lu3rzf", "Check out the bandage mummy!!"),
                                    new AssociatedImage("feb_plasticine_picture_rfivch",
                                        "Evan playing with his plasticine picture maker"),
                                    new AssociatedImage("feb_cute_face_sye5xj", "Caught taking a picture—cutie!")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "23rd February - Celebrating another birthday",
                                Entry = md.Transform(Year2008.y4Feb_23rd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("feb_baby_slide_hepyfz", "This was just the baby slide!"),
                                    new AssociatedImage("feb_flying_balls_cetwvp",
                                        "Balls placed here would be taken by the air flowing out of the holes..."),
                                    new AssociatedImage("feb_more_balls_jqkcgw",
                                        "...So Evan found a way to get lots of balls!"),
                                    new AssociatedImage("feb_party_food_sn99p5",
                                        "Why do we all do that with hula hoops as children?")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2008-march",
                    new DiaryEntry
                    {
                        Tag = "March (2008)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "9th March - Our London Adventure",
                                Entry = md.Transform(Year2008.y4Mar_9th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("mar_train_wpmds6", "Evan's first trip on a train"),
                                    new AssociatedImage("mar_craig_hyxvav", "This is Craig, he's an amazing friend"),
                                    new AssociatedImage("mar_in_london_n3cavw", "London Baby!"),
                                    new AssociatedImage("mar_london_eye_xrb0on", "The London Eye"),
                                    new AssociatedImage("mar_shark_h0xo5c", "Evan loved the sharks!"),
                                    new AssociatedImage("mar_ice-cream_m0p0fd", "Such a nice day for an ice-cream"),
                                    new AssociatedImage("mar_hannah_m4gldr", "Hannah had one too!"),
                                    new AssociatedImage("mar_new_shark_kobubt",
                                        "Evan's new shark teddy gets introduced to the racing track—literally!!")
                                }
                            }
                        }
                    });

            _imageCollection.Add(2008, new[]
            {
                new AssociatedImage("jj-celebrate_aorigs", "January", "251"),
                new AssociatedImage("feb_messy_face_g1hzs4", "February", "251"),
                new AssociatedImage("mar_ice-cream_m0p0fd", "March", "251")
            });
        }

        private void InitialiseYearOneContent()
        {
            var md = new Markdown {ExtraMode = true, SafeMode = false};

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
                                    new AssociatedImage("w0_emma_first_hold_yxohgg",
                                        "Emma holding Evan for the first time"),
                                    new AssociatedImage("w0_midwife_idbcyw", "Our wonderful midwife, Valeska"),
                                    new AssociatedImage("w0_before_birth_cgiahd",
                                        "Emma in the labour ward, before the birth"),
                                    new AssociatedImage("w0_caroline_first_hold_rgpgcj",
                                        "Caroline with Evan a few minutes after the birth")
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
                                    new AssociatedImage("w1_evan_peaceful_n7d6jq",
                                        "Caroline's first view of Evan in hospital, just a few hours old"),
                                    new AssociatedImage("w1_emmas_mum_lkfedi", "Emma's mum with Evan"),
                                    new AssociatedImage("w1_emma_evan_bed_corysg", "Emma and Evan, peaceful in hospital"),
                                    new AssociatedImage("w1_evans_foot_coxy5x", "What a cute footsie!")
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
                                    new AssociatedImage("w2_sleepy_baby_ukesh5", "Such a hard life"),
                                    new AssociatedImage("w2_ooh_looking_at_emma_zcxo7r",
                                        "One of Evan's cute little expressions! 'Hello mummy!'"),
                                    new AssociatedImage("w2_being_changed_joxhds",
                                        "Evan grumbling at having his nappy changed"),
                                    new AssociatedImage("w2_resting_nyyjod", "Both of us having a rest")
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
                                    new AssociatedImage("w3_zonked_k3isgq", "Completely zonked out! Too much boob! :-)"),
                                    new AssociatedImage("w3_matching_socks_aj3lgg", "Outfit includes matching socks"),
                                    new AssociatedImage("w3_playgym_ruptaf",
                                        "A rare moment amusing himself on the play gym"),
                                    new AssociatedImage("w3_wind_struggles_s7c6zt",
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
                                    new AssociatedImage("w4_keep_rocking_d66fey",
                                        "Evan letting Grandma know that she'll need to rock him for longer!"),
                                    new AssociatedImage("w4_right_mitt_zgtpu1", "Have you seen my left mitt?"),
                                    new AssociatedImage("w4_mindy_slamce",
                                        "Emma's mums dog Mindy is very intrigued by this new creature!"),
                                    new AssociatedImage("w4_left_mitt_cflghg", "Where's my right mitt now?!?")
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
                                    new AssociatedImage("w5_smiling_now_kukeoj", "Look Mummy, I can smile now"),
                                    new AssociatedImage("w5_sofa_snooze_q63dnp", "No trouble sleeping on the sofa"),
                                    new AssociatedImage("w5_baldy_g3x6t4",
                                        "I know you're looking at my bald patch, stop it!"),
                                    new AssociatedImage("w5_nice_and_warm_bhs0up", "All nice and warm in here")
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
                                    new AssociatedImage("w6_giggles_z4qpas",
                                        "Evan likes his change mat a lot for some reason!"),
                                    new AssociatedImage("w6_jazz_hands_y85uhg", "Evan doing his 'Jazz Hands'"),
                                    new AssociatedImage("w6_tootsies_n76p7e", "Thumbs Up! Oh no, that's tootsies!"),
                                    new AssociatedImage("w6_cutest_sleeper_oqsqt0", "Just the cutest little sleeper")
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
                                    new AssociatedImage("w7_whats_this_idgt3s", "hmmm... what's this?"),
                                    new AssociatedImage("w7_cute_with_tears_jio5m1", "So cute, even with tears!"),
                                    new AssociatedImage("w7_smiling_for_nan_kqzbuf", "Yep, I can hold it Mum!"),
                                    new AssociatedImage("w7_holding_bottle_tafgcb", "Evan smiling at Caroline's mum")
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
                                    new AssociatedImage("w8_are_you_sure_awndbi",
                                        "Are you sure you want me to pick you up?"),
                                    new AssociatedImage("w8_yes_i_am_sure_dr33f1", "Yes, I'm sure!"),
                                    new AssociatedImage("w8_tummy_time_v4fjqp",
                                        "Evan, demonstrating the benefits of tummy time"),
                                    new AssociatedImage("w8_stuffed_xjmydd", "Stuffed from a good feed")
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
                                    new AssociatedImage("w9_getting_stronger_wl8hdm", "Getting stronger"),
                                    new AssociatedImage("w9_peekaboo_kt3yit", "Peek-a-boo"),
                                    new AssociatedImage("w9_hello_billy_d63gj4", "Hello Billy, my name's Evan!"),
                                    new AssociatedImage("w9_all_smiles_whnfl4", "All smiles")
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
                                    new AssociatedImage("w10_tight_trousers_de4ppk",
                                        "Yes, my trousers are far too tight, and No, I'm not happy about it!"),
                                    new AssociatedImage("w10_lovely_eyes_wigbd3", "Lovely eyes with long lashes"),
                                    new AssociatedImage("w10_new_hat_enqoxo", "Do you like my new hat?"),
                                    new AssociatedImage("w10_double_tummy_time_ewooft", "Double tummy time")
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
                                    new AssociatedImage("w11_bath_time_i3xdve",
                                        "Evan, showing his happy face during bath time"),
                                    new AssociatedImage("w11_grumpy_face_dzz339",
                                        "Evan, doing his best impression of Emma with his grumpy face!"),
                                    new AssociatedImage("w11_munching_molly_s1svkk",
                                        "Evan about to munch on Molly Moo Moo (a toy cow!)"),
                                    new AssociatedImage("w11_less_sick_hsczcl", "Finally, the milk reflux has subsided")
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
                                    new AssociatedImage("w12_chewing_fist_cu9d4x",
                                        "Evan demonstrating his new fist-chewing ability"),
                                    new AssociatedImage("w12_frown_drq2oi", "Loving the frown"),
                                    new AssociatedImage("w12_holding_billy_ba5n5x",
                                        "Evan likes to carry his toys around with him these days"),
                                    new AssociatedImage("w12_just_hanging_iuh1s1", "Just hanging...")
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
                                    new AssociatedImage("w13_examining_fish_pbg7at",
                                        "Hmmm, interesting species of fish!"),
                                    new AssociatedImage("w13_wee_protection_kztpy9", "Protection from wee!"),
                                    new AssociatedImage("w13_muslin_z2hfny", "I'm hiding, you can't see me :)"),
                                    new AssociatedImage("w13_lick_db3e9b", "Tasty!")
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
                                    new AssociatedImage("w14_new_cap_q3wsat", "Ok, I do like my new cap after all..."),
                                    new AssociatedImage("w14_sleep_shoulder_x5uzhv", "Oh, it's a hard life!"),
                                    new AssociatedImage("w14_bath_robe_nkua21", "Showing a bit of leg :)"),
                                    new AssociatedImage("w14_hide_seek_uaznzr", "Pillow Den")
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
                                    new AssociatedImage("w15_sleeping_beauty_ejmpu8", "Sleeping Beauty?"),
                                    new AssociatedImage("w15_splish_splash_uaca8r", "Splish! Splash!"),
                                    new AssociatedImage("w15_teddies_ws1y3j", "Teddy zone"),
                                    new AssociatedImage("w15_baby_hidden_cs7wqc", "There's a baby in there")
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
                                    new AssociatedImage("w16_sunday_best_klwkyn", "Evan looking all smart"),
                                    new AssociatedImage("w16_grandmas_swing_l8v2ub", "I still like my swing Grandma"),
                                    new AssociatedImage("w16_commando_bsghhv", "Practicing for the Commandos!"),
                                    new AssociatedImage("w16_best_seller_rievif", "Reading the latest best seller")
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
                                    new AssociatedImage("w17_look_dillon_rbwcgo", "Evan watching Dillon Donkey"),
                                    new AssociatedImage("w17_very_happy_qesqd0", "Happy Baby"),
                                    new AssociatedImage("w17_cot_cry_yrpylz", "Evan didn't like his cot at first..."),
                                    new AssociatedImage("w17_zonko_bpk8od", "... but he likes his cot now :)")
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
                                    new AssociatedImage("w18_ooh_whassat_jittzh", "Evan with his curious expression"),
                                    new AssociatedImage("w18_sitting_strong_zrpg5r", "How does that Tottenham song go?"),
                                    new AssociatedImage("w18_sitting_grass_r6jvp9", "Sitting on the grass with Mummy"),
                                    new AssociatedImage("w18_chubby_chops_evqmns", "Look at his cute chubby cheeks!")
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
                                    new AssociatedImage("w19_baby_banz_apdzte", "Evan in his cool new baby banz"),
                                    new AssociatedImage("w19_book_mxcl2d", "Story time :)"),
                                    new AssociatedImage("w19_tummy_riueyz", "Look at this tummy strength!"),
                                    new AssociatedImage("w19_fist_d5xvmb", "Oh wait!? There's my fist.")
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
                                    new AssociatedImage("w20_gorgeous_d9u34v", "Gorgeous Mummy and baby"),
                                    new AssociatedImage("w20_standing_j46kzd", "Look Mum! I'm standing up!"),
                                    new AssociatedImage("w20_cats_bn4gtj", "Evan playing with the cats"),
                                    new AssociatedImage("w20_cats_unsure_lqgtez", "Poppy thinks twice")
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
                                    new AssociatedImage("w21_uncle_neil_ctggxg", "Evan and his Uncle Neil"),
                                    new AssociatedImage("w21_foot_or_toy_xznisk", "Toy or Foot?.... It's a hard life"),
                                    new AssociatedImage("w21_cup_drinking_godb3l", "Evan learning to drink from a cup"),
                                    new AssociatedImage("w21_yes_its_me_qitgew", "Yes, you keep looking at me")
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
                                    new AssociatedImage("w22_swim_trunks_jl2sra", "hmm... now what do I play with?"),
                                    new AssociatedImage("w22_bumbo_jgmwki",
                                        "Oooh what's this? - Evan in his new 'Bumbo Seat'"),
                                    new AssociatedImage("w22_nekkid_rgonxc", "Evan letting it all hang out"),
                                    new AssociatedImage("w22_baby_rice_sblciy", "Mmmmm, baby rice & formula :/")
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
                                SingleImage = new AssociatedImage("w23_the_party_mljefl", "The Party")
                                {
                                    Height = "397",
                                    Width = "520"
                                },
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("w23_cheeky_bottom_q56d1e", "I can see that bottom!"),
                                    new AssociatedImage("w23_great_grandmother_gf1v8x", "This is my great nanny!"),
                                    new AssociatedImage("w23_carrot_zxoikn",
                                        "Evan even managed to get carrot on his nose!"),
                                    new AssociatedImage("w23_computer_uqnsjh", "Quiet please, I'm concentrating!")
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
                                    new AssociatedImage("w24_happy_baby_oiy5jd", "Yes... the grass tickles my toes!"),
                                    new AssociatedImage("w24_big_cuddles_tzpglv",
                                        "Evan sharing a big cuddle with Grandma"),
                                    new AssociatedImage("w24_mel_fcltsy", "Evan with Caroline's best friend Mel"),
                                    new AssociatedImage("w24_vicky_wuquwh", "Evan asleep on Vicky's shoulder")
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
                                    new AssociatedImage("w25_pushchair_j8jwf0",
                                        "Mmm tasty pushchair, it gets the 'Toes-Up' from me Mum!"),
                                    new AssociatedImage("w25_trendy_qkqe3b", "Trendy boy"),
                                    new AssociatedImage("w25_car_ywwm5f", "Still prefers to eat his toys"),
                                    new AssociatedImage("w25_asleep_at_dinner_l8yf2g",
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
                                    new AssociatedImage("w26_lazy_sunday_scsegh", "Lazy Sunday morning..."),
                                    new AssociatedImage("w26_lazy_sunday2_y0sket", "...LOVE..."),
                                    new AssociatedImage("w26_lazy_sunday4_qyr2pc", "...him..."),
                                    new AssociatedImage("w26_lazy_sunday3_nq0pfk", "...SO MUCH!")
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
                                    new AssociatedImage("w27_carolines_new_hair_ojubpp",
                                        "Caroline has a hair cut - 'Bout time we had a pic of her again!"),
                                    new AssociatedImage("w27_zonked_nggrge", "It's a hard life"),
                                    new AssociatedImage("w27_sitting_up_kht5ey", "I don't need Mummy's support"),
                                    new AssociatedImage("w27_ice-cream_hsbgwt", "Gimme dat ice-cream!")
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
                                    new AssociatedImage("w28_hair_style_l17b0p",
                                        "Yes! Mummy has put stuff in my hair..."),
                                    new AssociatedImage("w28_cool_dude_rulh6a",
                                        "Evan showing how well he sits up. He'll sit and play for ages now"),
                                    new AssociatedImage("w28_how_many_fingers_bwdctt", "How mny fingers?"),
                                    new AssociatedImage("w28_lush_baby_qhjcvs",
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
                                    new AssociatedImage("w29_heat_wave_ei51wp",
                                        "Amidst all the horror - Evan enjoys the heat wave"),
                                    new AssociatedImage("w29_new_toys_hogwev", "Evan enjoying his new big boy toys"),
                                    new AssociatedImage("w29_any_resemblance_dxdezk", "Any resemblance?"),
                                    new AssociatedImage("w29_power_nap_frz6fk", "Power nap")
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
                                    new AssociatedImage("w30_high_chair_tewerx", "hmmm... definitely room to grow"),
                                    new AssociatedImage("w30_stacking_cups_ja7edn",
                                        "Evan getting psyched up for the collapse"),
                                    new AssociatedImage("w30_tower_crash_iwchah", "...Boom!"),
                                    new AssociatedImage("w30_always_happy_ixfs0s", "Love how happy he is.")
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
                                    new AssociatedImage("w31_dribble_kiss_fenbqm", "Kiss?"),
                                    new AssociatedImage("w31_euuw_dribble_ztdyis",
                                        "I show my affection to mummy with lots of dribble"),
                                    new AssociatedImage("w31_got_you_bcnkko", "Got you..."),
                                    new AssociatedImage("w31_want_one_ghn1i7", "Now you!")
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
                                    new AssociatedImage("w32_bottle_feed_g0arjp",
                                        "Evan is self-sufficient when it comes to the bottle"),
                                    new AssociatedImage("w32_team_mascot_wzzzom", "So... is this team any good Mum?"),
                                    new AssociatedImage("w32_all_fall_down_lgepyu", "eep! here they come!"),
                                    new AssociatedImage("w32_scrambled_egg_qts8bm", "Evan is not a fan of scrambled egg")
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
                                    new AssociatedImage("w33_evan_and_friends_hhtoly",
                                        "Evan enjoying a fun afternoon with his friends"),
                                    new AssociatedImage("w33_sucking_toast_gpc1cn",
                                        "Evan having a good suck on his first ever piece of toast"),
                                    new AssociatedImage("w33_biceps_f9jvp7", "Look at those biceps!"),
                                    new AssociatedImage("w33_funny_boy_ybn0ik", "Funny boy")
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
                                    new AssociatedImage("w34_cheeky_chappy_a2nuvv",
                                        "Evan is eyeing up the camera for dinner"),
                                    new AssociatedImage("w34_hello_fluffy_trjpfd", "Hello fluffy cat"),
                                    new AssociatedImage("w34_hello_xwpf0i", "Hello!"),
                                    new AssociatedImage("w34_tongue_xrramj", "Evan can stick out his tongue")
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
                                    new AssociatedImage("w35_professional_pose_ipy73z",
                                        "Evan posing for the camera, or is he eyeing up a sleeping cat?"),
                                    new AssociatedImage("w35_nice_n_clean_aninsf",
                                        "Evan showing an increasing desire to grab the camera"),
                                    new AssociatedImage("w35_hiding_m4egb7", "I'm hiding"),
                                    new AssociatedImage("w35_big_boy_msmi6v", "35 weeks and he's almost as big as Emma")
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
                                    new AssociatedImage("w36_where_are_we_quu52z", "Where are we?"),
                                    new AssociatedImage("w36_what_is_this_h7axdv", "What is this?"),
                                    new AssociatedImage("w36_strange_feeling_c9j0p2",
                                        "The sand feels cold on Evan's toes"),
                                    new AssociatedImage("w36_sand_feels_good_j7aiut", "Evan loves it")
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
                                    new AssociatedImage("w37_tickle_time_asant7", "It's tickle time"),
                                    new AssociatedImage("w37_choosing_toys_ig6gm4", "Let me choose the toys today"),
                                    new AssociatedImage("w37_yummy_bath_water_z2kve2", "Yummy bath water"),
                                    new AssociatedImage("w37_all_fours_ccyvlq", "Almost ready to crawl")
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
                                    new AssociatedImage("w38_new_seat_eq5mvb", "Evan sprawling out in his new seat"),
                                    new AssociatedImage("w38_dintons_pastures_e0ezn0",
                                        "Having a break from picking blackberries"),
                                    new AssociatedImage("w38_cutest_foot_ykdjq1", "I could just eat his feet"),
                                    new AssociatedImage("w38_play_pen_ul242g", "Staying safe in the play pen")
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
                                    new AssociatedImage("w39_crawling_e3mwdr", "I can crawl!"),
                                    new AssociatedImage("w39_camera_hunt_bhsm9p",
                                        "Taking pictures is tricky now he crawls"),
                                    new AssociatedImage("w39_my_seat_d8deak", "It's my seat now"),
                                    new AssociatedImage("w39_where_is_on_nmkwd7", "How do I turn this back on?")
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
                                    new AssociatedImage("w40_new_toys_e5qgoh", "But I want these toys mummy..."),
                                    new AssociatedImage("w40_finger_foods_pbfi5h",
                                        "Teaching Evan how to eat finger foods - this was before he mashed them everywhere!"),
                                    new AssociatedImage("w40_finger_foods2_dzrkuz", "This biscuit is as big as him"),
                                    new AssociatedImage("w40_tears_i6lxzq", "Tears of freedom?")
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
                                    new AssociatedImage("w41_standing_alone_z3uxwb", "Woohoo - Look at him now"),
                                    new AssociatedImage("w41_activity_table_bwfft8",
                                        "Evan enjoying his new found freedom at his new activity table"),
                                    new AssociatedImage("w41_keys_hq79mh", "So, that's where my keys are"),
                                    new AssociatedImage("w41_picture_for_mummy_owhjcs",
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
                                    new AssociatedImage("w42_evan_impression_yiqifo", "My impression of Evan"),
                                    new AssociatedImage("w42_play_biting_uorafp", "Play biting or fighting?"),
                                    new AssociatedImage("w42_mischievious_xsvaz4", "What are you up to?"),
                                    new AssociatedImage("w42_ball_pit_n2zbsz", "Playing with friends")
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
                                    new AssociatedImage("w43_first_shoes_bshqhe", "First pair of shoes"),
                                    new AssociatedImage("w43_first_shoes_closeup_eapus4", "So cute!"),
                                    new AssociatedImage("w43_need_a_haircut_ssnf8f", "Someone needs a hair cut"),
                                    new AssociatedImage("w43_tired_baby_zsn1s0", "Aww bless him")
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
                                    new AssociatedImage("w44_sept_filler_image2_lyzh69", "Healthy baby"),
                                    new AssociatedImage("w44_poorly_baby_lpm7e3", "Poorly baby"),
                                    new AssociatedImage("w44_double_poorly_c7yadn", "Everyone is ill this week"),
                                    new AssociatedImage("w44_sept_filler_image_gdncec", "A lot of baths this week")
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
                                    new AssociatedImage("w45_is_this_bath_i0ajg7", "Is this bath for me?"),
                                    new AssociatedImage("w45_for_me_qwnnsz",
                                        "Evan loves to peer into the bath as it is filling up"),
                                    new AssociatedImage("w45_new_trick_vea4az",
                                        "Evan's new trick is to drink from the cups as the water trickles through!"),
                                    new AssociatedImage("w45_loves_a_bath_samclj", "Delightful :)")
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
                                    new AssociatedImage("w46_camera_fascination_uxdn1v",
                                        "Evan proving how difficult it is to photograph him these days"),
                                    new AssociatedImage("w46_prebath_play_time_dg67bx", "Pre-bath play time"),
                                    new AssociatedImage("w46_what_ya_doing_rnyvlh",
                                        "Evan is interested in everything we do"),
                                    new AssociatedImage("w46_hurry_up_eljfo8", "Hurry up bath!")
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
                                    new AssociatedImage("w47_before_haircut_j2zw4h", "Before hair cut"),
                                    new AssociatedImage("w47_after_haircut_xx0jno", "After hair cut"),
                                    new AssociatedImage("w47_wax_duawul", "Showing interest in some product"),
                                    new AssociatedImage("w47_lush_crphqu", "Just beautiful")
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
                                    new AssociatedImage("w48_inquisitive_toilet_pdhvoc",
                                        "A toilet lock is now a necessity"),
                                    new AssociatedImage("w48_cheeky_ryelxx", "Cheeky look"),
                                    new AssociatedImage("w48_dribbler_paoede", "Dribbletastic"),
                                    new AssociatedImage("w48_not_a_toy_qfkpc8", "Obsessed much with the camera Evan?")
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
                                    new AssociatedImage("w49_strong_legs_vmkxth", "Strong legs"),
                                    new AssociatedImage("w49_stocky_chap_jfrghp", "Stocky chappy"),
                                    new AssociatedImage("w49_peek-a-boo_lhftfm", "Playing peek-a-boo"),
                                    new AssociatedImage("w49_shopping_tkyka2",
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
                                    new AssociatedImage("w50_introducing_gpr8ea",
                                        "Introducing Noodle, the new addition to our growing family"),
                                    new AssociatedImage("w50_first_nativity_nrxnue",
                                        "Getting ready for Evan's first nativity performance"),
                                    new AssociatedImage("w50_first_nativity2_ccscue",
                                        "Evan is the second one in from the left on the front row"),
                                    new AssociatedImage("w50_noodle_tphfpt", "Settling in very well")
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
                                    new AssociatedImage("w51_swings_esidsz", "Loves the swings in the park"),
                                    new AssociatedImage("w51_matching_hair_uroew9",
                                        "Evan's new haircut gets styled like Mummy's"),
                                    new AssociatedImage("w51_grandma_babysits_x0mubc",
                                        "Evan loves it when Grandma feeds him"),
                                    new AssociatedImage("w51_bathroom_fun_yjodxh", "Evan loves bathroom time")
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
                                    new AssociatedImage("w52_first_christmas_nyb97g",
                                        "Evan gets his hands on his presents"),
                                    new AssociatedImage("w52_noisy_toys_gkbvik", "New toys seem to be going down well"),
                                    new AssociatedImage("w52_christmas_dinner_c7crk7",
                                        "Evan is not sure about the crackers and hats"),
                                    new AssociatedImage("w52_it_snows_pndpsj", "It snows at Christmas!"),
                                    new AssociatedImage("w52_happy_birthday_oo4k25", "Happy 1st Birthday Evan"),
                                    new AssociatedImage("w52_end_of_the_year_db7zqg", "Birthday hug"),
                                    new AssociatedImage("w52_birthday_presents_e3y3pr",
                                        "You are supposed to push it Evan, not climb it"),
                                    new AssociatedImage("w52_still_loves_camera_a1quy1",
                                        "Yes, Yes, we all know you still love the camera")
                                }
                            }
                        }
                    });

            _imageCollection.Add(2005, new[]
            {
                new AssociatedImage("w0_emma_first_hold_yxohgg", "Week 0 - The Birth", "251"),
                new AssociatedImage("w1_evan_peaceful_n7d6jq", "Week 1", "251"),
                new AssociatedImage("w2_ooh_looking_at_emma_zcxo7r", "Week 2", "251"),
                new AssociatedImage("w3_playgym_ruptaf", "Week 3", "251"),
                new AssociatedImage("w4_keep_rocking_d66fey", "Week 4", "251"),
                new AssociatedImage("w5_smiling_now_kukeoj", "Week 5", "251"),
                new AssociatedImage("w6_giggles_z4qpas", "Week 6", "251"),
                new AssociatedImage("w7_holding_bottle_tafgcb", "Week 7", "251"),
                new AssociatedImage("w8_tummy_time_v4fjqp", "Week 8", "251"),
                new AssociatedImage("w9_hello_billy_d63gj4", "Week 9", "251"),
                new AssociatedImage("w10_new_hat_enqoxo", "Week 10", "251"),
                new AssociatedImage("w11_bath_time_i3xdve", "Week 11", "251"),
                new AssociatedImage("w12_chewing_fist_cu9d4x", "Week 12", "251"),
                new AssociatedImage("w13_muslin_z2hfny", "Week 13", "251"),
                new AssociatedImage("w14_new_cap_q3wsat", "Week 14", "251"),
                new AssociatedImage("w15_sleeping_beauty_ejmpu8", "Week 15", "251"),
                new AssociatedImage("w16_commando_bsghhv", "Week 16", "251"),
                new AssociatedImage("w17_zonko_bpk8od", "Week 17", "251"),
                new AssociatedImage("w18_sitting_grass_r6jvp9", "Week 18", "251"),
                new AssociatedImage("w19_book_mxcl2d", "Week 19", "251"),
                new AssociatedImage("w20_gorgeous_d9u34v", "Week 20", "251"),
                new AssociatedImage("w21_cup_drinking_godb3l", "Week 21", "251"),
                new AssociatedImage("w22_baby_rice_sblciy", "Week 22", "251"),
                new AssociatedImage("w23_computer_uqnsjh", "Week 23", "251"),
                new AssociatedImage("w24_happy_baby_oiy5jd", "Week 24", "251"),
                new AssociatedImage("w25_trendy_qkqe3b", "Week 25", "251"),
                new AssociatedImage("w26_lazy_sunday3_nq0pfk", "Week 26", "251"),
                new AssociatedImage("w27_sitting_up_kht5ey", "Week 27", "251"),
                new AssociatedImage("w28_cool_dude_rulh6a", "Week 28", "251"),
                new AssociatedImage("w29_heat_wave_ei51wp", "Week 29", "251"),
                new AssociatedImage("w30_stacking_cups_ja7edn", "Week 30", "251"),
                new AssociatedImage("w31_got_you_bcnkko", "Week 31", "251"),
                new AssociatedImage("w32_bottle_feed_g0arjp", "Week 32", "251"),
                new AssociatedImage("w33_sucking_toast_gpc1cn", "Week 33", "251"),
                new AssociatedImage("w34_hello_fluffy_trjpfd", "Week 34", "251"),
                new AssociatedImage("w35_nice_n_clean_aninsf", "Week 35", "251"),
                new AssociatedImage("w36_where_are_we_quu52z", "Week 36", "251"),
                new AssociatedImage("w37_tickle_time_asant7", "Week 37", "251"),
                new AssociatedImage("w38_new_seat_eq5mvb", "Week 38", "251"),
                new AssociatedImage("w39_camera_hunt_bhsm9p", "Week 39", "251"),
                new AssociatedImage("w40_finger_foods_pbfi5h", "Week 40", "251"),
                new AssociatedImage("w41_activity_table_bwfft8", "Week 41", "251"),
                new AssociatedImage("w42_evan_impression_yiqifo", "Week 42", "251"),
                new AssociatedImage("w43_first_shoes_bshqhe", "Week 43", "251"),
                new AssociatedImage("w44_poorly_baby_lpm7e3", "Week 44", "251"),
                new AssociatedImage("w45_new_trick_vea4az", "Week 45", "251"),
                new AssociatedImage("w46_camera_fascination_uxdn1v", "Week 46", "251"),
                new AssociatedImage("w47_wax_duawul", "Week 47", "251"),
                new AssociatedImage("w48_inquisitive_toilet_pdhvoc", "Week 48", "251"),
                new AssociatedImage("w49_strong_legs_vmkxth", "Week 49", "251"),
                new AssociatedImage("w50_introducing_gpr8ea", "Week 50", "251"),
                new AssociatedImage("w51_matching_hair_uroew9", "Week 51", "251"),
                new AssociatedImage("w52_still_loves_camera_a1quy1", "Week 52", "251")
            });
        }

        private void InitialiseYearThreeContent()
        {
            var md = new Markdown {ExtraMode = true, SafeMode = false};

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
                                    new AssociatedImage("jan_train_play_bixet6",
                                        "Mummy helps build it, but only Evan gets to play!"),
                                    new AssociatedImage("jan_play_watching_oyeyxq",
                                        "Evan finally notices he's being watched"),
                                    new AssociatedImage("jan_tv_zeybwf", "Catching up on some TV before bed time"),
                                    new AssociatedImage("jan_noodle_cuddle_t46wrd", "Having a cuddle with Noodle")
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
                                    new AssociatedImage("feb_wellies_indoors_rxgddv",
                                        "Can you spot the other obsession?... Wellies indoors!?"),
                                    new AssociatedImage("feb_puzzles_r4pbgf", "No trouble finding all the pieces"),
                                    new AssociatedImage("feb_all_done_ty8yfi", "One completed puzzle"),
                                    new AssociatedImage("feb_well_done_vnnj4p",
                                        "Evan always congratulates himself with a clap and a 'Well Done'")
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
                                    new AssociatedImage("mar_beale_park_whikyc", "Evan enjoys a picnic at Beale Park"),
                                    new AssociatedImage("mar_relaxed_i5sjsy",
                                        "Evan knows how to get comfy in his chair"),
                                    new AssociatedImage("mar_bath_friends_fjlfm2",
                                        "Evan has some bath friends"),
                                    new AssociatedImage("mar_bath_smiles_ki9lfz", "Look at the face!")
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
                                    new AssociatedImage("apr_exploring_ln1dfq", "Exploring the countryside"),
                                    new AssociatedImage("apr_long_grass_tywo0a",
                                        "Evan experiences the fun of playing in long grass"),
                                    new AssociatedImage("apr_monopoly_gy4ad9",
                                        "Not quite ready to play monopoly to the rules"),
                                    new AssociatedImage("apr_scar_smile_uvwdy9",
                                        "As you can see Evan's lip is recovering well - still a cutie!"),
                                    new AssociatedImage("apr_fridge_magnets_hm1nsn",
                                        "Evan's favourite toy at Nanny's is her fridge magnets!"),
                                    new AssociatedImage("apr_legoland_castle_h1c4uv", "Can you see us?"),
                                    new AssociatedImage("apr_safari_car_bjfohi", "We've just been spotting dinosaurs"),
                                    new AssociatedImage("apr_passing_time_moczuk",
                                        "Evan finds something to do whilst waiting in the ride queues")
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
                                    new AssociatedImage("may_footy_skills_yxh9ic",
                                        "Evan demonstrating his much improved football skills"),
                                    new AssociatedImage("may_head_first_m1dbyd",
                                        "This way is much more fun for Evan, and more scary for me!"),
                                    new AssociatedImage("may_sore_thumb_cmn4rh",
                                        "Evan's experience with a plaster for the bit of finger nail he pulled off"),
                                    new AssociatedImage("may_patio_seat_nsu0nb",
                                        "Garden bench?!? No Thanks, this is far more comfortable")
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
                                    new AssociatedImage("june_small_group_btzxlk",
                                        "Caroline's mum with her relatives from France"),
                                    new AssociatedImage("june_carlsberg_ualapc", "Anyone for Carlsberg?"),
                                    new AssociatedImage("june_evan_dances_fb8ydf",
                                        "Evan playing on the dance mat"),
                                    new AssociatedImage("june_large_group_uzxayy", "BBQ reuinion group photo")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "10th June 2007 - Marwell Zoo",
                                Entry = md.Transform(Year2007.y3Jun_10th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("june_zoo_day_out_kaz8d7", "All set for our day at the zoo"),
                                    new AssociatedImage("june_snow_leopard_a2zru3", "Beautiful Endangered Snow Leopard"),
                                    new AssociatedImage("june_giraffe_height_ozas7a", "Still a long way to go"),
                                    new AssociatedImage("june_penguin_uid4kz", "Poor little penguin looking far too hot")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "22nd June 2007 - Neil & Pascale's Wedding",
                                Entry = md.Transform(Year2007.y3Jun_22nd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("june_exploring_ln2mar",
                                        "Exploring the grounds keeping out of trouble"),
                                    new AssociatedImage("june_suit_plyo8l", "The suit is on the large side!"),
                                    new AssociatedImage("june_happily_married_gbkhzq",
                                        "Evan shows his smart side (if you ignore the black eye that is)"),
                                    new AssociatedImage("june_joke_with_grandma_vzltsk",
                                        "Evan shares a joke with Grandma")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "29th June 2007 - Holiday in France",
                                Entry = md.Transform(Year2007.y3Jun_29th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("june_river_washing_kddazo",
                                        "The private river came in handy for washing the car seat cover"),
                                    new AssociatedImage("june_jacques_bbq_kaexau",
                                        "Jacques prepares a natural fire for the BBQ. The sausages were yummy!"),
                                    new AssociatedImage("june_pleasant_walk_mowq7b",
                                        "Those little legs get tired easy, luckily Caroline saves the day"),
                                    new AssociatedImage("june_evan_boat_yjnkvf",
                                        "Evan is not sure what to think of the life jacket"),
                                    new AssociatedImage("june_pascale_carry_hdrmwq",
                                        "Pascale helped with the carrying when Evan got tired"),
                                    new AssociatedImage("june_wind_tears_urt1tn",
                                        "The wind was so strong it made Evan cry"),
                                    new AssociatedImage("june_strong_Arms_sb0gss",
                                        "Evan makes up a new ball game, with a tree!"),
                                    new AssociatedImage("june_room_to_run_cru2mp",
                                        "So much space for Evan to run around in")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-july",
                    new DiaryEntry
                    {
                        Tag = "July (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "7th July 2007",
                                Entry = md.Transform(Year2007.y3Jul_7th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("july_lego_fun_scje8g",
                                        "Evan is starting to appreciate his lego more now he is older"),
                                    new AssociatedImage("july_sleepy_boys_w2zysu",
                                        "Evan and Noodle decide that they just can't go on anymore"),
                                    new AssociatedImage("july_water_feature_eot3vq",
                                        "Fascinated by Nanny's garden water feature"),
                                    new AssociatedImage("july_rearrange_garden_thgon0",
                                        "Evan's new game—rearranging the garden ornaments")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "10th July 2007",
                                Entry = md.Transform(Year2007.y3Jul_10th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("july_bubble_machine_gbsipw",
                                        "Introducing the bubble machine..."),
                                    new AssociatedImage("july_make_bubbles_xjrjbv",
                                        "...getting used to how you turn the maker..."),
                                    new AssociatedImage("july_watch_bubbles_c9jjdx",
                                        "...huge bubbles start to float away..."),
                                    new AssociatedImage("july_bubbles_fly_away_uiykbt",
                                        "...Evan has mastered the art of making giant bubbles")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "14th July 2007 - Legoland Live Festival",
                                Entry = md.Transform(Year2007.y3Jul_14th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("july_first_festival_lvhhix", "Evan's first festival!"),
                                    new AssociatedImage("july_cardboard_bob_uiq3bg",
                                        "Evan shows off his cardboard Bob the Builder!"),
                                    new AssociatedImage("july_singing_along_jvjwzc", "Singing along to all the songs"),
                                    new AssociatedImage("july_legoland_swings_shugch",
                                        "Evan can now ride the swings solo")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "30th July 2007",
                                Entry = md.Transform(Year2007.y3Jul_30th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("july_which_one_jo64x4", "Time to choose... hat, dog or ship"),
                                    new AssociatedImage("july_this_one_lycv1t", "The ship it is"),
                                    new AssociatedImage("july_lets_play_tpgbbz",
                                        "Just like Caroline, Evan is going to be ruthless at Monopoly..."),
                                    new AssociatedImage("july_cheating_czygop",
                                        "... or he might steal from the bank like his Mum!")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-august",
                    new DiaryEntry
                    {
                        Tag = "August (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "2nd August 2007",
                                Entry = md.Transform(Year2007.y3Aug_2nd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("aug_flowers_e3dbku",
                                        "Any image like this saddens me, but it's worse when you know the person"),
                                    new AssociatedImage("aug_becky_trevor_h4cqcn",
                                        "Becky and Trevor having a laugh at the pub"),
                                    new AssociatedImage("aug_becky_clare_sousme",
                                        "Becky was very popular and friendly to everyone"),
                                    new AssociatedImage("aug_crossroad_ogbuq0",
                                        "The cross road showing the signs of the accident")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "18th August 2007",
                                Entry = md.Transform(Year2007.y3Aug_18th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("aug-bouncy-castle_y0cxna",
                                        "Finally Evan enjoys the bouncy castle"),
                                    new AssociatedImage("aug_play_dough_e7rg46",
                                        "Enjoying the texture, not quite making shapes yet"),
                                    new AssociatedImage("aug_nap_time_l6g2hx", "Nap time for Evan!"),
                                    new AssociatedImage("aug_block_stacking_v2tddw", "Stacking blocks successfully")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-september",
                    new DiaryEntry
                    {
                        Tag = "September (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "18th September 2007",
                                Entry = md.Transform(Year2007.y3Sep_18th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("sept_peanut_playdough_dxoncx",
                                        "Evan has fun making edible playdough"),
                                    new AssociatedImage("sept_dribbling_kncsrn",
                                        "Evan demonstrates where Tottenham have been going wrong this season"),
                                    new AssociatedImage("sept_football_rjsyho", "Not bad for a 2 year old"),
                                    new AssociatedImage("sept_swing_divjqo", "Evan still loves his swing in the garden")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "23rd September 2007 - Meeting the famous Roary",
                                Entry = md.Transform(Year2007.y3Sep_23rd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("sept_meeting_roary_f2dfbj", "Evan finally gets to meet Roary!"),
                                    new AssociatedImage("sept_playing_fireman_w9uu6t",
                                        "Head to head fire challenge at Legoland.. Uncle Frank Won!"),
                                    new AssociatedImage("sept_solo_zngtje", "More swing action"),
                                    new AssociatedImage("sept_lego_rides_wfp7hj", "Enjoying the big wheel ride")
                                }
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-october",
                    new DiaryEntry
                    {
                        Tag = "October (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "5th October 2007 - Potty Training",
                                Entry = md.Transform(Year2007.y3Oct_5th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("oct_book_uh3jx6", "Evan sharing a story with his nanny"),
                                    new AssociatedImage("oct_nanny_giggles_bxg4gn",
                                        "I'm not sure they are getting much of the story read there"),
                                    new AssociatedImage("oct_cheeky_boy_uv8rqz",
                                        "Evan shows off his typical cheeky look"),
                                    new AssociatedImage("oct_exploring_bveyej", "Evan is fascinated by the long grass")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "27th October 2007 - Cadbury's Gorilla",
                                Entry = md.Transform(Year2007.y3Oct_27th)
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-november",
                    new DiaryEntry
                    {
                        Tag = "November (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "2nd November - Amber turns 2",
                                Entry = md.Transform(Year2007.y3Nov_2nd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("nov_growing_up_drs1cb", "Growing up fast!"),
                                    new AssociatedImage("nov_amber_vxwop2", "Nice and cosy on the sofa"),
                                    new AssociatedImage("nov_evan_izzy_f9wplf",
                                        "Evan adores Izzy, I'm sure he wants his own dog!"),
                                    new AssociatedImage("nov_ice-cream_rn6d2j",
                                        "Showing some cute baby belly for ice-cream????")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "11th November - More birthday party fun",
                                Entry = md.Transform(Year2007.y3Nov_11th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("nov_abbie1_sfkeb1",
                                        "Evan finally settles in the soft play area with his friends"),
                                    new AssociatedImage("nov_abbie2_tghfxe", "Evan attempts to barracade Beth in"),
                                    new AssociatedImage("nov_abbie3_tkorbs", "These huge objects were a huge hit!"),
                                    new AssociatedImage("nov_abbie4_pzvppo",
                                        "All quiet when the children sit down to eat")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "18th November - No raisins for you",
                                Entry = md.Transform(Year2007.y3Nov_18th)
                            }
                        }
                    });

            _diaryEntries
                .Add(
                    "2007-december",
                    new DiaryEntry
                    {
                        Tag = "December (2007)",
                        Timeline = new List<ITimeLineEntry>
                        {
                            new TimeLineEntry
                            {
                                Subheading = "2nd December - 3 become 2",
                                Entry = md.Transform(Year2007.y3Dec_2nd),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_slide_start_at8kmg",
                                        "Is this going to have a happy ending?"),
                                    new AssociatedImage("dec_slide_finish_wi9hpm", "They seemed to like it!"),
                                    new AssociatedImage("dec_garden_krn8sm", "Not sure who is having the most fun!"),
                                    new AssociatedImage("dec_sofa_sleeps_njm4fc", "Having a sneaky little nap")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "14th December - King Evan",
                                Entry = md.Transform(Year2007.y3Dec_14th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_king_evan_r3inur", "Evan models his nativity outfit"),
                                    new AssociatedImage("dec_king_myrrh_c4wa7a", "Evan with his gift of myrrh"),
                                    new AssociatedImage("dec_nativity_dinner_hosxdi",
                                        "Nativity done, now onto the food!"),
                                    new AssociatedImage("dec_evan_and_lucy_sv76a9", "This is Lucy, Evan adores her")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "24th December - Birthday cake fun!",
                                Entry = md.Transform(Year2007.y3Dec_24th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_grandma_hosts_ajylpj",
                                        "It's Christmas at Grandma's this year"),
                                    new AssociatedImage("dec_cake_flat_cvps03", "Is that a cake?"),
                                    new AssociatedImage("dec_cake_rise_xextb2", "Now that's more like it!"),
                                    new AssociatedImage("lego_fire_engine_q597xb",
                                        "Evan's fire engine from legoland is still in one piece")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "25th December - Evan remembers Christmas",
                                Entry = md.Transform(Year2007.y3Dec_25th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_xmas_na9oui", "Finally the waiting is over!"),
                                    new AssociatedImage("dec_uncle_matt_pcdnhi", "Uncle Matt watches on"),
                                    new AssociatedImage("dec_playing_mrj2fg", "Presents all opened, now time to play"),
                                    new AssociatedImage("dec_toys_hrbyg8",
                                        "Chirpy the Spurs mascot has a look at the new cars")
                                }
                            },
                            new TimeLineEntry
                            {
                                Subheading = "26th December - Evan turns 3",
                                Entry = md.Transform(Year2007.y3Dec_26th),
                                Images = new List<IAssociatedImage>
                                {
                                    new AssociatedImage("dec_birthday_eh7fsc", "It's birthday time!"),
                                    new AssociatedImage("dec_more_presents_ozltbn", "Happy 3rd birthday"),
                                    new AssociatedImage("dec_lego_fan_mnkcob", "Lego features heavily again this year"),
                                    new AssociatedImage("dec_whos_toys_soqilm", "My my Evan, haven't you grown")
                                }
                            }
                        }
                    });

            _imageCollection.Add(2007, new[]
            {
                new AssociatedImage("jan_play_watching_oyeyxq", "January", "251"),
                new AssociatedImage("feb_well_done_vnnj4p", "February", "251"),
                new AssociatedImage("mar_relaxed_i5sjsy", "March", "251"),
                new AssociatedImage("apr_scar_smile_uvwdy9", "April", "251"),
                new AssociatedImage("may_head_first_m1dbyd", "May", "251"),
                new AssociatedImage("june_evan_boat_yjnkvf", "June", "251"),
                new AssociatedImage("july_cardboard_bob_uiq3bg", "July", "251"),
                new AssociatedImage("aug_block_stacking_v2tddw", "August", "251"),
                new AssociatedImage("sept_meeting_roary_f2dfbj", "September", "251"),
                new AssociatedImage("oct_nanny_giggles_bxg4gn", "October", "251"),
                new AssociatedImage("nov_abbie2_tghfxe", "November", "251"),
                new AssociatedImage("dec_king_evan_r3inur", "December", "251")
            });
        }

        private void InitialiseYearTwoContent()
        {
            var md = new Markdown {ExtraMode = true, SafeMode = false};

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
                                    new AssociatedImage("jan_sleepy_kxpchv", "Tired Mummy and Baby"),
                                    new AssociatedImage("jan_scary_funny_waqh1t", "Scary? No... funny"),
                                    new AssociatedImage("jan_quiet_time_dyhr4d",
                                        "Red cheeks evidence of Evan's new teeth coming through"),
                                    new AssociatedImage("jan_cheeky_chappy_ba0a3v", "Adorable cheeky chappy")
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
                                    new AssociatedImage("feb_watching_outside_cyga8y",
                                        "More interested in the dogs outside"),
                                    new AssociatedImage("feb_retro_toys_jpbboc",
                                        "Evan has found Caroline's Commodore 64 joy sticks!"),
                                    new AssociatedImage("feb_pillow_play_aopnwg",
                                        "Creature Comforts! Evan likes to have his pillows near by"),
                                    new AssociatedImage("feb_feeding_himself_czqamd",
                                        "Evan sitting on his stool demonstrating self-service"),
                                    new AssociatedImage("feb_gorgeous_bodvdk", "Evan with his mummy"),
                                    new AssociatedImage("feb_cat_play_foutjz", "Noodle play??"),
                                    new AssociatedImage("feb_camera_vwotzt",
                                        "Evan is still clearly obssessed with the camera"),
                                    new AssociatedImage("feb_playing_x12wj5",
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
                                    new AssociatedImage("mar_bed_hair_okw5lp", "Good morning scruffy head!"),
                                    new AssociatedImage(
                                        "mar_feeds_himself_lx8ykc",
                                        "Evan likes to feed himself when he is not being lazy"),
                                    new AssociatedImage("mar_domesticated_zduspx", "Now where did I put that washing?"),
                                    new AssociatedImage("mar_food_tasting_a8zy63", "Evan is very keen to try new foods"),
                                    new AssociatedImage("mar_indoor_car_vt6pev", "Getting the car ready"),
                                    new AssociatedImage("mar_congestion_i0xewu", "Congestion ahead"),
                                    new AssociatedImage("mar_winding_wbxdkb", "Getting the burps out!"),
                                    new AssociatedImage("mar_pants_yqzalg",
                                        "You are supposed to hang out the washing, not wear it!")
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
                                    new AssociatedImage("apr_england_hat_insurn", "Start supporting young"),
                                    new AssociatedImage("apr_odds_farm_lwwlpz",
                                        "Evan enjoying a ride about at Odds Farm Park"),
                                    new AssociatedImage("apr_stacking_bricks_pofhr3",
                                        "Evan showing off his stacking skills - his max is 10 so far!"),
                                    new AssociatedImage("apr_piggy_back_z8kqdb", "Evan loves Mummy's piggy back ride"),
                                    new AssociatedImage("apr_tower_osvpmv",
                                        "Evan needs help to complete his duplo towers"),
                                    new AssociatedImage("apr_collecting_stones_q43xld",
                                        "Collecting stones in the garden"),
                                    new AssociatedImage("apr_climbing_frame_fkaokm",
                                        "The swing doubles up as a climbing frame"),
                                    new AssociatedImage("apr_swing_high_kuskoo",
                                        "A trip to the park swing is necessary for maximum height")
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
                                    new AssociatedImage("may_pink_hair_l9hz3t",
                                        "Maybe he wants to be patriotic by dying his hair!"),
                                    new AssociatedImage("may_sleepy_lunch_vfvko5",
                                        "Oh such a hard life! Evan couldn't even wait for pudding this day..."),
                                    new AssociatedImage("may_world_cup_ready_zmfxpi",
                                        "Evan's all ready for the World Cup!"),
                                    new AssociatedImage("may_plane_spotting_vhyoq2",
                                        "Spotting some planes (Evan says pwane)"),
                                    new AssociatedImage("may_make_shift_chair_snngxc", "Our makeshift chair for Evan"),
                                    new AssociatedImage("may_new_car_cinicp", "Evan finally gets out in his new car"),
                                    new AssociatedImage("may_happy_in_car_mcotp3", "Beep! Beep!"),
                                    new AssociatedImage("may_play_for_country_fo1amv", "Love a baby in a football kit")
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
                                    new AssociatedImage("jun_lovely_smile_wpgwv8", "Evan being just a happy chappy!"),
                                    new AssociatedImage("jun_wellplace_zoo_nc4rrt",
                                        "Evan loved his trip to see all the animals at the Zoo!"),
                                    new AssociatedImage("jun_beach_ball_m5tdye",
                                        "The beach ball was a huge success at the beach"),
                                    new AssociatedImage("jun_seaside_sedn5o", "Playing against the waves"),
                                    new AssociatedImage("jun_road_trip_qkepix", "Going on a road trip"),
                                    new AssociatedImage("jun_rice_krispies_da6oqs", "That's one way to eat your cereal"),
                                    new AssociatedImage("jun_gardener_cq1oim", "Checking on the strawberries"),
                                    new AssociatedImage("jun_football_skills_jbl0tp", "Football skills!")
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
                                    new AssociatedImage("jul_trampoline_uq0bnv", "Evan loves his new trampoline"),
                                    new AssociatedImage("july_booster_tut8vf", "Evan loves eating at the table with us"),
                                    new AssociatedImage("july_slide_p5ywyv",
                                        "'Wow!' was Evan's reaction to his new slide"),
                                    new AssociatedImage("jul_legoland_nu9upk", "Oooh! look at this Mummy"),
                                    new AssociatedImage("jul_slide_done_da9wel", "Little rest after sliding"),
                                    new AssociatedImage("jul_queue_entertainment_fklxze",
                                        "Keeping a child entertained in a queue is a challenge"),
                                    new AssociatedImage("jul_paddling_pool_jgtlzh", "This is more fun than swimming!"),
                                    new AssociatedImage("jul_legoland_ride_kmoimp", "Enjoying the train ride")
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
                                    new AssociatedImage("aug_doggy_kiss_giqhhv", "errghh yuk... Doggy kiss!"),
                                    new AssociatedImage("aug_flying_closeup_pb8c59",
                                        "Evan decides to launch himself on Mummy whilst she's not looking!"),
                                    new AssociatedImage("aug_group_photo_mie4pd",
                                        "Evan and his friends - this scene took only one attempt"),
                                    new AssociatedImage("aug_water_feature_ukzkha",
                                        "Playing with the water feature at Nanny's"),
                                    new AssociatedImage("aug_new_tower_ahqnzs", "A new way to build a tower"),
                                    new AssociatedImage("aug_model_pose_z5nus5", "Always has such a cheeky look"),
                                    new AssociatedImage("aug_concentration_mqgaye",
                                        "His little tongue sneaks out when he is concentrating"),
                                    new AssociatedImage("aug_ball_on_slide_yypv84",
                                        "Even balls can have fun on the slide")
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
                                    new AssociatedImage("sept_ikea_chair_ngv3tq", "At last! we have a chair"),
                                    new AssociatedImage("sept_slippers_jp3gak",
                                        "See Mum, I told you these were the right size"),
                                    new AssociatedImage("sept_legoland_i4elmf",
                                        "Come on, you know you want to get closer..."),
                                    new AssociatedImage("sept_hello_dog_ke8a5d",
                                        "Evan likes to watch Holly the dog next door")
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
                                    new AssociatedImage("oct_ball_play_ga0ai6", "Isn't he just adorable?!?!"),
                                    new AssociatedImage("oct_who_needs_toys_p063d8",
                                        "Who needs toys, when we have Nanny's potatoes and spoons?"),
                                    new AssociatedImage("oct_serious_ektnmc", "Evan enjoying a rare sit down moment...."),
                                    new AssociatedImage("oct_nanny_smiles_yznloa", "....always ends up laughing")
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
                                    new AssociatedImage("nov_bin_pose_irwlwl", "Ignore the bin mummy, just look at me!"),
                                    new AssociatedImage("nov_cute_hair_bypigp",
                                        "Mummy always finds Evan when he is hiding"),
                                    new AssociatedImage("nov_ice_cream_jprryw", "Sharing some ice-cream"),
                                    new AssociatedImage("nov_casual_cpxiw9", "Hello cutie")
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
                                    new AssociatedImage("dec_cooking_lhxk9l",
                                        "Alex, I really think we're missing the point here"),
                                    new AssociatedImage("dec_xmas_dinner_xnarez",
                                        "Don't think we're wearing these hats all day!"),
                                    new AssociatedImage("dec_xmas_presents_p61qix", "I don't need any help this year"),
                                    new AssociatedImage("dec_together_glpge0", "Another amazing year"),
                                    new AssociatedImage("dec_pudding_fnskvu", "Evan loves a pudding!"),
                                    new AssociatedImage("dec_neil_look_e8jmkv", "Discussing presents with Neil"),
                                    new AssociatedImage("dec_computer_ic6pbj", "Playing on the computer"),
                                    new AssociatedImage("dec_birthday_grandma_nva09e", "Grandma helping Evan open presents")
                                }
                            }
                        }
                    });

            _imageCollection.Add(2006, new[]
            {
                new AssociatedImage("jan_cheeky_chappy_ba0a3v", "January", "251"),
                new AssociatedImage("feb_feeding_himself_czqamd", "February", "251"),
                new AssociatedImage("mar_bed_hair_okw5lp", "March", "251"),
                new AssociatedImage("apr_odds_farm_lwwlpz", "April", "251"),
                new AssociatedImage("may_world_cup_ready_zmfxpi", "May", "251"),
                new AssociatedImage("jun_lovely_smile_wpgwv8", "June", "251"),
                new AssociatedImage("jul_legoland_nu9upk", "July", "251"),
                new AssociatedImage("aug_doggy_kiss_giqhhv", "August", "251"),
                new AssociatedImage("sept_legoland_i4elmf", "September", "251"),
                new AssociatedImage("oct_nanny_smiles_yznloa", "October", "251"),
                new AssociatedImage("nov_cute_hair_bypigp", "November", "251"),
                new AssociatedImage("dec_xmas_dinner_xnarez", "December", "251")
            });
        }
    }
}