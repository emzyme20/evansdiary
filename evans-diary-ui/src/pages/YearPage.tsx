import styles from "./YearPage.module.css";
import { yearTiles } from "../yearTiles";
import { PolaroidGrid } from "../components/PolaroidGrid";

function YearPage() {
  const indexOffset = yearTiles.mode === "month" ? 1 : 0;
  const linkedTiles = yearTiles.images.map((image, index) => ({
    image,
    location: `${yearTiles.mode}/${index + indexOffset}`,
  }));

  return (
    <main className={styles.page}>
      <PolaroidGrid items={linkedTiles} aria-label="diary navigation tiles" />
    </main>
  );
}

export default YearPage;
