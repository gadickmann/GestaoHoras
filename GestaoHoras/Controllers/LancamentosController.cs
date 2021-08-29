using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestaoHoras3.Data;

namespace GestaoHoras3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LancamentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Lancamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lancamento>>> GetLancamento()
        {
            return await _context.Lancamento.ToListAsync();
        }
       
        // POST: api/Lancamentos
        [HttpPost]
        public async Task<ActionResult<Lancamento>> PostLancamento(Lancamento lancamento)
        {
            _context.Lancamento.Add(lancamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLancamento", new { id = lancamento.Id }, lancamento);
        }

        private bool LancamentoExists(int id)
        {
            return _context.Lancamento.Any(e => e.Id == id);
        }
    }
}
