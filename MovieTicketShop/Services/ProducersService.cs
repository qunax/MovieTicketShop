using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Services
{
    public interface IProducersService
    {
        public Task<IList<Producer>> GetAllProducers();
    }
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _dbContext;

        public ProducersService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Producer>> GetAllProducers()
        {
            List<Producer> allProducers = await _dbContext.Producers.ToListAsync();
            return allProducers;
        }
    }
}
