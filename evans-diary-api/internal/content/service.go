package content

import (
	"encoding/json"
	"fmt"
	"log"
	"os"
)

var cloudName = "dqg9nkccw"

// ImageItem defines a clean standalone image type
type ImageItem struct {
	Caption string `json:"caption"`
	Source  string `json:"source"`
	Crop    string `json:"crop"`
}

// HomeSection groups the home specific layout properties
type HomeSection struct {
	Title       string      `json:"title"`
	Description string      `json:"description"`
	Images      []ImageItem `json:"images"`
}

// ContentSchema represents your overall JSON structure
type ContentSchema struct {
	Home HomeSection `json:"home"`
}

type Service struct {
	contentDir string
}

func NewService(dir string) *Service {
	return &Service{contentDir: dir}
}

// LoadHomeContent loads the single English content file directly
func (s *Service) LoadHomeContent() (*ContentSchema, error) {
	var path = s.contentDir + "/home.json"
	fileBytes, err := os.ReadFile(path)
	if err != nil {
		return nil, fmt.Errorf("content file not found")
	}

	var data HomeSection
	if err := json.Unmarshal(fileBytes, &data); err != nil {
		log.Panicln("Heelloooo?")
		return nil, fmt.Errorf("invalid json format")
	}

	// 1. Initialize your final return structure with default values
	var homeData ContentSchema
	homeData.Home.Title = data.Title
	homeData.Home.Description = data.Description

	// Pre-allocate slice memory size for performance based on your source data length
	homeData.Home.Images = make([]ImageItem, 0, len(data.Images))

	// 2. Loop through the raw images loaded from your JSON file
	for _, item := range data.Images {
		path := item.Source

		// Fallback gravity crop placement if the JSON string is blank
		gravity := item.Crop
		if gravity == "" {
			gravity = "face"
		}

		// 3. Instantiate your clean, strongly-typed ImageItem struct object
		image := ImageItem{
			Crop:    item.Crop,
			Caption: item.Caption,
			// Construct the optimized Cloudinary delivery string using .webp extension formatting
			Source: "https://res.cloudinary.com/" + cloudName + "/image/upload/c_fill,g_" + gravity + ",h_380,q_80,w_380/" + path + ".webp",
		}

		log.Println(image.Source)

		// 4. Append the newly transformed structural item to your output array state
		homeData.Home.Images = append(homeData.Home.Images, image)
	}

	return &homeData, nil
}
