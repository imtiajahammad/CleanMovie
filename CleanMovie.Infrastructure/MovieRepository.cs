using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>(){
            new Movie { Id = 1, Name = "Passion of Christ", Cost=2 },
            new Movie { Id = 2, Name = "Home Along 4", Cost=3 }
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}