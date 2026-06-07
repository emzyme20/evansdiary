import styles from "./DiaryPage.module.css";
import { getDiaryHeading, getMonthName } from "../utils";
import { useLocation, useParams } from "react-router-dom";
import { DIARY_CONTENT_REGISTRY, DIARY_REGISTRY } from "../data/diaryStructure";
import ReactMarkdown from "react-markdown";
import { useEffect, useState } from "react";
import ImageReel from "../components/ImageReel";

interface DiaryPageLocationState {
  caption?: string;
}

function DiaryPage() {
  const [contentA, setContentA] = useState<string>("");
  const [contentB, setContentB] = useState<string>("");
  const [loadedKey, setLoadedKey] = useState<string>("");

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
  const loading = Boolean(diaryEntry && key && loadedKey !== key);

  const imagesPerReel = 4;
  const imageReelCount = diaryEntry
    ? diaryEntry.images.length / imagesPerReel
    : 0;

  const showPerson = diaryEntry?.markdownPaths.length === 2;

  const getEntryLoadMessage = (entryName: string) =>
    `_${entryName} could not be loaded._`;

  console.log("imageReelCount", imageReelCount);
  console.log("total images", diaryEntry?.images.length);
  console.log("showPerson", showPerson);

  useEffect(() => {
    if (!diaryEntry || !key) return;

    let cancelled = false;

    const loadContent = async () => {
      const fetchMarkdown = async (path: string, entryName: string) => {
        try {
          const response = await fetch(path);

          if (!response.ok) {
            return getEntryLoadMessage(entryName);
          }

          const contentType =
            response.headers.get("content-type")?.toLowerCase() ?? "";
          const text = await response.text();

          // Some static servers return index.html with a 200 status for missing files.
          const isHtmlFallback =
            contentType.includes("text/html") ||
            /^\s*<!doctype html/i.test(text) ||
            /^\s*<html[\s>]/i.test(text);

          if (isHtmlFallback) {
            return getEntryLoadMessage(entryName);
          }

          return text;
        } catch {
          return getEntryLoadMessage(entryName);
        }
      };

      try {
        const textA = await fetchMarkdown(
          diaryEntry.markdownPaths[0],
          "Emma's entry",
        );
        const textB = diaryEntry.markdownPaths[1]
          ? await fetchMarkdown(diaryEntry.markdownPaths[1], "Caroline's entry")
          : "";
        const safeTextA = textA || getEntryLoadMessage("Emma's entry");

        if (cancelled) return;

        setContentA(safeTextA);
        setContentB(textB);
        setLoadedKey(key);
      } catch {
        if (cancelled) return;

        setContentA(getEntryLoadMessage("Emma's entry"));
        setContentB(
          diaryEntry.markdownPaths[1]
            ? getEntryLoadMessage("Caroline's entry")
            : "",
        );
        setLoadedKey(key);
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

  return (
    <main className={styles.page}>
      <section className={styles.diaryEntry} aria-label="Diary entry content">
        <h1>{getDiaryHeading(Number(year), caption)}</h1>
        <h2>{diaryEntry.period}</h2>
        {imageReelCount > 1 || diaryEntry.markdownPaths.length === 1 ? (
          <ImageReel
            images={diaryEntry.images.slice(0, imagesPerReel).map((image) => ({
              image: image,
            }))}
          />
        ) : null}
        <div>
          {showPerson ? <h3>Emma's Entry</h3> : null}
          <div className="markdown-body">
            <ReactMarkdown>{contentA}</ReactMarkdown>
          </div>
        </div>

        {diaryEntry.markdownPaths.length === 2 && imageReelCount === 1 && (
          <div>
            <ImageReel
              images={diaryEntry.images
                .slice(0, imagesPerReel)
                .map((image) => ({
                  image: image,
                }))}
            />
            <div>
              {showPerson ? <h3>Caroline's Entry</h3> : null}
              <div className="markdown-body">
                <ReactMarkdown>{contentB}</ReactMarkdown>
              </div>
            </div>
          </div>
        )}

        {imageReelCount > 1 ? (
          <ImageReel
            images={diaryEntry.images
              .slice(imagesPerReel, imagesPerReel * 2)
              .map((image) => ({
                image: image,
              }))}
          />
        ) : null}
      </section>
    </main>
  );
}

export default DiaryPage;
