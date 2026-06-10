import styles from "./ImageReel.module.css";
import type { Media } from "../types";
import { getTransformationImageUrl } from "../utils";

interface ImageReelData {
  image: Media;
}

interface ItemListProps<T extends ImageReelData> {
  images: readonly T[];
}

export function ImageReel<T extends ImageReelData>({
  images,
}: ItemListProps<T>) {
  return (
    <div className={styles.reel} aria-label={`image reel`}>
      {images.map((image) => {
        return (
          <div
            key={`image-reel-${image.image.source}`}
            className={styles.reelItem}
          >
            <img
              className={styles.photo}
              src={getTransformationImageUrl(
                "diary-image-reel",
                image.image.source,
              )}
              alt={image.image.caption}
            />
            <aside className={styles.caption}>
              <span>{image.image.caption}</span>
            </aside>
          </div>
        );
      })}
    </div>
  );
}

export default ImageReel;
