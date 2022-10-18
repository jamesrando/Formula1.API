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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teams>()
                .HasData(
                    new Teams("Ferrari")  { Id = 1, Description = "Ferrari Racing Team" },
                    new Teams("Mercedes") { Id = 2, Description = "Mercedes Racing Team" },
                    new Teams("Red Bull") { Id = 3, Description = "Red Bull Racing Team" }
                );

            modelBuilder.Entity<TeamLocation>()
               .HasData(
                   new TeamLocation("Italy") { Id = 1, TeamsId = 1, Description = "The location of Ferrari Racing Team", Location = "Monza" },
                   new TeamLocation("Germany") { Id = 2, TeamsId = 2, Description = "The location of Mercedes Racing Team", Location = "Nürburgring" },
                   new TeamLocation("Netherlands") { Id = 3, TeamsId = 3, Description = "The location of Red Bull Racing Team", Location = "Zandvoort" }
               );

            base.OnModelCreating(modelBuilder);
        }

    }
}
