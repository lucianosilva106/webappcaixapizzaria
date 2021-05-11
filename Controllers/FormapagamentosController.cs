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
    public class FormapagamentosController : ControllerBase
    {
        private readonly Contexto _context;

        public FormapagamentosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Formapagamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Formapagamento>>> GetFormaPagamento()
        {
            return await _context.FormaPagamento.ToListAsync();
        }

        // GET: api/Formapagamentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Formapagamento>> GetFormapagamento(int id)
        {
            var formapagamento = await _context.FormaPagamento.FindAsync(id);

            if (formapagamento == null)
            {
                return NotFound();
            }

            return formapagamento;
        }

        // PUT: api/Formapagamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormapagamento(int id, [FromForm]Formapagamento formapagamento)
        {
            if (id != formapagamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(formapagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormapagamentoExists(id))
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

        // POST: api/Formapagamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Formapagamento>> PostFormapagamento([FromForm] Formapagamento formapagamento)
        {
            _context.FormaPagamento.Add(formapagamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormapagamento", new { id = formapagamento.Id }, formapagamento);
        }

        // DELETE: api/Formapagamentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFormapagamento(int id)
        {
            var formapagamento = await _context.FormaPagamento.FindAsync(id);
            if (formapagamento == null)
            {
                return NotFound();
            }

            _context.FormaPagamento.Remove(formapagamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FormapagamentoExists(int id)
        {
            return _context.FormaPagamento.Any(e => e.Id == id);
        }
    }
}
