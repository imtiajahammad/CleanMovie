using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanMovie.Domain;

namespace CleanMovie.Application;

public class MovieService : IMovieService
{
    public readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
            this._movieRepository = movieRepository;
    }
    public List<Movie> GetAllMovies()
    {
        var movies = _movieRepository.GetAllMovies();
        return movies;
    }
}
