using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;



        public ProducersController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            List<Producer> allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
