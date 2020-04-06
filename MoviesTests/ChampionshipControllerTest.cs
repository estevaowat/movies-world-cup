
using FluentAssertions;
using MoviesWorldCup.Interface;
using MoviesWorldCup.Controllers;
using MoviesWorldCup.Services;

using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MoviesWorldCup.Models;
using AutoFixture;

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
            var fixture = new Fixture();
            var listMovies = fixture.Create<List<Movie>>();

            fixture.RepeatCount = 8;
            fixture.AddManyTo(listMovies);

            var result = championshipController.Post(listMovies);

            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
