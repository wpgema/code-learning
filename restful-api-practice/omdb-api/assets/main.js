const body = document.body;
const container = document.querySelector(".movie-container");
const keyword = document.getElementById("input-keyword");
const modalBody = document.querySelector(".modal-body");

body.addEventListener('click', function(e){
    if(e.target.className == 'btn btn-primary search-button'){
        container.innerHTML = '';

        let err = document.createElement("p");
        let valKeyword = keyword.value;

        let xhr = new XMLHttpRequest();
        xhr.onreadystatechange = () => {
            if(xhr.readyState == 4){
                if(xhr.status == 200){
                    let response = xhr.responseText;
                    let movies = JSON.parse(response);
                    movies = movies.Search;
                    container.innerHTML = addUI(movies);

                    // request ajax untuk detail film
                    const modal = document.querySelectorAll(".modal-detail-button");
                    modal.forEach(m => {
                        m.addEventListener("click", ()=>{
                            modalBody.innerHTML = '';

                            m.addEventListener("click", ()=>{
                                const imdb = m.getAttribute('data-imdbid')
                                let xhr = new XMLHttpRequest();
                                xhr.onreadystatechange = ()=>{
                                    if(xhr.readyState == 4 && xhr.status == 200){
                                        let response = xhr.responseText;
                                        let movie = JSON.parse(response);
                                        modalBody.innerHTML = showMovieDetail(movie);
                                    }
                                }
                                xhr.open("GET", "http://www.omdbapi.com/?apikey=a129207&i=" + imdb, true);
                                xhr.send();
                            })
                        })
                    })

                } else {
                    // ketika keyword invalid
                    err.textContent = "Check your keyword";
                    container.appendChild(err);
                }
            } else {
                // ketika url salah
                err.textContent = "film not found";
                container.appendChild(err);
            }
        }
        xhr.open("GET", "http://www.omdbapi.com/?apikey=a129207&s=" + valKeyword, true);
        xhr.send();
    }
    
})




function addUI(movies){
    let card = ''
    movies.forEach(m =>{
        card += `<div class="col-md-4 my-2 d-flex justify-content-center">
                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="${m.Poster}" alt="">
                        <div class="card-body">
                            <h5 class="card-title">${m.Title}</h5>
                            <h6 class="card-subtitle mb-2 text-muted">${m.Year}</h6>
                            <button href="#" class="btn btn-primary modal-detail-button" data-toggle="modal" data-target="#exampleModal" data-imdbid="${m.imdbID}">Show Detail</button>
                        </div>
                    </div>
                </div>`;
    })

    return card;
}

function showMovieDetail(m){
    return `
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3 d-flex justify-content-center align-items-center">
                <img src="${m.Poster}" alt="" class="img-fluid">
            </div>
            <div class="col-md">
                <ul class="list-group">
                <li class="list-group-item"><h4>${m.Title} (${m.Year})</h4></li>
                <li class="list-group-item"><strong>Director : </strong> ${m.Director}</li>
                <li class="list-group-item"><strong>Actors : </strong> ${m.Actor}</li>
                <li class="list-group-item"><strong>Writer : </strong> ${m.Writer}</li>
                <li class="list-group-item"><strong>Plot : </strong> <br> ${m.Plot} </li>
            </ul>
            </div>
        </div>
    </div>`;
}