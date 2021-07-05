using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SaleformAccept
    {
        public SaleformAccept()
        {
            AcceptInsaleforms = new HashSet<AcceptInsaleform>();
        }

        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public string AcceptName { get; set; }
        public decimal? Serial { get; set; }
        public decimal? Userid { get; set; }

        public virtual Saleform Saleform { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AcceptInsaleform> AcceptInsaleforms { get; set; }
    }
}
