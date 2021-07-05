using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentperiod
    {
        public Rentperiod()
        {
            Rentinstalmentsms = new HashSet<Rentinstalmentsm>();
        }

        public decimal Id { get; set; }
        public DateTime? Startrentperiod { get; set; }
        public DateTime? Endrentperiod { get; set; }

        public virtual ICollection<Rentinstalmentsm> Rentinstalmentsms { get; set; }
    }
}
