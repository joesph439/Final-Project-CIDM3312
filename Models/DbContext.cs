using Final_Project_CIDM3312.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_CIDM3312.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    public DbSet<Player> Players {get; set;}
    public DbSet<Character> Characters {get; set;}
    public DbSet<Stats> Statss {get; set;}
}