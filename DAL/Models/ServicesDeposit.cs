using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesDeposit
    {
        public decimal Id { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Depositratio { get; set; }
        public DateTime? Fromdate { get; set; }

        public virtual ServicesInstitem Unit { get; set; }
    }
}
