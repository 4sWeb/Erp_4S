using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Inttradespec
    {
        public Inttradespec()
        {
            Storeminttrades = new HashSet<Storeminttrade>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Storeminttrade> Storeminttrades { get; set; }
    }
}
