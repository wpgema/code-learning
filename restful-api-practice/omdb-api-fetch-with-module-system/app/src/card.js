import {body, container, keyword} from './init.js';
import {getMovies} from './getMovies.js';
import {addUI} from './addUi.js';

export let fContainer = () => {
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
}