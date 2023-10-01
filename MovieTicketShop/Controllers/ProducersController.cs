using Microsoft.AspNetCore.Mvc;
using MovieTicketShop.Models;
using MovieTicketShop.Services;

namespace MovieTicketShop.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _producersService;

        public ProducersController(IProducersService producersService)
        {
            _producersService = producersService;
        }

        public async Task<IActionResult> Index()
        {
            IList<Producer> allProducers = await _producersService.GetAllProducers();
            return View(allProducers);
        }
    }
}
