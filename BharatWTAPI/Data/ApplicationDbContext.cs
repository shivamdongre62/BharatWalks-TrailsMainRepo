using BharatWTAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BharatWTAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Region> Regions { get; set; }  
        public DbSet<Difficulty> Difficulties{ get; set; }  
        public DbSet<Walks> WalksData{ get; set;}  

    }
}
