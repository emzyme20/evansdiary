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
