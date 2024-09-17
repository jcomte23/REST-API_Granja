using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_API_Granja.Models;

[Table("animals")]
public class Animal
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public required string Name { get; set; }

    [MaxLength(250)]
    [Column("description")]
    public string? Description { get; set; }

    [Required]
    [Column("animal_type_id")]
    public int AnimalTypeId { get; set; }

    [Column("weight")]
    public double? WeightKg { get; set; } 

    [Column("birth_date")]
    public DateOnly? BirthDate { get; set; }

    [ForeignKey(nameof(AnimalTypeId))]
    public AnimalType? AnimalType { get; set; }
}
