import { createRoot } from "react-dom/client";
import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import "./index.css";
import App from "./App.tsx";
import NavBar from "./components/NavBar.tsx";
import AthleticsPage from "./pages/AthleticsPage.tsx";
import DiaryPage from "./pages/DiaryPage.tsx";
import FamilyPage from "./pages/FamilyPage.tsx";

createRoot(document.getElementById("root")!).render(
  <BrowserRouter>
    <NavBar />
    <Routes>
      <Route path="/" element={<App />} />
      <Route path="/family" element={<FamilyPage />} />
      <Route path="/athletics" element={<AthleticsPage />} />
      <Route path="/diary" element={<DiaryPage />} />
      <Route path="*" element={<Navigate to="/" replace />} />
    </Routes>
  </BrowserRouter>,
);
