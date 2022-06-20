using Microsoft.EntityFrameworkCore;
using UpmeetEventBackend.Models;

namespace UpmeetEventBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event(1, "Red Hot Chili Peppers", "Concert", 200m),
                new Event(2, "Detroit Red Wings", "Hockey Game", 50m),
                new Event(3, "Detroit Tigers", "Baseball Game", 25m),
                new Event(4, "Detroit Pistons", "Basketball Game", 57m),
                new Event(5, "Blink-182", "Concert", 89m),
                new Event(6, "Ann Arbor Art fair", "Craft Fair", 0m)
                );
        }

        public DbSet<Event> Events { get; set; }
    }
}
