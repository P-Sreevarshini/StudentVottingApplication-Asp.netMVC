using Dotnet_M1_A2.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_M1_A2.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Position> positionTbl { get; set; }
       public DbSet<Student> studentTbl { get; set; }
       public DbSet<Vote> voteTbl { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for the Position table
            modelBuilder.Entity<Position>().HasData(
                new Position { PositionID = 1, PositionName = "President", Nominee1 = "John", Nominee2 = "Jane", Nominee3 = "Mike", Nominee4 = "Sara" },
                new Position { PositionID = 2, PositionName = "Vice President", Nominee1 = "Alex", Nominee2 = "Emily", Nominee3 = "Chris", Nominee4 = "Lily" },
                new Position { PositionID = 3, PositionName = "Captain", Nominee1 = "Yash", Nominee2 = "Jill", Nominee3 = "Daniel", Nominee4 = "Peter" },
                new Position { PositionID = 4, PositionName = "Secretary", Nominee1 = "Michale", Nominee2 = "jack", Nominee3 = "Deni", Nominee4 = "Dory" }
                
            );

            // You can add seed data for other tables here if needed

            base.OnModelCreating(modelBuilder);
        }

    }
}
