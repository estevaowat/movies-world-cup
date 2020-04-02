using MoviesWorldCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWorldCup.Interface {
    public interface IChampionshipService {
        public Movie SelectWinner(Movie movie1, Movie movie2);
    }
}
