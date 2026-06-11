import styles from "./HospitalDashboard.module.css";
import { Link } from "react-router-dom";
import { hospitalDiaryEntries } from "../data/hospitalDashboard";

function HospitalDashboard() {
  return (
    <main className={styles.page}>
      <section aria-label="Hospital diary">
        <h1>Caroline's Hospital Diary</h1>
        <h2>Introduction</h2>
        <p>
          I'm not writing this diary to be morbid but as a reminder to myself of
          the reason why I want to ensure that I stay fit and healthy so that I
          never have to go through it again.
        </p>
        <ul
          className={styles.list}
          aria-label={`text links to hospital diary entries`}
        >
          {hospitalDiaryEntries.map((title, index) => {
            return (
              <li key={`diary-nav-${index}`} className={styles.item}>
                <Link className={styles.link} to={`/hospital/day/${index + 1}`}>
                  {title}
                </Link>
              </li>
            );
          })}
        </ul>
      </section>
    </main>
  );
}

export default HospitalDashboard;
