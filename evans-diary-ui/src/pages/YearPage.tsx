import styles from "./YearPage.module.css";
import { yearTiles } from "../yearTiles";
import { PolaroidGrid } from "../components/PolaroidGrid";

function YearPage() {
  const linkedTiles = yearTiles.map((year, index) => ({
    image: year.image,
    location: `${year.mode}/${index + year.mode === "month" ? index + 1 : index}`,
  }));

  return (
    <main className={styles.page}>
      <PolaroidGrid items={linkedTiles} aria-label="diary navigation tiles" />
    </main>
  );
}

export default YearPage;
