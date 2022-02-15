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
    public class GuestItemsOrderedController : ControllerBase
    {
        private readonly DBContext _context;

        public GuestItemsOrderedController(DBContext context)
        {
            _context = context;
        }

        // GET: api/GuestItemsOrdered
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuestItemOrdered>>> GetGuestItemOrdered()
        {
            return await _context.GuestItemOrdered.ToListAsync();
        }

        // GET: api/GuestItemsOrdered/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuestItemOrdered>> GetGuestItemOrdered(string id)
        {
            var guestItemOrdered = await _context.GuestItemOrdered.FindAsync(id);

            if (guestItemOrdered == null)
            {
                return NotFound();
            }

            return guestItemOrdered;
        }

        // PUT: api/GuestItemsOrdered/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuestItemOrdered(string id, GuestItemOrdered guestItemOrdered)
        {
            if (id != guestItemOrdered.ID)
            {
                return BadRequest();
            }

            _context.Entry(guestItemOrdered).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestItemOrderedExists(id))
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

        // POST: api/GuestItemsOrdered
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GuestItemOrdered>> PostGuestItemOrdered(GuestItemOrdered guestItemOrdered)
        {
            _context.GuestItemOrdered.Add(guestItemOrdered);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GuestItemOrderedExists(guestItemOrdered.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGuestItemOrdered", new { id = guestItemOrdered.ID }, guestItemOrdered);
        }

        // DELETE: api/GuestItemsOrdered/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuestItemOrdered(string id)
        {
            var guestItemOrdered = await _context.GuestItemOrdered.FindAsync(id);
            if (guestItemOrdered == null)
            {
                return NotFound();
            }

            _context.GuestItemOrdered.Remove(guestItemOrdered);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GuestItemOrderedExists(string id)
        {
            return _context.GuestItemOrdered.Any(e => e.ID == id);
        }
    }
}
