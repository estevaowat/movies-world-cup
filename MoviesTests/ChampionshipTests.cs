using MoviesWorldCup.Models;
using System;
using Xunit;

namespace MoviesTests {
    public class ChampionshipTests {

        public ChampionshipTests() {
 
        }


        [Fact]
        public void SelectWinner_ShouldReturnWinner() {
            //Arrange
            var movie1 = new Movie()
            {
                Id = "tt3606756",
                Title = "Os Incríveis 2",
                ReleaseYear = 2018,
                Rating = 8.5
            };

            var movie2 = new Movie()
            {
                Id = "tt4881806",
                Title = "Jurassic World: Reino Ameaçado",
                ReleaseYear = 2018,
                Rating = 6.7
            };

            //Act



        }
    }
}
