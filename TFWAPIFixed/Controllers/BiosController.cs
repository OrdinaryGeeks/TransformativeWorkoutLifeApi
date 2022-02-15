#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TFWAPIFixed.Models;

namespace TFWAPIFixed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiosController : ControllerBase
    {
        private readonly DBContext _context;

        public BiosController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Bios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bio>>> GetBio()
        {
            return await _context.Bio.ToListAsync();
        }

        // GET: api/Bios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bio>> GetBio(string id)
        {
            var bio = await _context.Bio.FindAsync(id);

            if (bio == null)
            {
                return NotFound();
            }

            return bio;
        }

        // PUT: api/Bios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBio(string id, Bio bio)
        {
            if (id != bio.ID)
            {
                return BadRequest();
            }

            _context.Entry(bio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BioExists(id))
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

        // POST: api/Bios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bio>> PostBio(Bio bio)
        {
            _context.Bio.Add(bio);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BioExists(bio.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBio", new { id = bio.ID }, bio);
        }

        // DELETE: api/Bios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBio(string id)
        {
            var bio = await _context.Bio.FindAsync(id);
            if (bio == null)
            {
                return NotFound();
            }

            _context.Bio.Remove(bio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BioExists(string id)
        {
            return _context.Bio.Any(e => e.ID == id);
        }
    }
}
