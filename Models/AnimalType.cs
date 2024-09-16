using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_API_Granja.Models;
[Table("animal_type")]
public class AnimalType
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
}
