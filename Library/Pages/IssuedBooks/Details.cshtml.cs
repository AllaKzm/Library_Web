using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Pages.IssuedBooks
{
    public class DetailsModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public DetailsModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public IssuedBook IssuedBook { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IssuedBook = await _context.IssuedBooks
                .Include(i => i.Book)
                .Include(i => i.Emp)
                .Include(i => i.Read).FirstOrDefaultAsync(m => m.IssueId == id);

            if (IssuedBook == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
