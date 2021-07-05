using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StageCost
    {
        public StageCost()
        {
            StageCostaccs = new HashSet<StageCostacc>();
        }

        public decimal Id { get; set; }
        public decimal? Stageid { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? Cost { get; set; }
        public bool? Costtype { get; set; }

        public virtual ICollection<StageCostacc> StageCostaccs { get; set; }
    }
}
