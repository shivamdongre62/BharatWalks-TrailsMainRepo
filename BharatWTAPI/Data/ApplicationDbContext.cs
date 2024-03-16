using BharatWTAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BharatWTAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Walks> WalksData { get; set; }

        //Data Seeeding During Migration

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var regions = new List<Region>()
            { new Region
            {
                Id = Guid.Parse("9bf7e666-e9ea-4a71-947e-9d32a94f05af"),
                Name = "MP",  
                Code = "45",  
                RegionImageUrl = "xyz",
            },
            new Region
            {
                Id = Guid.Parse("9b727db9-4880-4009-b099-c34b346559f6"),
                Name = "UP",
                Code = "50",
                RegionImageUrl = "abc",
            },
            new Region
            {
                Id = Guid.Parse("5d28c997-0e23-47cd-a27a-ebfb5ca74f17"),
                Name = "MH",
                Code = "55",
                RegionImageUrl = "efg",
            },
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
