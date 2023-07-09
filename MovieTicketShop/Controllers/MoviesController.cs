using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;


        public MoviesController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            List<Movie> allMovies = await _context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}
