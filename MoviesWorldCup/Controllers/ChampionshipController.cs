using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesWorldCup.Interface;
using MoviesWorldCup.Models;

namespace MoviesWorldCup.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase {
        private IChampionshipService _championshipService;

        public ChampionshipController(IChampionshipService championshipService) {
            _championshipService = championshipService;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(new { ok = true });
        }

        public IActionResult Post([FromBody] List<Movie> listMovies) {

            List<Movie> listWinners = new List<Movie>();
            int rounds = (listMovies.Count / 2) - 1;
            Movie secondPlace = null;

            listMovies.OrderBy(m => m.titulo);


            for(var i = rounds; i > 0; i--) {
                if(listWinners.Count > 0) {

                    listMovies.AddRange(listWinners);
                    listWinners.Clear();
                }


                while(listMovies.Count > 0) {

                    var firstMovie = listMovies.First();
                    var lastMovie = listMovies.Last();

                    var movieWinner = _championshipService.SelectWinner(firstMovie, lastMovie);
                     
                    secondPlace = movieWinner != firstMovie ? firstMovie : lastMovie;
                     
                    listMovies.Remove(firstMovie);
                    listMovies.Remove(lastMovie);
                    listWinners.Add(movieWinner);
                }
            }
            listWinners.Add(secondPlace);
            return Ok(listWinners);
        }
    }
}
