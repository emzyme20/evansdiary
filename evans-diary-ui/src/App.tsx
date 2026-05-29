import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import type { HomeSchema } from "./types";
import styles from "./App.module.css";

const homeContentUrl =
  import.meta.env.VITE_HOME_CONTENT_URL || "/content/home.json";

const homeTiles = [
  {
    title: "#Family",
    href: "/family",
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
  const [isHeroHovered, setIsHeroHovered] = useState<boolean>(false);

  // Hook 1: Fetches the data EXACTLY ONCE on browser tab initialization mount
  useEffect(() => {
    fetch(homeContentUrl)
      .then((res) => {
        if (!res.ok) throw new Error("Home content request failed");
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

    let carouselInterval: ReturnType<typeof setInterval> | undefined;
    if (!isHeroHovered) {
      carouselInterval = setInterval(() => {
        setCarouselIndex((prevIndex) => {
          const totalImages = content.carousel.images.length;
          return prevIndex === totalImages - 1 ? 0 : prevIndex + 1;
        });
      }, 4500);
    }

    const flipbookInterval = setInterval(() => {
      setFlipbookIndex((prevIndex) => {
        const totalImages = content.flipbook.images.length;
        return prevIndex === totalImages - 1 ? 0 : prevIndex + 1;
      });
    }, 1800);

    return () => {
      if (carouselInterval) clearInterval(carouselInterval);
      clearInterval(flipbookInterval);
    };
  }, [content, isHeroHovered]);

  if (!content) return <p>Loading your grid engine profile layout...</p>;

  const flipbookImages = content.flipbook.images;
  const carouselImages = content.carousel.images;

  return (
    <main className={styles.homePage}>
      <section
        className={styles.heroSection}
        aria-label="Featured images"
        onMouseEnter={() => setIsHeroHovered(true)}
        onMouseLeave={() => setIsHeroHovered(false)}
      >
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
          <div className={styles.carouselNav} aria-label="Carousel navigation">
            {carouselImages.map((image, index) => {
              const isActive = index === carouselIndex;
              return (
                <button
                  type="button"
                  key={`carousel-indicator-${image.source}`}
                  className={`${styles.carouselNavButton} ${isActive ? styles.active : ""}`}
                  onClick={() => setCarouselIndex(index)}
                  aria-label={`Go to slide ${index + 1} of ${carouselImages.length}`}
                  aria-current={isActive ? "true" : undefined}
                />
              );
            })}
          </div>
        </div>
      </section>

      <section className={styles.tilesSection} aria-label="Grid sections">
        <div className={styles.tilesGrid}>
          {homeTiles.map((tile) => (
            <div className={styles.tile} key={`tile-${tile.title}`}>
              {tile.href ? (
                <Link className={styles.navTile} to={tile.href}>
                  <img
                    src={tile.image}
                    alt={tile.imageAlt}
                    className={styles.tileImage}
                  />
                  <div className={styles.tileOverlay}>
                    <h2>{tile.title}</h2>
                    <p>{tile.description}</p>
                  </div>
                </Link>
              ) : (
                <div className={styles.navTile} aria-disabled="true">
                  <img
                    src={tile.image}
                    alt={tile.imageAlt}
                    className={styles.tileImage}
                  />
                  <div className={styles.tileOverlay}>
                    <h2>{tile.title}</h2>
                    <p>{tile.description}</p>
                  </div>
                </div>
              )}
            </div>
          ))}

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
        </div>
      </section>
    </main>
  );
}

export default App;
