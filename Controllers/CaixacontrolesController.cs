using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webappcaixapizzaria.Configuracao;
using webappcaixapizzaria.Model;

namespace webappcaixapizzaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaixacontrolesController : ControllerBase
    {
        private readonly Contexto _context;

        public CaixacontrolesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Caixacontroles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caixacontrole>>> GetCaixacontrole()
        {
            return await _context.Caixacontrole.ToListAsync();
        }

        // GET: api/Caixacontroles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caixacontrole>> GetCaixacontrole(int id)
        {
            var caixacontrole = await _context.Caixacontrole.FindAsync(id);

            if (caixacontrole == null)
            {
                return NotFound();
            }

            return caixacontrole;
        }

        // PUT: api/Caixacontroles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaixacontrole(int id, Caixacontrole caixacontrole)
        {
            if (id != caixacontrole.Id)
            {
                return BadRequest();
            }

            _context.Entry(caixacontrole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaixacontroleExists(id))
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

        // POST: api/Caixacontroles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caixacontrole>> PostCaixacontrole( Caixacontrole caixacontrole)
        {
            _context.Caixacontrole.Add(caixacontrole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaixacontrole", new { id = caixacontrole.Id }, caixacontrole);
        }

        // DELETE: api/Caixacontroles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixacontrole(int id)
        {
            var caixacontrole = await _context.Caixacontrole.FindAsync(id);
            if (caixacontrole == null)
            {
                return NotFound();
            }

            _context.Caixacontrole.Remove(caixacontrole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CaixacontroleExists(int id)
        {
            return _context.Caixacontrole.Any(e => e.Id == id);
        }
    }
}
