const body = document.body;
const header = document.getElementsByTagName("header");
const icon = document.getElementsByTagName("i");

body.addEventListener("click", function(e){
    if(e.target.className == "bi bi-brightness-high-fill"){
        header[0].classList.add("bg-light")
        body.classList.add("dark")
        icon[0].classList.replace("bi-brightness-high-fill", "bi-moon-fill")
    } else if(e.target.className == "bi bi-moon-fill"){
        header[0].classList.remove("bg-light")
        body.classList.remove("dark")
        icon[0].classList.replace("bi-moon-fill", "bi-brightness-high-fill")
    }
})
