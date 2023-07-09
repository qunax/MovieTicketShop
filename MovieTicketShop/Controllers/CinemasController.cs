using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;



        public CinemasController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            List<Cinema> allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
