using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Pages.FiltresAndRequests.Filtres
{
    public class PubFilModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public PubFilModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; }
        public IList<Genre> Genre { get; set; }
        public Publisher Publisher { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Publisher = _context.Publisher.First(m => m.PubId == id);
            if (Publisher == null)
            {
                return NotFound();
            }
            Book = await _context.Books
                .Include(b => b.Gen)
                .Include(b => b.Pub).Where(m => m.PubId == Publisher.PubId).ToListAsync();
            Genre = await _context.Genres.Where(m => m.GenId == Publisher.PubId).ToListAsync();
            return Page();
        }
    }
}
