using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformdeliverunit
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime? Deliverdate { get; set; }

        public virtual Saleform Saleform { get; set; }
    }
}
