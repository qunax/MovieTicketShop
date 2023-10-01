using Microsoft.EntityFrameworkCore;
using MovieTicketShop.DbContexts;
using MovieTicketShop.Models;

namespace MovieTicketShop.Services
{
    public interface IMoviesService
    {
        public Task<IList<Movie>> GetAllMovies();
        public Task<IList<Movie>> GetFilteredMovies();
    }
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _dbContext;

        public MoviesService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Movie>> GetAllMovies()
        {
            List<Movie> allMovies = await _dbContext.Movies.Include(c => c.Cinema)
                                                           .OrderBy(m => m.StartDate)
                                                           .ThenBy(m => m.Title)
                                                           .ToListAsync();
            return allMovies;
        }

        public async Task<IList<Movie>> GetFilteredMovies()
        {
            List<Movie> filteredMovies = await _dbContext.Movies.Where(m => m.Price < 30)
                                                                .Include(c => c.Cinema)
                                                                .OrderBy(m => m.StartDate)
                                                                .ThenBy(m => m.Title)
                                                                .ToListAsync();
            return filteredMovies;
        }
    }
}
