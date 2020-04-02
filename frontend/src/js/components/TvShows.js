export default function TvShows(tvShows){
    return `
    <h2>All TV Shows</h2>
        <div class="tvShows__grid_container">
            ${tvShows.map(tvShow => {
                return `
                <div class="tvShows__specific_tvShow"
                    <h4 class="tvShow__name_btn">${tvShow.name}</h4>
                    <input class="tvShow__id" type="hidden" value="${tvShow.id}">
                </div>
               `
        }).join("")}
        </div>
    `
}