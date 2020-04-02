using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesWorldCup.Models;

namespace MoviesWorldCup.Controllers {
    public class ChampionshipController : Controller {
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
                    Rating = 8.5
                },
                new Movie
                {
                    Id = "tt4881806",
                    Title = "Jurassic World: Reino Ameaçado",
                    ReleaseYear = 2018,
                    Rating = 6.7
                },
                new Movie
                {
                    Id = "tt5164214",
                    Title = "Oito Mulheres e um Segredo",
                    ReleaseYear = 2018,
                    Rating = 6.3
                },
                new Movie
                {
                    Id = "tt7784604",
                    Title = "Hereditário",
                    ReleaseYear = 2018,
                    Rating = 7.8
                },
                new Movie
                {
                    Id = "tt4154756",
                    Title = "Vingadores: Guerra Infinita",
                    ReleaseYear = 2018,
                    Rating = 8.8
                },
                new Movie
                {
                    Id = "tt5463162",
                    Title = "Deadpool 2",
                    ReleaseYear = 2018,
                    Rating = 8.1
                },
                 new Movie
                {
                    Id = "tt3778644",
                    Title = "Han Solo: Uma História Star Wars",
                    ReleaseYear = 2018,
                    Rating = 7.2
                },
                 new Movie
                {
                    Id = "tt3501632",
                    Title = "Thor: Ragnarok",
                    ReleaseYear = 2017,
                    Rating = 7.9
                }
            };

            listMovies.OrderBy(m => m.Title);




        }

        public Movie SelectWinner(Movie movie1, Movie movie2) {
            if(movie1.Rating > movie2.Rating) { }
        
        
        }


    }
}