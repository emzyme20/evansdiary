import { useState } from "react";
import styles from "./DocumentPopout.module.css";

interface DocumentViewerProps {
  buttonText: string;
  documentUrl: string;
}

export function DocumentViewer({
  buttonText,
  documentUrl,
}: DocumentViewerProps) {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <div className={styles.documentViewer}>
      {/* Clicking this link triggers our clean layout popup instead of a download */}
      <button onClick={() => setIsOpen(true)} className={styles.linkButton}>
        {buttonText}
      </button>

      {isOpen && (
        <div className={styles.modalOverlay} onClick={() => setIsOpen(false)}>
          <div
            className={styles.modalContent}
            onClick={(e) => e.stopPropagation()}
          >
            <button
              className={styles.closeBtn}
              onClick={() => setIsOpen(false)}
            >
              X
            </button>

            {/* The iframe cleanly loads the PDF inside the page layout */}
            <iframe
              src={documentUrl}
              title="Document Viewer"
              className={styles.iframeViewer}
            />
          </div>
        </div>
      )}
    </div>
  );
}
