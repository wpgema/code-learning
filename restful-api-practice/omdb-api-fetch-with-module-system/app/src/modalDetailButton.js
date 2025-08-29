import {body, modalBody} from './init.js';
import {getDetailMovie} from './getDetailMovie.js';
import {showMovieDetail} from './showMovieDetail.js';

export let fModalBody = () => {
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
}