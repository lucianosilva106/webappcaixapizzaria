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
    public class CaixalancamentoesController : ControllerBase
    {
        private readonly Contexto _context;

        public CaixalancamentoesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Caixalancamentoes
        [HttpGet]
        [Route("caixa/{idcaixacontrole}/lancamento")]

         public async Task<ActionResult<IEnumerable<Caixalancamento>>> GetCaixalancamentos(int idcaixacontrole)
        {
            return await _context.Caixalancamento.Where(a => a.Idcaixacontrole == idcaixacontrole).ToListAsync();
        }

//        public async Task<ActionResult<IEnumerable<Caixalancamento>>> GetCaixalancamento()
//        {
//            return await _context.Caixalancamento.ToListAsync();
//        }

        // GET: api/Caixalancamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caixalancamento>> GetCaixalancamento(int id)
        {
            var caixalancamento = await _context.Caixalancamento.FindAsync(id);

            if (caixalancamento == null)
            {
                return NotFound();
            }

            return caixalancamento;
        }

        // PUT: api/Caixalancamentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaixalancamento(int id, Caixalancamento caixalancamento)
        {
            if (id != caixalancamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(caixalancamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaixalancamentoExists(id))
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

        // POST: api/Caixalancamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caixalancamento>> PostCaixalancamento(Caixalancamento caixalancamento)
        {
            _context.Caixalancamento.Add(caixalancamento);
            await _context.SaveChangesAsync();
                    
            return CreatedAtAction("GetCaixalancamento", new { id = caixalancamento.Id }, caixalancamento);
        }

        // DELETE: api/Caixalancamentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixalancamento(int id)
        {
            var caixalancamento = await _context.Caixalancamento.FindAsync(id);
            if (caixalancamento == null)
            {
                return NotFound();
            }

            _context.Caixalancamento.Remove(caixalancamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CaixalancamentoExists(int id)
        {
            return _context.Caixalancamento.Any(e => e.Id == id);
        }
    }
}
