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
                id = "tt4881806",
                titulo = "Jurassic World: Reino Ameaçado",
                ano= 2018,
                nota= 6.7f
            };


            var movie2 = new Movie()
            {
                id = "tt3606756",
                titulo = "Os Incríveis 2",
                ano = 2018,
                nota = 8.5f
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
                id = "tt4881806",
                titulo = "Jurassic World: Reino Ameaçado",
                ano = 2018,
                nota = 6.7f
            };


            var movie2 = new Movie()
            {
                id = "tt3606756",
                titulo = "O fantastica fabrica de chocolate",
                ano = 2018,
                nota = 6.7f
            };

            //Act
            var result = championshipService.SelectWinner(movie1, movie2);
             
            //Assert
            result.Should().Be(movie1);

        }
    }
}
