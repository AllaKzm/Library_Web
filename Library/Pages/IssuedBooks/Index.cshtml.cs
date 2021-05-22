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
    public class IndexModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public IndexModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<IssuedBook> IssuedBook { get;set; }

        public async Task OnGetAsync()
        {
            IssuedBook = await _context.IssuedBooks
                .Include(i => i.Book)
                .Include(i => i.Emp)
                .Include(i => i.Read).ToListAsync();
        }
    }
}
