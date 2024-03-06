const date = new Date();
const spanTime = document.querySelector(".time");
const daysOfWeek = [
    "Chủ nhật",
    "Thứ hai",
    "Thứ ba",
    "Thứ tư",
    "Thứ năm",
    "Thứ sáu",
    "Thứ bảy",
];

function getDayName(dayIndex) {
    return daysOfWeek[dayIndex];
}

const aAllMenu = document.getElementById("a_all_menu");
const wrapMenu = document.getElementById("wrap_menu");
const wrapMainNav = document.getElementById("wrap-main-nav");
const btnCLose = document.getElementById("btn-close-menu");

document.addEventListener("DOMContentLoaded", () => {
    const dayName = getDayName(date.getDay());
    const formattedDate = `${dayName}, ${date.getDate()}/${date.getMonth() + 1
        }/${date.getFullYear()}`;
    spanTime.innerText = formattedDate;

    aAllMenu.addEventListener("click", () => {
        wrapMainNav.classList.toggle("show-all-menu");
    });

    btnCLose.addEventListener("click", () => {
        wrapMainNav.classList.toggle("show-all-menu");
    });

    const headerOffset = wrapMainNav.offsetTop;
    window.addEventListener("scroll", () => {
        if (window.pageYOffset >= headerOffset) {
            wrapMainNav.classList.add("sticky");
        } else {
            wrapMainNav.classList.remove("sticky");
        }
    });
});

const toTop = document.getElementById("to_top");

toTop.addEventListener("click", function () {
    window.scrollTo({
        top: 0,
        behavior: "smooth",
    });
});

function isInViewport(element) {
    var rect = element.getBoundingClientRect();
    return a = (
        rect.top <= 230 &&
        rect.bottom <= 1300
    );
}

function addClassOnScroll() {
    var element = document.querySelector("#startclearfade");
    if (isInViewport(element)) {
        let eFade = document.querySelectorAll(".animatedFadeInUp");
        eFade.forEach(element => {
            element.classList.add("clear-fade");
        });
    }
}

window.addEventListener("scroll", function () {
    addClassOnScroll();
});

window.addEventListener("load", function () {
    addClassOnScroll();
});
