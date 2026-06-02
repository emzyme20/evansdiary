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
}

export interface FamilyTile {
  image: Media;
}

export interface TimelineEntry {
  year: number;
  heading: string;
  description: string;
  images?: Media[];
  video?: Media;
  type: "Event" | "Video" | "Blog";
}
