const reveal = (el, cls, point) => {
    if(el){
        for(let i = 0; i < el.length; i++){
            let windowHeight = window.innerHeight;
            let revealTop = el[i].getBoundingClientRect().top;
            let revealPoint = point;
            if(revealTop < windowHeight - revealPoint){
                el[i].classList.remove('display-none');
                el[i].classList.add(cls);
            } else {
                el[i].classList.remove(cls);
            }
        }
    }
}

const revealAbout = () => {
    let reveals = document.querySelectorAll(".reveal");
    reveal(reveals, 'active', 160)
}

const revealCardServices = () => {
    let card = document.getElementById("container-services").children;
    reveal(card, 'upAnimate', 150)
}

const revealCardProjectComplete = () => {
    let card = document.getElementById("container-project-complete").children;
    reveal(card, 'upAnimate', 150)
}

const revealCardProvide = () => {
    let card = document.getElementById("container-provide").children;
    reveal(card, 'upAnimate', 150)
}

const revealCardProvide2 = () => {
    let card = document.getElementById("container-provide2").children;
    reveal(card, 'upAnimate', 150)
}

const revealCardAnswer = () => {
    let card = document.getElementById("faq").children;
    reveal(card, 'upAnimate', 140)
}

const revealCardIMG = () => {
    let card = document.querySelectorAll(".img-laptop");
    reveal(card, 'upAnimate', 100)
}

const revealTitle = () => {
    let title = document.querySelectorAll(".title");
    reveal(title, 'upAnimate', 140)
}

const revealSpan = () => {
    let about = document.getElementById("about");
    let span = about.querySelectorAll("span");
    reveal(span, 'downAnimate', 150)
}

window.addEventListener("scroll", revealTitle)
window.addEventListener("scroll", revealAbout)
window.addEventListener("scroll", revealSpan)
window.addEventListener("scroll", revealCardServices)
window.addEventListener("scroll", revealCardProjectComplete)
window.addEventListener("scroll", revealCardProvide)
window.addEventListener("scroll", revealCardProvide2)
window.addEventListener("scroll", revealCardAnswer)
window.addEventListener("scroll", revealCardIMG)