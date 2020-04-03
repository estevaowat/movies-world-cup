using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesWorldCup.Interface;
using MoviesWorldCup.Models;

namespace MoviesWorldCup.Controllers {
    public class ChampionshipController : Controller {
        private readonly IChampionshipService _championshipService;

        public ChampionshipController(IChampionshipService championshipService) {
            _championshipService = championshipService;
        }

        // POST: Championship/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create() {
            List<Movie> listMovies = new List<Movie>
            {
                new Movie
                {
                    Id = "tt3606756",
                    Title = "Os Incríveis 2",
                    ReleaseYear = 2018,
                    Rating = 8.5f
                },
                new Movie
                {
                    Id = "tt4881806",
                    Title = "Jurassic World: Reino Ameaçado",
                    ReleaseYear = 2018,
                    Rating = 6.7f
                },
                new Movie
                {
                    Id = "tt5164214",
                    Title = "Oito Mulheres e um Segredo",
                    ReleaseYear = 2018,
                    Rating = 6.3f
                },
                new Movie
                {
                    Id = "tt7784604",
                    Title = "Hereditário",
                    ReleaseYear = 2018,
                    Rating = 7.8f
                },
                new Movie
                {
                    Id = "tt4154756",
                    Title = "Vingadores: Guerra Infinita",
                    ReleaseYear = 2018,
                    Rating = 8.8f
                },
                new Movie
                {
                    Id = "tt5463162",
                    Title = "Deadpool 2",
                    ReleaseYear = 2018,
                    Rating = 8.1f
                },
                 new Movie
                {
                    Id = "tt3778644",
                    Title = "Han Solo: Uma História Star Wars",
                    ReleaseYear = 2018,
                    Rating = 7.2f
                },
                 new Movie
                {
                    Id = "tt3501632",
                    Title = "Thor: Ragnarok",
                    ReleaseYear = 2017,
                    Rating = 7.9f
                }
            };
            List<Movie> listWinners = new List<Movie>();
            int rounds = (listMovies.Count / 2) - 1;
            Movie secondPlace = null;

            listMovies.OrderBy(m => m.Title);


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