import { mkdir, readFile, writeFile } from "node:fs/promises";
import path from "node:path";
import { fileURLToPath } from "node:url";

const cloudName = "dqg9nkccw";

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);
const uiRoot = path.resolve(__dirname, "..");
const repoRoot = path.resolve(uiRoot, "..");

const flipbookPath = path.join(
  repoRoot,
  "evans-diary-api",
  "content",
  "flipbook.json",
);
const carouselPath = path.join(
  repoRoot,
  "evans-diary-api",
  "content",
  "carousel.json",
);
const outputDir = path.join(uiRoot, "public", "content");
const outputPath = path.join(outputDir, "home.json");

function buildImage(item) {
  if (item.crop === undefined || item.crop === null) {
    return {
      caption: item.caption,
      source: `https://res.cloudinary.com/${cloudName}/image/upload/c_fill,q_80/${item.source}`,
    };
  }

  const gravity = item.crop && item.crop.trim().length > 0 ? item.crop : "face";

  return {
    caption: item.caption,
    source: `https://res.cloudinary.com/${cloudName}/image/upload/c_fill,g_${gravity},h_380,q_80,w_380/${item.source}.webp`,
    crop: item.crop,
  };
}

async function main() {
  const [flipbookRaw, carouselRaw] = await Promise.all([
    readFile(flipbookPath, "utf8"),
    readFile(carouselPath, "utf8"),
  ]);

  const flipbook = JSON.parse(flipbookRaw);
  const carousel = JSON.parse(carouselRaw);

  const homeContent = {
    flipbook: {
      title: flipbook.title,
      description: flipbook.description,
      images: Array.isArray(flipbook.images)
        ? flipbook.images.map(buildImage)
        : [],
    },
    carousel: {
      images: Array.isArray(carousel.images)
        ? carousel.images.map(buildImage)
        : [],
    },
  };

  await mkdir(outputDir, { recursive: true });
  await writeFile(
    outputPath,
    `${JSON.stringify(homeContent, null, 2)}\n`,
    "utf8",
  );

  console.log(`Synced home content to ${outputPath}`);
}

main().catch((error) => {
  console.error("Failed to sync home content", error);
  process.exit(1);
});
