using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Services
{ 
    public interface IActorsService
    {
        public Task<IList<Actor>> GetAllActors();
    }

    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Actor>> GetAllActors()
        {
            List<Actor> allActors = await _context.Actors.ToListAsync();
            return allActors;
        }
    }
}
