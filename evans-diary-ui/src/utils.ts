export const getImageUrl = (
  path: string,
  width?: number,
  height?: number,
  fill?: number,
  quality?: number,
) => {
  return `https://res.cloudinary.com/dqg9nkccw/image/upload/${fill ? fill : "c_fill"}${height ? `,h_${height}` : ""}${quality ? `,q_${quality}` : ",q_80"}${width ? `,w_${width}` : ",w_251"}/${path}`;
};

export const getMonthName = (monthNumber: number) => {
  const date = new Date(2000, monthNumber, 1);
  return date.toLocaleString("en-GB", { month: "long" });
};

export const getDiaryHeading = (year: number, imageCaption: string) => {
  return `Year ${year - 2004} - ${imageCaption}`;
};
