using FluentAssertions;
using MoviesWorldCup.Interface;
using MoviesWorldCup.Models;
using MoviesWorldCup.Services;
using System;
using Xunit;

namespace MoviesTests {
    public class ChampionshipServiceTests {

        private readonly IChampionshipService championshipService;

        public ChampionshipServiceTests() {
            championshipService = CreateNewInstanceChampionshipService();
        }

        public IChampionshipService CreateNewInstanceChampionshipService() {
            return new ChampionshipService();
        }


        [Fact]
        public void SelectWinner_ShouldReturnWinnerWithGreaterRating() {
            //Arrange
            var movie1 = new Movie()
            {
                Id = "tt4881806",
                Title = "Jurassic World: Reino Ameaçado",
                ReleaseYear = 2018,
                Rating = 6.7f
            };


            var movie2 = new Movie()
            {
                Id = "tt3606756",
                Title = "Os Incríveis 2",
                ReleaseYear = 2018,
                Rating = 8.5f
            };

            //Act
            var result = championshipService.SelectWinner(movie1, movie2);
             
            //Assert
            result.Should().Be(movie2);

        }


        [Fact]
        public void SelectWinner_ShouldReturnJurassicWorld() {
            //Arrange
            var movie1 = new Movie()
            {
                Id = "tt4881806",
                Title = "Jurassic World: Reino Ameaçado",
                ReleaseYear = 2018,
                Rating = 6.7f
            };


            var movie2 = new Movie()
            {
                Id = "tt3606756",
                Title = "O fantastica fabrica de chocolate",
                ReleaseYear = 2018,
                Rating = 6.7f
            };

            //Act
            var result = championshipService.SelectWinner(movie1, movie2);
             
            //Assert
            result.Should().Be(movie1);

        }
    }
}
