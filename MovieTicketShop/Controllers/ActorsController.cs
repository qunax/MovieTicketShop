using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;



        public ActorsController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            List<Actor> allActors = await _context.Actors.ToListAsync();
            return View(allActors);
        }
    }
}
