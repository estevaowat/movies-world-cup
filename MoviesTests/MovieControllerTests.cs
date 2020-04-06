using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using MoviesWorldCup.Controllers;
using MoviesWorldCup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MoviesTests {
    public class MovieControllerTests {

        private readonly MovieController movieController;



        public MovieControllerTests() {
            movieController = CreateNewInstanceMovieController();
        }

        public MovieController CreateNewInstanceMovieController() {

            var mockFactory = new Mock<IHttpClientFactory>();
            var fixture = new Fixture();
            var listMovies = fixture.Create<List<Movie>>();

            fixture.AddManyTo(listMovies);


            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
       .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
       .ReturnsAsync(new HttpResponseMessage
       {
           StatusCode = HttpStatusCode.OK,
           Content = new StringContent(JsonConvert.SerializeObject(listMovies))
       })
            ;

            var client = new HttpClient(mockHttpMessageHandler.Object)
            {
                BaseAddress = new Uri("http://copafilmes.azurewebsites.net")
            };

            mockFactory.Setup(_ => _.CreateClient("apiMovies")).Returns(client);

            return new MovieController(mockFactory.Object);
        }


        [Fact]
        public async Task GetMovies_ShouldReturnMovieFromApiAsync() {

            var result = await movieController.GetAsync();

            result.Should().NotBeNull();

        }
    }
}
