using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlExpectedBalance
    {
        public decimal Id { get; set; }
        public DateTime? Ebdate { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Financialyear { get; set; }
        public decimal? Account { get; set; }
    }
}
