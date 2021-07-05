using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Stafflevel
    {
        public Stafflevel()
        {
            staff = new HashSet<staff>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public bool? Stafflevel1 { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
