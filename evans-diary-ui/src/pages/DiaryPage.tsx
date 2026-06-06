import styles from "./DiaryPage.module.css";
import { getDiaryHeading, getMonthName } from "../utils";
import { useLocation, useParams } from "react-router-dom";
import { DIARY_CONTENT_REGISTRY, DIARY_REGISTRY } from "../data/diaryStructure";
import ReactMarkdown from "react-markdown";
import { useEffect, useState } from "react";

interface DiaryPageLocationState {
  caption?: string;
}

interface DiaryPageLoadError {
  key: string;
  message: string;
}

function DiaryPage() {
  const [contentA, setContentA] = useState<string>("");
  const [contentB, setContentB] = useState<string>("");
  const [loadedKey, setLoadedKey] = useState<string>("");
  const [loadError, setLoadError] = useState<DiaryPageLoadError | null>(null);

  const location = useLocation();
  const { year, week, month } = useParams<{
    year: string;
    week: string;
    month: string;
  }>();

  const yearData = year ? DIARY_REGISTRY[year] : undefined;
  const selectedIndex =
    week !== undefined
      ? Number(week)
      : yearData?.items.findIndex(
          (_, index) =>
            month !== undefined &&
            getMonthName(index - 1).toLowerCase() === month.toLowerCase(),
        );

  const normalizedEntryIndex =
    selectedIndex !== undefined &&
    Number.isFinite(selectedIndex) &&
    selectedIndex >= 0
      ? String(selectedIndex).padStart(2, "0")
      : undefined;

  const key =
    year && normalizedEntryIndex
      ? `${year}-${normalizedEntryIndex}`
      : undefined;

  // Look up the specific meta asset paths instantly
  const diaryEntry = key ? DIARY_CONTENT_REGISTRY[key] : null;
  const errorMessage =
    loadError && loadError?.key === key ? loadError.message : null;
  const loading = Boolean(
    diaryEntry && key && loadedKey !== key && !errorMessage,
  );

  useEffect(() => {
    if (!diaryEntry || !key) return;

    let cancelled = false;

    const loadContent = async () => {
      try {
        const fetchMarkdown = async (path: string) => {
          const response = await fetch(path);

          if (!response.ok) {
            throw new Error(`Failed to load content (${response.status})`);
          }

          return response.text();
        };

        const [textA, textB] = await Promise.all([
          fetchMarkdown(diaryEntry.markdownPaths[0]),
          diaryEntry.markdownPaths[1]
            ? fetchMarkdown(diaryEntry.markdownPaths[1])
            : Promise.resolve(""),
        ]);

        if (cancelled) return;

        setContentA(textA);
        setContentB(textB);
        setLoadedKey(key);
        setLoadError(null);
      } catch (error) {
        if (cancelled) return;

        setContentA("");
        setContentB("");
        setLoadError({
          key,
          message:
            error instanceof Error
              ? error.message
              : "Unable to load this diary entry.",
        });
      }
    };

    void loadContent();

    return () => {
      cancelled = true;
    };
  }, [diaryEntry, key]);

  const routeState = location.state as DiaryPageLocationState | null;
  const caption =
    routeState?.caption ??
    (selectedIndex !== undefined && selectedIndex >= 0
      ? yearData?.items[selectedIndex]?.caption
      : undefined) ??
    "Diary Entry";

  if (!diaryEntry) {
    return (
      <main className={styles.page}>
        <section>
          <h1>{getDiaryHeading(Number(year), caption)}</h1>
          <h2>Entry not found</h2>
        </section>
      </main>
    );
  }

  if (loading) return <div>Loading diary entries...</div>;

  if (errorMessage) {
    return (
      <main className={styles.page}>
        <section>
          <h1>{getDiaryHeading(Number(year), caption)}</h1>
          <h2>{diaryEntry.period}</h2>
          <p>{errorMessage}</p>
        </section>
      </main>
    );
  }

  return (
    <main className={styles.page}>
      <section className={styles.diaryEntry} aria-label="Diary entry content">
        <h1>{getDiaryHeading(Number(year), caption)}</h1>
        <h2>{diaryEntry.period}</h2>
        <div>
          <h3>Emma's Entry</h3>
          <div className="markdown-body">
            <ReactMarkdown>{contentA}</ReactMarkdown>
          </div>
        </div>

        {diaryEntry.markdownPaths.length === 2 && (
          <div>
            <h3>Caroline's Entry</h3>
            <div className="markdown-body">
              <ReactMarkdown>{contentB}</ReactMarkdown>
            </div>
          </div>
        )}
      </section>
    </main>
  );
}

export default DiaryPage;
