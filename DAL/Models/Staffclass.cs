using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Staffclass
    {
        public Staffclass()
        {
            staff = new HashSet<staff>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
