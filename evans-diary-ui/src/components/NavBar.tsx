import { useEffect, useRef, useState } from "react";
import { NavLink } from "react-router-dom";
import styles from "../App.module.css";

function NavBar() {
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const navRef = useRef<HTMLElement | null>(null);

  useEffect(() => {
    if (!isMenuOpen) {
      return;
    }

    const handlePointerDown = (event: PointerEvent) => {
      if (!navRef.current?.contains(event.target as Node)) {
        setIsMenuOpen(false);
      }
    };

    const handleKeyDown = (event: KeyboardEvent) => {
      if (event.key === "Escape") {
        setIsMenuOpen(false);
      }
    };

    document.addEventListener("pointerdown", handlePointerDown);
    document.addEventListener("keydown", handleKeyDown);

    return () => {
      document.removeEventListener("pointerdown", handlePointerDown);
      document.removeEventListener("keydown", handleKeyDown);
    };
  }, [isMenuOpen]);

  const getNavLinkClassName = ({ isActive }: { isActive: boolean }) =>
    `${styles.navLink} ${isActive ? styles.navLinkActive : ""}`;

  const handleNavClick = () => {
    setIsMenuOpen(false);
  };

  return (
    <nav className={styles.navbar} ref={navRef}>
      <NavLink className={styles.navbarBrand} to="/">
        Evan's Diary
      </NavLink>
      <button
        type="button"
        className={`${styles.navbarToggle} ${isMenuOpen ? styles.navbarToggleOpen : ""}`}
        aria-expanded={isMenuOpen}
        aria-controls="primary-navigation"
        aria-label={
          isMenuOpen ? "Close navigation menu" : "Open navigation menu"
        }
        onClick={() => setIsMenuOpen((current) => !current)}
      >
        <span className={styles.navbarToggleBar} />
        <span className={styles.navbarToggleBar} />
        <span className={styles.navbarToggleBar} />
      </button>
      <div
        className={`${styles.navbarContainer} ${isMenuOpen ? styles.navbarContainerOpen : ""}`}
        id="primary-navigation"
      >
        <ul className={styles.navBarMenu}>
          <li className={styles.navItem}>
            <NavLink
              className={getNavLinkClassName}
              to="/"
              end
              onClick={handleNavClick}
            >
              Home
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink
              className={getNavLinkClassName}
              to="/diary"
              onClick={handleNavClick}
            >
              The Diary
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink
              className={getNavLinkClassName}
              to="/athletics"
              onClick={handleNavClick}
            >
              Athletics
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink
              className={getNavLinkClassName}
              to="/family"
              onClick={handleNavClick}
            >
              Family
            </NavLink>
          </li>
        </ul>
      </div>
    </nav>
  );
}

export default NavBar;
