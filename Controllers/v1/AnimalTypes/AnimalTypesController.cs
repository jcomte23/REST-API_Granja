using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Data;
using REST_API_Granja.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace REST_API_Granja.Controllers.v1.AnimalTypes;

[Route("api/v1/[controller]")]
[ApiController]
public class AnimalTypesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AnimalTypesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [SwaggerOperation(
    Summary = "Retrieves all animal types",
    Description = "Gets a list of all animal types in the database."
)]
    [SwaggerResponse(200, "Returns a list of animal types.", typeof(IEnumerable<AnimalType>))]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<ActionResult<IEnumerable<AnimalType>>> GetAnimalTypes()
    {
        return await _context.AnimalTypes.ToListAsync();
    }

    [HttpGet("{id}")]
    [SwaggerOperation(
        Summary = "Retrieves a specific animal type by ID",
        Description = "Gets a specific animal type from the database using the provided ID."
    )]
    [SwaggerResponse(200, "Returns the animal type with the specified ID.", typeof(AnimalType))]
    [SwaggerResponse(404, "The animal type was not found.")]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<ActionResult<AnimalType>> GetAnimalType(int id)
    {
        var animalType = await _context.AnimalTypes.FindAsync(id);

        if (animalType == null)
        {
            return NotFound();
        }

        return animalType;
    }

    [HttpPut("{id}")]
    [SwaggerOperation(
        Summary = "Updates an existing animal type",
        Description = "Updates an existing animal type in the database with the provided data."
    )]
    [SwaggerResponse(204, "The animal type was updated successfully.")]
    [SwaggerResponse(400, "The request is invalid or the ID does not match the animal type ID.")]
    [SwaggerResponse(404, "The animal type was not found.")]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<IActionResult> PutAnimalType(int id, AnimalType animalType)
    {
        if (id != animalType.Id)
        {
            return BadRequest();
        }

        _context.Entry(animalType).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AnimalTypeExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpPost]
    [SwaggerOperation(
        Summary = "Creates a new animal type",
        Description = "Adds a new animal type to the database."
    )]
    [SwaggerResponse(201, "The animal type was created successfully.", typeof(AnimalType))]
    [SwaggerResponse(400, "The request is invalid.")]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<ActionResult<AnimalType>> PostAnimalType(AnimalType animalType)
    {
        _context.AnimalTypes.Add(animalType);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAnimalType", new { id = animalType.Id }, animalType);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(
        Summary = "Deletes an existing animal type",
        Description = "Removes an animal type from the database using the provided ID."
    )]
    [SwaggerResponse(204, "The animal type was deleted successfully.")]
    [SwaggerResponse(404, "The animal type was not found.")]
    [SwaggerResponse(500, "An internal server error occurred.")]
    public async Task<IActionResult> DeleteAnimalType(int id)
    {
        var animalType = await _context.AnimalTypes.FindAsync(id);
        if (animalType == null)
        {
            return NotFound();
        }

        _context.AnimalTypes.Remove(animalType);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AnimalTypeExists(int id)
    {
        return _context.AnimalTypes.Any(e => e.Id == id);
    }
}
