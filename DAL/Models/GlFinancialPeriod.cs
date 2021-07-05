using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlFinancialPeriod
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public DateTime? Openingdate { get; set; }
        public DateTime? Closingdate { get; set; }
        public bool? Iseditable { get; set; }
        public decimal? Financialyear { get; set; }
    }
}
