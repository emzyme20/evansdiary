import styles from "./DiaryPage.module.css";
import {
  getDiaryHeading,
  getImageUrl,
  getMonthName,
  getMonthNumber,
  fetchMarkdown,
  getEntryLoadMessage,
} from "../utils";
import { DocumentViewer } from "../components/DocumentPopout";
import { Link, useLocation, useParams } from "react-router-dom";
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

interface DiaryNavigationLink {
  to: string;
  label: string;
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

  // Build the key and currentIndex to look up the diary entry in the content registry
  const { key, currentIndex } = (() => {
    if (week !== undefined) {
      const weekNumber = Number(week);
      if (Number.isFinite(weekNumber)) {
        return {
          key: `${year}-${String(weekNumber).padStart(2, "0")}`,
          currentIndex: weekNumber,
        };
      }
    } else if (month !== undefined) {
      const monthNumber = getMonthNumber(month);
      return {
        key: `${year}-${String(monthNumber).padStart(2, "0")}`,
        currentIndex: monthNumber - 1,
      };
    }
    return { key: undefined, currentIndex: NaN };
  })();

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

  const currentItem =
    Number.isFinite(currentIndex) &&
    yearData &&
    currentIndex >= 0 &&
    currentIndex < yearData.items.length
      ? yearData.items[currentIndex]
      : undefined;

  const getEntryPath = (index: number) => {
    if (!year || !yearData) return "";

    return yearData.mode === "week"
      ? `/diary/year/${year}/week/${index}`
      : `/diary/year/${year}/${getMonthName(index)}`;
  };

  const buildNavLink = (index: number, direction: "previous" | "next") => {
    if (!yearData || !Number.isFinite(currentIndex)) return null;
    if (index < 0 || index >= yearData.items.length) return null;

    const item = yearData.items[index];
    const prefix = direction === "previous" ? "Previous" : "Next";
    const periodType = yearData.mode === "week" ? "week" : "month";

    const label = `Go to ${prefix.toLowerCase()} ${periodType}: ${item.caption}`;
    const to = getEntryPath(index);

    return {
      to,
      label,
    } satisfies DiaryNavigationLink;
  };

  const previousLink = buildNavLink(currentIndex - 1, "previous");
  const nextLink = buildNavLink(currentIndex + 1, "next");

  const showPerson =
    diaryEntry && "markdownPaths" in diaryEntry
      ? diaryEntry.markdownPaths.length === 2
      : false;

  const renderEdgeTriggers = () => {
    if (!yearData || (!previousLink && !nextLink)) return null;

    return (
      <>
        {previousLink ? (
          <Link
            className={`${styles.edgeTrigger} ${styles.edgeTriggerLeft}`}
            to={previousLink.to}
            aria-label={previousLink.label}
          >
            <span className={styles.edgeTriggerArrow} aria-hidden="true">
              {"<"}
            </span>
          </Link>
        ) : null}

        {nextLink ? (
          <Link
            className={`${styles.edgeTrigger} ${styles.edgeTriggerRight}`}
            to={nextLink.to}
            aria-label={nextLink.label}
          >
            <span className={styles.edgeTriggerArrow} aria-hidden="true">
              {">"}
            </span>
          </Link>
        ) : null}
      </>
    );
  };

  const renderImageReel = (images: Media[]) =>
    images.length > 0 ? (
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
              <div>
                <div className={styles.videoWrapper}>
                  <iframe
                    src={video.url}
                    title={video.title}
                    allow="autoplay; fullscreen; picture-in-picture; clipboard-write; encrypted-media; web-share"
                    referrerPolicy="strict-origin-when-cross-origin"
                  ></iframe>
                </div>
                <script src="https://player.vimeo.com/api/player.js"></script>
              </div>
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
      {renderEdgeTriggers()}
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
      {renderEdgeTriggers()}
      <section className={styles.diaryEntry} aria-label="Diary entry content">
        <h1>{getDiaryHeading(Number(year), caption)}</h1>
        {yearData?.mode === "week" ? <h2>{entry.period}</h2> : null}
        {imageReelCount > 1 || entry.markdownPaths.length === 1
          ? renderImageReel(entry.images.slice(0, imagesPerReel))
          : null}
        <div>
          {showPerson ? <h3>Emma's Entry</h3> : null}
          {renderMarkdown(contentA)}
        </div>

        {entry.markdownPaths.length === 2 && (
          <div>
            {imageReelCount === 1
              ? renderImageReel(entry.images.slice(0, imagesPerReel))
              : null}
            <div>
              {showPerson ? <h3>Caroline's Entry</h3> : null}
              {renderMarkdown(contentB)}
            </div>
          </div>
        )}

        {entry.documents && entry.documents.length > 0 && (
          <div className={styles.documents}>
            {entry.documents.map((document, index) => (
              <DocumentViewer
                key={`${key}-document-${index}`}
                buttonText={document.buttonText}
                documentUrl={document.documentUrl}
              />
            ))}
          </div>
        )}

        {imageReelCount > 1
          ? renderImageReel(
              entry.images.slice(imagesPerReel, imagesPerReel * 2),
            )
          : null}
      </section>
    </main>
  );

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
  const caption = routeState?.caption ?? currentItem?.caption ?? "";

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
