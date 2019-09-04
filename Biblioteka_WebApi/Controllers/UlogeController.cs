using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteka_WebApi.Database;

namespace Biblioteka_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        private readonly eLibraryContext _context;

        public UlogeController(eLibraryContext context)
        {
            _context = context;
        }

        // GET: api/Uloge
        [HttpGet]
        public IEnumerable<Uloge> GetUloge()
        {
            return _context.Uloge;
        }

        // GET: api/Uloge/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUloge([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var uloge = await _context.Uloge.FindAsync(id);

            if (uloge == null)
            {
                return NotFound();
            }

            return Ok(uloge);
        }

        // PUT: api/Uloge/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUloge([FromRoute] int id, [FromBody] Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uloge.UlogaId)
            {
                return BadRequest();
            }

            _context.Entry(uloge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlogeExists(id))
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

        // POST: api/Uloge
        [HttpPost]
        public async Task<IActionResult> PostUloge([FromBody] Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Uloge.Add(uloge);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUloge", new { id = uloge.UlogaId }, uloge);
        }

        // DELETE: api/Uloge/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUloge([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var uloge = await _context.Uloge.FindAsync(id);
            if (uloge == null)
            {
                return NotFound();
            }

            _context.Uloge.Remove(uloge);
            await _context.SaveChangesAsync();

            return Ok(uloge);
        }

        private bool UlogeExists(int id)
        {
            return _context.Uloge.Any(e => e.UlogaId == id);
        }
    }
}