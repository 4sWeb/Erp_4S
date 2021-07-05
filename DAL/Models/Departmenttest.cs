using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Departmenttest
    {
        public Departmenttest()
        {
            Employees = new HashSet<Employee>();
        }

        public decimal Depid { get; set; }
        public string Depname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
