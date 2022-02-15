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
    public class GuestSchedulesController : ControllerBase
    {
        private readonly DBContext _context;

        public GuestSchedulesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/GuestSchedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuestSchedule>>> GetGuestSchedule()
        {
            return await _context.GuestSchedule.ToListAsync();
        }

        // GET: api/GuestSchedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuestSchedule>> GetGuestSchedule(string id)
        {
            var guestSchedule = await _context.GuestSchedule.FindAsync(id);

            if (guestSchedule == null)
            {
                return NotFound();
            }

            return guestSchedule;
        }

        // PUT: api/GuestSchedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuestSchedule(string id, GuestSchedule guestSchedule)
        {
            if (id != guestSchedule.ID)
            {
                return BadRequest();
            }

            _context.Entry(guestSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestScheduleExists(id))
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

        // POST: api/GuestSchedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GuestSchedule>> PostGuestSchedule(GuestSchedule guestSchedule)
        {
            _context.GuestSchedule.Add(guestSchedule);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GuestScheduleExists(guestSchedule.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGuestSchedule", new { id = guestSchedule.ID }, guestSchedule);
        }

        // DELETE: api/GuestSchedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuestSchedule(string id)
        {
            var guestSchedule = await _context.GuestSchedule.FindAsync(id);
            if (guestSchedule == null)
            {
                return NotFound();
            }

            _context.GuestSchedule.Remove(guestSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GuestScheduleExists(string id)
        {
            return _context.GuestSchedule.Any(e => e.ID == id);
        }
    }
}
