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
    public class BlurbsController : ControllerBase
    {
        private readonly DBContext _context;

        public BlurbsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Blurbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blurb>>> GetBlurb()
        {
            return await _context.Blurb.ToListAsync();
        }

        // GET: api/Blurbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Blurb>> GetBlurb(string id)
        {
            var blurb = await _context.Blurb.FindAsync(id);

            if (blurb == null)
            {
                return NotFound();
            }

            return blurb;
        }

        // PUT: api/Blurbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlurb(string id, Blurb blurb)
        {
            if (id != blurb.ID)
            {
                return BadRequest();
            }

            _context.Entry(blurb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlurbExists(id))
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

        // POST: api/Blurbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blurb>> PostBlurb(Blurb blurb)
        {
            _context.Blurb.Add(blurb);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BlurbExists(blurb.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBlurb", new { id = blurb.ID }, blurb);
        }

        // DELETE: api/Blurbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlurb(string id)
        {
            var blurb = await _context.Blurb.FindAsync(id);
            if (blurb == null)
            {
                return NotFound();
            }

            _context.Blurb.Remove(blurb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BlurbExists(string id)
        {
            return _context.Blurb.Any(e => e.ID == id);
        }
    }
}
