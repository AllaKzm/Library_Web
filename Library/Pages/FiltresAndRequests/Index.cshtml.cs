using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Pages.FiltresAndRequests
{
    public class IndexModel : PageModel
    {
        private readonly Library.Data.LibraryContext _context;

        public IndexModel(Library.Data.LibraryContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelPos { get; set; }
        public List<SelectListItem> SelPub { get; set; }
        public List<SelectListItem> SelAuthor { get; set; }
        public List<SelectListItem> SelDate { get; set; }
        public List<SelectListItem> SelOnHand { get; set; }
        public List<SelectListItem> SelRead { get; set; }

        public void OnGet()
        {
            SelPos = _context.Positions.Select(p => new SelectListItem
            {
                Value = p.PositionId.ToString(),
                Text = p.PositionTitle
            }).ToList();
            SelPub = _context.Publisher.Select(p => new SelectListItem
            {
                Value = p.PubId.ToString(),
                Text = p.PublicistTitle
            }).ToList();
            SelAuthor = _context.Books.Select(p => new SelectListItem
            {
                Value = p.BookId.ToString(),
                Text = p.Author
            }).ToList();
            SelDate = _context.Books.Select(p => new SelectListItem
            {
                Value = p.BookId.ToString(),
                Text = p.PubYear.ToString()
            }).ToList();
            SelOnHand = new List<SelectListItem>
            {
            new SelectListItem
            {
                Value = "False",
                Text = "На руках"
            },
             new SelectListItem
                {
                    Value = "True",
                    Text = "Возвращенные"
                }};
            SelRead = _context.Reader.Select(p => new SelectListItem
            {
                Value = p.ReadId.ToString(),
                Text = p.Name
            }).ToList();
        }
    }
}
