using Microsoft.EntityFrameworkCore;
using NZWalks.API.Modules.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {
                
        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
