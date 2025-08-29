export function getMovies(keyword){
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