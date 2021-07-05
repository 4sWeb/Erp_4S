using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Employee
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? Age { get; set; }
        public string Address { get; set; }
        public decimal? Depid { get; set; }
        public string Phone { get; set; }

        public virtual Departmenttest Dep { get; set; }
    }
}
