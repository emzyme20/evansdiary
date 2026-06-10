import type { Media } from "../types";

export interface YearPageParams {
  year: string;
  mode: "week" | "month";
  title: string;
  subtitle: string;
  content: string;
  image: Media;
}

export const yearTiles: YearPageParams[] = [
  {
    year: "2005",
    mode: "week",
    title: "Year - 1 (2005)",
    subtitle: "Evan's Weekly Diary",
    content:
      "Use the links below to read about Evan's development up to his first birthday.",
    image: {
      source: "w0_emma_first_hold_yxohgg",
      caption: "Year 1",
      width: 251,
    },
  },
  {
    year: "2006",
    mode: "month",
    title: "Year - 2 (2006)",
    subtitle: "Evan's Monthly Diary",
    content:
      "Use the links below to read about Evan's development up to his second birthday.",
    image: {
      source: "w52_end_of_the_year_db7zqg",
      caption: "Year 2",
      width: 285,
      height: 214,
    },
  },
  {
    year: "2007",
    mode: "month",
    title: "Year - 3 (2007)",
    subtitle: "Evan's Monthly Diary",
    content:
      "Use the links below to read about Evan's development up to his third birthday.",
    image: {
      source: "dec_together_glpge0",
      caption: "Year 3",
      width: 285,
      height: 214,
    },
  },
  {
    year: "2008",
    mode: "month",
    title: "Year - 4 (2008)",
    subtitle: "Evan's Monthly Diary",
    content:
      "Use the links below to read about Evan's development up to his fourth birthday.",
    image: {
      source: "apr_legoland_2008_xjfsvp",
      caption: "Year 4",
      width: 285,
      height: 214,
    },
  },
];
