import { NavLink } from "react-router-dom";
import styles from "../App.module.css";

function NavBar() {
  return (
    <nav className={styles.navbar} style={{ backgroundColor: "#343a40" }}>
      <NavLink className={styles.navbarBrand} to="/">
        Evan's Diary
      </NavLink>
      <div className={styles.navbarContainer}>
        <ul className={styles.navBarMenu}>
          <li className={styles.navItem}>
            <NavLink className={styles.navLink} to="/">
              Home
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink className={styles.navLink} to="/diary">
              The Diary
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink className={styles.navLink} to="/athletics">
              Athletics
            </NavLink>
          </li>
          <li className={styles.navItem}>
            <NavLink className={styles.navLink} to="/family">
              Family
            </NavLink>
          </li>
        </ul>
      </div>
    </nav>
  );
}

export default NavBar;
