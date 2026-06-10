import type { Media } from "../types";
import { getImageUrl } from "../utils";
import styles from "./PolaroidImage.module.css";

export function PolaroidImage({ image }: { image: Media }) {
  return (
    <figure className={styles.polaroid}>
      <img
        src={getImageUrl(
          image.source,
          image.width,
          image.height,
          image.fill,
          image.quality,
        )}
        alt={image.caption}
        width={image.width}
        className={styles.polaroidImage}
      />
      <figcaption className={styles.caption}>{image.caption}</figcaption>
    </figure>
  );
}
