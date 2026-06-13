document.addEventListener("DOMContentLoaded", () => {
  // Create modal elements dynamically so you don't break your HTML layout
  const modal = document.createElement("div");
  modal.id = "lightboxModal";
  modal.style.cssText = "display:none; position:fixed; z-index:9999; left:0; top:0; width:100%; height:100%; background-color:rgba(0,0,0,0.9); align-items:center; justify-content:center; cursor:pointer;";

  const modalImg = document.createElement("img");
  modalImg.style.cssText = "max-width:85%; max-height:85%; margin:auto; display:block; border:3px solid white; border-radius:4px;";

  const closeBtn = document.createElement("span");
  closeBtn.innerHTML = "&times;";
  closeBtn.style.cssText = "position:absolute; top:20px; right:35px; color:white; font-size:60px; font-weight:bold; cursor:pointer;";

  // Assemble the modal elements
  modal.appendChild(closeBtn);
  modal.appendChild(modalImg);
  document.body.appendChild(modal);

  // Find all images inside your main website content area
  const images = document.querySelectorAll("main img, .gallery img, content img, body > img");

  images.forEach(img => {
    img.style.cursor = "pointer"; // Make it look clickable
    img.addEventListener("click", () => {
      modalImg.src = img.src;
      modal.style.display = "flex";
    });
  });

  // Close when clicking the 'X' or background
  closeBtn.addEventListener("click", () => modal.style.display = "none");
  modal.addEventListener("click", (e) => {
    if (e.target === modal) modal.style.display = "none";
  });
});
