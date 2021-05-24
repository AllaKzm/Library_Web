using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages.FiltresAndRequests.Requests
{
    public class RequestModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public RequestModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
    }
}
