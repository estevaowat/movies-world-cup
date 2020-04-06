using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesWorldCup.Models;
using Newtonsoft.Json;

namespace MoviesWorldCup.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase {
        private readonly IHttpClientFactory _clientFactory;

        private HttpClient Client { get; }
        public MovieController(IHttpClientFactory clientFactory) {
            _clientFactory = clientFactory;
            Client = _clientFactory.CreateClient("apiMovies");
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync() {
            var response = await Client.GetAsync("api/filmes");
            string content = response.Content.ReadAsStringAsync().Result;
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(content);
            return Ok(movies);
        }
    }
}
