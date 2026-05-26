import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev
export default defineConfig({
  plugins: [react()],
  server: {
    port: 5173, // Your React local development server port
    proxy: {
      // Catch any frontend request starting with '/api'
      '/api': {
        target: 'http://localhost:8080', // Forward it to your Go/Gin backend
        changeOrigin: true,              // Needed for virtual hosted sites
        secure: false,                   // If using self-signed certificates locally
      }
    }
  }
})

