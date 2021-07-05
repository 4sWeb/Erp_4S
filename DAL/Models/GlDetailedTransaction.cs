using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlDetailedTransaction
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Leafaccount { get; set; }
        public decimal? Mastertransaction { get; set; }
        public string Referencetype { get; set; }
        public string Referenceno { get; set; }
        public DateTime? Referencedate { get; set; }
        public decimal? Localamount { get; set; }
        public decimal? Currency { get; set; }
    }
}
