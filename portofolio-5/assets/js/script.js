const tombol = document.getElementById('tombol');
const nav = document.getElementById('nav');
const nav_links = document.querySelectorAll('.nav_link');
const main = document.getElementById('main');
const icons = document.querySelectorAll('i');
const faqs = document.querySelectorAll('.faqs');
const answer = document.querySelector('.answer')

const arr = [nav, main];

nav_links.forEach(n_l => {
    n_l.addEventListener('click', function(){

        document.querySelector('.nav_active')?.classList.remove('nav_active');
        n_l.classList.add('nav_active')

    })

})

tombol.addEventListener('click', function(){
    nav.classList.toggle('nav-toggle');

    setTimeout(function(){
        icons[0].classList.toggle('bi-list')
        icons[0].classList.toggle('bi-x')
    }, 500)

});

for(let i = 0; i < arr.length; i++){
    arr[i].addEventListener('click', function(){
        nav.classList.remove('nav-toggle');
        icons[0].classList.remove('bi-x')
        icons[0].classList.add('bi-list')
    })    
}

faqs.forEach(faq => {
    faq.addEventListener('click', function(){
        faq.classList.toggle('active')
    })
})