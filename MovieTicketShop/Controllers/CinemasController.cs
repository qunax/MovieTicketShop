using Microsoft.AspNetCore.Mvc;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;
using MovieTicketShop.Services;

namespace MovieTicketShop.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
            _cinemasService = cinemasService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Cinema> allCinemas = await _cinemasService.GetAllCinemas();
            return View(allCinemas);
        }
    }
}
