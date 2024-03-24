using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BharatWTAPI.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "35fd9bde-ffc0-4757-8b97-3693e9126a09";
            var writerRoleId = "f0a0f746-d335-47c5-a70a-bfe7f57d7797";

            var roles = new List<IdentityRole>() { new IdentityRole
            {
                Id = readerRoleId,
                ConcurrencyStamp = readerRoleId,
                Name = "Reader",
                NormalizedName = "Reader".ToLower(),
            },
            new IdentityRole
            {
                Id = writerRoleId,
                ConcurrencyStamp = writerRoleId,
                Name = "Writer",
                NormalizedName = "Writer".ToLower(),
            }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
