using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformapplevel
    {
        public Saleformapplevel()
        {
            Saleformapprovals = new HashSet<Saleformapproval>();
        }

        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public string Levelname { get; set; }
        public decimal? Saleformid { get; set; }

        public virtual Saleform Saleform { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Saleformapproval> Saleformapprovals { get; set; }
    }
}
