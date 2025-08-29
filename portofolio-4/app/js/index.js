const toggle = document.getElementById("toggle");
const navbar = document.querySelector(".navbar");
toggle.addEventListener("click", () => {
    navbar.classList.toggle("appear");
    const toggle_top = document.querySelector(".toggle-top");
    const toggle_center = document.querySelector(".toggle-center");
    const toggle_bottom = document.querySelector(".toggle-bottom");
    if(navbar.classList.contains("appear")){
        toggle_bottom.style.display = "none";
        toggle_top.style.transform = "rotate(45deg)";
        toggle_center.style.transform = "rotate(-45deg) translateX(6px)  translateY(-6px)";
    } else {
        toggle_bottom.style.display = "block";
        toggle_top.style.transform = "rotate(0)";
        toggle_center.style.transform = "rotate(0) translateX(0)  translateY(0)";
    }
})

const main = document.getElementById("main");
main.addEventListener("click", function(){
    const toggle_top = document.querySelector(".toggle-top");
    const toggle_center = document.querySelector(".toggle-center");
    const toggle_bottom = document.querySelector(".toggle-bottom");
    if(navbar.classList.contains("appear")){
        navbar.classList.remove("appear");
        toggle_bottom.style.display = "block";
        toggle_top.style.transform = "rotate(0)";
        toggle_center.style.transform = "rotate(0) translateX(0)  translateY(0)";
    }
});

window.addEventListener("scroll", function(){
    const toggle_top = document.querySelector(".toggle-top");
    const toggle_center = document.querySelector(".toggle-center");
    const toggle_bottom = document.querySelector(".toggle-bottom");
    if(navbar.classList.contains("appear")){
        navbar.classList.remove("appear");
        toggle_bottom.style.display = "block";
        toggle_top.style.transform = "rotate(0)";
        toggle_center.style.transform = "rotate(0) translateX(0)  translateY(0)";
    }
});