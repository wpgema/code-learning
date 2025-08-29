export function showMovieDetail(m){
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