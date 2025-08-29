const body = document.body;
const container = document.querySelector(".movie-container");
const keyword = document.getElementById("input-keyword");
const modalBody = document.querySelector(".modal-body");

function getMovies(keyword){
    return fetch("http://www.omdbapi.com/?apikey=a129207&s=" + keyword)
            .then(response => {
                if(!response.ok){
                    throw new Error("Internal Server Error");
                }
                return response.json();
            })
            .then(response => {
                if(!response.Search){
                    throw new Error("Film Not Found");
                }
                return response.Search;
            })
}

function getDetailMovie(imdb){
    return fetch("http://www.omdbapi.com/?apikey=a129207&i=" + imdb)
            .then(response => {
                if(!response.ok){
                    throw new Error("Internal Server Error");
                }
                return response.json();
            })
            .then(response => {
                if(!response){
                    throw new Error("Detail Movie Not Found");
                }
                return response;
            })
}

body.addEventListener('click', async e => {
    if(e.target.className == 'btn btn-primary search-button'){
        container.innerHTML = '';
        try{
            let movies = await getMovies(keyword.value);
            let cards = addUI(movies);
            container.innerHTML = cards;
        } catch(error){
            container.textContent = error;
        }
    }
})

body.addEventListener('click', async e => {
    if(e.target.classList.contains("modal-detail-button")){
        modalBody.innerHTML = '';
        const imdb = e.target.dataset.imdbid;
        try{
            let detailMovie = await getDetailMovie(imdb);
            let movie = showMovieDetail(detailMovie);
            modalBody.innerHTML = movie;
        } catch (error){
            modalBody.textContent = error;
        }
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