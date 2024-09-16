using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Data;
using REST_API_Granja.Models;

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
    public async Task<ActionResult<IEnumerable<AnimalType>>> GetAnimalTypes()
    {
        return await _context.AnimalTypes.ToListAsync();
    }


    [HttpGet("{id}")]
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
    public async Task<ActionResult<AnimalType>> PostAnimalType(AnimalType animalType)
    {
        _context.AnimalTypes.Add(animalType);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAnimalType", new { id = animalType.Id }, animalType);
    }

    [HttpDelete("{id}")]
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
