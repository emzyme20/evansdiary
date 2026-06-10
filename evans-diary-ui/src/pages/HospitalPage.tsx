import { Link, useParams } from "react-router-dom";
import styles from "./HospitalPage.module.css";
import ReactMarkdown from "react-markdown";
import { useEffect, useState } from "react";
import { fetchMarkdown, getEntryLoadMessage } from "../utils";
import { hospitalDiaryEntries } from "../data/hospitalDashboard";

function HospitalPage() {
  const [content, setContent] = useState<string>("");
  const [loadedKey, setLoadedKey] = useState<string>("");

  // Extract the day parameters from the URL
  const { day } = useParams<{
    day: string;
  }>();

  const dayNumber = Number(day);
  const isValidDay = Number.isFinite(dayNumber);
  const maxDay = hospitalDiaryEntries.length;
  const hasPrevious = isValidDay && dayNumber > 1;
  const hasNext = isValidDay && dayNumber < maxDay;
  const previousDay = dayNumber - 1;
  const nextDay = dayNumber + 1;
  const title =
    isValidDay && dayNumber >= 1 && dayNumber <= maxDay
      ? hospitalDiaryEntries[dayNumber - 1]
      : undefined;

  // Generate the markdown file name based on the day parameter
  const key = isValidDay
    ? `/content/hospital/day-${String(dayNumber).padStart(2, "0")}.md`
    : undefined;

  const loading = Boolean(key && loadedKey !== key);

  useEffect(() => {
    if (!key) return;

    let cancelled = false;

    const loadContent = async () => {
      try {
        const text = await fetchMarkdown(key, "Hospital diary entry");

        const safeText = text || getEntryLoadMessage("Hospital diary entry");

        if (cancelled) return;

        setContent(safeText);
        setLoadedKey(key);
      } catch {
        if (cancelled) return;

        setContent(getEntryLoadMessage("Hospital diary entry"));
      }
      setLoadedKey(key);
    };

    void loadContent();

    return () => {
      cancelled = true;
    };
  }, [key]);

  if (loading) return <div>Loading hospital diary...</div>;

  return (
    <main className={styles.page}>
      <section className={styles.diaryEntry} aria-label="Hospital diary">
        <h1>Caroline's Hospital Diary</h1>
        {title && <h2>{title}</h2>}
        <div className="markdown-body">
          <ReactMarkdown>{content}</ReactMarkdown>
        </div>
        <nav className={styles.pageNav} aria-label="Hospital diary navigation">
          <div>
            {hasPrevious ? (
              <Link
                className={styles.navLink}
                to={`/hospital/day/${previousDay}`}
              >
                Previous
              </Link>
            ) : null}
          </div>
          <div>
            {hasNext ? (
              <Link className={styles.navLink} to={`/hospital/day/${nextDay}`}>
                Next
              </Link>
            ) : null}
          </div>
        </nav>
      </section>
    </main>
  );
}

export default HospitalPage;
