import { Link } from "react-router-dom";
import styles from "./PolaroidGrid.module.css";
import type { Media } from "../types";
import { PolaroidImage } from "./PolaroidImage";

interface PolaroidGridData {
  image: Media;
  location: string;
  state?: unknown;
}

interface ItemListProps<T extends PolaroidGridData> {
  items: readonly T[];
}

export function PolaroidGrid<T extends PolaroidGridData>({
  items,
}: ItemListProps<T>) {
  return (
    <section aria-label="Polaroid photos">
      <ul className={styles.grid} aria-label={`polaroid photo tiles`}>
        {items.map((tile) => {
          return (
            <li key={`diary-nav-${tile.image.source}`} className={styles.item}>
              {tile.location ? (
                <Link
                  className={styles.link}
                  to={tile.location}
                  state={tile.state}
                >
                  <PolaroidImage image={tile.image} />
                </Link>
              ) : (
                <PolaroidImage image={tile.image} />
              )}
            </li>
          );
        })}
      </ul>
    </section>
  );
}
