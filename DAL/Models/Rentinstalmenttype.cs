using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentinstalmenttype
    {
        public Rentinstalmenttype()
        {
            Rentinstalmentsms = new HashSet<Rentinstalmentsm>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Rentinstalmentsm> Rentinstalmentsms { get; set; }
    }
}
