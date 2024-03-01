using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanMovie.Domain;

namespace CleanMovie.Application;

public interface IMovieRepository
{
    List<Movie> GetAllMovies();
    
}
