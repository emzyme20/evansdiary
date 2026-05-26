import { useEffect, useState } from "react";
import type { ContentSchema } from "./types";
import styles from "./App.module.css";

function App() {
  const [content, setContent] = useState<ContentSchema | null>(null);

  // 1. Initialize active slider tracking state
  const [activeIndex, setActiveIndex] = useState<number>(0);

  // Hook 1: Fetches the data EXACTLY ONCE on browser tab initialization mount
  useEffect(() => {
    fetch("/api/content/home")
      .then((res) => {
        if (!res.ok) throw new Error("API network response failed");
        return res.json();
      })
      .then((data: ContentSchema) => setContent(data))
      .catch((err) => console.error("Error loading content:", err));
  }, []); // Keep this empty to ensure it runs only once!

  // Hook 2: Starts the automated image switcher loop once content becomes available
  useEffect(() => {
    // Safety check: Don't start a timer if there are no images to display yet
    if (!content || !content.home.images || content.home.images.length === 0)
      return;

    console.log(
      `Starting slider interval tracking for ${content.home.images.length} photos`,
    );

    // 2. Set up the automated image cycle tracking loop (every 3 seconds)
    const interval = setInterval(() => {
      // Visual Anchor: Use a functional state update callback to completely avoid stale closures
      setActiveIndex((prevIndex) => {
        const totalImages = content.home.images.length;
        return prevIndex === totalImages - 1 ? 0 : prevIndex + 1;
      });
    }, 3000);

    // 3. MANDATORY CLEANUP: Cleans up the background timer memory if the component re-renders
    return () => {
      console.log("Clearing old slider interval track instance");
      clearInterval(interval);
    };
  }, [content]); // This hook will re-run automatically the moment 'content' populates!

  if (!content) return <p>Loading your diary engine profile layout...</p>;

  return (
    <div className={styles.flipbookViewport} id="flipbook">
      {content.home.images.map((image, index) => (
        <img
          src={image.source} // Fully populated absolute Cloudinary web addresses from your Go backend
          alt={image.caption}
          // Visual Anchor: Compare dynamic tracking positions to toggle your active stylesheet class
          className={`${styles.card} ${index === activeIndex ? styles.active : ""}`}
          key={index}
        />
      ))}
    </div>
  );
}

export default App;
