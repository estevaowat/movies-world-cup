using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWorldCup.Models {
    public class Movie {
        public string Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public float Rating { get; set; }
    }
}
