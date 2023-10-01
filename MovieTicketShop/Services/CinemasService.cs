using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Services
{
    public interface ICinemasService
    {
        public Task<IList<Cinema>> GetAllCinemas();
    }

    public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _dbContext;

        public CinemasService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Cinema>> GetAllCinemas()
        {
            List<Cinema> allCinemas = await _dbContext.Cinemas.ToListAsync();
            return allCinemas;
        }
    }
}
