﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
		public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
		{
			var result = await _context.Books.ToListAsync();
			return result;
		}

		// GET: api/Books/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Book>> GetBook(long id)
		{
			var book = await _context.Books.FindAsync(id);

			if (book == null)
			{
				return NotFound();
			}

			return book;
		}

		// PUT: api/Books/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutBook(long id, Book book)
		{
			if (id != book.Id)
			{
				return BadRequest();
			}

			_context.Entry(book).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!BookExists(id))
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
		public async Task<ActionResult<Book>> PostBook(Book book)
		{
			_context.Books.Add(book);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetBook", new { id = book.Id }, book);
		}

		// DELETE: api/Books/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBook(long id)
		{
			var book = await _context.Books.FindAsync(id);
			if (book == null)
			{
				return NotFound();
			}

			_context.Books.Remove(book);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool BookExists(long id)
		{
			return _context.Books.Any(e => e.Id == id);
		}
	}
}
