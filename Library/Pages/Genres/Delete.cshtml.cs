using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Pages.Genres
{
    public class DeleteModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public DeleteModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genres.FirstOrDefaultAsync(m => m.GenId == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genres.FindAsync(id);

            if (Genre != null)
            {
                _context.Genres.Remove(Genre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
