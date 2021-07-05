using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CostDistributionM
    {
        public CostDistributionM()
        {
            CostDistributionOs = new HashSet<CostDistributionO>();
        }

        public decimal Id { get; set; }
        public decimal? Branchid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public string Remark { get; set; }
        public decimal? Trnsno { get; set; }

        public virtual ICollection<CostDistributionO> CostDistributionOs { get; set; }
    }
}
