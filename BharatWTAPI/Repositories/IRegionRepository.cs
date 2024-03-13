using BharatWTAPI.Models.Domain;

namespace BharatWTAPI.Repositories
{
    public interface IRegionRepository
    {
        public Task<List<Region>> GetAll();

    }
}
