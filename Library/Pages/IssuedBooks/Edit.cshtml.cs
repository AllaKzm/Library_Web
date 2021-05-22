using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Pages.IssuedBooks
{
    public class EditModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public EditModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Author");
           ViewData["EmpId"] = new SelectList(_context.Employee, "EmpId", "Address");
           ViewData["ReadId"] = new SelectList(_context.Reader, "ReadId", "Address");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(IssuedBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssuedBookExists(IssuedBook.IssueId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IssuedBookExists(long id)
        {
            return _context.IssuedBooks.Any(e => e.IssueId == id);
        }
    }
}
