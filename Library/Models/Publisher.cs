using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }
        [Display(Name = "Код издательства")]
        public long PubId { get; set; }
        [Display(Name = "Название издательства")]
        public string PublicistTitle { get; set; }
        [Display(Name = "Город")]
        public string City { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
