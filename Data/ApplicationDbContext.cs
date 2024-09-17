using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Models;
using REST_API_Granja.Seeders;

namespace REST_API_Granja.Data;
public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AnimalType> AnimalTypes { get; set; }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AnimalTypeSeeder.Seed(modelBuilder);
    }
}
