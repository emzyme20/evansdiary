import type { Media } from "../types";

/*
 * Diary Structure and Dynamic Content Types
 */
// 1. Navigation/Header Structure (Lightweight)
export interface DiaryNodeIndex {
  id: string;
  source: string;
  caption: string;
}

export interface YearStructure {
  year: string;
  mode: "week" | "month"; // Determines how the content is structured
  items: Media[];
}

// 2. Deep Content Model (Only loaded on the actual entry page)
export interface DiaryEntry {
  period: string; // e.g., "26th December 2004 - 1st January 2005"
  markdownPaths: string[]; // Array of paths to markdown files for this entry, e.g., ["/assets/diary-content/2026/month-01-a.md", "/assets/diary-content/2005-00-a.md"]
  images: Media[]; // Array of up to 12 image objects
}

/*
 * Static Route Registry
 */
export const DIARY_REGISTRY: Record<string, YearStructure> = {
  "2005": {
    year: "2005",
    mode: "week",
    items: [
      {
        //id: "2005-00",
        source: "w0_emma_first_hold_yxohgg",
        caption: "The Birth",
      },
      {
        //id: "2005-01",
        source: "w1_evan_peaceful_n7d6jq",
        caption: "Week 1",
      },
      {
        //id: "2005-02",
        source: "w2_ooh_looking_at_emma_zcxo7r",
        caption: "Week 2",
      },
      {
        //id: "2005-03",
        source: "w3_playgym_ruptaf",
        //period: "9th - 15th January 2005",
        caption: "Week 3",
      },
      {
        //id: "2005-04",
        source: "w4_keep_rocking_d66fey",
        //period: "16th - 22nd January 2005",
        caption: "Week 4",
      },
      {
        //id: "2005-05",
        source: "w5_smiling_now_kukeoj",
        //period: "23rd - 29th January 2005",
        caption: "Week 5",
      },
      {
        //id: "2005-06",
        source: "w6_giggles_z4qpas",
        //period: "30th January - 5th February 2005",
        caption: "Week 6",
      },
      {
        //id: "2005-07",
        source: "w7_holding_bottle_tafgcb",
        //period: "6th - 12th February 2005",
        caption: "Week 7",
      },
      {
        //id: "2005-08",
        source: "w8_tummy_time_v4fjqp",
        //period: "13th - 19th February 2005",
        caption: "Week 8",
      },
      {
        //id: "2005-09",
        source: "w9_hello_billy_d63gj4",
        //period: "20th - 26th February 2005",
        caption: "Week 9",
      },
      {
        //id: "2005-10",
        source: "w10_new_hat_enqoxo",
        //period: "27th February - 5th March 2005",
        caption: "Week 10",
      },
      {
        //id: "2005-11",
        source: "w11_bath_time_i3xdve",
        //period: "6th - 12th March 2005",
        caption: "Week 11",
      },
      {
        //id: "2005-12",
        source: "w12_chewing_fist_cu9d4x",
        //period: "13th - 19th March 2005",
        caption: "Week 12",
      },
      {
        //id: "2005-13",
        source: "w13_muslin_z2hfny",
        //period: "20th - 26th March 2005",
        caption: "Week 13",
      },
      {
        //id: "2005-14",
        source: "w14_new_cap_q3wsat",
        //period: "27th March - 2nd April 2005",
        caption: "Week 14",
      },
      {
        //id: "2005-15",
        source: "w15_sleeping_beauty_ejmpu8",
        //period: "3rd - 9th April 2005",
        caption: "Week 15",
      },
      {
        //id: "2005-16",
        source: "w16_commando_bsghhv",
        //period: "10th - 16th April 2005",
        caption: "Week 16",
      },
      {
        //id: "2005-17",
        source: "w17_zonko_bpk8od",
        //period: "17th - 23rd April 2005",
        caption: "Week 17",
      },
      {
        //id: "2005-18",
        source: "w18_sitting_grass_r6jvp9",
        //period: "24th - 30th April 2005",
        caption: "Week 18",
      },
      {
        //id: "2005-19",
        source: "w19_book_mxcl2d",
        //period: "1st - 7th May 2005",
        caption: "Week 19",
      },
      {
        //id: "2005-20",
        source: "w20_gorgeous_d9u34v",
        //period: "8th - 14th May 2005",
        caption: "Week 20",
      },
      {
        //id: "2005-21",
        source: "w21_cup_drinking_godb3l",
        //period: "15th - 21st May 2005",
        caption: "Week 21",
      },
      {
        //id: "2005-22",
        source: "w22_baby_rice_sblciy",
        //period: "22nd - 28th May 2005",
        caption: "Week 22",
      },
      {
        //id: "2005-23",
        source: "w23_computer_uqnsjh",
        //period: "29th May - 4th June 2005",
        caption: "Week 23",
      },
      {
        //id: "2005-24",
        source: "w24_happy_baby_oiy5jd",
        //period: "5th - 11th June 2005",
        caption: "Week 24",
      },
      {
        //id: "2005-25",
        source: "w25_trendy_qkqe3b",
        //period: "12th - 18th June 2005",
        caption: "Week 25",
      },
      {
        //id: "2005-26",
        source: "w26_lazy_sunday3_nq0pfk",
        //period: "19th - 25th June 2005",
        caption: "Week 26",
      },
      {
        //id: "2005-27",
        source: "w27_sitting_up_kht5ey",
        //period: "26th June - 2nd July 2005",
        caption: "Week 27",
      },
      {
        //id: "2005-28",
        source: "w28_cool_dude_rulh6a",
        //period: "3rd - 9th July 2005",
        caption: "Week 28",
      },
      {
        //id: "2005-29",
        source: "w29_heat_wave_ei51wp",
        //period: "10th - 16th July 2005",
        caption: "Week 29",
      },
      {
        //id: "2005-30",
        source: "w30_stacking_cups_ja7edn",
        //period: "17th - 23rd July 2005",
        caption: "Week 30",
      },
      {
        //id: "2005-31",
        source: "w31_got_you_bcnkko",
        //period: "24th - 30th July 2005",
        caption: "Week 31",
      },
      {
        //id: "2005-32",
        source: "w32_bottle_feed_g0arjp",
        //period: "31st July - 6th August 2005",
        caption: "Week 32",
      },
      {
        //id: "2005-33",
        source: "w33_sucking_toast_gpc1cn",
        //period: "7th - 13th August 2005",
        caption: "Week 33",
      },
      {
        //id: "2005-34",
        source: "w34_hello_fluffy_trjpfd",
        //period: "14th - 20th August 2005",
        caption: "Week 34",
      },
      {
        //id: "2005-35",
        source: "w35_nice_n_clean_aninsf",
        //period: "21st - 27th August 2005",
        caption: "Week 35",
      },
      {
        //id: "2005-36",
        source: "w36_where_are_we_quu52z",
        //period: "28th August - 3rd September 2005",
        caption: "Week 36",
      },
      {
        //id: "2005-37",
        source: "w37_tickle_time_asant7",
        //period: "4th - 10th September 2005",
        caption: "Week 37",
      },
      {
        //id: "2005-38",
        source: "w38_new_seat_eq5mvb",
        //period: "11th - 17th September 2005",
        caption: "Week 38",
      },
      {
        //id: "2005-39",
        source: "w39_camera_hunt_bhsm9p",
        //period: "18th - 24th September 2005",
        caption: "Week 39",
      },
      {
        //id: "2005-40",
        source: "w40_finger_foods_pbfi5h",
        //period: "25th September - 1st October 2005",
        caption: "Week 40",
      },
      {
        //id: "2005-41",
        source: "w41_activity_table_bwfft8",
        //period: "2nd - 8th October 2005",
        caption: "Week 41",
      },
      {
        //id: "2005-42",
        source: "w42_evan_impression_yiqifo",
        //period: "9th - 15th October 2005",
        caption: "Week 42",
      },
      {
        //id: "2005-43",
        source: "w43_first_shoes_bshqhe",
        //period: "16th - 22nd October 2005",
        caption: "Week 43",
      },
      {
        //id: "2005-44",
        source: "w44_poorly_baby_lpm7e3",
        //period: "23rd - 29th October 2005",
        caption: "Week 44",
      },
      {
        //id: "2005-45",
        source: "w45_new_trick_vea4az",
        //period: "30th October - 5th November 2005",
        caption: "Week 45",
      },
      {
        //id: "2005-46",
        source: "w46_camera_fascination_uxdn1v",
        //period: "6th - 12th November 2005",
        caption: "Week 46",
      },
      {
        //id: "2005-47",
        source: "w47_wax_duawul",
        //period: "13th - 19th November 2005",
        caption: "Week 47",
      },
      {
        //id: "2005-48",
        source: "w48_inquisitive_toilet_pdhvoc",
        //period: "20th - 26th November 2005",
        caption: "Week 48",
      },
      {
        //id: "2005-49",
        source: "w49_strong_legs_vmkxth",
        //period: "27th November - 3rd December 2005",
        caption: "Week 49",
      },
      {
        //id: "2005-50",
        source: "w50_introducing_gpr8ea",
        //period: "4th - 10th December 2005",
        caption: "Week 50",
      },
      {
        //id: "2005-51",
        source: "w51_matching_hair_uroew9",
        //period: "11th - 17th December 2005",
        caption: "Week 51",
      },
      {
        //id: "2005-52",
        source: "w52_still_loves_camera_a1quy1",
        //period: "18th - 25th December 2005",
        caption: "Week 52",
      },
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
};
