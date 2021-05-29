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
    public class ReadBooksModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public ReadBooksModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<IssuedBook> IssuedBook { get; set; }
        public IList<Book> Book { get; set; }
        public IList<Employee> Employee { get; set; }
        public Reader Reader { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Reader = _context.Reader.First(m => m.ReadId == id);
            if (Reader == null)
            {
                return NotFound();
            }
            IssuedBook = await _context.IssuedBooks
                .Include(r => r.Book)
                .Include(r => r.Emp)
                .Include(r => r.Read).Where(m => m.ReadId == Reader.ReadId).ToListAsync();
            Book = await _context.Books.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            return Page();
        }
    }
}

