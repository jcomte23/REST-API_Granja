using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Data;
using REST_API_Granja.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace REST_API_Granja.Controllers.v2.Animals;

[ApiController]
[Route("api/v2/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AnimalsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [SwaggerOperation(
        Summary = "Retrieves all animals",
        Description = "Gets a list of all animals in the database."
    )]
    [SwaggerResponse(200, "Returns a list of animals.", typeof(IEnumerable<Animal>))]
    [SwaggerResponse(204, "No animals found in the database.")]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
    {
        var animals = await _context.Animals.Include(p => p.AnimalType).ToListAsync();

        if (animals == null || !animals.Any())
        {
            return NoContent();
        }

        return Ok(animals); 
    }
}
