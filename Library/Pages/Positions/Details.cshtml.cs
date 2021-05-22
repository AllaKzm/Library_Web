using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public DetailsModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Positions.FirstOrDefaultAsync(m => m.PositionId == id);

            if (Position == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
