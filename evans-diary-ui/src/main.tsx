import { createRoot } from "react-dom/client";
import { StrictMode } from "react";
import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import "./index.css";
import App from "./App.tsx";
import NavBar from "./components/NavBar.tsx";
import AthleticsPage from "./pages/AthleticsPage.tsx";
import DiaryPage from "./pages/DiaryPage.tsx";
import FamilyPage from "./pages/FamilyPage.tsx";
import YearPage from "./pages/YearPage.tsx";

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <BrowserRouter>
      <NavBar />
      <main className="appContent">
        <Routes>
          <Route path="/" element={<App />} />
          <Route path="/family" element={<FamilyPage />} />
          <Route path="/athletics" element={<AthleticsPage />} />
          <Route path="/diary" element={<DiaryPage />} />
          <Route path="*" element={<Navigate to="/" replace />} />
          <Route path="/diary/year/:year" element={<YearPage />} />
        </Routes>
      </main>
      <footer className="siteFooter">
        &copy; {new Date().getFullYear()} Evan&apos;s Diary. All rights
        reserved.
      </footer>
    </BrowserRouter>
  </StrictMode>,
);
