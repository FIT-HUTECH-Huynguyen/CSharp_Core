const btnOpenPopupMenu = document.getElementById("btn_open_popup_menu");
const menuPopup = document.getElementById("menu_popup");

document.addEventListener("DOMContentLoaded", () => {
    btnOpenPopupMenu.addEventListener("click", () => {
        btnOpenPopupMenu.classList.toggle("active");
        menuPopup.classList.toggle("active");
    })
})