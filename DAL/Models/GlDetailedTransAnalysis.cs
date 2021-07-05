using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlDetailedTransAnalysis
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Leafanalysis { get; set; }
        public decimal? Detailedtransaction { get; set; }
    }
}
