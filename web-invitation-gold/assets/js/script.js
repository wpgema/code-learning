simplyCountdown('.simply-countdown', {
    year: 2023, // required
    month: 9, // required
    day: 4, // required
    hours: 8, // Default is 0 [0-23] integer
    words: { //words displayed into the countdown
        days: { singular: 'Hari', plural: 'Hari' },
        hours: { singular: 'Jam', plural: 'Jam' },
        minutes: { singular: 'Menit', plural: 'Menit' },
        seconds: { singular: 'Detik', plural: 'Detik' }
    },
});

const hero = document.getElementById('hero')
const main = document.getElementById('main');
const tombol = document.getElementById('a');

hero.style.backgroundImage = "url('assets/img/wedding-1353829_640.jpg')"

main.classList.add('display');

tombol.addEventListener("click", function(){
    main.classList.remove('display')
})

window.addEventListener("scroll", reveal);

function reveal(){
    var reveals = document.querySelectorAll('.reveal');

    for(var i = 0; i < reveals.length; i++){
        var windowHeight = window.innerHeight;
        var revealTop = reveals[i].getBoundingClientRect().top;
        var revealPoint = 80;

        if(revealTop < windowHeight - revealPoint){
            reveals[i].classList.add('active');
        }
        else{
            reveals[i].classList.remove('active')
        }
    }
}