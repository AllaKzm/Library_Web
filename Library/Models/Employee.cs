using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Employee
    {
        public Employee()
        {
            IssuedBooks = new HashSet<IssuedBook>();
        }
        [Display(Name = "Код сотрудника")]
        public long EmpId { get; set; }
        [Display(Name = "Имя сотрудника")]
        public string Name { get; set; }
        [Display(Name = "Дата рождения")] 
        public DateTime BirthDate { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес проживания")]
        public string Address { get; set; }
        [Display(Name = "Номер телефона")] 
        public string Phone { get; set; }
        [Display(Name = "Пасспортные данные")] 
        public string PassportData { get; set; }
        [Display(Name = "Код должности")] 
        public long PositionId { get; set; }
        
        [Display(Name = "Код должности")]
        public virtual Position Position { get; set; }
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
    }
}
