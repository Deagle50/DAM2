using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetoODOONetCore.Models;

namespace RetoODOONetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FleetVehiclesController : ControllerBase
    {
        private readonly OdooDBContext _context;

        public FleetVehiclesController(OdooDBContext context)
        {
            _context = context;
        }

        // GET: api/FleetVehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FleetVehicle>>> GetFleetVehicle()
        {
            return await _context.FleetVehicle.ToListAsync();
        }

        // GET: api/FleetVehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FleetVehicle>> GetFleetVehicle(int id)
        {
            var fleetVehicle = await _context.FleetVehicle.FindAsync(id);

            if (fleetVehicle == null)
            {
                return NotFound();
            }

            return fleetVehicle;
        }

        // PUT: api/FleetVehicles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFleetVehicle(int id, FleetVehicle fleetVehicle)
        {
            if (id != fleetVehicle.Id)
            {
                return BadRequest();
            }

            _context.Entry(fleetVehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FleetVehicleExists(id))
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

        // POST: api/FleetVehicles
        [HttpPost]
        public async Task<ActionResult<FleetVehicle>> PostFleetVehicle(FleetVehicle fleetVehicle)
        {
            _context.FleetVehicle.Add(fleetVehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFleetVehicle", new { id = fleetVehicle.Id }, fleetVehicle);
        }

        // DELETE: api/FleetVehicles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FleetVehicle>> DeleteFleetVehicle(int id)
        {
            var fleetVehicle = await _context.FleetVehicle.FindAsync(id);
            if (fleetVehicle == null)
            {
                return NotFound();
            }

            _context.FleetVehicle.Remove(fleetVehicle);
            await _context.SaveChangesAsync();

            return fleetVehicle;
        }

        private bool FleetVehicleExists(int id)
        {
            return _context.FleetVehicle.Any(e => e.Id == id);
        }
    }
}
