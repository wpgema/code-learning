const toggleTombol = document.getElementById('tombol');
const navToggle = document.getElementById('nav');

toggleTombol.addEventListener("click", function(){
    navToggle.classList.toggle("nav-toggle");
});

// const nav_link = document.querySelectorAll('.nav-link');

// nav_link.forEach(navlinkEl => {
//     navlinkEl.addEventListener("click", () => {
//         document.querySelector('.active').classList.remove('active');
//         navlinkEl.classList.add('active');

//         event.preventDefault();
//     });
// });