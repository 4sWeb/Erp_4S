using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checktype
    {
        public Checktype()
        {
            Checks = new HashSet<Check>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
    }
}
