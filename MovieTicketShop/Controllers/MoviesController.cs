using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;
using MovieTicketShop.Services;

namespace MovieTicketShop.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Movie> allMovies = await _moviesService.GetAllMovies();
            return View(allMovies);
        }

        public async Task<IActionResult> Filtered()
        {
            IList<Movie> filteredMovies = await _moviesService.GetFilteredMovies();
            return View(filteredMovies);
        }
    }
}
