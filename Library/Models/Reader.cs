using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Reader
    {
        public Reader()
        {
            IssuedBooks = new HashSet<IssuedBook>();
        }
        [Display(Name = "Код читателя")]
        public long ReadId { get; set; }
        [Display(Name = "ФИО читателя")]
        public string Name { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес проживания")] 
        public string Address { get; set; }
        [Display(Name = "Номер телефона")] 
        public string Phone { get; set; }
        [Display(Name = "Паспортные данные")] 
        public string PassportData { get; set; }

        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
    }
}
