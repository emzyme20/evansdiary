package content

import (
	"encoding/json"
	"fmt"
	"log"
	"os"
	"path/filepath"
)

var cloudName = "dqg9nkccw"

// ImageItem defines a clean standalone image type
type ImageItem struct {
	Caption string `json:"caption"`
	Source  string `json:"source"`
	Crop    *string `json:"crop,omitempty"`
}

// FlipbookSection groups the flipbook specific layout properties
type FlipbookSection struct {
	Title       string      `json:"title"`
	Description string      `json:"description"`
	Images      []ImageItem `json:"images"`
}

type CarouselSection struct {
	Images      []ImageItem `json:"images"`
}

func (f *FlipbookSection) SetImages(images []ImageItem) {
	f.Images = images
}

func (c *CarouselSection) SetImages(images []ImageItem) {
	c.Images = images
}

// HomeSchema represents your overall JSON structure
type HomeSchema struct {
	Flipbook FlipbookSection `json:"flipbook"`
	Carousel CarouselSection `json:"carousel"`
}

type Service struct {
	contentDir string
}

func NewService(dir string) *Service {
	return &Service{contentDir: dir}
}

// LoadHomeContent loads the single English content file directly
func (s *Service) LoadHomeContent() (*HomeSchema, error) {
	flipbook, err := LoadJsonContent[FlipbookSection](s, "flipbook.json")
	if err != nil {
		return nil, err
	}

	carousel, err := LoadJsonContent[CarouselSection](s, "carousel.json")
	if err != nil {
		return nil, err
	}

	var content HomeSchema
	content.Flipbook.Title = flipbook.Title
	content.Flipbook.Description = flipbook.Description

	GenerateImageUrls(&content.Flipbook, flipbook.Images)
	GenerateImageUrls(&content.Carousel, carousel.Images)

	return &content, nil
}

type ImageSection interface {
	SetImages([]ImageItem)
}

func GenerateImageUrls(section ImageSection, images []ImageItem) {
	builtImages := make([]ImageItem, 0, len(images))

	for _, item := range images {
		path := item.Source

		var image ImageItem

		if item.Crop == nil {
			image = ImageItem{
				Caption: item.Caption,
				Source:  "https://res.cloudinary.com/" + cloudName + "/image/upload/c_fill,q_80/" + path,
			}
		} else {
			gravity := *item.Crop
			if gravity == "" {
				gravity = "face"
			}

			image = ImageItem{
				Crop:    item.Crop,
				Caption: item.Caption,
				Source:  "https://res.cloudinary.com/" + cloudName + "/image/upload/c_fill,g_" + gravity + ",h_380,q_80,w_380/" + path + ".webp",
			}
		}

		log.Println(image.Source)
		builtImages = append(builtImages, image)
	}

	section.SetImages(builtImages)
}

func (s *Service) LoadHomeSchema() (*HomeSchema, error) {
	return s.LoadHomeContent()
}

func LoadJsonContent[T any](s *Service, fileName string) (T, error) {
	var data T

	path := filepath.Join(s.contentDir, fileName)
	fileBytes, err := os.ReadFile(path)
	if err != nil {
		return data, fmt.Errorf("content file not found: %s", fileName)
	}

	if err := json.Unmarshal(fileBytes, &data); err != nil {
		return data, fmt.Errorf("invalid json format in %s", fileName)
	}

	return data, nil
}
