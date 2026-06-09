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
  width?: number;
  height?: number;
  quality?: number;
  fill?: string;
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

// MediaLink is used to define an image that navigates to a specific location when clicked
export interface MediaLink {
  image: Media;
  location: string;
}

export interface EmbeddedMedia {
  type: "Embedded";
  url: string;
  title: string;
}

export interface ExternalMedia {
  type: "External";
  image: Media;
  url: string;
  title: string;
}

// VideoMedia is a union type that can represent either an embedded video or an external video link.
// The external video link contains an image thumbnail, URL, and title.
export type VideoMedia = EmbeddedMedia | ExternalMedia;

export interface YearPageParams {
  year: string;
  mode: "week" | "month";
  title: string;
  subtitle: string;
  content: string;
  image: Media;
}
