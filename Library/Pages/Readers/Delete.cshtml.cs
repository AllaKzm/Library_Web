using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Pages.Readers
{
    public class DeleteModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public DeleteModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Reader Reader { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reader = await _context.Reader.FirstOrDefaultAsync(m => m.ReadId == id);

            if (Reader == null)
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

            Reader = await _context.Reader.FindAsync(id);

            if (Reader != null)
            {
                _context.Reader.Remove(Reader);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
