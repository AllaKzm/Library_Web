using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class IssuedBook
    {
        [Display(Name = "Код выдачи")]
        public long IssueId { get; set; }
        [Display(Name = "Дата выдачи")] 
        public DateTime IssueDate { get; set; }
        [Display(Name = "Дата возврата")] 
        public DateTime ReturnDate { get; set; }
        [Display(Name = "Отметка о возврате")] 
        public string ReturnMark { get; set; }
        [Display(Name = "Сотрудник, выдавший книгу")] 
        public long EmpId { get; set; }
        [Display(Name = "Читатель")] 
        public long ReadId { get; set; }
        [Display(Name = "Книга")] 
        public long BookId { get; set; }

        [Display(Name = "Книга")]
        public virtual Book Book { get; set; }
        [Display(Name = "Сотрудник, выдавший книгу")]
        public virtual Employee Emp { get; set; }
        [Display(Name = "Читатель")]
        public virtual Reader Read { get; set; }
    }
}
