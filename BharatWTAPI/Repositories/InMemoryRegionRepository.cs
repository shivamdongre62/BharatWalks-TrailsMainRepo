using BharatWTAPI.Models.Domain;

namespace BharatWTAPI.Repositories
{
    public class InMemoryRegionRepository : IRegionRepository
    {
        public async  Task<List<Region>> GetAll()
        {
            return new List<Region>
            {
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Code = "Sam",
                    Name= "Janvi"

                }
            };
        }
    }
}
