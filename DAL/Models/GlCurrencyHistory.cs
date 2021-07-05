using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlCurrencyHistory
    {
        public decimal Id { get; set; }
        public decimal? Exchangerate { get; set; }
        public DateTime? Ratedate { get; set; }
        public decimal? Currency { get; set; }
    }
}
