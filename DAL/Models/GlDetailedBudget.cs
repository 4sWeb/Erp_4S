using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlDetailedBudget
    {
        public decimal Id { get; set; }
        public decimal? Debitamount { get; set; }
        public decimal? Creditamount { get; set; }
        public decimal? Financialaccount { get; set; }
        public decimal? Masterbudget { get; set; }
        public decimal? Financialyear { get; set; }
        public bool? Manual { get; set; }
        public DateTime? Dbdate { get; set; }
    }
}
