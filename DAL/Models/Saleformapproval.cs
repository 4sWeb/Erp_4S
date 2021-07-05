using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformapproval
    {
        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Levelid { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime? Approvaldate { get; set; }

        public virtual Saleformapplevel Level { get; set; }
        public virtual Saleform Saleform { get; set; }
        public virtual User User { get; set; }
    }
}
