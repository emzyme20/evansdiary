import type { DiarySection } from "./types";

export const diaryNavTiles: readonly DiarySection[] = [
  {
    tag: "Year 1 - The Birth!",
    headline: "26th December 2004",
    entries: [
      {
        heading: "Emma's Entry",
        contentKey: "y1w0One",
      },
      {
        heading: "Caroline's Entry",
        contentKey: "y1w0Two",
        images: [
          {
            source: "w0_emma_first_hold_yxohgg",
            caption: "Emma holding Evan for the first time",
            width: 285,
          },
          {
            source: "w0_midwife_idbcyw",
            caption: "Our wonderful midwife, Valeska",
            width: 285,
          },
          {
            source: "w0_before_birth_cgiahd",
            caption: "Emma in the labour ward, before the birth",
            width: 285,
          },
          {
            source: "w0_caroline_first_hold_rgpgcj",
            caption: "Caroline with Evan a few minutes after the birth",
            width: 285,
          },
        ],
      },
    ],
  },
];
