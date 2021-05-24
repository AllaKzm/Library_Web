using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Pages.FiltresAndRequests.Requests
{
        public class Books_On_HandsModel : PageModel
        {
            private readonly Library.Data.LibraryContext _context;

            public Books_On_HandsModel(Library.Data.LibraryContext context)
            {
                _context = context;
            }

            public IList<IssuedBook> IssuedBook { get; set; }
            public IList<Book> Book { get; set; }
            public IList<Employee> Employee { get; set; }
            public IList<Reader> Reader { get; set; }
            public async Task OnGetAsync()
            {
                IssuedBook = await _context.IssuedBooks
                    .Include(r => r.Book)
                    .Include(r => r.Emp)
                    .Include(r => r.Read).ToListAsync();
                Book = await _context.Books.ToListAsync();
                Employee = await _context.Employee.ToListAsync();
                Reader = await _context.Reader.ToListAsync();
            }
        }
}
