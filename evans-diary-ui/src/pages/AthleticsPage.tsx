import { useEffect, useMemo, useRef, useState } from "react";
import { athleticsTimeline } from "../timelineEntries";
import type { TimelineEntry } from "../types";
import { getImageUrl } from "../utils";
import styles from "./AthleticsPage.module.css";

const BLOG_PREVIEW_LENGTH = 250;

const typeIcon: Record<TimelineEntry["type"], string> = {
  Event: "📅",
  Video: "📽️",
  Blog: "📝",
};

function splitParagraphs(text: string): string[] {
  return text
    .split(/\n\s*\n/)
    .map((paragraph) => paragraph.trim())
    .filter(Boolean);
}

function getPreviewText(text: string, maxLength: number): string {
  if (text.length <= maxLength) {
    return text;
  }

  const trimmed = text.slice(0, maxLength);
  const lastSpaceIndex = trimmed.lastIndexOf(" ");
  const safeTrimmed =
    lastSpaceIndex > 0 ? trimmed.slice(0, lastSpaceIndex) : trimmed;
  return `${safeTrimmed}...`;
}

function AthleticsPage() {
  const [visibleIndexes, setVisibleIndexes] = useState<Set<number>>(
    () => new Set(),
  );
  const [expandedBlogEntries, setExpandedBlogEntries] = useState<Set<string>>(
    () => new Set(),
  );
  const timelineRef = useRef<HTMLElement | null>(null);

  const timeline = useMemo(
    () => athleticsTimeline.slice().sort((a, b) => a.year - b.year),
    [],
  );

  useEffect(() => {
    document.body.classList.add("athleticsPageBackground");
    return () => {
      document.body.classList.remove("athleticsPageBackground");
    };
  }, []);

  useEffect(() => {
    if (!timelineRef.current) {
      return;
    }

    const entries = Array.from(
      timelineRef.current.querySelectorAll<HTMLElement>(
        "[data-timeline-index]",
      ),
    );
    const observer = new IntersectionObserver(
      (observed) => {
        setVisibleIndexes((previous) => {
          const next = new Set(previous);
          for (const item of observed) {
            if (!item.isIntersecting) {
              continue;
            }
            const indexValue = Number(
              item.target.getAttribute("data-timeline-index"),
            );
            if (Number.isFinite(indexValue)) {
              next.add(indexValue);
            }
          }
          return next;
        });
      },
      {
        threshold: 0.35,
        rootMargin: "0px 0px -8% 0px",
      },
    );

    for (const entry of entries) {
      observer.observe(entry);
    }

    return () => {
      observer.disconnect();
    };
  }, [timeline.length]);

  return (
    <main className={styles.page}>
      <section
        className={styles.timelineSection}
        aria-label="Athletics timeline"
        ref={timelineRef}
      >
        <header className={styles.timelineHeader}>
          <p className={styles.kicker}>Evan's Journey</p>
          <h1 className={styles.title}>Athletics Timeline</h1>
          <p className={styles.subtitle}>
            Scroll through key moments from first races to major milestones.
          </p>
        </header>

        <div className={styles.timeline}>
          {timeline.map((entry, index) => {
            const entryKey = `${entry.year}-${entry.heading}`;
            const isEven = index % 2 === 0;
            const isVisible = visibleIndexes.has(index);
            const isBlogEntry = entry.type === "Blog";
            const isBlogExpanded = expandedBlogEntries.has(entryKey);
            const hasBlogOverflow =
              entry.description.length > BLOG_PREVIEW_LENGTH;
            const paragraphs = splitParagraphs(entry.description);
            const previewText = getPreviewText(
              entry.description,
              BLOG_PREVIEW_LENGTH,
            );

            return (
              <article
                key={entryKey}
                className={`${styles.timelineEntry} ${isEven ? styles.left : styles.right} ${
                  isVisible ? styles.visible : ""
                }`}
                data-timeline-index={index}
              >
                <div className={styles.yearWrap}>
                  <span className={styles.yearBadge}>{entry.year}</span>
                </div>

                <div className={styles.nodeWrap} aria-hidden="true">
                  <span className={styles.node}>{typeIcon[entry.type]}</span>
                </div>

                <div className={styles.card}>
                  <p className={styles.entryType}>{entry.type}</p>
                  <h2 className={styles.entryHeading}>{entry.heading}</h2>
                  <div className={styles.entryBody}>
                    {isBlogEntry && !isBlogExpanded ? (
                      <p>{previewText}</p>
                    ) : (
                      paragraphs.map((paragraph, paragraphIndex) => (
                        <p key={`${entry.heading}-paragraph-${paragraphIndex}`}>
                          {paragraph}
                        </p>
                      ))
                    )}
                  </div>

                  {entry.link ? (
                    <p className={styles.entryLinkWrap}>
                      <a
                        href={entry.link.href}
                        target="_blank"
                        rel="noopener noreferrer"
                        className={styles.entryLink}
                      >
                        {entry.link.label}
                      </a>
                    </p>
                  ) : null}

                  {isBlogEntry && hasBlogOverflow ? (
                    <button
                      type="button"
                      className={styles.readMoreButton}
                      onClick={() => {
                        setExpandedBlogEntries((previous) => {
                          const next = new Set(previous);
                          if (next.has(entryKey)) {
                            next.delete(entryKey);
                          } else {
                            next.add(entryKey);
                          }
                          return next;
                        });
                      }}
                    >
                      {isBlogExpanded ? "Read less" : "Read more"}
                    </button>
                  ) : null}

                  {entry.images && entry.images.length > 0 ? (
                    <ul
                      className={styles.mediaGrid}
                      aria-label={`${entry.heading} photos`}
                    >
                      {entry.images.map((image) => (
                        <li
                          key={`${entry.heading}-${image.source}`}
                          className={styles.mediaItem}
                        >
                          <figure className={styles.polaroid}>
                            <img
                              src={getImageUrl(
                                image.source,
                                image.width,
                                image.height,
                              )}
                              alt={image.caption}
                              width={image.width}
                              className={styles.polaroidImage}
                            />
                            <figcaption className={styles.polaroidCaption}>
                              {image.caption}
                            </figcaption>
                          </figure>
                        </li>
                      ))}
                    </ul>
                  ) : null}

                  {entry.video ? (
                    <ul
                      className={styles.mediaGrid}
                      aria-label={`${entry.heading} video`}
                    >
                      <li
                        key={`${entry.heading}-${entry.video.source}`}
                        className={styles.mediaItem}
                      >
                        <figure className={styles.polaroid}>
                          <iframe
                            src={entry.video.source}
                            title={entry.video.caption}
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                            allowFullScreen
                          ></iframe>
                          <figcaption className={styles.polaroidCaption}>
                            {entry.video.caption}
                          </figcaption>
                        </figure>
                      </li>
                    </ul>
                  ) : null}
                </div>
              </article>
            );
          })}
        </div>
      </section>
    </main>
  );
}

export default AthleticsPage;
