using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlAccountFySummary
    {
        public decimal Id { get; set; }
        public decimal? Account { get; set; }
        public decimal? Year { get; set; }
        public decimal? Openingbalance { get; set; }
    }
}
