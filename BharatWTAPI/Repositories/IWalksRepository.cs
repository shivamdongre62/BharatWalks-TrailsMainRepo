using BharatWTAPI.Models.Domain;

namespace BharatWTAPI.Repositories
{
    public interface IWalksRepository
    {
        Task<Walks> Create(Walks model);
    }
}
