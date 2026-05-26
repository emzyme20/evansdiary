package main

import (
	"evans-diary-api/internal/content"
	"evans-diary-api/internal/middleware"
	"log"

	"github.com/gin-gonic/gin"
)

func main() {
	// Visual Anchor: Sets Gin to production mode, silencing all framework warning logs
	// gin.SetMode(gin.ReleaseMode)

	// Initialize default Gin engine
	r := gin.Default()

	// Visual Anchor: Only trust requests coming from the local proxy engine
	err := r.SetTrustedProxies([]string{"127.0.0.1", "::1"})
	if err != nil {
		log.Printf("Proxy configuration error: %v", err)
	}

	// Apply CORS middleware so your React frontend can talk to it
	r.Use(middleware.CORS())

	// Your favicon helper block
	r.GET("/favicon.ico", func(c *gin.Context) {
		c.Status(204)
	})
	
	// Initialize the service and handler layers
	contentService := content.NewService("./content")
	contentHandler := content.NewHandler(contentService)

	// Healthcheck for the API
	r.GET("/", func(c *gin.Context) {
		c.JSON(200, gin.H{
			"status":  "healthy",
			"message": "Evans Diary API Engine is running smoothly",
		})
	})

	// Define your API routes
	api := r.Group("/api")
	{
		// Visual Anchor: Static route with no variable parameters
		api.GET("/content/home", contentHandler.GetHomeContent)
	}

	// Start the server on port 8080
	log.Println("Server starting on :8080...")
	if err := r.Run(":8080"); err != nil {
		log.Fatalf("Server failed to start: %v", err)
	}
}
