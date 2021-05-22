using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Library.Data;
using Library.Models;

namespace Library.Pages.IssuedBooks
{
    public class CreateModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public CreateModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Author");
        ViewData["EmpId"] = new SelectList(_context.Employee, "EmpId", "Address");
        ViewData["ReadId"] = new SelectList(_context.Reader, "ReadId", "Address");
            return Page();
        }

        [BindProperty]
        public IssuedBook IssuedBook { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.IssuedBooks.Add(IssuedBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
