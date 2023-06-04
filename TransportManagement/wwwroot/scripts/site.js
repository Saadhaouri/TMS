﻿//Change image avatar when a file is selected
function changeAvatarImage(e) {
    let avatar = document.getElementById("avatar");
    avatar.src = URL.createObjectURL(e.files[0]);
    avatar.style.height = "250px";
    avatar.style.width = "250px";
}
//change pageSize pagination

const defaultPage = 1;
const defaultPageSize = document.getElementById("pageSize") != null ? document.getElementById("pageSize").value : 0;
const domain = window.location.origin;
const path = window.location.pathname;
let pathArr = path.split("/");

function changePageSize(el) {
    if (path == "/") {
        window.location.href = `/home/index?page${defaultPage}/${el.value}`;
    } else if (pathArr[2] == null) {
        window.location.href = `${domain}/${pathArr[1]}/Index?page=${defaultPage}&pageSize=${el.value}`;
    } else {
        window.location.href = `${domain}/${pathArr[1]}/${pathArr[2]}?page=${defaultPage}&pageSize=${el.value}`;
    }
}

//Search function

function searchKeyword(el) {
    if (path == "/") {
        window.location.href = `/home/index/${defaultPage}?page=${defaultPageSize}&search=${el.value}`;
    } else if (pathArr[2] == null) {
        window.location.href = `${domain}/${pathArr[1]}/Index?page=${defaultPage}&pageSize=${defaultPageSize}&search=${el.value}`;
    } else {
        window.location.href = `${domain}/${pathArr[1]}/${pathArr[2]}?page=${defaultPage}&pageSize=${defaultPageSize}&search=${el.value}`;
    }
}

//disable first last button at pagination

const pageLinks = document.getElementsByClassName("page-link");
if (pageLinks.length > 0) {

    const currentLocation = location.href;
    for (var i = 2; i < pageLinks.length - 2; i++) {
        pageLinks[i].parentElement.classList.remove("active");
        if (pageLinks[i].href === currentLocation) {
            pageLinks[i].parentElement.classList.add("active")
        }
    }

    if (currentLocation === pageLinks[0].href || currentLocation === `${window.location.origin}/`) {
        pageLinks[0].parentElement.classList.add("disabled")
        pageLinks[1].parentElement.classList.add("disabled")
    }

    if (currentLocation == pageLinks[pageLinks.length - 1].href) {
        pageLinks[pageLinks.length - 1].parentElement.classList.add("disabled")
        pageLinks[pageLinks.length - 2].parentElement.classList.add("disabled")
    }
}
//notification system
const notfication = document.getElementById("notification-response");
if (notfication != null) {
    if (notfication.innerHTML !== "") {
        setTimeout(function () {
            notfication.style.opacity = "0";
            setTimeout(function () { notfication.style.display = "none" }, 1500);
        }, 3000);
    }
}

////make active
//function makeactive() {
//   const navlinks = document.getelementsbyclassname("nav-link");
//    const url = window.location.pathname;
//    for (var i = 0; i < navlinks.length; i++) {
//       if (url === navlinks[i]) {
//            navlinks[i].classlist.add("active");
//           return
//       }if (url !== "/" && url.indexof(navlinks[i] !== -1)){
//            navlinks[i].classlist.add("active");
//           return
//        }
//    }
//}

//show homepage button when driver login in mobile
const hompageBtnMobile = document.getElementById("HomeMobile");
if (hompageBtnMobile != null) {
    if (screen.width <= 699) {
        hompageBtnMobile.classList.remove("d-none");
    }
}

//loader

$(window).on("load", function () {
    // Animate loader off screen
    $(".loader-wrapper").fadeOut("slow");;
});

