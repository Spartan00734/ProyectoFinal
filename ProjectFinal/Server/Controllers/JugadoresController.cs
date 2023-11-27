using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.Server.Data;
using ProjectFinal.Shared.Models;
using ProjectFinal.Shared.Models.DTO;

namespace ProjectFinal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadoresController : ControllerBase
    {
        private readonly PlataformaDbContext _context;

        public JugadoresController(PlataformaDbContext context)
        {
            _context = context;
        }

        // GET: api/Jugadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JugadorDTO>>> GetJugadores()
        {
            if (_context.Jugadores == null)
            {
                return NotFound();
            }
            var respuesta = _context.Jugadores.Include(j => j.Torneo).Select(r => new JugadorDTO() { Id = r.Id, Nombre = r.Nombre, Edad = r.Edad, Pais_Residencia = r.Pais_Residencia, NombreJuegos = r.Torneo.Juego.Nombre, NombreOrganizador = r.Torneo.Organizador.Nombre, NombreTorneo = r.Torneo.Nombre });
            return await respuesta.ToListAsync();
        }

        // GET: api/Jugadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jugador>> GetJugador(int id)
        {
          if (_context.Jugadores == null)
          {
              return NotFound();
          }
            var jugador = await _context.Jugadores.FindAsync(id);

            if (jugador == null)
            {
                return NotFound();
            }

            return jugador;
        }

        // PUT: api/Jugadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugador(int id, Jugador jugador)
        {
            if (id != jugador.Id)
            {
                return BadRequest();
            }

            _context.Entry(jugador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JugadorExists(id))
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

        // POST: api/Jugadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jugador>> PostJugador(Jugador jugador)
        {
          if (_context.Jugadores == null)
          {
              return Problem("Entity set 'PlataformaDbContext.Jugadores'  is null.");
          }
            _context.Jugadores.Add(jugador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJugador", new { id = jugador.Id }, jugador);
        }

        // DELETE: api/Jugadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugador(int id)
        {
            if (_context.Jugadores == null)
            {
                return NotFound();
            }
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }

            _context.Jugadores.Remove(jugador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JugadorExists(int id)
        {
            return (_context.Jugadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
