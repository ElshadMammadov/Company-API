using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;


namespace Repository.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCitiesWithCountriesAsync()
        {
            return await _context.Cities
                                 .Include(c => c.Country)
                                 .ToListAsync();
        }
    }
}