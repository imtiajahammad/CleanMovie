using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanMovie.Domain;

namespace CleanMovie.Application;
// this is a use case
public interface IMovieService
{
    List<Movie> GetAllMovies();
    Movie CreateMovie(Movie movie);
}
