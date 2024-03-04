using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _service;

    public MoviesController(IMovieService service)
    {
        this._service = service;
    }

    [HttpGet]
    public ActionResult<List<Movie>> Get()
    {
        var moviesFromService = _service.GetAllMovies();
        return Ok(moviesFromService);
    }
}
