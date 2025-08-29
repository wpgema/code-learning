const toggleTombol = document.getElementById('nav-togle');
const navToggle = document.getElementById('nav');
const header = document.getElementById('header');
const home = document.getElementById('home');
const main = document.getElementById('main');
const footer = document.getElementById('footer');

toggleTombol.addEventListener("click", function(){
    navToggle.classList.toggle("nav-togle")

    nav.addEventListener("click", function(){
        navToggle.classList.remove("nav-togle")
    })

    main.addEventListener("click", function(){
        navToggle.classList.remove("nav-togle")
    })

    footer.addEventListener("click", function(){
        navToggle.classList.remove("nav-togle")
    })
})