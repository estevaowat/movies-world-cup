using MoviesWorldCup.Interface;
using MoviesWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWorldCup.Services {
    public class ChampionshipService : IChampionshipService {
        public Movie SelectWinner(Movie movie1, Movie movie2) {
            if(movie1.nota > movie2.nota) {
                return movie1;
            }

            if(movie2.nota > movie1.nota) {
                return movie2;
            }
            return String.Compare(movie1.titulo, movie2.titulo) <= 0 ? movie1 : movie2;
        }
    }
}
