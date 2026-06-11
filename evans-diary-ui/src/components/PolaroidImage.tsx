import type { Media } from "../types";
import { getTransformationImageUrl } from "../utils";
import styles from "./PolaroidImage.module.css";

export function PolaroidImage({ image }: { image: Media }) {
  return (
    <figure className={styles.polaroid}>
      <img
        src={getTransformationImageUrl("diary-image-reel", image.source)}
        alt={image.caption}
        className={styles.polaroidImage}
      />
      <figcaption className={styles.caption}>{image.caption}</figcaption>
    </figure>
  );
}
