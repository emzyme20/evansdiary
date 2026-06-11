import styles from "./YearPage.module.css";
import { useParams } from "react-router-dom";
import { DIARY_REGISTRY } from "../data/diaryStructure";
import { getMonthName } from "../utils";
import { PolaroidGrid } from "../components/PolaroidGrid";

function YearPage() {
  const { year } = useParams<{ year: string }>();

  const yearData = DIARY_REGISTRY[year!];

  const linkedTiles = yearData.items.map((item, index) => ({
    image: item,
    location: `/diary/year/${year}/${yearData.mode === "month" ? getMonthName(index) : `week/${index}`}`,
    state: { caption: item.caption },
  }));

  return (
    <main className={styles.page}>
      <PolaroidGrid items={linkedTiles} aria-label="diary navigation tiles" />
    </main>
  );
}

export default YearPage;
