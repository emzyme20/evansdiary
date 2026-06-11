import type { Media, VideoMedia, DocumentReference } from "../types";

/*
 * Diary Structure and Dynamic Content Types
 */
export interface YearStructure {
  year: string;
  mode: "week" | "month"; // Determines how the content is structured
  items: Media[];
}

// 2. Deep Content Model (Only loaded on the actual entry page)
export interface CalendarDiaryEntryItem {
  heading: string;
  markdownPath: string;
  images: Media[];
  videos?: VideoMedia[];
}

export interface StandardDiaryEntry {
  period: string; // e.g., "26th December 2004 - 1st January 2005"
  markdownPaths: string[]; // Array of paths to markdown files for this entry, e.g., ["/assets/diary-content/2026/month-01-a.md", "/assets/diary-content/2005-00-a.md"]
  images: Media[]; // Array of up to 12 image objects
  documents?: DocumentReference[]; // Any associated documents to open in a popout viewer
  type?: "standard";
}

export interface CalendarDiaryEntry {
  period: string;
  type: "calendar";
  calendarEntries: CalendarDiaryEntryItem[];
}

// Union type for diary entries, allowing for both standard and calendar formats
export type DiaryEntry = StandardDiaryEntry | CalendarDiaryEntry;

/*
 * Static Route Registry
 */
export const DIARY_REGISTRY: Record<string, YearStructure> = {
  "2005": {
    year: "2005",
    mode: "week",
    items: [
      {
        source: "w0_emma_first_hold_yxohgg",
        caption: "The Birth",
      },
      {
        source: "w1_evan_peaceful_n7d6jq",
        caption: "Week 1",
      },
      {
        source: "w2_ooh_looking_at_emma_zcxo7r",
        caption: "Week 2",
      },
      {
        source: "w3_playgym_ruptaf",
        caption: "Week 3",
      },
      {
        source: "w4_keep_rocking_d66fey",
        caption: "Week 4",
      },
      {
        source: "w5_smiling_now_kukeoj",
        caption: "Week 5",
      },
      {
        source: "w6_giggles_z4qpas",
        caption: "Week 6",
      },
      {
        source: "w7_holding_bottle_tafgcb",
        caption: "Week 7",
      },
      {
        source: "w8_tummy_time_v4fjqp",
        caption: "Week 8",
      },
      {
        source: "w9_hello_billy_d63gj4",
        caption: "Week 9",
      },
      {
        source: "w10_new_hat_enqoxo",
        caption: "Week 10",
      },
      {
        source: "w11_bath_time_i3xdve",
        caption: "Week 11",
      },
      {
        source: "w12_chewing_fist_cu9d4x",
        caption: "Week 12",
      },
      {
        source: "w13_muslin_z2hfny",
        caption: "Week 13",
      },
      {
        source: "w14_new_cap_q3wsat",
        caption: "Week 14",
      },
      {
        source: "w15_sleeping_beauty_ejmpu8",
        caption: "Week 15",
      },
      {
        source: "w16_commando_bsghhv",
        caption: "Week 16",
      },
      {
        source: "w17_zonko_bpk8od",
        caption: "Week 17",
      },
      {
        source: "w18_sitting_grass_r6jvp9",
        caption: "Week 18",
      },
      {
        source: "w19_book_mxcl2d",
        caption: "Week 19",
      },
      {
        source: "w20_gorgeous_d9u34v",
        caption: "Week 20",
      },
      {
        source: "w21_cup_drinking_godb3l",
        caption: "Week 21",
      },
      {
        source: "w22_baby_rice_sblciy",
        caption: "Week 22",
      },
      {
        source: "w23_computer_uqnsjh",
        caption: "Week 23",
      },
      {
        source: "w24_happy_baby_oiy5jd",
        caption: "Week 24",
      },
      {
        source: "w25_trendy_qkqe3b",
        caption: "Week 25",
      },
      {
        source: "w26_lazy_sunday3_nq0pfk",
        caption: "Week 26",
      },
      {
        source: "w27_sitting_up_kht5ey",
        caption: "Week 27",
      },
      {
        source: "w28_cool_dude_rulh6a",
        caption: "Week 28",
      },
      {
        source: "w29_heat_wave_ei51wp",
        caption: "Week 29",
      },
      {
        source: "w30_stacking_cups_ja7edn",
        caption: "Week 30",
      },
      {
        source: "w31_got_you_bcnkko",
        caption: "Week 31",
      },
      {
        source: "w32_bottle_feed_g0arjp",
        caption: "Week 32",
      },
      {
        source: "w33_sucking_toast_gpc1cn",
        caption: "Week 33",
      },
      {
        source: "w34_hello_fluffy_trjpfd",
        caption: "Week 34",
      },
      {
        source: "w35_nice_n_clean_aninsf",
        caption: "Week 35",
      },
      {
        source: "w36_where_are_we_quu52z",
        caption: "Week 36",
      },
      {
        source: "w37_tickle_time_asant7",
        caption: "Week 37",
      },
      {
        source: "w38_new_seat_eq5mvb",
        caption: "Week 38",
      },
      {
        source: "w39_camera_hunt_bhsm9p",
        caption: "Week 39",
      },
      {
        source: "w40_finger_foods_pbfi5h",
        caption: "Week 40",
      },
      {
        source: "w41_activity_table_bwfft8",
        caption: "Week 41",
      },
      {
        source: "w42_evan_impression_yiqifo",
        caption: "Week 42",
      },
      {
        source: "w43_first_shoes_bshqhe",
        caption: "Week 43",
      },
      {
        source: "w44_poorly_baby_lpm7e3",
        caption: "Week 44",
      },
      {
        source: "w45_new_trick_vea4az",
        caption: "Week 45",
      },
      {
        source: "w46_camera_fascination_uxdn1v",
        caption: "Week 46",
      },
      {
        source: "w47_wax_duawul",
        caption: "Week 47",
      },
      {
        source: "w48_inquisitive_toilet_pdhvoc",
        caption: "Week 48",
      },
      {
        source: "w49_strong_legs_vmkxth",
        caption: "Week 49",
      },
      {
        source: "w50_introducing_gpr8ea",
        caption: "Week 50",
      },
      {
        source: "w51_matching_hair_uroew9",
        caption: "Week 51",
      },
      {
        source: "w52_still_loves_camera_a1quy1",
        caption: "Week 52",
      },
    ],
  },
  "2006": {
    year: "2006",
    mode: "month",
    items: [
      { source: "jan_cheeky_chappy_ba0a3v", caption: "January" },
      { source: "feb_feeding_himself_czqamd", caption: "February" },
      { source: "mar_bed_hair_okw5lp", caption: "March" },
      { source: "apr_odds_farm_lwwlpz", caption: "April" },
      { source: "may_world_cup_ready_zmfxpi", caption: "May" },
      { source: "jun_lovely_smile_wpgwv8", caption: "June" },
      { source: "jul_legoland_nu9upk", caption: "July" },
      { source: "aug_doggy_kiss_giqhhv", caption: "August" },
      { source: "sept_legoland_i4elmf", caption: "September" },
      { source: "oct_nanny_smiles_yznloa", caption: "October" },
      { source: "nov_cute_hair_bypigp", caption: "November" },
      { source: "dec_xmas_dinner_xnarez", caption: "December" },
    ],
  },
  "2007": {
    year: "2007",
    mode: "month",
    items: [
      { source: "jan_play_watching_oyeyxq", caption: "January" },
      { source: "feb_well_done_vnnj4p", caption: "February" },
      { source: "mar_relaxed_i5sjsy", caption: "March" },
      { source: "apr_scar_smile_uvwdy9", caption: "April" },
      { source: "may_head_first_m1dbyd", caption: "May" },
      { source: "june_evan_boat_yjnkvf", caption: "June" },
      { source: "july_cardboard_bob_uiq3bg", caption: "July" },
      { source: "aug_block_stacking_v2tddw", caption: "August" },
      { source: "sept_meeting_roary_f2dfbj", caption: "September" },
      { source: "oct_nanny_giggles_bxg4gn", caption: "October" },
      { source: "nov_abbie2_tghfxe", caption: "November" },
      { source: "dec_king_evan_r3inur", caption: "December" },
    ],
  },
  "2008": {
    year: "2008",
    mode: "month",
    items: [
      { source: "jj-celebrate_aorigs", caption: "January" },
      { source: "feb_messy_face_g1hzs4", caption: "February" },
      { source: "mar_ice-cream_m0p0fd", caption: "March" },
    ],
  },
};

