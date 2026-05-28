import { useEffect, useState } from "react";
import type { HomeSchema } from "./types";
import styles from "./App.module.css";

const homeTiles = [
  {
    title: "#Family",
    href: "/Family",
    description: "My family, we mean the world to each other",
    image: "/images/family.jpg",
    imageAlt: "My Family",
  },
  {
    title: "#BestFriends",
    href: "",
    description: "My best friend—love her so much",
    image: "/images/best-friends.jpg",
    imageAlt: "My Best Friend",
  },
  {
    title: "#MyTeam",
    href: "",
    description:
      "Like my Mum, there's only one team for me. Come on you Spurs!",
    image: "/images/cockerel.jpg",
    imageAlt: "My Team",
  },
  {
    title: "#MyPassion",
    href: "/athletics",
    description: "Competing for my athletics club—Team Bath",
    image: "/images/team-bath.jpg",
    imageAlt: "Team Bath",
  },
  {
    title: "#Hobbies",
    href: "",
    description: "My creative side sees me painting my warhammer figures",
    image: "/images/warhammer.jpg",
    imageAlt: "Warhammer",
  },
] as const;

function App() {
  const [content, setContent] = useState<HomeSchema | null>(null);
  const [carouselIndex, setCarouselIndex] = useState<number>(0);
  const [flipbookIndex, setFlipbookIndex] = useState<number>(0);

  // Hook 1: Fetches the data EXACTLY ONCE on browser tab initialization mount
  useEffect(() => {
    fetch("/api/content/home")
      .then((res) => {
        if (!res.ok) throw new Error("API network response failed");
        return res.json();
      })
      .then((data: HomeSchema) => setContent(data))
      .catch((err) => console.error("Error loading content:", err));
  }, []); // Keep this empty to ensure it runs only once!

  useEffect(() => {
    if (
      !content ||
      !content.flipbook.images ||
      !content.carousel.images ||
      content.flipbook.images.length === 0 ||
      content.carousel.images.length === 0
    )
      return;

    const carouselInterval = setInterval(() => {
      setCarouselIndex((prevIndex) => {
        const totalImages = content.carousel.images.length;
        return prevIndex === totalImages - 1 ? 0 : prevIndex + 1;
      });
    }, 4500);

    const flipbookInterval = setInterval(() => {
      setFlipbookIndex((prevIndex) => {
        const totalImages = content.flipbook.images.length;
        return prevIndex === totalImages - 1 ? 0 : prevIndex + 1;
      });
    }, 1800);

    return () => {
      clearInterval(carouselInterval);
      clearInterval(flipbookInterval);
    };
  }, [content]);

  if (!content) return <p>Loading your grid engine profile layout...</p>;

  const flipbookImages = content.flipbook.images;
  const carouselImages = content.carousel.images;

  return (
    <main className={styles.homePage}>
      <section className={styles.heroSection} aria-label="Featured images">
        <div className={styles.heroTrack}>
          {carouselImages.map((image, index) => (
            <img
              src={image.source}
              alt={image.caption}
              className={`${styles.heroImage} ${index === carouselIndex ? styles.active : ""}`}
              key={`carousel-${index}`}
            />
          ))}
        </div>
        <div className={styles.heroCaptionWrap}>
          <p className={styles.heroCaption}>
            {carouselImages[carouselIndex].caption}
          </p>
        </div>
      </section>

      <section className={styles.tilesSection} aria-label="Grid sections">
        <div className={styles.tilesGrid}>
          {homeTiles.map((tile) => (
            <div key={`tile-${tile.title}`}>
              <img
                src={tile.image}
                alt={tile.imageAlt}
                className={styles.tileImage}
              />
              <a className={styles.navTile} href={tile.href}>
                <h2>{tile.title}</h2>
                <p>{tile.description}</p>
              </a>
            </div>
          ))}

          <article
            className={`${styles.navTile} ${styles.flipbookTile}`}
            aria-label="Flipbook preview"
          >
            <div className={styles.flipbookViewport} id="flipbook">
              {flipbookImages.map((image, index) => (
                <img
                  src={image.source}
                  alt={image.caption}
                  className={`${styles.card} ${index === flipbookIndex ? styles.active : ""}`}
                  key={`flipbook-${image.source}`}
                />
              ))}
            </div>
            <div className={styles.flipbookCaption}>Flipbook Preview</div>
          </article>
        </div>
      </section>
    </main>
  );
}

export default App;
