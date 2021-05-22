using System;
using System.Collections.Generic;

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

        public long EmpId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PassportData { get; set; }
        public long PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
    }
}
