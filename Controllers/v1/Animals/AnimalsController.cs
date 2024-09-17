using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST_API_Granja.Data;
using REST_API_Granja.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace REST_API_Granja.Controllers.v1.Animals
{
    [Route("api/v1/[controller]")]
    [ApiController]
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
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
        {
            return await _context.Animals.ToListAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieves a specific animal by ID",
            Description = "Gets a specific animal from the database using the provided ID."
        )]
        [SwaggerResponse(200, "Returns the animal with the specified ID.", typeof(Animal))]
        [SwaggerResponse(404, "The animal was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }

        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing animal",
            Description = "Updates an existing animal in the database with the provided data."
        )]
        [SwaggerResponse(204, "The animal was updated successfully.")]
        [SwaggerResponse(400, "The request is invalid or the ID does not match the animal ID.")]
        [SwaggerResponse(404, "The animal was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> PutAnimal(int id, Animal animal)
        {
            if (id != animal.Id)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(id))
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
            Summary = "Creates a new animal",
            Description = "Adds a new animal to the database."
        )]
        [SwaggerResponse(201, "The animal was created successfully.", typeof(Animal))]
        [SwaggerResponse(400, "The request is invalid.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimal", new { id = animal.Id }, animal);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes an existing animal",
            Description = "Removes an animal from the database using the provided ID."
        )]
        [SwaggerResponse(204, "The animal was deleted successfully.")]
        [SwaggerResponse(404, "The animal was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalExists(int id)
        {
            return _context.Animals.Any(e => e.Id == id);
        }
    }
}
