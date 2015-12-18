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
                            new AssociatedImage("w1_emmas_mum_psbo4x", "Emma's mum with Evan"),
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
                            new AssociatedImage("w7_holding_bottle_qdmcu5", "Evan smiling at Caroline's mum")
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
                        Title = "17th - 23rd April 2005",
                        Tag = "17",
                        EntryOne = md.Transform(Year2005.y1w17One),
                        EntryTwo = md.Transform(Year2005.y1w17Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w17_look_dillon_kufrlr", "Evan watching Dillon Donkey"),
                            new AssociatedImage("w17_very_happy_n8obt8", "Happy Baby"),
                            new AssociatedImage("w17_cot_cry_oto9v3", "Evan didn't like his cot at first..."),
                            new AssociatedImage("w17_zonko_tytzud", "... but he likes his cot now :)")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-18",
                    new DiaryEntry
                    {
                        Title = "24th - 30th April 2005",
                        Tag = "18",
                        EntryOne = md.Transform(Year2005.y1w18One),
                        EntryTwo = md.Transform(Year2005.y1w18Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w18_ooh_whassat_knacas", "Evan with his curious expression"),
                            new AssociatedImage("w18_sitting_strong_vv7q7o", "How does that Tottenham song go?"),
                            new AssociatedImage("w18_sitting_grass_n0iesr", "Sitting on the grass with Mummy"), 
                            new AssociatedImage("w18_chubby_chops_nch5nc", "Look at his cute chubby cheeks!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-19",
                    new DiaryEntry
                    {
                        Title = "1st - 7th May 2005",
                        Tag = "19",
                        EntryOne = md.Transform(Year2005.y1w19One),
                        EntryTwo = md.Transform(Year2005.y1w19Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w19_baby_banz_vkuvma", "Evan in his cool new baby banz"),
                            new AssociatedImage("w19_book_ktfben", "Story time :)"),
                            new AssociatedImage("w19_tummy_batn3n", "Look at this tummy strength!"),
                            new AssociatedImage("w19_fist_emluef", "Oh wait!? There's my fist.")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-20",
                    new DiaryEntry
                    {
                        Title = "8th - 14th May 2005",
                        Tag = "20",
                        EntryOne = md.Transform(Year2005.y1w20One),
                        EntryTwo = md.Transform(Year2005.y1w20Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w20_gorgeous_e1ic6v", "Gorgeous Mummy and baby"),
                            new AssociatedImage("w20_standing_wb05ej", "Look Mum! I'm standing up!"),
                            new AssociatedImage("w20_cats_agynzg", "Evan playing with the cats"),
                            new AssociatedImage("w20_cats_unsure_jkisxh", "Poppy thinks twice")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-21",
                    new DiaryEntry
                    {
                        Title = "15th - 21st May 2005",
                        Tag = "21",
                        EntryOne = md.Transform(Year2005.y1w21One),
                        EntryTwo = md.Transform(Year2005.y1w21Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w21_uncle_neil_zw7sq6", "Evan and his Uncle Neil"),
                            new AssociatedImage("w21_foot_or_toy_nnrdhh", "Toy or Foot?.... It's a hard life"), 
                            new AssociatedImage("w21_cup_drinking_cmtiso", "Evan learning to drink from a cup"), 
                            new AssociatedImage("w21_yes_its_me_cvqbl3", "Yes, you keep looking at me")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-22",
                    new DiaryEntry
                    {
                        Title = "22nd - 28th May 2005",
                        Tag = "22",
                        EntryOne = md.Transform(Year2005.y1w22One),
                        EntryTwo = md.Transform(Year2005.y1w22Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w22_swim_trunks_xjz012", "hmm... now what do I play with?"),
                            new AssociatedImage("w22_bumbo_yq6rid", "Oooh what's this? - Evan in his new 'Bumbo Seat'"),
                            new AssociatedImage("w22_nekkid_xx4ip1", "Evan letting it all hang out"),
                            new AssociatedImage("w22_baby_rice_uy0nyu", "Mmmmm, baby rice & formula :/") 
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-23",
                    new DiaryEntry
                    {
                        Title = "29th May - 4th June 2005",
                        Tag = "23",
                        EntryOne = md.Transform(Year2005.y1w23One),
                        EntryOneAdditionalImage = new AssociatedImage("w23_the_party_u8scfn", "The Party"),
                        EntryTwo = md.Transform(Year2005.y1w23Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w23_cheeky_bottom_bmu0br", "I can see that bottom!"), 
                            new AssociatedImage("w23_great_grandmother_wimpnn", "This is my great nanny!"),
                            new AssociatedImage("w23_carrot_gkqncr", "Evan even managed to get carrot on his nose!"),
                            new AssociatedImage("w23_computer_anr207", "Quiet please, I'm concentrating!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-24",
                    new DiaryEntry
                    {
                        Title = "5th - 11th June 2005",
                        Tag = "24",
                        EntryOne = md.Transform(Year2005.y1w24One),
                        EntryTwo = md.Transform(Year2005.y1w24Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w24_happy_baby_ng0web", "Yes... the grass tickles my toes!"), 
                            new AssociatedImage("w24_big_cuddles_unbchl", "Evan sharing a big cuddle with Grandma"), 
                            new AssociatedImage("w24_mel_smzrqq", "Evan with Caroline's best friend Mel"), 
                            new AssociatedImage("w24_vicky_n1s1zh", "Evan asleep on Vicky's shoulder") 
                        }
                    });


            _diaryEntries
                .Add(
                    "2005-25",
                    new DiaryEntry
                    {
                        Title = "12th - 18th June 2005",
                        Tag = "25",
                        EntryOne = md.Transform(Year2005.y1w25One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w25_pushchair_lspemu", "Mmm tasty pushchair, it gets the 'Toes-Up' from me Mum!"),
                            new AssociatedImage("w25_trendy_cd6ogm", "Trendy boy"),
                            new AssociatedImage("w25_car_arudgn", "Still prefers to eat his toys"),
                            new AssociatedImage("w25_asleep_at_dinner_xrarxa", "Boob or bottle, both seem to send him to sleep")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-26",
                    new DiaryEntry
                    {
                        Title = "19th - 25th June 2005",
                        Tag = "26",
                        EntryOne = md.Transform(Year2005.y1w26One),
                        EntryTwo = md.Transform(Year2005.y1w26Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w26_lazy_sunday_cf7yyf", "Lazy Sunday morning..."),
                            new AssociatedImage("w26_lazy_sunday2_yojgye", "...LOVE..."),
                            new AssociatedImage("w26_lazy_sunday4_qxibmn", "...him..."),
                            new AssociatedImage("w26_lazy_sunday3_cvua3k", "...SO MUCH!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-27",
                    new DiaryEntry
                    {
                        Title = "26th June - 2nd July 2005",
                        Tag = "27",
                        EntryOne = md.Transform(Year2005.y1w27One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w27_carolines_new_hair_pybyio", "Caroline has a hair cut - 'Bout time we had a pic of her again!"),
                            new AssociatedImage("w27_zonked_qyvx2a", "It's a hard life"),
                            new AssociatedImage("w27_sitting_up_rxcgde", "I don't need Mummy's support"),
                            new AssociatedImage("w27_ice-cream_rmuye6", "Gimme dat ice-cream!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-28",
                    new DiaryEntry
                    {
                        Title = "3rd - 9th July 2005",
                        Tag = "28",
                        EntryOne = md.Transform(Year2005.y1w28One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w28_hair_style_hatwjl", "Yes! Mummy has put stuff in my hair..."),
                            new AssociatedImage("w28_cool_dude_d6c1du", "Evan showing how well he sits up. He'll sit and play for ages now"),
                            new AssociatedImage("w28_how_many_fingers_lflgva", "How mny fingers?"),
                            new AssociatedImage("w28_lush_baby_xhua1l", "Fluffy blonde hair and gorgeous blue eyes")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-29",
                    new DiaryEntry
                    {
                        Title = "10th - 16th July 2005",
                        Tag = "29",
                        EntryOne = md.Transform(Year2005.y1w29One),
                        EntryTwo = md.Transform(Year2005.y1w29Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w29_heat_wave_ngftvr", "Amidst all the horror - Evan enjoys the heat wave"),
                            new AssociatedImage("w29_new_toys_kcmuqv", "Evan enjoying his new big boy toys"),
                            new AssociatedImage("w29_any_resemblance_h0ybcw", "Any resemblance?"),
                            new AssociatedImage("w29_power_nap_sempgs", "Power nap")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-30",
                    new DiaryEntry
                    {
                        Title = "17th - 23rd July 2005",
                        Tag = "30",
                        EntryOne = md.Transform(Year2005.y1w30One),
                        EntryTwo = md.Transform(Year2005.y1w30Two),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w30_high_chair_zui889", "hmmm... definitely room to grow"),
                            new AssociatedImage("w30_stacking_cups_nw83vy", "Evan getting psyched up for the collapse"), 
                            new AssociatedImage("w30_tower_crash_m44ihu", "...Boom!"), 
                            new AssociatedImage("w30_always_happy_m0vpfh", "Love how happy he is.")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-31",
                    new DiaryEntry
                    {
                        Title = "24th - 30th July 2005",
                        Tag = "31",
                        EntryOne = md.Transform(Year2005.y1w31One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w31_dribble_kiss_v1lb7o", "Kiss?"),
                            new AssociatedImage("w31_euuw_dribble_lmnqf9", "I show my affection to mummy with lots of dribble"),
                            new AssociatedImage("w31_got_you_mqwo2u", "Got you..."), 
                            new AssociatedImage("w31_want_one_s96t4l", "Now you!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-32",
                    new DiaryEntry
                    {
                        Title = "31st July - 6th August 2005",
                        Tag = "32",
                        EntryOne = md.Transform(Year2005.y1w32One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w32_bottle_feed_nrtgjv", "Evan is self-sufficient when it comes to the bottle"),
                            new AssociatedImage("w32_team_mascot_cn9m4k", "So... is this team any good Mum?"),
                            new AssociatedImage("w32_all_fall_down_yidzjx", "eep! here they come!"),
                            new AssociatedImage("w32_scrambled_egg_t4pm66", "Evan is not a fan of scrambled egg")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-33",
                    new DiaryEntry
                    {
                        Title = "7th - 13th August 2005",
                        Tag = "33",
                        EntryOne = md.Transform(Year2005.y1w33One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w33_evan_and_friends_uzmyhc", "Evan enjoying a fun afternoon with his friends"), 
                            new AssociatedImage("w33_sucking_toast_ftgyye", "Evan having a good suck on his first ever piece of toast"),
                            new AssociatedImage("w33_biceps_wknqsk", "Look at those biceps!"), 
                            new AssociatedImage("w33_funny_boy_pggzmj", "Funny boy")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-34",
                    new DiaryEntry
                    {
                        Title = "14th - 20th August 2005",
                        Tag = "34",
                        EntryOne = md.Transform(Year2005.y1w34One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w34_cheeky_chappy_wj2nlc", "Evan is eyeing up the camera for dinner"),
                            new AssociatedImage("w34_hello_fluffy_emky6d", "Hello fluffy cat"),
                            new AssociatedImage("w34_hello_vwlpvf", "Hello!"), 
                            new AssociatedImage("w34_tongue_hvlflr", "Evan can stick out his tongue")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-35",
                    new DiaryEntry
                    {
                        Title = "21st - 27th August 2005",
                        Tag = "35",
                        EntryOne = md.Transform(Year2005.y1w35One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w35_professional_pose_lfm62g", "Evan posing for the camera, or is he eyeing up a sleeping cat?"), 
                            new AssociatedImage("w35_nice_n_clean_qkvuku", "Evan showing an increasing desire to grab the camera"), 
                            new AssociatedImage("w35_hiding_pjaeo8", "I'm hiding"), 
                            new AssociatedImage("w35_big_boy_ltjyw8", "35 weeks and he's almost as big as Emma")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-36",
                    new DiaryEntry
                    {
                        Title = "28th August - 3rd September 2005",
                        Tag = "36",
                        EntryOne = md.Transform(Year2005.y1w36One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w36_where_are_we_xizm58", "Where are we?"), 
                            new AssociatedImage("w36_what_is_this_u0kvtn", "What is this?"), 
                            new AssociatedImage("w36_strange_feeling_pt8twn", "The sand feels cold on Evan's toes"),
                            new AssociatedImage("w36_sand_feels_good_nd9v2f", "Evan loves it")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-37",
                    new DiaryEntry
                    {
                        Title = "4th - 10th September 2005",
                        Tag = "37",
                        EntryOne = md.Transform(Year2005.y1w37One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w37_tickle_time_zwaq1u", "It's tickle time"), 
                            new AssociatedImage("w37_choosing_toys_jvjujr", "Let me choose the toys today"), 
                            new AssociatedImage("w37_yummy_bath_water_zlugqo", "Yummy bath water"), 
                            new AssociatedImage("w37_all_fours_ctlk6z", "Almost ready to crawl")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-38",
                    new DiaryEntry
                    {
                        Title = "11th - 17th September 2005",
                        Tag = "38",
                        EntryOne = md.Transform(Year2005.y1w38One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w38_new_seat_oormsl", "Evan sprawling out in his new seat"), 
                            new AssociatedImage("w38_dintons_pastures_qpqyxj", "Having a break from picking blackberries"), 
                            new AssociatedImage("w38_cutest_foot_xbg42k", "I could just eat his feet"),
                            new AssociatedImage("w38_play_pen_dn51mb", "Staying safe in the play pen")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-39",
                    new DiaryEntry
                    {
                        Title = "18th - 24th September 2005",
                        Tag = "39",
                        EntryOne = md.Transform(Year2005.y1w39One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w39_crawling_v14frs", "I can crawl!"), 
                            new AssociatedImage("w39_camera_hunt_bkxsza", "Taking pictures is tricky now he crawls"), 
                            new AssociatedImage("w39_my_seat_wyssfe", "It's my seat now"), 
                            new AssociatedImage("w39_where_is_on_kgozrx", "How do I turn this back on?")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-40",
                    new DiaryEntry
                    {
                        Title = "25th September - 1st October 2005",
                        Tag = "40",
                        EntryOne = md.Transform(Year2005.y1w40One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w40_new_toys_hftsfo", "But I want these toys mummy..."), 
                            new AssociatedImage("w40_finger_foods_scd7hi", "Teaching Evan how to eat finger foods - this was before he mashed them everywhere!"), 
                            new AssociatedImage("w40_finger_foods2_if3sk0", "This biscuit is as big as him"), 
                            new AssociatedImage("w40_tears_jkqy78", "Tears of freedom?")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-41",
                    new DiaryEntry
                    {
                        Title = "2nd - 8th October 2005",
                        Tag = "41",
                        EntryOne = md.Transform(Year2005.y1w41One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w41_standing_alone_lw9vke", "Woohoo - Look at him now"), 
                            new AssociatedImage("w41_activity_table_f8nsb2", "Evan enjoying his new found freedom at his new activity table"), 
                            new AssociatedImage("w41_keys_st6umh", "So, that's where my keys are"), 
                            new AssociatedImage("w41_picture_for_mummy_bepmwe", "Our first picture that Evan made at nursery (pasta shapes glued to paper) ")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-42",
                    new DiaryEntry
                    {
                        Title = "9th - 15th October 2005",
                        Tag = "42",
                        EntryOne = md.Transform(Year2005.y1w42One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w42_evan_impression_skoa4q", "My impression of Evan"), 
                            new AssociatedImage("w42_play_biting_wv7jjb", "Play biting or fighting?"), 
                            new AssociatedImage("w42_mischievious_ceqpqe", "What are you up to?"), 
                            new AssociatedImage("w42_ball_pit_r70zbv", "Playing with friends")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-43",
                    new DiaryEntry
                    {
                        Title = "16th - 22nd October 2005",
                        Tag = "43",
                        EntryOne = md.Transform(Year2005.y1w43One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w43_first_shoes_osqu8g", "First pair of shoes"), 
                            new AssociatedImage("w43_first_shoes_closeup_podqjj", "So cute!"), 
                            new AssociatedImage("w43_need_a_haircut_kkisqy", "Someone needs a hair cut"), 
                            new AssociatedImage("w43_tired_baby_eh8lcd", "Aww bless him")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-44",
                    new DiaryEntry
                    {
                        Title = "23rd - 29th October 2005",
                        Tag = "44",
                        EntryOne = md.Transform(Year2005.y1w44One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w44_sept_filler_image2_rfjglh", "Healthy baby"), 
                            new AssociatedImage("w44_poorly_baby_tjdx4i", "Poorly baby"), 
                            new AssociatedImage("w44_double_poorly_aj2k4o", "Everyone is ill this week"), 
                            new AssociatedImage("w44_sept_filler_image_lqajad", "A lot of baths this week")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-45",
                    new DiaryEntry
                    {
                        Title = "30th October - 5th November 2005",
                        Tag = "45",
                        EntryOne = md.Transform(Year2005.y1w45One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w45_is_this_bath_lrvv5l", "Is this bath for me?"), 
                            new AssociatedImage("w45_for_me_zayvh1", "Evan loves to peer into the bath as it is filling up"), 
                            new AssociatedImage("w45_new_trick_j2p3jd", "Evan's new trick is to drink from the cups as the water trickles through!"), 
                            new AssociatedImage("w45_loves_a_bath_pnx3it", "Delightful :)")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-46",
                    new DiaryEntry
                    {
                        Title = "6th - 12th November 2005",
                        Tag = "46",
                        EntryOne = md.Transform(Year2005.y1w46One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w46_camera_fascination_g336ah", "Evan proving how difficult it is to photograph him these days"), 
                            new AssociatedImage("w46_prebath_play_time_ykp6n7", "Pre-bath play time"), 
                            new AssociatedImage("w46_what_ya_doing_oqbptf", "Evan is interested in everything we do"), 
                            new AssociatedImage("w46_hurry_up_gdhtbu", "Hurry up bath!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-47",
                    new DiaryEntry
                    {
                        Title = "13th - 19th November 2005",
                        Tag = "47",
                        EntryOne = md.Transform(Year2005.y1w47One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w47_before_haircut_qpvsrj", "Before hair cut"), 
                            new AssociatedImage("w47_after_haircut_rp8ntl", "After hair cut"), 
                            new AssociatedImage("w47_wax_weciuo", "Showing interest in some product"), 
                            new AssociatedImage("w47_lush_xpbspn", "Just beautiful")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-48",
                    new DiaryEntry
                    {
                        Title = "20th - 26th November 2005",
                        Tag = "48",
                        EntryOne = md.Transform(Year2005.y1w48One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w48_inquisitive_toilet_zqubt8", "A toilet lock is now a necessity"), 
                            new AssociatedImage("w48_cheeky_hlo7ri", "Cheeky look"), 
                            new AssociatedImage("w48_dribbler_v81hyc", "Dribbletastic"), 
                            new AssociatedImage("w48_not_a_toy_bnpgvj", "Obsessed much with the camera Evan?")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-49",
                    new DiaryEntry
                    {
                        Title = "27th November - 3rd December 2005",
                        Tag = "49",
                        EntryOne = md.Transform(Year2005.y1w49One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w49_strong_legs_kqhxmb", "Strong legs"), 
                            new AssociatedImage("w49_stocky_chap_kcrkxk", "Stocky chappy"), 
                            new AssociatedImage("w49_peek-a-boo_dsiiiv", "Playing peek-a-boo"), 
                            new AssociatedImage("w49_shopping_pdsjvf", "Helping to unpack, does not mean eat it first!")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-50",
                    new DiaryEntry
                    {
                        Title = "4th - 10th December 2005",
                        Tag = "50",
                        EntryOne = md.Transform(Year2005.y1w50One),
                        Images = new List<IAssociatedImage>
                        {
                            new AssociatedImage("w50_introducing_nneldz", "Introducing Noodle, the new addition to our growing family"), 
                            new AssociatedImage("w50_first_nativity_o74tfp", "Getting ready for Evan's first nativity performance"), 
                            new AssociatedImage("w50_first_nativity2_ubugj2", "Evan is the second one in from the left on the front row"), 
                            new AssociatedImage("w50_noodle_fmwilp", "Settling in very well")
                        }
                    });

            _diaryEntries
                .Add(
                    "2005-51",
                    new DiaryEntry
                    {
                        Title = "11th - 17th December 2005",
                        Tag = "51",
                        EntryOne = md.Transform(Year2005.y1w51One),
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
                    "2005-52",
                    new DiaryEntry
                    {
                        Title = "",
                        Tag = "52",
                        EntryOne = md.Transform(Year2005.y1w52One),
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
