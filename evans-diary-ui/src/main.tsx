import { createRoot } from "react-dom/client";
import { StrictMode } from "react";
import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import "./index.css";
import Home from "./Home.tsx";
import NavBar from "./components/NavBar.tsx";
import AthleticsPage from "./pages/AthleticsPage.tsx";
import DiaryPage from "./pages/DiaryPage.tsx";
import DiaryDashboard from "./pages/DiaryDashboard.tsx";
import FamilyPage from "./pages/FamilyPage.tsx";
import YearPage from "./pages/YearPage.tsx";

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <BrowserRouter>
      <NavBar />
      <main className="appContent">
        <Routes>
          <Route path="/" element={<Home />} />

          <Route path="/family" element={<FamilyPage />} />
          <Route path="/athletics" element={<AthleticsPage />} />

          {/* Diary Sub-routes */}
          <Route path="/diary" element={<DiaryDashboard />} />
          <Route path="/diary/year/:year" element={<YearPage />} />
          <Route path="/diary/year/:year/:month" element={<DiaryPage />} />
          <Route path="/diary/year/:year/week/:week" element={<DiaryPage />} />

          {/* Catch-all redirect */}
          <Route path="*" element={<Navigate to="/" replace />} />
        </Routes>
      </main>
      <footer className="siteFooter">
        &copy; {new Date().getFullYear()} Evan&apos;s Diary. All rights
        reserved.
      </footer>
    </BrowserRouter>
  </StrictMode>,
);
