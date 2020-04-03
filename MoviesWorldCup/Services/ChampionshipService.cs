using MoviesWorldCup.Interface;
using MoviesWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWorldCup.Services {
    public class ChampionshipService : IChampionshipService {
        public Movie SelectWinner(Movie movie1, Movie movie2) {

            if(movie1.Rating > movie2.Rating) {
                return movie1;
            }

            if(movie2.Rating > movie1.Rating) {
                return movie2;
            }


            return String.Compare(movie1.Title, movie2.Title) <= 0 ? movie1 : movie2;
             







        }
    }
}
