export interface ContentSchema {
  home: {
    title: string;
    description: string;
    images: {
      caption: string;
      source: string;
      crop: string;
    }[];
  };
}