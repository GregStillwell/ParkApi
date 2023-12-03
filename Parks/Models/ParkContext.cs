using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class ParksContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksAPIContext(DbContextOptions<ParksAPIContext> options) : base(options)
    {
    }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", },
          new Park { ParkId = 2, Name = "Acadia National Park", State = " Maine",  },
          new Park { ParkId = 3, Name = "Zion National Park", State = "Utah", }
        );
      }
    }
  }