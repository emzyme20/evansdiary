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
