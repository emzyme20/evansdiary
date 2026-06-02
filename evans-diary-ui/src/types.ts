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

export interface FamilyTile {
  source: string;
  caption: string;
  width: number;
}
