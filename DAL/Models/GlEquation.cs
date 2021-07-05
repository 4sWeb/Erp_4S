using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlEquation
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public string Formula { get; set; }
        public bool? Posted { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
    }
}
