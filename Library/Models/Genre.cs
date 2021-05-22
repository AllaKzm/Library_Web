using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }
        [Display(Name = "Код жанра")]
        public long GenId { get; set; }
        [Display(Name = "Название жанра")]
        public string GenTitle { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
