using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemspenaltyrule
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Penaltyrulesid { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual Instpenaltyrule Penaltyrules { get; set; }
    }
}
