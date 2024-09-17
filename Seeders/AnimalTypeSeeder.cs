using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Models;

namespace REST_API_Granja.Seeders;

public class AnimalTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimalType>().HasData(
            new AnimalType
            {
                Id = 1,
                Name = "mamífero",
                Description = "vertebrados de sangre caliente con pelo o pelaje."
            },
            new AnimalType
            {
                Id = 2,
                Name = "ave",
                Description = "vertebrados emplumados y alados capaces de volar."
            },
            new AnimalType
            {
                Id = 3,
                Name = "reptil",
                Description = "vertebrados de sangre fría con escamas."
            },
            new AnimalType
            {
                Id = 4,
                Name = "anfibio",
                Description = "vertebrados de sangre fría que pasan parte de su vida en el agua y parte en tierra."
            },
            new AnimalType
            {
                Id = 5,
                Name = "pez",
                Description = "vertebrados acuáticos con branquias, aletas y escamas."
            },
            new AnimalType
            {
                Id = 6,
                Name = "invertebrado",
                Description = "animales sin columna vertebral, incluyendo insectos, arañas y moluscos."
            }
        );
    }

}