// A map containing paths to heavy content, queried only on the Entry Page
export const DIARY_CONTENT_REGISTRY: Record<string, DiaryEntry> = {
  "2005-00": {
    period: "26th Decemeber 2004",
    markdownPaths: [
      "/content/diary/2005/2005-00-a.md",
      "/content/diary/2005/2005-00-b.md",
    ],
    images: [
      {
        source: "w0_emma_first_hold_yxohgg",
        caption: "Emma holding Evan for the first time",
      },
      {
        source: "w0_midwife_idbcyw",
        caption: "Our wonderful midwife, Valeska",
      },
      {
        source: "w0_before_birth_cgiahd",
        caption: "Emma in the labour ward, before the birth",
      },
      {
        source: "w0_caroline_first_hold_rgpgcj",
        caption: "Caroline with Evan a few minutes after the birth",
      },
    ],
  },
  "2005-01": {
    period: "26th December 2004 - 1st January 2005",
    markdownPaths: [
      "/content/diary/2005/2005-01-a.md",
      "/content/diary/2005/2005-01-b.md",
    ],
    images: [
      {
        source: "w1_evan_peaceful_n7d6jq",
        caption:
          "Caroline's first view of Evan in hospital, just a few hours old",
      },
      {
        source: "w1_emmas_mum_lkfedi",
        caption: "Emma's mum with Evan",
      },
      {
        source: "w1_emma_evan_bed_corysg",
        caption: "Emma and Evan, peaceful in hospital",
      },
      {
        source: "w1_evans_foot_coxy5x",
        caption: "What a cute footsie!",
      },
    ],
  },
  "2005-02": {
    period: "2nd - 8th January 2005",
    markdownPaths: [
      "/content/diary/2005/2005-02-a.md",
      "/content/diary/2005/2005-02-b.md",
    ],
    images: [
      {
        source: "w2_sleepy_baby_ukesh5",
        caption: "Such a hard life",
      },
      {
        source: "w2_ooh_looking_at_emma_zcxo7r",
        caption: "One of Evan's cute little expressions! 'Hello mummy!'",
      },
      {
        source: "w2_being_changed_joxhds",
        caption: "Evan grumbling at having his nappy changed",
      },
      {
        source: "w2_resting_nyyjod",
        caption: "Both of us having a rest",
      },
    ],
  },
  "2005-03": {
    period: "9th - 15th January 2005",
    markdownPaths: [
      "/content/diary/2005/2005-03-a.md",
      "/content/diary/2005/2005-03-b.md",
    ],
    images: [
      {
        source: "w3_zonked_k3isgq",
        caption: "Completely zonked out! Too much boob! :-)",
      },
      {
        source: "w3_matching_socks_aj3lgg",
        caption: "Outfit includes matching socks",
      },
      {
        source: "w3_playgym_ruptaf",
        caption: "A rare moment amusing himself on the play gym",
      },
      {
        source: "w3_wind_struggles_s7c6zt",
        caption: "Practicing different winding techniques",
      },
    ],
  },
  "2005-04": {
    period: "16th - 22nd January 2005",
    markdownPaths: [
      "/content/diary/2005/2005-04-a.md",
      "/content/diary/2005/2005-04-b.md",
    ],
    images: [
      {
        source: "w4_keep_rocking_d66fey",
        caption:
          "Evan letting Grandma know that she'll need to rock him for longer!",
      },
      {
        source: "w4_right_mitt_zgtpu1",
        caption: "Have you seen my left mitt?",
      },
      {
        source: "w4_mindy_slamce",
        caption:
          "Emma's mums dog Mindy is very intrigued by this new creature!",
      },
      {
        source: "w4_left_mitt_cflghg",
        caption: "Where's my right mitt now?!?",
      },
    ],
  },
  "2005-05": {
    period: "23rd - 29th January 2005",
    markdownPaths: [
      "/content/diary/2005/2005-05-a.md",
      "/content/diary/2005/2005-05-b.md",
    ],
    images: [
      {
        source: "w5_smiling_now_kukeoj",
        caption: "Look Mummy, I can smile now",
      },
      {
        source: "w5_sofa_snooze_q63dnp",
        caption: "No trouble sleeping on the sofa",
      },
      {
        source: "w5_baldy_g3x6t4",
        caption: "I know you're looking at my bald patch, stop it!",
      },
      {
        source: "w5_nice_and_warm_bhs0up",
        caption: "All nice and warm in here",
      },
    ],
  },
  "2005-06": {
    period: "30th January - 5th February 2005",
    markdownPaths: [
      "/content/diary/2005/2005-06-a.md",
      "/content/diary/2005/2005-06-b.md",
    ],
    images: [
      {
        source: "w6_giggles_z4qpas",
        caption: "Evan likes his change mat a lot for some reason!",
      },
      {
        source: "w6_jazz_hands_y85uhg",
        caption: "Evan doing his 'Jazz Hands'",
      },
      {
        source: "w6_tootsies_n76p7e",
        caption: "Thumbs Up! Oh no, that's tootsies!",
      },
      {
        source: "w6_cutest_sleeper_oqsqt0",
        caption: "Just the cutest little sleeper",
      },
    ],
  },
  "2005-07": {
    period: "6th - 12th February 2005",
    markdownPaths: [
      "/content/diary/2005/2005-07-a.md",
      "/content/diary/2005/2005-07-b.md",
    ],
    images: [
      {
        source: "w7_whats_this_idgt3s",
        caption: "Hmmm... what's this?",
      },
      {
        source: "w7_cute_with_tears_jio5m1",
        caption: "So cute, even with tears!",
      },
      {
        source: "w7_smiling_for_nan_kqzbuf",
        caption: "Yep, I can hold it Mum!",
      },
      {
        source: "w7_holding_bottle_tafgcb",
        caption: "Evan smiling at Caroline's mum",
      },
    ],
  },
  "2005-08": {
    period: "13th - 19th February 2005",
    markdownPaths: [
      "/content/diary/2005/2005-08-a.md",
      "/content/diary/2005/2005-08-b.md",
    ],
    images: [
      {
        source: "w8_are_you_sure_awndbi",
        caption: "Are you sure you want me to pick you up?",
      },
      {
        source: "w8_yes_i_am_sure_dr33f1",
        caption: "Yes, I'm sure!",
      },
      {
        source: "w8_tummy_time_v4fjqp",
        caption: "Evan, demonstrating the benefits of tummy time",
      },
      {
        source: "w8_stuffed_xjmydd",
        caption: "Stuffed from a good feed",
      },
    ],
  },
  "2005-09": {
    period: "20th - 26th February 2005",
    markdownPaths: [
      "/content/diary/2005/2005-09-a.md",
      "/content/diary/2005/2005-09-b.md",
    ],
    images: [
      {
        source: "w9_getting_stronger_wl8hdm",
        caption: "Getting stronger",
      },
      {
        source: "w9_peekaboo_kt3yit",
        caption: "Peek-a-boo",
      },
      {
        source: "w9_hello_billy_d63gj4",
        caption: "Hello Billy, my name's Evan!",
      },
      {
        source: "w9_all_smiles_whnfl4",
        caption: "All smiles",
      },
    ],
  },
  "2005-10": {
    period: "27th February - 5th March 2005",
    markdownPaths: [
      "/content/diary/2005/2005-10-a.md",
      "/content/diary/2005/2005-10-b.md",
    ],
    images: [
      {
        source: "w10_tight_trousers_de4ppk",
        caption:
          "Yes, my trousers are far too tight, and No, I'm not happy about it!",
      },
      {
        source: "w10_lovely_eyes_wigbd3",
        caption: "Lovely eyes with long lashes",
      },
      {
        source: "w10_new_hat_enqoxo",
        caption: "Do you like my new hat?",
      },
      {
        source: "w10_double_tummy_time_ewooft",
        caption: "Double tummy time",
      },
    ],
  },
  "2005-11": {
    period: "6th - 12th March 2005",
    markdownPaths: [
      "/content/diary/2005/2005-11-a.md",
      "/content/diary/2005/2005-11-b.md",
    ],
    images: [
      {
        source: "w11_bath_time_i3xdve",
        caption: "Evan, showing his happy face during bath time",
      },
      {
        source: "w11_grumpy_face_dzz339",
        caption:
          "Evan, doing his best impression of Emma with his grumpy face!",
      },
      {
        source: "w11_munching_molly_s1svkk",
        caption: "Evan about to munch on Molly Moo Moo (a toy cow!)",
      },
      {
        source: "w11_less_sick_hsczcl",
        caption: "Finally, the milk reflux has subsided",
      },
    ],
  },
  "2005-12": {
    period: "13th - 19th March 2005",
    markdownPaths: [
      "/content/diary/2005/2005-12-a.md",
      "/content/diary/2005/2005-12-b.md",
    ],
    images: [
      {
        source: "w12_chewing_fist_cu9d4x",
        caption: "Evan demonstrating his new fist-chewing ability",
      },
      {
        source: "w12_frown_drq2oi",
        caption: "Loving the frown",
      },
      {
        source: "w12_holding_billy_ba5n5x",
        caption: "Evan likes to carry his toys around with him these days",
      },
      {
        source: "w12_just_hanging_iuh1s1",
        caption: "Just hanging...",
      },
    ],
  },
  "2005-13": {
    period: "20th - 26th March 2005",
    markdownPaths: [
      "/content/diary/2005/2005-13-a.md",
      "/content/diary/2005/2005-13-b.md",
    ],
    images: [
      {
        source: "w13_examining_fish_pbg7at",
        caption: "Hmmm, interesting species of fish!",
      },
      {
        source: "w13_wee_protection_kztpy9",
        caption: "Protection from wee!",
      },
      {
        source: "w13_muslin_z2hfny",
        caption: "I'm hiding, you can't see me :)",
      },
      {
        source: "w13_lick_db3e9b",
        caption: "Tasty!",
      },
    ],
  },
  "2005-14": {
    period: "27th March - 2nd April 2005",
    markdownPaths: [
      "/content/diary/2005/2005-14-a.md",
      "/content/diary/2005/2005-14-b.md",
    ],
    images: [
      {
        source: "w14_new_cap_q3wsat",
        caption: "Ok, I do like my new cap after all...",
      },
      {
        source: "w14_sleep_shoulder_x5uzhv",
        caption: "Oh, it's a hard life!",
      },
      {
        source: "w14_bath_robe_nkua21",
        caption: "Showing a bit of leg :)",
      },
      {
        source: "w14_hide_seek_uaznzr",
        caption: "Pillow Den",
      },
    ],
  },
  "2005-15": {
    period: "3rd - 9th April 2005",
    markdownPaths: [
      "/content/diary/2005/2005-15-a.md",
      "/content/diary/2005/2005-15-b.md",
    ],
    images: [
      {
        source: "w15_sleeping_beauty_ejmpu8",
        caption: "Sleeping Beauty?",
      },
      {
        source: "w15_splish_splash_uaca8r",
        caption: "Splish! Splash!",
      },
      {
        source: "w15_teddies_ws1y3j",
        caption: "Teddy zone",
      },
      {
        source: "w15_baby_hidden_cs7wqc",
        caption: "There's a baby in there",
      },
    ],
  },
  "2005-16": {
    period: "10th - 16th April 2005",
    markdownPaths: [
      "/content/diary/2005/2005-16-a.md",
      "/content/diary/2005/2005-16-b.md",
    ],
    images: [
      {
        source: "w16_sunday_best_klwkyn",
        caption: "Evan looking all smart",
      },
      {
        source: "w16_grandmas_swing_l8v2ub",
        caption: "I still like my swing Grandma",
      },
      {
        source: "w16_commando_bsghhv",
        caption: "Practicing for the Commandos!",
      },
      {
        source: "w16_best_seller_rievif",
        caption: "Reading the latest best seller",
      },
    ],
  },
  "2005-17": {
    period: "17th - 23rd April 2005",
    markdownPaths: [
      "/content/diary/2005/2005-17-a.md",
      "/content/diary/2005/2005-17-b.md",
    ],
    images: [
      {
        source: "w17_look_dillon_rbwcgo",
        caption: "Evan watching Dillon Donkey",
      },
      {
        source: "w17_very_happy_qesqd0",
        caption: "Happy Baby",
      },
      {
        source: "w17_cot_cry_yrpylz",
        caption: "Evan didn't like his cot at first...",
      },
      {
        source: "w17_zonko_bpk8od",
        caption: "... but he likes his cot now :)",
      },
    ],
  },
  "2005-18": {
    period: "24th - 30th April 2005",
    markdownPaths: [
      "/content/diary/2005/2005-18-a.md",
      "/content/diary/2005/2005-18-b.md",
    ],
    images: [
      {
        source: "w18_ooh_whassat_jittzh",
        caption: "Evan with his curious expression",
      },
      {
        source: "w18_sitting_strong_zrpg5r",
        caption: "How does that Tottenham song go?",
      },
      {
        source: "w18_sitting_grass_r6jvp9",
        caption: "Sitting on the grass with Mummy",
      },
      {
        source: "w18_chubby_chops_evqmns",
        caption: "Look at his cute chubby cheeks!",
      },
    ],
  },
  "2005-19": {
    period: "1st - 7th May 2005",
    markdownPaths: [
      "/content/diary/2005/2005-19-a.md",
      "/content/diary/2005/2005-19-b.md",
    ],
    images: [
      {
        source: "w19_baby_banz_apdzte",
        caption: "Evan in his cool new baby banz",
      },
      {
        source: "w19_book_mxcl2d",
        caption: "Story time :)",
      },
      {
        source: "w19_tummy_riueyz",
        caption: "Look at this tummy strength!",
      },
      {
        source: "w19_fist_d5xvmb",
        caption: "Oh wait!? There's my fist.",
      },
    ],
  },
  "2005-20": {
    period: "8th - 14th May 2005",
    markdownPaths: [
      "/content/diary/2005/2005-20-a.md",
      "/content/diary/2005/2005-20-b.md",
    ],
    images: [
      {
        source: "w20_gorgeous_d9u34v",
        caption: "Gorgeous Mummy and baby",
      },
      {
        source: "w20_standing_j46kzd",
        caption: "Look Mum! I'm standing up!",
      },
      {
        source: "w20_cats_bn4gtj",
        caption: "Evan playing with the cats",
      },
      {
        source: "w20_cats_unsure_lqgtez",
        caption: "Poppy thinks twice",
      },
    ],
  },
  "2005-21": {
    period: "15th - 21st May 2005",
    markdownPaths: [
      "/content/diary/2005/2005-21-a.md",
      "/content/diary/2005/2005-21-b.md",
    ],
    images: [
      {
        source: "w21_uncle_neil_ctggxg",
        caption: "Evan and his Uncle Neil",
      },
      {
        source: "w21_foot_or_toy_xznisk",
        caption: "Toy or Foot?.... It's a hard life",
      },
      {
        source: "w21_cup_drinking_godb3l",
        caption: "Evan learning to drink from a cup",
      },
      {
        source: "w21_yes_its_me_qitgew",
        caption: "Yes, you keep looking at me",
      },
    ],
  },
  "2005-22": {
    period: "22nd - 28th May 2005",
    markdownPaths: [
      "/content/diary/2005/2005-22-a.md",
      "/content/diary/2005/2005-22-b.md",
    ],
    images: [
      {
        source: "w22_swim_trunks_jl2sra",
        caption: "hmm... now what do I play with?",
      },
      {
        source: "w22_bumbo_jgmwki",
        caption: "Oooh what's this? - Evan in his new 'Bumbo Seat'",
      },
      {
        source: "w22_nekkid_rgonxc",
        caption: "Evan letting it all hang out",
      },
      {
        source: "w22_baby_rice_sblciy",
        caption: "Mmmmm, baby rice & formula :/",
      },
    ],
  },
  "2005-23": {
    period: "29th May - 4th June 2005",
    markdownPaths: [
      "/content/diary/2005/2005-23-a.md",
      "/content/diary/2005/2005-23-b.md",
    ],
    documents: [
      {
        buttonText: "Evan's first letter to his Mummy",
        documentUrl: "/content/documents/evans_first_letter.pdf",
      },
      {
        buttonText: "Evan's second letter to his Mummy",
        documentUrl: "/content/documents/evans_second_letter.pdf",
      },
    ],
    images: [
      {
        source: "w23_cheeky_bottom_q56d1e",
        caption: "I can see that bottom!",
      },
      {
        source: "w23_great_grandmother_gf1v8x",
        caption: "This is my great nanny!",
      },
      {
        source: "w23_carrot_zxoikn",
        caption: "Evan even managed to get carrot on his nose!",
      },
      {
        source: "w23_computer_uqnsjh",
        caption: "Quiet please, I'm concentrating!",
      },
      {
        source: "w23_esther_c8pkge",
        caption: "Esther minus her son James who couldn't make it",
      },
      {
        source: "w23_rachel_megan_cake_vmtcug",
        caption: "Rachel and Megan with the infamous Cherry and Almond cake",
      },
      {
        source: "w23_nathalie_tumwga",
        caption: "Nathalie",
      },
      {
        source: "w23_alex_aryce4",
        caption: "Nathalie's son Alex",
      },
    ],
  },
  "2005-24": {
    period: "5th - 11th June 2005",
    markdownPaths: [
      "/content/diary/2005/2005-24-a.md",
      "/content/diary/2005/2005-24-b.md",
    ],
    images: [
      {
        source: "w24_happy_baby_oiy5jd",
        caption: "Yes... the grass tickles my toes!",
      },
      {
        source: "w24_big_cuddles_tzpglv",
        caption: "Evan sharing a big cuddle with Grandma",
      },
      {
        source: "w24_mel_fcltsy",
        caption: "Evan with Caroline's best friend Mel",
      },
      {
        source: "w24_vicky_wuquwh",
        caption: "Evan asleep on Vicky's shoulder",
      },
    ],
  },
  "2005-25": {
    period: "12th - 18th June 2005",
    markdownPaths: ["/content/diary/2005/2005-25-a.md"],
    images: [
      {
        source: "w25_pushchair_j8jwf0",
        caption: "Mmm tasty pushchair, it gets the 'Toes-Up' from me Mum!",
      },
      { source: "w25_trendy_qkqe3b", caption: "Trendy boy" },
      { source: "w25_car_ywwm5f", caption: "Still prefers to eat his toys" },
      {
        source: "w25_asleep_at_dinner_l8yf2g",
        caption: "Boob or bottle, both seem to send him to sleep",
      },
    ],
  },
  "2005-26": {
    period: "19th - 25th June 2005",
    markdownPaths: [
      "/content/diary/2005/2005-26-a.md",
      "/content/diary/2005/2005-26-b.md",
    ],
    images: [
      {
        source: "w26_lazy_sunday_scsegh",
        caption: "Lazy Sunday morning...",
      },
      {
        source: "w26_lazy_sunday2_y0sket",
        caption: "...LOVE...",
      },
      {
        source: "w26_lazy_sunday4_qyr2pc",
        caption: "...him...",
      },
      {
        source: "w26_lazy_sunday3_nq0pfk",
        caption: "...SO MUCH!",
      },
    ],
  },
  "2005-27": {
    period: "26th June - 2nd July 2005",
    markdownPaths: ["/content/diary/2005/2005-27-a.md"],
    images: [
      {
        source: "w27_carolines_new_hair_ojubpp",
        caption:
          "Caroline has a hair cut - 'Bout time we had a pic of her again!",
      },
      {
        source: "w27_zonked_nggrge",
        caption: "It's a hard life",
      },
      {
        source: "w27_sitting_up_kht5ey",
        caption: "I don't need Mummy's support",
      },
      {
        source: "w27_ice-cream_hsbgwt",
        caption: "Gimme dat ice-cream!",
      },
    ],
  },
  "2005-28": {
    period: "3rd - 9th July 2005",
    markdownPaths: ["/content/diary/2005/2005-28-a.md"],
    images: [
      {
        source: "w28_hair_style_l17b0p",
        caption: "Yes! Mummy has put stuff in my hair...",
      },
      {
        source: "w28_cool_dude_rulh6a",
        caption:
          "Evan showing how well he sits up. He'll sit and play for ages now",
      },
      {
        source: "w28_how_many_fingers_bwdctt",
        caption: "How many fingers?",
      },
      {
        source: "w28_lush_baby_qhjcvs",
        caption: "Fluffy blonde hair and gorgeous blue eyes",
      },
    ],
  },
  "2005-29": {
    period: "10th - 16th July 2005",
    markdownPaths: [
      "/content/diary/2005/2005-29-a.md",
      "/content/diary/2005/2005-29-b.md",
    ],
    images: [
      {
        source: "w29_heat_wave_ei51wp",
        caption: "Amidst all the horror - Evan enjoys the heat wave",
      },
      {
        source: "w29_new_toys_hogwev",
        caption: "Evan enjoying his new big boy toys",
      },
      {
        source: "w29_any_resemblance_dxdezk",
        caption: "Any resemblance?",
      },
      {
        source: "w29_power_nap_frz6fk",
        caption: "Power nap",
      },
    ],
  },
  "2005-30": {
    period: "17th - 23rd July 2005",
    markdownPaths: [
      "/content/diary/2005/2005-30-a.md",
      "/content/diary/2005/2005-30-b.md",
    ],
    images: [
      {
        source: "w30_high_chair_tewerx",
        caption: "hmmm... definitely room to grow",
      },
      {
        source: "w30_stacking_cups_ja7edn",
        caption: "Evan getting psyched up for the collapse",
      },
      {
        source: "w30_tower_crash_iwchah",
        caption: "...Boom!",
      },
      {
        source: "w30_always_happy_ixfs0s",
        caption: "Love how happy he is.",
      },
    ],
  },
  "2005-31": {
    period: "24th - 30th July 2005",
    markdownPaths: ["/content/diary/2005/2005-31-a.md"],
    images: [
      {
        source: "w31_dribble_kiss_fenbqm",
        caption: "Kiss?",
      },
      {
        source: "w31_euuw_dribble_ztdyis",
        caption: "I show my affection to mummy with lots of dribble",
      },
      {
        source: "w31_got_you_bcnkko",
        caption: "Got you...",
      },
      {
        source: "w31_want_one_ghn1i7",
        caption: "Now you!",
      },
    ],
  },
  "2005-32": {
    period: "31st July - 6th August 2005",
    markdownPaths: ["/content/diary/2005/2005-32-a.md"],
    images: [
      {
        source: "w32_bottle_feed_g0arjp",
        caption: "Evan is self-sufficient when it comes to the bottle",
      },
      {
        source: "w32_team_mascot_wzzzom",
        caption: "So... is this team any good Mum?",
      },
      {
        source: "w32_all_fall_down_lgepyu",
        caption: "eep! here they come!",
      },
      {
        source: "w32_scrambled_egg_qts8bm",
        caption: "Evan is not a fan of scrambled egg",
      },
    ],
  },
  "2005-33": {
    period: "7th - 13th August 2005",
    markdownPaths: ["/content/diary/2005/2005-33-a.md"],
    images: [
      {
        source: "w33_evan_and_friends_hhtoly",
        caption: "Evan enjoying a fun afternoon with his friends",
      },
      {
        source: "w33_sucking_toast_gpc1cn",
        caption: "Evan having a good suck on his first ever piece of toast",
      },
      {
        source: "w33_biceps_f9jvp7",
        caption: "Look at those biceps!",
      },
      {
        source: "w33_funny_boy_ybn0ik",
        caption: "Funny boy",
      },
    ],
  },
  "2005-34": {
    period: "14th - 20th August 2005",
    markdownPaths: ["/content/diary/2005/2005-34-a.md"],
    images: [
      {
        source: "w34_cheeky_chappy_a2nuvv",
        caption: "Evan is eyeing up the camera for dinner",
      },
      {
        source: "w34_hello_fluffy_trjpfd",
        caption: "Hello fluffy cat",
      },
      {
        source: "w34_hello_xwpf0i",
        caption: "Hello!",
      },
      {
        source: "w34_tongue_xrramj",
        caption: "Evan can stick out his tongue",
      },
    ],
  },
  "2005-35": {
    period: "21st - 27th August 2005",
    markdownPaths: ["/content/diary/2005/2005-35-a.md"],
    images: [
      {
        source: "w35_professional_pose_ipy73z",
        caption:
          "Evan posing for the camera, or is he eyeing up a sleeping cat?",
      },
      {
        source: "w35_nice_n_clean_aninsf",
        caption: "Evan showing an increasing desire to grab the camera",
      },
      {
        source: "w35_hiding_m4egb7",
        caption: "I'm hiding",
      },
      {
        source: "w35_big_boy_msmi6v",
        caption: "35 weeks and he's almost as big as Emma",
      },
    ],
  },
  "2005-36": {
    period: "28th August - 3rd September 2005",
    markdownPaths: ["/content/diary/2005/2005-36-a.md"],
    images: [
      {
        source: "w36_where_are_we_quu52z",
        caption: "Where are we?",
      },
      {
        source: "w36_what_is_this_h7axdv",
        caption: "What is this?",
      },
      {
        source: "w36_strange_feeling_c9j0p2",
        caption: "The sand feels cold on Evan's toes",
      },
      {
        source: "w36_sand_feels_good_j7aiut",
        caption: "Evan loves it",
      },
    ],
  },
  "2005-37": {
    period: "4th - 10th September 2005",
    markdownPaths: ["/content/diary/2005/2005-37-a.md"],
    images: [
      {
        source: "w37_tickle_time_asant7",
        caption: "It's tickle time",
      },
      {
        source: "w37_choosing_toys_ig6gm4",
        caption: "Let me choose the toys today",
      },
      {
        source: "w37_yummy_bath_water_z2kve2",
        caption: "Yummy bath water",
      },
      {
        source: "w37_all_fours_ccyvlq",
        caption: "Almost ready to crawl",
      },
    ],
  },
  "2005-38": {
    period: "11th - 17th September 2005",
    markdownPaths: ["/content/diary/2005/2005-38-a.md"],
    images: [
      {
        source: "w38_new_seat_eq5mvb",
        caption: "Evan sprawling out in his new seat",
      },
      {
        source: "w38_dintons_pastures_e0ezn0",
        caption: "Having a break from picking blackberries",
      },
      {
        source: "w38_cutest_foot_ykdjq1",
        caption: "I could just eat his feet",
      },
      {
        source: "w38_play_pen_ul242g",
        caption: "Staying safe in the play pen",
      },
    ],
  },
  "2005-39": {
    period: "18th - 24th September 2005",
    markdownPaths: ["/content/diary/2005/2005-39-a.md"],
    images: [
      {
        source: "w39_crawling_e3mwdr",
        caption: "I can crawl!",
      },
      {
        source: "w39_camera_hunt_bhsm9p",
        caption: "Taking pictures is tricky now he crawls",
      },
      {
        source: "w39_my_seat_d8deak",
        caption: "It's my seat now",
      },
      {
        source: "w39_where_is_on_nmkwd7",
        caption: "How do I turn this back on?",
      },
    ],
  },
  "2005-40": {
    period: "25th September - 1st October 2005",
    markdownPaths: ["/content/diary/2005/2005-40-a.md"],
    images: [
      {
        source: "w40_new_toys_e5qgoh",
        caption: "But I want these toys mummy...",
      },
      {
        source: "w40_finger_foods_pbfi5h",
        caption:
          "Teaching Evan how to eat finger foods - this was before he mashed them everywhere!",
      },
      {
        source: "w40_finger_foods2_dzrkuz",
        caption: "This biscuit is as big as him",
      },
      { source: "w40_tears_i6lxzq", caption: "Tears of freedom?" },
    ],
  },
  "2005-41": {
    period: "2nd - 8th October 2005",
    markdownPaths: ["/content/diary/2005/2005-41-a.md"],
    images: [
      {
        source: "w41_standing_alone_z3uxwb",
        caption: "Woohoo - Look at him now",
      },
      {
        source: "w41_activity_table_bwfft8",
        caption:
          "Evan enjoying his new found freedom at his new activity table",
      },
      {
        source: "w41_keys_hq79mh",
        caption: "So, that's where my keys are",
      },
      {
        source: "w41_picture_for_mummy_owhjcs",
        caption:
          "Our first picture that Evan made at nursery (pasta shapes glued to paper) ",
      },
    ],
  },
  "2005-42": {
    period: "9th - 15th October 2005",
    markdownPaths: ["/content/diary/2005/2005-42-a.md"],
    images: [
      {
        source: "w42_evan_impression_yiqifo",
        caption: "My impression of Evan",
      },
      {
        source: "w42_play_biting_uorafp",
        caption: "Play biting or fighting?",
      },
      {
        source: "w42_mischievious_xsvaz4",
        caption: "What are you up to?",
      },
      {
        source: "w42_ball_pit_n2zbsz",
        caption: "Playing with friends",
      },
    ],
  },
  "2005-43": {
    period: "16th - 22nd October 2005",
    markdownPaths: ["/content/diary/2005/2005-43-a.md"],
    images: [
      {
        source: "w43_first_shoes_bshqhe",
        caption: "Evan's first pair of shoes",
      },
      {
        source: "w43_first_shoes_closeup_eapus4",
        caption: "So cute!",
      },
      {
        source: "w43_need_a_haircut_ssnf8f",
        caption: "Someone needs a hair cut",
      },
      {
        source: "w43_tired_baby_zsn1s0",
        caption: "Aww bless him",
      },
    ],
  },
  "2005-44": {
    period: "23rd - 29th October 2005",
    markdownPaths: ["/content/diary/2005/2005-44-a.md"],
    images: [
      {
        source: "w44_sept_filler_image2_lyzh69",
        caption: "Healthy baby",
      },
      {
        source: "w44_poorly_baby_lpm7e3",
        caption: "Poorly baby",
      },
      {
        source: "w44_double_poorly_c7yadn",
        caption: "Everyone is ill this week",
      },
      {
        source: "w44_sept_filler_image_gdncec",
        caption: "A lot of baths this week",
      },
    ],
  },
  "2005-45": {
    period: "30th October - 5th November 2005",
    markdownPaths: ["/content/diary/2005/2005-45-a.md"],
    images: [
      {
        source: "w45_is_this_bath_i0ajg7",
        caption: "Is this bath for me?",
      },
      {
        source: "w45_for_me_qwnnsz",
        caption: "Evan loves to peer into the bath as it is filling up",
      },
      {
        source: "w45_new_trick_vea4az",
        caption:
          "Evan's new trick is to drink from the cups as the water trickles through!",
      },
      {
        source: "w45_loves_a_bath_samclj",
        caption: "Delightful :)",
      },
    ],
  },
  "2005-46": {
    period: "6th - 12th November 2005",
    markdownPaths: ["/content/diary/2005/2005-46-a.md"],
    images: [
      {
        source: "w46_camera_fascination_uxdn1v",
        caption:
          "Evan proving how difficult it is to photograph him these days",
      },
      {
        source: "w46_prebath_play_time_dg67bx",
        caption: "Pre-bath play time",
      },
      {
        source: "w46_what_ya_doing_rnyvlh",
        caption: "Evan is interested in everything we do",
      },
      {
        source: "w46_hurry_up_eljfo8",
        caption: "Hurry up bath!",
      },
    ],
  },
  "2005-47": {
    period: "13th - 19th November 2005",
    markdownPaths: ["/content/diary/2005/2005-47-a.md"],
    images: [
      {
        source: "w47_before_haircut_j2zw4h",
        caption: "Before hair cut",
      },
      {
        source: "w47_after_haircut_xx0jno",
        caption: "After hair cut",
      },
      {
        source: "w47_wax_duawul",
        caption: "Showing interest in some product",
      },
      {
        source: "w47_lush_crphqu",
        caption: "Just beautiful",
      },
    ],
  },
  "2005-48": {
    period: "20th - 26th November 2005",
    markdownPaths: ["/content/diary/2005/2005-48-a.md"],
    images: [
      {
        source: "w48_inquisitive_toilet_pdhvoc",
        caption: "A toilet lock is now a necessity",
      },
      {
        source: "w48_cheeky_ryelxx",
        caption: "Cheeky look",
      },
      {
        source: "w48_dribbler_paoede",
        caption: "Dribbletastic",
      },
      {
        source: "w48_not_a_toy_qfkpc8",
        caption: "Obsessed much with the camera Evan?",
      },
    ],
  },
  "2005-49": {
    period: "27th November - 3rd December 2005",
    markdownPaths: ["/content/diary/2005/2005-49-a.md"],
    images: [
      {
        source: "w49_strong_legs_vmkxth",
        caption: "Strong legs",
      },
      {
        source: "w49_stocky_chap_jfrghp",
        caption: "Stocky chappy",
      },
      {
        source: "w49_peek-a-boo_lhftfm",
        caption: "Playing peek-a-boo",
      },
      {
        source: "w49_shopping_tkyka2",
        caption: "Helping to unpack, does not mean eat it first!",
      },
    ],
  },
  "2005-50": {
    period: "4th - 10th December 2005",
    markdownPaths: ["/content/diary/2005/2005-50-a.md"],
    images: [
      {
        source: "w50_introducing_gpr8ea",
        caption: "Introducing Noodle, the new addition to our growing family",
      },
      {
        source: "w50_first_nativity_nrxnue",
        caption: "Getting ready for Evan's first nativity performance",
      },
      {
        source: "w50_first_nativity2_ccscue",
        caption: "Evan is the second one in from the left on the front row",
      },
      {
        source: "w50_noodle_tphfpt",
        caption: "Settling in very well",
      },
    ],
  },
  "2005-51": {
    period: "11th - 17th December 2005",
    markdownPaths: ["/content/diary/2005/2005-51-a.md"],
    images: [
      {
        source: "w51_swings_esidsz",
        caption: "Loves the swings in the park",
      },
      {
        source: "w51_matching_hair_uroew9",
        caption: "Evan's new haircut gets styled like Mummy's",
      },
      {
        source: "w51_grandma_babysits_x0mubc",
        caption: "Evan loves it when Grandma feeds him",
      },
      {
        source: "w51_bathroom_fun_yjodxh",
        caption: "Evan loves bathroom time",
      },
    ],
  },
  "2005-52": {
    period: "18th - 24th December 2005",
    markdownPaths: ["/content/diary/2005/2005-52-a.md"],
    images: [
      {
        source: "w52_first_christmas_nyb97g",
        caption: "Evan gets his hands on his presents",
      },
      {
        source: "w52_noisy_toys_gkbvik",
        caption: "New toys seem to be going down well",
      },
      {
        source: "w52_christmas_dinner_c7crk7",
        caption: "Evan is not sure about the crackers and hats",
      },
      {
        source: "w52_it_snows_pndpsj",
        caption: "It snows at Christmas!",
      },
      {
        source: "w52_happy_birthday_oo4k25",
        caption: "Happy 1st Birthday Evan",
      },
      {
        source: "w52_end_of_the_year_db7zqg",
        caption: "Birthday hug",
      },
      {
        source: "w52_birthday_presents_e3y3pr",
        caption: "You are supposed to push it Evan, not climb it",
      },
      {
        source: "w52_still_loves_camera_a1quy1",
        caption: "Yes, Yes, we all know you still love the camera",
      },
    ],
  },
  "2006-01": {
    period: "January 2006",
    markdownPaths: ["/content/diary/2006/2006-01.md"],
    images: [
      {
        source: "jan_sleepy_kxpchv",
        caption: "Tired Mummy and Baby",
      },
      {
        source: "jan_scary_funny_waqh1t",
        caption: "Scary? No... funny",
      },
      {
        source: "jan_quiet_time_dyhr4d",
        caption: "Red cheeks evidence of Evan's new teeth coming through",
      },
      {
        source: "jan_cheeky_chappy_ba0a3v",
        caption: "Adorable cheeky chappy",
      },
    ],
  },
  "2006-02": {
    period: "February 2006",
    markdownPaths: ["/content/diary/2006/2006-02.md"],
    images: [
      {
        source: "feb_watching_outside_cyga8y",
        caption: "More interested in the dogs outside",
      },
      {
        source: "feb_retro_toys_jpbboc",
        caption: "Evan has found Caroline's Commodore 64 joy sticks!",
      },
      {
        source: "feb_pillow_play_aopnwg",
        caption: "Creature Comforts! Evan likes to have his pillows near by",
      },
      {
        source: "feb_feeding_himself_czqamd",
        caption: "Evan sitting on his stool demonstrating self-service",
      },
      {
        source: "feb_gorgeous_bodvdk",
        caption: "Evan with his mummy",
      },
      {
        source: "feb_cat_play_foutjz",
        caption: "Noodle play??",
      },
      {
        source: "feb_camera_vwotzt",
        caption: "Evan is still clearly obssessed with the camera",
      },
      {
        source: "feb_playing_x12wj5",
        caption: "Catching a sneaky picture of Evan whilst he is unaware",
      },
    ],
  },
  "2006-03": {
    period: "March 2006",
    markdownPaths: ["/content/diary/2006/2006-03.md"],
    images: [
      {
        source: "mar_bed_hair_okw5lp",
        caption: "Good morning scruffy head!",
      },
      {
        source: "mar_feeds_himself_lx8ykc",
        caption: "Evan likes to feed himself when he is not being lazy",
      },
      {
        source: "mar_domesticated_zduspx",
        caption: "Now where did I put that washing?",
      },
      {
        source: "mar_food_tasting_a8zy63",
        caption: "Evan is very keen to try new foods",
      },
      {
        source: "mar_indoor_car_vt6pev",
        caption: "Getting the car ready",
      },
      {
        source: "mar_congestion_i0xewu",
        caption: "Congestion ahead",
      },
      {
        source: "mar_winding_wbxdkb",
        caption: "Getting the burps out!",
      },
      {
        source: "mar_pants_yqzalg",
        caption: "You are supposed to hang out the washing, not wear it!",
      },
    ],
  },
  "2006-04": {
    period: "April 2006",
    markdownPaths: ["/content/diary/2006/2006-04.md"],
    images: [
      {
        source: "apr_england_hat_insurn",
        caption: "Start supporting young",
      },
      {
        source: "apr_odds_farm_lwwlpz",
        caption: "Evan enjoying a ride about at Odds Farm Park",
      },
      {
        source: "apr_stacking_bricks_pofhr3",
        caption: "Evan showing off his stacking skills - his max is 10 so far!",
      },
      {
        source: "apr_piggy_back_z8kqdb",
        caption: "Evan loves Mummy's piggy back ride",
      },
      {
        source: "apr_tower_osvpmv",
        caption: "Evan needs help to complete his duplo towers",
      },
      {
        source: "apr_collecting_stones_q43xld",
        caption: "Collecting stones in the garden",
      },
      {
        source: "apr_climbing_frame_fkaokm",
        caption: "The swing doubles up as a climbing frame",
      },
      {
        source: "apr_swing_high_kuskoo",
        caption: "A trip to the park swing is necessary for maximum height",
      },
    ],
  },
  "2006-05": {
    period: "May 2006",
    markdownPaths: ["/content/diary/2006/2006-05.md"],
    images: [
      {
        source: "may_pink_hair_l9hz3t",
        caption: "Maybe he wants to be patriotic by dying his hair!",
      },
      {
        source: "may_sleepy_lunch_vfvko5",
        caption:
          "Oh such a hard life! Evan couldn't even wait for pudding this day...",
      },
      {
        source: "may_world_cup_ready_zmfxpi",
        caption: "Evan's all ready for the World Cup!",
      },
      {
        source: "may_plane_spotting_vhyoq2",
        caption: "Spotting some planes (Evan says pwane)",
      },
      {
        source: "may_make_shift_chair_snngxc",
        caption: "Our makeshift chair for Evan",
      },
      {
        source: "may_new_car_cinicp",
        caption: "Evan finally gets out in his new car",
      },
      {
        source: "may_happy_in_car_mcotp3",
        caption: "Beep! Beep!",
      },
      {
        source: "may_play_for_country_fo1amv",
        caption: "Love a baby in a football kit",
      },
    ],
  },
  "2006-06": {
    period: "June 2006",
    markdownPaths: ["/content/diary/2006/2006-06.md"],
    images: [
      {
        source: "jun_lovely_smile_wpgwv8",
        caption: "Evan being just a happy chappy!",
      },
      {
        source: "jun_wellplace_zoo_nc4rrt",
        caption: "Evan loved his trip to see all the animals at the Zoo!",
      },
      {
        source: "jun_beach_ball_m5tdye",
        caption: "The beach ball was a huge success at the beach",
      },
      {
        source: "jun_seaside_sedn5o",
        caption: "Playing against the waves",
      },
      {
        source: "jun_road_trip_qkepix",
        caption: "Going on a road trip",
      },
      {
        source: "jun_rice_krispies_da6oqs",
        caption: "That's one way to eat your cereal",
      },
      {
        source: "jun_gardener_cq1oim",
        caption: "Checking on the strawberries",
      },
      {
        source: "jun_football_skills_jbl0tp",
        caption: "Football skills!",
      },
    ],
  },
  "2006-07": {
    period: "July 2006",
    markdownPaths: ["/content/diary/2006/2006-07.md"],
    images: [
      {
        source: "jul_trampoline_uq0bnv",
        caption: "Evan loves his new trampoline",
      },
      {
        source: "july_booster_tut8vf",
        caption: "Evan loves eating at the table with us",
      },
      {
        source: "july_slide_p5ywyv",
        caption: "'Wow!' was Evan's reaction to his new slide",
      },
      {
        source: "jul_legoland_nu9upk",
        caption: "Oooh! look at this Mummy",
      },
      {
        source: "jul_slide_done_da9wel",
        caption: "Little rest after sliding",
      },
      {
        source: "jul_queue_entertainment_fklxze",
        caption: "Keeping a child entertained in a queue is a challenge",
      },
      {
        source: "jul_paddling_pool_jgtlzh",
        caption: "This is more fun than swimming!",
      },
      {
        source: "jul_legoland_ride_kmoimp",
        caption: "Enjoying the train ride",
      },
    ],
  },
  "2006-08": {
    period: "August 2006",
    markdownPaths: ["/content/diary/2006/2006-08.md"],
    images: [
      {
        source: "aug_doggy_kiss_giqhhv",
        caption: "errghh yuk... Doggy kiss!",
      },
      {
        source: "aug_flying_closeup_pb8c59",
        caption:
          "Evan decides to launch himself on Mummy whilst she's not looking!",
      },
      {
        source: "aug_group_photo_mie4pd",
        caption: "Evan and his friends - this scene took only one attempt",
      },
      {
        source: "aug_water_feature_ukzkha",
        caption: "Playing with the water feature at Nanny's",
      },
      {
        source: "aug_new_tower_ahqnzs",
        caption: "A new way to build a tower",
      },
      {
        source: "aug_model_pose_z5nus5",
        caption: "Always has such a cheeky look",
      },
      {
        source: "aug_concentration_mqgaye",
        caption: "His little tongue sneaks out when he is concentrating",
      },
      {
        source: "aug_ball_on_slide_yypv84",
        caption: "Even balls can have fun on the slide",
      },
    ],
  },
  "2006-09": {
    period: "September 2006",
    markdownPaths: ["/content/diary/2006/2006-09.md"],
    images: [
      {
        source: "sept_ikea_chair_ngv3tq",
        caption: "At last! we have a chair",
      },
      {
        source: "sept_slippers_jp3gak",
        caption: "See Mum, I told you these were the right size",
      },
      {
        source: "sept_legoland_i4elmf",
        caption: "Come on, you know you want to get closer...",
      },
      {
        source: "sept_hello_dog_ke8a5d",
        caption: "Evan likes to watch Holly the dog next door",
      },
    ],
  },
  "2006-10": {
    period: "October 2006",
    markdownPaths: ["/content/diary/2006/2006-10.md"],
    images: [
      {
        source: "oct_ball_play_ga0ai6",
        caption: "Isn't he just adorable?!?!",
      },
      {
        source: "oct_who_needs_toys_p063d8",
        caption: "Who needs toys, when we have Nanny's potatoes and spoons?",
      },
      {
        source: "oct_serious_ektnmc",
        caption: "Evan enjoying a rare sit down moment....",
      },
      {
        source: "oct_nanny_smiles_yznloa",
        caption: "....always ends up laughing",
      },
    ],
  },
  "2006-11": {
    period: "November 2006",
    markdownPaths: ["/content/diary/2006/2006-11.md"],
    images: [
      {
        source: "nov_bin_pose_irwlwl",
        caption: "Ignore the bin mummy, just look at me!",
      },
      {
        source: "nov_cute_hair_bypigp",
        caption: "Mummy always finds Evan when he is hiding",
      },
      {
        source: "nov_ice_cream_jprryw",
        caption: "Sharing some ice-cream",
      },
      {
        source: "nov_casual_cpxiw9",
        caption: "Hello cutie",
      },
    ],
  },
  "2006-12": {
    period: "December 2006",
    markdownPaths: ["/content/diary/2006/2006-12.md"],
    images: [
      {
        source: "dec_cooking_lhxk9l",
        caption: "Alex, I really think we're missing the point here",
      },
      {
        source: "dec_xmas_dinner_xnarez",
        caption: "Don't think we're wearing these hats all day!",
      },
      {
        source: "dec_xmas_presents_p61qix",
        caption: "I don't need any help this year",
      },
      {
        source: "dec_together_glpge0",
        caption: "Another amazing year",
      },
      {
        source: "dec_pudding_fnskvu",
        caption: "Evan loves a pudding!",
      },
      {
        source: "dec_neil_look_e8jmkv",
        caption: "Discussing presents with Neil",
      },
      {
        source: "dec_computer_ic6pbj",
        caption: "Playing on the computer",
      },
      {
        source: "dec_birthday_grandma_nva09e",
        caption: "Grandma helping Evan open presents",
      },
    ],
  },
  "2007-01": {
    period: "January 2007",
    markdownPaths: ["/content/diary/2007/2007-01.md"],
    images: [
      {
        source: "jan_train_play_bixet6",
        caption: "Mummy helps build it, but only Evan gets to play!",
      },
      {
        source: "jan_play_watching_oyeyxq",
        caption: "Evan finally notices he's being watched",
      },
      {
        source: "jan_tv_zeybwf",
        caption: "Catching up on some TV before bed time",
      },
      {
        source: "jan_noodle_cuddle_t46wrd",
        caption: "Having a cuddle with Noodle",
      },
    ],
  },
  "2007-02": {
    period: "February 2007",
    markdownPaths: ["/content/diary/2007/2007-02.md"],
    images: [
      {
        source: "feb_wellies_indoors_rxgddv",
        caption: "Can you spot the other obsession?... Wellies indoors!?",
      },
      {
        source: "feb_puzzles_r4pbgf",
        caption: "No trouble finding all the pieces",
      },
      {
        source: "feb_all_done_ty8yfi",
        caption: "One completed puzzle",
      },
      {
        source: "feb_well_done_vnnj4p",
        caption:
          "Evan always congratulates himself with a clap and a 'Well Done'",
      },
    ],
  },
  "2007-03": {
    period: "March 2007",
    markdownPaths: ["/content/diary/2007/2007-03.md"],
    images: [
      {
        source: "mar_beale_park_whikyc",
        caption: "Evan enjoys a picnic at Beale Park",
      },
      {
        source: "mar_relaxed_i5sjsy",
        caption: "Evan knows how to get comfy in his chair",
      },
      {
        source: "mar_bath_friends_fjlfm2",
        caption: "Evan has some bath friends",
      },
      {
        source: "mar_bath_smiles_ki9lfz",
        caption: "Look at the face!",
      },
    ],
  },
  "2007-04": {
    period: "April 2007",
    markdownPaths: ["/content/diary/2007/2007-04.md"],
    images: [
      {
        source: "apr_exploring_ln1dfq",
        caption: "Exploring the countryside",
      },
      {
        source: "apr_long_grass_tywo0a",
        caption: "Evan experiences the fun of playing in long grass",
      },
      {
        source: "apr_monopoly_gy4ad9",
        caption: "Not quite ready to play monopoly to the rules",
      },
      {
        source: "apr_scar_smile_uvwdy9",
        caption:
          "As you can see Evan's lip is recovering well - still a cutie!",
      },
      {
        source: "apr_fridge_magnets_hm1nsn",
        caption: "Evan's favourite toy at Nanny's is her fridge magnets!",
      },
      {
        source: "apr_legoland_castle_h1c4uv",
        caption: "Can you see us?",
      },
      {
        source: "apr_safari_car_bjfohi",
        caption: "We've just been spotting dinosaurs",
      },
      {
        source: "apr_passing_time_moczuk",
        caption: "Evan finds something to do whilst waiting in the ride queues",
      },
    ],
  },
  "2007-05": {
    period: "May 2007",
    markdownPaths: ["/content/diary/2007/2007-05.md"],
    images: [
      {
        source: "may_footy_skills_yxh9ic",
        caption: "Evan demonstrating his much improved football skills",
      },
      {
        source: "may_head_first_m1dbyd",
        caption: "This way is much more fun for Evan, and more scary for me!",
      },
      {
        source: "may_sore_thumb_cmn4rh",
        caption:
          "Evan's experience with a plaster for the bit of finger nail he pulled off",
      },
      {
        source: "may_patio_seat_nsu0nb",
        caption: "Garden bench?!? No Thanks, this is far more comfortable",
      },
    ],
  },
  "2007-06": {
    period: "June 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "1st June 2007 - Family Reunion BBQ",
        markdownPath: "/content/diary/2007/2007-06-01.md",
        images: [
          {
            source: "june_small_group_btzxlk",
            caption: "Caroline's mum with her relatives from France",
          },
          {
            source: "june_carlsberg_ualapc",
            caption: "Anyone for Carlsberg?",
          },
          {
            source: "june_evan_dances_fb8ydf",
            caption: "Evan playing on the dance mat",
          },
          {
            source: "june_large_group_uzxayy",
            caption: "BBQ reunion group photo",
          },
        ],
      },
      {
        heading: "10th June 2007 - Marwell Zoo",
        markdownPath: "/content/diary/2007/2007-06-10.md",
        images: [
          {
            source: "june_zoo_day_out_kaz8d7",
            caption: "All set for our day at the zoo",
          },
          {
            source: "june_snow_leopard_a2zru3",
            caption: "Beautiful Endangered Snow Leopard",
          },
          {
            source: "june_giraffe_height_ozas7a",
            caption: "Still a long way to go",
          },
          {
            source: "june_penguin_uid4kz",
            caption: "Poor little penguin looking far too hot",
          },
        ],
      },
      {
        heading: "22nd June 2007 - Neil & Pascale's Wedding",
        markdownPath: "/content/diary/2007/2007-06-22.md",
        images: [
          {
            source: "june_exploring_ln2mar",
            caption: "Exploring the grounds keeping out of trouble",
          },
          {
            source: "june_suit_plyo8l",
            caption: "The suit is on the large side!",
          },
          {
            source: "june_happily_married_gbkhzq",
            caption:
              "Evan shows his smart side (if you ignore the black eye that is)",
          },
          {
            source: "june_joke_with_grandma_vzltsk",
            caption: "Evan shares a joke with Grandma",
          },
        ],
      },
      {
        heading: "29th June 2007 - Holiday in France",
        markdownPath: "/content/diary/2007/2007-06-29.md",
        images: [
          {
            source: "june_river_washing_kddazo",
            caption:
              "The private river came in handy for washing the car seat cover",
          },
          {
            source: "june_jacques_bbq_kaexau",
            caption:
              "Jacques prepares a natural fire for the BBQ. The sausages were yummy!",
          },
          {
            source: "june_pleasant_walk_mowq7b",
            caption:
              "Those little legs get tired easy, luckily Caroline saves the day",
          },
          {
            source: "june_evan_boat_yjnkvf",
            caption: "Evan is not sure what to think of the life jacket",
          },
          {
            source: "june_pascale_carry_hdrmwq",
            caption: "Pascale helped with the carrying when Evan got tired",
          },
          {
            source: "june_wind_tears_urt1tn",
            caption: "The wind was so strong it made Evan cry",
          },
          {
            source: "june_strong_arms_sb0gss",
            caption: "Evan makes up a new ball game, with a tree!",
          },
          {
            source: "june_room_to_run_cru2mp",
            caption: "So much space for Evan to run around in",
          },
        ],
      },
    ],
  },
  "2007-07": {
    period: "July 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "7th July 2007",
        markdownPath: "/content/diary/2007/2007-07-07.md",
        images: [
          {
            source: "july_lego_fun_scje8g",
            caption:
              "Evan is starting to appreciate his lego more now he is older",
          },
          {
            source: "july_sleepy_boys_w2zysu",
            caption:
              "Evan and Noodle decide that they just can't go on anymore",
          },
          {
            source: "july_water_feature_eot3vq",
            caption: "Fascinated by Nanny's garden water feature",
          },
          {
            source: "july_rearrange_garden_thgon0",
            caption: "Evan's new game—rearranging the garden ornaments",
          },
        ],
      },
      {
        heading: "10th July 2007",
        markdownPath: "/content/diary/2007/2007-07-10.md",
        images: [
          {
            source: "july_bubble_machine_gbsipw",
            caption: "Introducing the bubble machine...",
          },
          {
            source: "july_make_bubbles_xjrjbv",
            caption: "...getting used to how you turn the maker...",
          },
          {
            source: "july_watch_bubbles_c9jjdx",
            caption: "...huge bubbles start to float away...",
          },
          {
            source: "july_bubbles_fly_away_uiykbt",
            caption: "...Evan has mastered the art of making giant bubbles",
          },
        ],
      },
      {
        heading: "14th July 2007 - Legoland Live Festival",
        markdownPath: "/content/diary/2007/2007-07-14.md",
        images: [
          {
            source: "july_first_festival_lvhhix",
            caption: "Evan's first festival!",
          },
          {
            source: "july_cardboard_bob_uiq3bg",
            caption: "Evan shows off his cardboard Bob the Builder!",
          },
          {
            source: "july_singing_along_jvjwzc",
            caption: "Singing along to all the songs",
          },
          {
            source: "july_legoland_swings_shugch",
            caption: "Evan can now ride the swings solo",
          },
        ],
      },
      {
        heading: "30th July 2007",
        markdownPath: "/content/diary/2007/2007-07-30.md",
        images: [
          {
            source: "july_which_one_jo64x4",
            caption: "Time to choose... hat, dog or ship",
          },
          {
            source: "july_this_one_lycv1t",
            caption: "The ship it is",
          },
          {
            source: "july_lets_play_tpgbbz",
            caption:
              "Just like Caroline, Evan is going to be ruthless at Monopoly...",
          },
          {
            source: "july_cheating_czygop",
            caption: "... or he might steal from the bank like his Mum!",
          },
        ],
      },
    ],
  },
  "2007-08": {
    period: "August 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "2nd August 2007",
        markdownPath: "/content/diary/2007/2007-08-02.md",
        images: [
          {
            source: "aug_flowers_e3dbku",
            caption:
              "Any image like this saddens me, but it's worse when you know the person",
          },
          {
            source: "aug_becky_trevor_h4cqcn",
            caption: "Becky and Trevor having a laugh at the pub",
          },
          {
            source: "aug_becky_clare_sousme",
            caption: "Becky was very popular and friendly to everyone",
          },
          {
            source: "aug_crossroad_ogbuq0",
            caption: "The cross road showing the signs of the accident",
          },
        ],
      },
      {
        heading: "18th August 2007",
        markdownPath: "/content/diary/2007/2007-08-18.md",
        images: [
          {
            source: "aug-bouncy-castle_y0cxna",
            caption: "Finally Evan enjoys the bouncy castle",
          },
          {
            source: "aug_play_dough_e7rg46",
            caption: "Enjoying the texture, not quite making shapes yet",
          },
          {
            source: "aug_nap_time_l6g2hx",
            caption: "Nap time for Evan!",
          },
          {
            source: "aug_block_stacking_v2tddw",
            caption: "Stacking blocks successfully",
          },
        ],
      },
    ],
  },
  "2007-09": {
    period: "September 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "18th September 2007",
        markdownPath: "/content/diary/2007/2007-09-18.md",
        images: [
          {
            source: "sept_peanut_playdough_dxoncx",
            caption: "Evan has fun making edible playdough",
          },
          {
            source: "sept_dribbling_kncsrn",
            caption:
              "Evan demonstrates where Tottenham have been going wrong this season",
          },
          {
            source: "sept_football_rjsyho",
            caption: "Not bad for a 2 year old",
          },
          {
            source: "sept_swing_divjqo",
            caption: "Evan still loves his swing in the garden",
          },
        ],
      },
      {
        heading: "23rd September 2007 - Meeting the famous Roary",
        markdownPath: "/content/diary/2007/2007-09-23.md",
        images: [
          {
            source: "sept_meeting_roary_f2dfbj",
            caption: "Evan finally gets to meet Roary!",
          },
          {
            source: "sept_playing_fireman_w9uu6t",
            caption:
              "Head to head fire challenge at Legoland.. Uncle Frank Won!",
          },
          {
            source: "sept_solo_zngtje",
            caption: "More swing action",
          },
          {
            source: "sept_lego_rides_wfp7hj",
            caption: "Enjoying the big wheel ride",
          },
        ],
      },
    ],
  },
  "2007-10": {
    period: "October 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "5th October 2007 - Potty Training",
        markdownPath: "/content/diary/2007/2007-10-05.md",
        images: [
          {
            source: "oct_book_uh3jx6",
            caption: "Evan sharing a story with his nanny",
          },
          {
            source: "oct_nanny_giggles_bxg4gn",
            caption:
              "I'm not sure they are getting much of the story read there",
          },
          {
            source: "oct_cheeky_boy_uv8rqz",
            caption: "Evan shows off his typical cheeky look",
          },
          {
            source: "oct_exploring_bveyej",
            caption: "Evan is fascinated by the long grass",
          },
        ],
      },
      {
        heading: "27th October 2007 - Cadbury's Gorilla",
        markdownPath: "/content/diary/2007/2007-10-27.md",
        images: [],
        videos: [
          {
            type: "External",
            image: {
              source: "gorilla_ttc8qz.jpg",
              caption: "Cadbury Gorilla Drummer",
            },
            url: "https://www.youtube.com/watch?v=NNerJzj1kjU",
            title: "Phil Collins 'Gorilla Drummer' Cadbury's Dairy Milk Advert",
          },
          {
            type: "Embedded",
            url: "https://player.vimeo.com/video/1200445597?badge=0&amp;autopause=0&amp;player_id=0&amp;app_id=58479",
            title: "Evan impersonating the Gorilla Drummer",
          },
        ],
      },
    ],
  },
  "2007-11": {
    period: "November 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "2nd November - Amber turns 2",
        markdownPath: "/content/diary/2007/2007-11-02.md",
        images: [
          {
            source: "nov_growing_up_drs1cb",
            caption: "Growing up fast!",
          },
          {
            source: "nov_amber_vxwop2",
            caption: "Nice and cosy on the sofa",
          },
          {
            source: "nov_evan_izzy_f9wplf",
            caption: "Evan adores Izzy, I'm sure he wants his own dog!",
          },
          {
            source: "nov_ice-cream_rn6d2j",
            caption: "Showing some cute baby belly for ice-cream????",
          },
        ],
      },
      {
        heading: "11th November - More birthday party fun",
        markdownPath: "/content/diary/2007/2007-11-11.md",
        images: [
          {
            source: "nov_abbie1_sfkeb1",
            caption:
              "Evan finally settles in the soft play area with his friends",
          },
          {
            source: "nov_abbie2_tghfxe",
            caption: "Evan attempts to barracade Beth in",
          },
          {
            source: "nov_abbie3_tkorbs",
            caption: "These huge objects were a huge hit!",
          },
          {
            source: "nov_abbie4_pzvppo",
            caption: "All quiet when the children sit down to eat",
          },
        ],
      },
      {
        heading: "18th November - No raisins for you",
        markdownPath: "/content/diary/2007/2007-11-18.md",
        images: [],
      },
    ],
  },
  "2007-12": {
    period: "December 2007",
    type: "calendar",
    calendarEntries: [
      {
        heading: "2nd December - 3 become 2",
        markdownPath: "/content/diary/2007/2007-12-02.md",
        images: [
          {
            source: "dec_slide_start_at8kmg",
            caption: "Is this going to have a happy ending?",
          },
          {
            source: "dec_slide_finish_wi9hpm",
            caption: "They seemed to like it!",
          },
          {
            source: "dec_garden_krn8sm",
            caption: "Not sure who is having the most fun!",
          },
          {
            source: "dec_sofa_sleeps_njm4fc",
            caption: "Having a sneaky little nap",
          },
        ],
      },
      {
        heading: "14th December - King Evan",
        markdownPath: "/content/diary/2007/2007-12-14.md",
        images: [
          {
            source: "dec_king_evan_r3inur",
            caption: "Evan models his nativity outfit",
          },
          {
            source: "dec_king_myrrh_c4wa7a",
            caption: "Evan with his gift of myrrh",
          },
          {
            source: "dec_nativity_dinner_hosxdi",
            caption: "Nativity done, now onto the food!",
          },
          {
            source: "dec_evan_and_lucy_sv76a9",
            caption: "This is Lucy, Evan adores her",
          },
        ],
      },
      {
        heading: "24th December - Birthday cake fun!",
        markdownPath: "/content/diary/2007/2007-12-24.md",
        images: [
          {
            source: "dec_grandma_hosts_ajylpj",
            caption: "It's Christmas at Grandma's this year",
          },
          {
            source: "dec_cake_flat_cvps03",
            caption: "Is that a cake?",
          },
          {
            source: "dec_cake_rise_xextb2",
            caption: "Now that's more like it!",
          },
          {
            source: "lego_fire_engine_q597xb",
            caption: "Evan's fire engine from legoland is still in one piece",
          },
        ],
      },
      {
        heading: "25th December - Evan remembers Christmas",
        markdownPath: "/content/diary/2007/2007-12-25.md",
        images: [
          {
            source: "dec_xmas_na9oui",
            caption: "Finally the waiting is over!",
          },
          {
            source: "dec_uncle_matt_pcdnhi",
            caption: "Uncle Matt watches on",
          },
          {
            source: "dec_playing_mrj2fg",
            caption: "Presents all opened, now time to play",
          },
          {
            source: "dec_toys_hrbyg8",
            caption: "Chirpy the Spurs mascot has a look at the new cars",
          },
        ],
      },
      {
        heading: "26th December - Evan turns 3",
        markdownPath: "/content/diary/2007/2007-12-26.md",
        images: [
          {
            source: "dec_birthday_eh7fsc",
            caption: "It's birthday time!",
          },
          {
            source: "dec_more_presents_ozltbn",
            caption: "Happy 3rd birthday",
          },
          {
            source: "dec_lego_fan_mnkcob",
            caption: "Lego features heavily again this year",
          },
          {
            source: "dec_whos_toys_soqilm",
            caption: "My my Evan, haven't you grown",
          },
        ],
      },
    ],
  },
  "2008-01": {
    period: "January 2008",
    type: "calendar",
    calendarEntries: [
      {
        heading: "1st January - A new start for us!",
        markdownPath: "/content/diary/2008/2008-01-01.md",
        images: [],
      },
      {
        heading: "22nd January - Tottenham vs Arsenal Carling Cup Semi Final",
        markdownPath: "/content/diary/2008/2008-01-22.md",
        images: [],
        videos: [
          {
            type: "External",
            image: {
              source: "jj-celebrate_aorigs.jpg",
              caption: "Jermaine Jenas celebrates scoring against Arsenal",
            },
            url: "https://www.skysports.com/football/video/19508/10001626/sky-sports-vault-tottenham-5-1-arsenal",
            title:
              "Sky Sports Vault | Tottenham 5-1 Arsenal - Carling Cup Semi Final",
          },
        ],
      },
    ],
  },
  "2008-02": {
    period: "February 2008",
    type: "calendar",
    calendarEntries: [
      {
        heading: "5th February - Introducing the latest Middlebrook",
        markdownPath: "/content/diary/2008/2008-02-05.md",
        images: [
          {
            source: "feb_ryan_alex_eywe7b",
            caption: "Introducing Ryan Alex Middlebrook",
          },
          {
            source: "feb_park_rechvc",
            caption: "Evan loves playing at the park!",
          },
          {
            source: "feb_interesting_hqbqzq",
            caption:
              "Evan contemplates how to get across this new piece of play equipment",
          },
          {
            source: "feb_dog_obsession_cagvyc",
            caption: "Evan's love of dogs has not diminished!",
          },
        ],
      },
      {
        heading: "9th February - Day out feeding the ducks",
        markdownPath: "/content/diary/2008/2008-02-09.md",
        images: [
          {
            source: "feb_sam_rgy9ig",
            caption: "Sam watches on as Evan plays with his toys",
          },
          {
            source: "feb_baby_toys_chp7tm",
            caption: "Evan playing nicely with Sam's toys",
          },
          {
            source: "feb_mel_james_eyhv13",
            caption: "Doesn't James just look like a cool dude!",
          },
          {
            source: "feb_evan_running_bv1ghz",
            caption: "Mind the slippery patches!",
          },
        ],
      },
      {
        heading: "17th February - A visit from Caroline",
        markdownPath: "/content/diary/2008/2008-02-17.md",
        images: [
          {
            source: "feb_piano_mat_ueqv5j",
            caption: "Evan making his music",
          },
          {
            source: "feb_head_injury_lu3rzf",
            caption: "Check out the bandage mummy!!",
          },
          {
            source: "feb_plasticine_picture_rfivch",
            caption: "Evan playing with his plasticine picture maker",
          },
          {
            source: "feb_cute_face_sye5xj",
            caption: "Caught taking a picture—cutie!",
          },
        ],
      },
      {
        heading: "23rd February - Celebrating another birthday",
        markdownPath: "/content/diary/2008/2008-02-23.md",
        images: [
          {
            source: "feb_baby_slide_hepyfz",
            caption: "This was just the baby slide!",
          },
          {
            source: "feb_flying_balls_cetwvp",
            caption:
              "Balls placed here would be taken by the air flowing out of the holes...",
          },
          {
            source: "feb_more_balls_jqkcgw",
            caption: "...So Evan found a way to get lots of balls!",
          },
          {
            source: "feb_party_food_sn99p5",
            caption: "Why do we all do that with hula hoops as children?",
          },
        ],
      },
    ],
  },
  "2008-03": {
    period: "March 2008",
    type: "calendar",
    calendarEntries: [
      {
        heading: "9th March - Our London Adventure",
        markdownPath: "/content/diary/2008/2008-03-09.md",
        images: [
          {
            source: "mar_train_wpmds6",
            caption: "Evan's first trip on a train",
          },
          {
            source: "mar_craig_hyxvav",
            caption: "This is Craig, he's an amazing friend",
          },
          { source: "mar_in_london_n3cavw", caption: "London Baby!" },
          { source: "mar_london_eye_xrb0on", caption: "The London Eye" },
          { source: "mar_shark_h0xo5c", caption: "Evan loved the sharks!" },
          {
            source: "mar_ice-cream_m0p0fd",
            caption: "Such a nice day for an ice-cream",
          },
          { source: "mar_hannah_m4gldr", caption: "Hannah had one too!" },
          {
            source: "mar_new_shark_kobubt",
            caption:
              "Evan's new shark teddy gets introduced to the racing track—literally!!",
          },
        ],
      },
    ],
  },
};
