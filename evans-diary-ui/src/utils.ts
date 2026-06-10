export const getImageUrl = (
  path: string,
  width?: number,
  height?: number,
  fill?: string,
  quality?: number,
) => {
  // Check if path has an explicit file extension
  const hasExtension = /\.\w+$/.test(path);
  const addExtension = hasExtension ? "" : ".webp";

  // If no transformations are needed, return the original URL
  if (
    width === undefined &&
    height === undefined &&
    fill === undefined &&
    quality === undefined
  ) {
    return `https://res.cloudinary.com/dqg9nkccw/image/upload/${path}${addExtension}`;
  }

  return `https://res.cloudinary.com/dqg9nkccw/image/upload/${fill ? `c_${fill}` : "c_fill"}${height ? `,h_${height}` : ""}${quality ? `,q_${quality}` : ",q_80"}${width ? `,w_${width}` : ",w_251"}/${path}${addExtension}`;
};

// Diary pages have specific heigh and width requirements.
// A transformation has been saved in Cloudinary that can support serving images
// with the correct dimensions, fill and quality.
// https://res.cloudinary.com/dqg9nkccw/image/upload/t_diary-image-reel/{imageId}
export const getTransformationImageUrl = (
  transformName: string,
  imageId: string,
) => {
  return `https://res.cloudinary.com/dqg9nkccw/image/upload/t_${transformName}/${imageId}`;
};

export const getMonthName = (monthNumber: number) => {
  console.log("getMonthName called with monthNumber:", monthNumber);
  const date = new Date(2000, monthNumber, 1);
  return date.toLocaleString("en-GB", { month: "long" }).toLocaleLowerCase();
};

export const getMonthNumber = (monthName: string) => {
  const date = new Date(`${monthName} 1, 2000`);
  return date.getMonth() + 1;
};

export const getDiaryHeading = (year: number, imageCaption: string) => {
  return `Year ${year - 2004} - ${imageCaption} (${year})`;
};

export const getEntryLoadMessage = (entryName: string) =>
  `_${entryName} could not be loaded._`;

export const fetchMarkdown = async (
  path: string,
  entryName: string,
): Promise<string> => {
  try {
    const response = await fetch(path);

    if (!response.ok) {
      return getEntryLoadMessage(entryName);
    }

    const contentType =
      response.headers.get("content-type")?.toLowerCase() ?? "";
    const text = await response.text();

    // Some static servers return index.html with a 200 status for missing files.
    const isHtmlFallback =
      contentType.includes("text/html") ||
      /^\s*<!doctype html/i.test(text) ||
      /^\s*<html[\s>]/i.test(text);

    if (isHtmlFallback) {
      return getEntryLoadMessage(entryName);
    }

    return text;
  } catch {
    return getEntryLoadMessage(entryName);
  }
};
