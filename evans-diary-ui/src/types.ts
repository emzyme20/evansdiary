export interface HomeSchema {
  flipbook: {
    title: string;
    description: string;
    images: {
      caption: string;
      source: string;
      crop: string;
    }[];
  };
  carousel: {
    images: {
      caption: string;
      source: string;
    }[];
  };
}

export interface HomeTile {
  title: string;
  href: string;
  description: string;
  image: string;
  imageAlt: string;
}

export interface Media {
  source: string;
  caption: string;
  width: number;
  height?: number;
  quality?: number;
  fill?: number;
}

export interface FamilyTile {
  image: Media;
}

export interface TimelineEntry {
  year: number;
  heading: string;
  description: string;
  link?: {
    href: string;
    label: string;
  };
  images?: Media[];
  video?: Media;
  type: "Event" | "Video" | "Blog" | "Image";
}

export interface DiaryNavTile {
  image: Media;
  location: string;
}

export interface DiaryEntry {
  heading: string;
  contentKey: string;
  images?: Media[];
}

export interface DiarySection {
  tag: string;
  headline: string;
  entries: DiaryEntry[];
}

export interface YearPageParams {
  year: string;
  mode: "week" | "month";
  title: string;
  subtitle: string;
  content: string;
  image: Media;
}
