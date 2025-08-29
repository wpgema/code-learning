const toggleTombol = document.getElementById('nav-togle');
const navToggle = document.getElementById('nav');
const main = document.getElementById('main');
const tagline = document.getElementById('tagline');

toggleTombol.addEventListener("click", function(){
    navToggle.classList.toggle("nav-togle");
    tagline.classList.toggle('margin-top');

    navToggle.addEventListener("click", function(){
        navToggle.classList.remove("nav-togle");
        tagline.classList.remove('margin-top');
    });

    main.addEventListener("click", function(){
        navToggle.classList.remove("nav-togle");
        tagline.classList.remove('margin-top');
    });
})