using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Book
    {
        public Book()
        {
            IssuedBooks = new HashSet<IssuedBook>();
        }

        public long BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PubYear { get; set; }
        public long GenId { get; set; }
        public long PubId { get; set; }

        public virtual Genre Gen { get; set; }
        public virtual Publisher Pub { get; set; }
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
    }
}
