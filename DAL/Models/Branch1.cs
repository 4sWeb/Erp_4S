using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Branch1
    {
        public decimal RowId { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Defaultbranch { get; set; }

        public virtual User User { get; set; }
    }
}
