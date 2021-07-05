using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CostDistributionO
    {
        public decimal Id { get; set; }
        public decimal? CostDistributionMid { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? Cost { get; set; }

        public virtual CostDistributionM CostDistributionM { get; set; }
    }
}
