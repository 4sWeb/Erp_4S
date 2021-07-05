using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Irrigationemp
    {
        public decimal Id { get; set; }
        public decimal? Transid { get; set; }
        public decimal? Allcodeid { get; set; }
        public string Irrigationperiod { get; set; }

        public virtual StoreAllcode Allcode { get; set; }
        public virtual StoreTrnsM Trans { get; set; }
    }
}
