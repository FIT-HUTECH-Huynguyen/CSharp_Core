// time
const date = new Date();
const spanTime = document.querySelector(".time-d");
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

document.addEventListener("DOMContentLoaded", () => {
  const dayName = getDayName(date.getDay());
  const formattedDate = `${dayName}, ngày ${date.getDate()}-${
    date.getMonth() + 1
  }-${date.getFullYear()}`;
  spanTime.innerText = formattedDate;
});

const formSearchMenu = document.getElementById("form-search-menu");
const btnSearchMenu = document.getElementById("header-search-menu");
const inpSearch = document.querySelector(".input-search");
const header = document.getElementById("div-header");
const btnShowProvince = document.getElementById("btn-show-province");
const boxWeather = document.querySelector(".box_weather");
const toTop = document.getElementById("back-to-top");

document.addEventListener("click", (e) => {
  if (btnSearchMenu.contains(e.target)) {
    formSearchMenu.classList.toggle("show");
  } else if (! inpSearch.contains(e.target) && ! btnSearchMenu.contains(e.target) && formSearchMenu.classList.contains("show")) {
    formSearchMenu.classList.remove("show");
  }
});

window.addEventListener("scroll", function () {
  if (window.scrollY > 50) {
    header.classList.add("sticky_header");
    toTop.classList.add("show");
  } else {
    header.classList.remove("sticky_header");
    toTop.classList.remove("show");
  }
});

btnShowProvince.addEventListener("click", () => {
    boxWeather.classList.toggle("active_box_weather");
})

// search
const searchInput = document.querySelector('.search_city');
const cityList = document.querySelectorAll('.itemWeather');

searchInput.addEventListener('input', function() {
    const searchTerm = this.value.toLowerCase();
    
    cityList.forEach(city => {
        const cityName = city.querySelector('.label').textContent.toLowerCase();
        
        if (cityName.includes(searchTerm)) {
            city.style.display = 'flex';
        } else {
            city.style.display = 'none';
        }
    });
});

toTop.addEventListener("click", function () {
  window.scrollTo({
    top: 0,
    behavior: "smooth",
  });
});

// Swiper Tab
const swiperView = document.getElementById("swiper-views");
const swiperStar = document.getElementById("swiper-views1");
const selectMenuView = document.querySelectorAll(".box-category-view-title");
const menuView = selectMenuView[0];
const menuStar = selectMenuView[1];

menuView.addEventListener("click", () => {
    if(! menuView.classList.contains("active_tab") && menuStar.classList.contains("active_tab")) {
        menuView.classList.add("active_tab");
        swiperView.style.setProperty("display", "block", "important");
        menuStar.classList.remove("active_tab");
        swiperStar.style.setProperty("display", "none", "important");
    }
})

menuStar.addEventListener("click", () => {
    if(! menuStar.classList.contains("active_tab") && menuView.classList.contains("active_tab")) {
        menuStar.classList.add("active_tab");
        swiperStar.style.setProperty("display", "block", "important");
        menuView.classList.remove("active_tab");
        swiperView.style.setProperty("display", "none", "important");
    }
})

// part2
const menuItem = document.querySelectorAll(".menu-item-2");

let elementActiveTab2 = menuItem[0];
let divActiveTab2 = document.querySelector(".home-anh-sw");

function changeTabMenuItem(element){
    const swiperAnh = document.querySelector(".home-anh-sw");
    const swiperMaga = document.querySelector(".home-maga-sw");
    const swiperInfog = document.querySelector(".home-infog-sw");

    const nameTab = element.dataset.swTab;

    console.log(element, nameTab, elementActiveTab2, divActiveTab2);
    if(nameTab === "home-anh-sw") {
        elementActiveTab2.classList.remove("active_tab");
        divActiveTab2.style.setProperty("display", "none", "important");
        menuItem[0].classList.add("active_tab");
        swiperAnh.style.setProperty("display", "block", "important");
        elementActiveTab2 = menuItem[0];
        divActiveTab2 = swiperAnh;
    } else if (nameTab === "home-maga-sw") {
        elementActiveTab2.classList.remove("active_tab");
        divActiveTab2.style.setProperty("display", "none", "important");
        menuItem[1].classList.add("active_tab");
        swiperMaga.style.setProperty("display", "block", "important");
        elementActiveTab2 = menuItem[1];
        divActiveTab2 = swiperMaga;
    } else if (nameTab === "home-infog-sw") {
        elementActiveTab2.classList.remove("active_tab");
        divActiveTab2.style.setProperty("display", "none", "important");
        menuItem[2].classList.add("active_tab");
        swiperInfog.style.setProperty("display", "block", "important");
        elementActiveTab2 = menuItem[2];
        divActiveTab2 = swiperInfog;
    }
}

menuItem.forEach((e) => {
    e.addEventListener("click", (e) => {
        changeTabMenuItem(e.target);
    })
})