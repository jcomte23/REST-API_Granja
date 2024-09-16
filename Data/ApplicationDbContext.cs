using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Models;

namespace REST_API_Granja.Data;
public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AnimalType> AnimalTypes { get; set; }
}
