using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InMemoryWebApi.Context;
using InMemoryWebApi.Models;

namespace InMemoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BooksController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookEntity>>> GetBookEntities()
        {
            return await _context.BookEntities.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookEntity>> GetBookEntity(int id)
        {
            var bookEntity = await _context.BookEntities.FindAsync(id);

            if (bookEntity == null)
            {
                return NotFound();
            }

            return bookEntity;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookEntity(int id, BookEntity bookEntity)
        {
            if (id != bookEntity.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookEntityExists(id))
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

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookEntity>> PostBookEntity(BookEntity bookEntity)
        {
            _context.BookEntities.Add(bookEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookEntity", new { id = bookEntity.Id }, bookEntity);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookEntity(int id)
        {
            var bookEntity = await _context.BookEntities.FindAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _context.BookEntities.Remove(bookEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookEntityExists(int id)
        {
            return _context.BookEntities.Any(e => e.Id == id);
        }
    }
}
