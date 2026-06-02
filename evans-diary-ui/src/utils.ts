export const getImageUrl = (
  path: string,
  width: number,
  height?: number,
  fill?: string,
  quality?: string,
) => {
  return `https://res.cloudinary.com/dqg9nkccw/image/upload/${fill ? fill : "c_fill"}${height ? `,h_${height}` : ""}${quality ? `,q_${quality}` : ",q_80"}${width ? `,w_${width}` : ",w_250"}/${path}`;
};
