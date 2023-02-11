using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Psicología.Shared.Model;

namespace Psicología.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerapeutasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TerapeutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Terapeutas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Terapeuta>>> GetTerapeutas()
        {
            return await _context.Terapeutas.ToListAsync();
        }

        // GET: api/Terapeutas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Terapeuta>> GetTerapeuta(int id)
        {
            var terapeuta = await _context.Terapeutas.FindAsync(id);

            if (terapeuta == null)
            {
                return NotFound();
            }

            return terapeuta;
        }

        // PUT: api/Terapeutas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTerapeuta(int id, Terapeuta terapeuta)
        {
            if (id != terapeuta.Id)
            {
                return BadRequest();
            }

            _context.Entry(terapeuta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerapeutaExists(id))
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

        // POST: api/Terapeutas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Terapeuta>> PostTerapeuta(Terapeuta terapeuta)
        {
            _context.Terapeutas.Add(terapeuta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTerapeuta", new { id = terapeuta.Id }, terapeuta);
        }

        // DELETE: api/Terapeutas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTerapeuta(int id)
        {
            var terapeuta = await _context.Terapeutas.FindAsync(id);
            if (terapeuta == null)
            {
                return NotFound();
            }

            _context.Terapeutas.Remove(terapeuta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TerapeutaExists(int id)
        {
            return _context.Terapeutas.Any(e => e.Id == id);
        }
    }
}
