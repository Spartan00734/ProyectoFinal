using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.Server.Data;
using ProjectFinal.Shared.Models;

namespace ProjectFinal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizadoresController : ControllerBase
    {
        private readonly PlataformaDbContext _context;

        public OrganizadoresController(PlataformaDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizador>>> GetOrganizadores()
        {
          if (_context.Organizadores == null)
          {
              return NotFound();
          }
            return await _context.Organizadores.ToListAsync();
        }

        // GET: api/Organizadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organizador>> GetOrganizador(int id)
        {
          if (_context.Organizadores == null)
          {
              return NotFound();
          }
            var organizador = await _context.Organizadores.FindAsync(id);

            if (organizador == null)
            {
                return NotFound();
            }

            return organizador;
        }

        // PUT: api/Organizadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganizador(int id, Organizador organizador)
        {
            if (id != organizador.Id)
            {
                return BadRequest();
            }

            _context.Entry(organizador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizadorExists(id))
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

        // POST: api/Organizadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Organizador>> PostOrganizador(Organizador organizador)
        {
          if (_context.Organizadores == null)
          {
              return Problem("Entity set 'PlataformaDbContext.Organizadores'  is null.");
          }
            _context.Organizadores.Add(organizador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganizador", new { id = organizador.Id }, organizador);
        }

        // DELETE: api/Organizadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganizador(int id)
        {
            if (_context.Organizadores == null)
            {
                return NotFound();
            }
            var organizador = await _context.Organizadores.FindAsync(id);
            if (organizador == null)
            {
                return NotFound();
            }

            _context.Organizadores.Remove(organizador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrganizadorExists(int id)
        {
            return (_context.Organizadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
