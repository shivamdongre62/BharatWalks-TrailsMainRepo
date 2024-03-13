using BharatWTAPI.Data;
using BharatWTAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BharatWTAPI.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly ApplicationDbContext _context; 
        public SQLRegionRepository(ApplicationDbContext context)
        {
            _context = context;       
        }
        public async Task<List<Region>> GetAll()
        {
            return await _context.Regions.ToListAsync();
        }
    }
}
