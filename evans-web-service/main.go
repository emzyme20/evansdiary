package main

import (
	"cmp"
	"encoding/json"
	"fmt"
	"html/template"
	_ "image/jpeg" // Register JPEG decoder
	_ "image/png"  // Register PNG decoder
	"log"
	"net/http"
	"os"
)

var cloudName = "dqg9nkccw"

type AssociatedImage struct {
	Height  string `json:"height"`
	Width   string `json:"width"`
	Caption string `json:"caption"`
	Source  string `json:"source"`
}

type FlipbookItem struct {
	AssociatedImage AssociatedImage `json:"associatedImage"`
	Crop            string          `json:"crop"`
}

type ModelImage struct {
	Crop    string `json:"crop"`
	Caption string `json:"caption"`
	Source  string `json:"source"`
}

type IndexModel struct {
	FlipbookImages []ModelImage `json:"flipbookImages"`
}

func flipbookHandler(w http.ResponseWriter, r *http.Request) {
	// Read the data for the flipbook
	content, err := os.ReadFile("flipbook.json")
	if err != nil {
		fmt.Printf("Error reading JSON file: %v\n", err)
	}

	var flipbookBlueprint []FlipbookItem

	// Unmarshal the JSON data into the flipbook structure
	if err := json.Unmarshal(content, &flipbookBlueprint); err != nil {
		fmt.Printf("Error parsing JSON: %v\n", err)
	}

	payload := IndexModel{
		FlipbookImages: []ModelImage{},
	}

	fmt.Println("blueprint length", len(flipbookBlueprint))

	// Fetch each image and get url
	for _, item := range flipbookBlueprint {
		var path = item.AssociatedImage.Source

		var flipbookImage ModelImage
		flipbookImage.Caption = item.AssociatedImage.Caption
		flipbookImage.Crop = cmp.Or(item.Crop, "face")

		// Fully populate the url
		flipbookImage.Source = "https://res.cloudinary.com/" + cloudName + "/image/upload/c_fill,g_" + flipbookImage.Crop + ",h_380,q_80,w_380/" + path + ".webp"
		payload.FlipbookImages = append(payload.FlipbookImages, flipbookImage)
		if err != nil {
			fmt.Printf("Error generating URL string for %s: %v\n", path, err)
			continue
		}
	}

	// Compile your frontend HTML template
	tmpl, err := template.ParseFiles("index.html")
	if err != nil {
		http.Error(w, "Template file not found", http.StatusInternalServerError)
		return
	}

	// 4. Pass the data struct straight to the template executor
	tmpl.Execute(w, payload)

}

func main() {
	mux := http.NewServeMux()

	// 1. Intercept the favicon request here
	mux.HandleFunc("/favicon.ico", func(w http.ResponseWriter, r *http.Request) {
		w.WriteHeader(http.StatusNoContent)
	})

	// 2. Your existing main handler route
	mux.HandleFunc("/", flipbookHandler)
	log.Println("Server running at http://localhost:8080")
	log.Fatal(http.ListenAndServe(":8080", mux))
}
