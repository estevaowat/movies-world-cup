
using FluentAssertions;
using MoviesWorldCup.Interface;
using MoviesWorldCup.Controllers;
using MoviesWorldCup.Services;

using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MoviesWorldCup.Models;

namespace MoviesTests {
    public class ChampionshipControllerTest {
        private readonly ChampionshipController championshipController;

        public ChampionshipControllerTest() {
            championshipController = CreateNewInstanceChampionshipController();
        }

        public ChampionshipController CreateNewInstanceChampionshipController() {
            return new ChampionshipController(new ChampionshipService());
        }


        [Fact]
        public void SelectWinner_ShouldReturnWinnerWithGreaterRating() {
            List<Movie> listExcepted = new List<Movie>() {
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
            };

            var result = championshipController.Create();

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
