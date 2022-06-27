using Microsoft.EntityFrameworkCore;

namespace SuperHero.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
