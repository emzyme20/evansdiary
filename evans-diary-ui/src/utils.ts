export const getImageUrl = (
  path: string,
  width?: number,
  height?: number,
  fill?: number,
  quality?: number,
) => {
  // Check if path has an explicit file extension
  const hasExtension = /\.\w+$/.test(path);
  const addExtension = hasExtension ? "" : ".webp";

  return `https://res.cloudinary.com/dqg9nkccw/image/upload/${fill ? fill : "c_fill"}${height ? `,h_${height}` : ""}${quality ? `,q_${quality}` : ",q_80"}${width ? `,w_${width}` : ",w_251"}/${path}${addExtension}`;
};

export const getMonthName = (monthNumber: number) => {
  const date = new Date(2000, monthNumber, 1);
  return date.toLocaleString("en-GB", { month: "long" }).toLocaleLowerCase();
};

export const getDiaryHeading = (year: number, imageCaption: string) => {
  return `Year ${year - 2004} - ${imageCaption} (${year})`;
};
