using Formula1.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Formula1.API.DbContexts
{
    public class Formula1Context : DbContext
    {
        public DbSet<Teams>? Teams { get; set; } 
        public DbSet<TeamLocation>? TeamLocations { get; set; }

        public Formula1Context(DbContextOptions<Formula1Context> options)
            : base(options)
        {

        }

    }
}
