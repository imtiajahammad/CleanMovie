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
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            this._movieDbContext = movieDbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}