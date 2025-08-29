export function getDetailMovie(imdb){
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