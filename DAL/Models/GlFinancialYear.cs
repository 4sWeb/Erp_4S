using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlFinancialYear
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime? Closuredate { get; set; }
        public bool? Isclosed { get; set; }
        public bool? Old { get; set; }
    }
}
