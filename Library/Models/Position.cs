using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Library.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }
        [Display(Name = "Код должности")]
        public long PositionId { get; set; }
        [Display(Name = "Название должности")]
        public string PositionTitle { get; set; }
        [Display(Name = "Заработная плата")]
        public double Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Duties { get; set; }
        [Display(Name = "Требования")]
        public string Demands { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
