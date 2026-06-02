import { useEffect } from "react";
import { familyTiles } from "../familyTiles";
import { getImageUrl } from "../utils";
import styles from "./FamilyPage.module.css";

function FamilyPage() {
  useEffect(() => {
    document.body.classList.add("familyPageBackground");
    return () => {
      document.body.classList.remove("familyPageBackground");
    };
  }, []);

  return (
    <main className={styles.page}>
      <section aria-label="Polaroid photos">
        <ul className={styles.grid}>
          {familyTiles.map((tile) => {
            return (
              <li key={`family-tile-${tile.source}`} className={styles.item}>
                <figure className={styles.polaroid}>
                  <img
                    src={getImageUrl(tile.source, tile.width)}
                    alt={tile.caption}
                    width={tile.width}
                    className={styles.image}
                  />
                  <figcaption className={styles.caption}>
                    {tile.caption}
                  </figcaption>
                </figure>
              </li>
            );
          })}
        </ul>
      </section>
    </main>
  );
}

export default FamilyPage;
