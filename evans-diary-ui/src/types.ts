export interface Media {
  source: string;
  caption: string;
  width?: number;
  height?: number;
  quality?: number;
  fill?: string;
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

export interface DocumentReference {
  buttonText: string;
  documentUrl: string;
}
