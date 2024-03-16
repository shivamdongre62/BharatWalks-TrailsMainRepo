using BharatWTAPI.Data;
using BharatWTAPI.Models.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BharatWTAPI.Repositories
{
    public class SQLWalkRepository : IWalksRepository
    {
        private readonly ApplicationDbContext context;

        public SQLWalkRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Walks> Create(Walks model)
        {
            await context.WalksData.AddAsync(model);   
            context.SaveChanges();
            return model;
        }


    }
}
