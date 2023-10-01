using Microsoft.AspNetCore.Mvc;
using MovieTicketShop.Models;
using MovieTicketShop.Services;

namespace MovieTicketShop.Controllers
{
    public class ActorsController : Controller
    {
        
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Actor> allActors = await _actorsService.GetAllActors();
            return View(allActors);
        }
    }
}
