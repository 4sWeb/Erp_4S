using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DimensionBalance
    {
        public decimal DimensionId { get; set; }
        public decimal? Dimensionlevelsid { get; set; }
        public string DimensionCode { get; set; }
        public string LeafCode { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? InitialDebit { get; set; }
        public decimal? InitialCredit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
