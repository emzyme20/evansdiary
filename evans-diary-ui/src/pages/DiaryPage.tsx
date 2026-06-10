import styles from "./DiaryPage.module.css";
import {
  getDiaryHeading,
  getImageUrl,
  getMonthNumber,
  fetchMarkdown,
  getEntryLoadMessage,
} from "../utils";
import { useLocation, useParams } from "react-router-dom";
import {
  DIARY_CONTENT_REGISTRY,
  DIARY_REGISTRY,
  type CalendarDiaryEntry,
  type CalendarDiaryEntryItem,
  type DiaryEntry,
  type StandardDiaryEntry,
} from "../data/diaryStructure";
import ReactMarkdown from "react-markdown";
import { useEffect, useState } from "react";
import ImageReel from "../components/ImageReel";
import type { EmbeddedMedia, ExternalMedia, Media } from "../types";

interface DiaryPageLocationState {
  caption?: string;
}

function isCalendarDiaryEntry(entry: DiaryEntry): entry is CalendarDiaryEntry {
  return entry.type === "calendar";
}

function DiaryPage() {
  const [contentA, setContentA] = useState<string>("");
  const [contentB, setContentB] = useState<string>("");
  const [calendarContent, setCalendarContent] = useState<
    Record<number, string>
  >({});
  const [loadedKey, setLoadedKey] = useState<string>("");

  // Extract the year, week, and month parameters from the URL
  const { year, week, month } = useParams<{
    year: string;
    week: string;
    month: string;
  }>();

  // Build the key to look up the diary entry in the content registry based on the URL parameters
  const key =
    week !== undefined
      ? (() => {
          const weekNumber = Number(week);
          if (Number.isFinite(weekNumber)) {
            return `${year}-${String(weekNumber).padStart(2, "0")}`;
          }
        })()
      : month !== undefined
        ? (() => {
            return `${year}-${String(getMonthNumber(month)).padStart(2, "0")}`;
          })()
        : undefined;

  // Look up the year data from the registry based on the year parameter
  const yearData = year ? DIARY_REGISTRY[year] : undefined;

  // Look up the specific meta asset paths instantly
  const diaryEntry = key ? DIARY_CONTENT_REGISTRY[key] : null;
  const loading = Boolean(diaryEntry && key && loadedKey !== key);

  const imagesPerReel = 4;
  const imageReelCount =
    diaryEntry && "images" in diaryEntry
      ? diaryEntry.images.length / imagesPerReel
      : 0;

  const showPerson =
    diaryEntry && "markdownPaths" in diaryEntry
      ? diaryEntry.markdownPaths.length === 2
      : false;

  const renderImageReel = (
    images: Media[],
    position?: "top" | "bottom",
    layout?: "top" | "bottom",
    totalImages?: number,
  ) =>
    images.length > 0 &&
    (layout === undefined || (layout === position && totalImages === 4)) ? (
      <ImageReel
        images={images.map((image) => ({
          image,
        }))}
      />
    ) : null;

  const renderVideos = (videos?: Array<EmbeddedMedia | ExternalMedia>) =>
    videos && videos.length > 0
      ? videos.map((video, index) => (
          <figure className={styles.video} key={index}>
            {video.type === "External" ? (
              <a
                href={video.url}
                target="_blank"
                rel="noopener noreferrer"
                title={video.title}
              >
                <img
                  src={getImageUrl(video.image.source)}
                  alt={video.image.caption}
                />
              </a>
            ) : (
              <iframe
                src={video.url}
                title={video.title}
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                allowFullScreen
              ></iframe>
            )}
          </figure>
        ))
      : null;

  const renderMarkdown = (content: string) => (
    <div className="markdown-body">
      <ReactMarkdown>{content}</ReactMarkdown>
    </div>
  );

  const renderCalendarLayout = (calendarEntry: CalendarDiaryEntry) => (
    <main className={styles.page}>
      <section className={styles.diaryEntry} aria-label="Diary entry content">
        <h1>{getDiaryHeading(Number(year), caption)}</h1>
        {calendarEntry.calendarEntries.map(
          (calendarEntry: CalendarDiaryEntryItem, index: number) => (
            <div key={`${key}-calendar-entry-${index}`}>
              <h3>{calendarEntry.heading}</h3>
              {renderImageReel(calendarEntry.images.slice(0, imagesPerReel))}
              {renderMarkdown(
                calendarContent[index] ||
                  getEntryLoadMessage(calendarEntry.heading),
              )}
              {renderImageReel(
                calendarEntry.images.slice(imagesPerReel, imagesPerReel * 2),
              )}
              {renderVideos(calendarEntry.videos)}
            </div>
          ),
        )}
      </section>
    </main>
  );

  const renderStandardLayout = (entry: StandardDiaryEntry) => (
    <main className={styles.page}>
      <section className={styles.diaryEntry} aria-label="Diary entry content">
        <h1>{getDiaryHeading(Number(year), caption)}</h1>
        {yearData?.mode === "week" ? <h2>{entry.period}</h2> : null}
        {imageReelCount > 1 ||
        entry.markdownPaths.length === 1 ||
        entry.options?.imageReelLayout === "top"
          ? renderImageReel(
              entry.images.slice(0, imagesPerReel),
              "top",
              entry.options?.imageReelLayout,
              entry.images.length,
            )
          : null}
        <div>
          {showPerson ? <h3>Emma's Entry</h3> : null}
          {renderMarkdown(contentA)}
        </div>

        {entry.markdownPaths.length === 2 && imageReelCount === 1 && (
          <div>
            {renderImageReel(
              entry.images.slice(0, imagesPerReel),
              undefined,
              entry.options?.imageReelLayout,
              entry.images.length,
            )}
            <div>
              {showPerson ? <h3>Caroline's Entry</h3> : null}
              {renderMarkdown(contentB)}
            </div>
          </div>
        )}

        {imageReelCount > 1 || entry.options?.imageReelLayout === "bottom"
          ? renderImageReel(
              entry.images.slice(imagesPerReel, imagesPerReel * 2),
              "bottom",
              entry.options?.imageReelLayout,
              entry.images.length,
            )
          : null}
      </section>
    </main>
  );

  if (diaryEntry && !isCalendarDiaryEntry(diaryEntry)) {
    console.log(
      "Standard diary entry data:",
      diaryEntry.options,
      diaryEntry.images.length,
    );
  }

  useEffect(() => {
    if (!diaryEntry || !key) return;

    let cancelled = false;

    const loadContent = async () => {
      try {
        if (diaryEntry.type === "calendar") {
          const resolvedEntries = await Promise.all(
            diaryEntry.calendarEntries.map(async (entry, index) => {
              const content = await fetchMarkdown(
                entry.markdownPath,
                entry.heading,
              );
              return [index, content] as const;
            }),
          );

          if (cancelled) return;

          setCalendarContent(Object.fromEntries(resolvedEntries));
          setLoadedKey(key);
          return;
        }

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

        if (diaryEntry.type === "calendar") {
          const fallbackEntries = Object.fromEntries(
            diaryEntry.calendarEntries.map((entry, index) => [
              index,
              getEntryLoadMessage(entry.heading),
            ]),
          );
          setCalendarContent(fallbackEntries);
        } else {
          setContentA(getEntryLoadMessage("Emma's entry"));
          setContentB(
            diaryEntry.markdownPaths[1]
              ? getEntryLoadMessage("Caroline's entry")
              : "",
          );
        }
        setLoadedKey(key);
      }
    };

    void loadContent();

    return () => {
      cancelled = true;
    };
  }, [diaryEntry, key]);

  // Access the location state to retrieve the caption passed from the year page navigation image
  const location = useLocation();
  const routeState = location.state as DiaryPageLocationState | null;
  const caption = routeState?.caption ?? "";

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

  if (isCalendarDiaryEntry(diaryEntry)) {
    return renderCalendarLayout(diaryEntry);
  }

  return renderStandardLayout(diaryEntry);
}

export default DiaryPage;
