export function addUI(movies){
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