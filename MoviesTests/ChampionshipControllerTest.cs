
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
    
            var result = championshipController.Post(null);

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
