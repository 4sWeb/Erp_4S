using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StageCostacc
    {
        public decimal Id { get; set; }
        public decimal? StageCostid { get; set; }
        public decimal? StageCostaccid { get; set; }
        public decimal? Cost { get; set; }
        public bool? Costtype { get; set; }

        public virtual StageCost StageCost { get; set; }
        public virtual Accountstree StageCostaccNavigation { get; set; }
    }
}
