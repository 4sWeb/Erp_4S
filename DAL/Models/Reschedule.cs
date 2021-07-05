using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Reschedule
    {
        public decimal? Checkid { get; set; }
        public decimal? Trnsid { get; set; }
        public decimal? Reschedvalue { get; set; }
        public decimal? Checkid2 { get; set; }
        public decimal Id { get; set; }

        public virtual Check Check { get; set; }
        public virtual Check Checkid2Navigation { get; set; }
        public virtual Financem Trns { get; set; }
    }
}
