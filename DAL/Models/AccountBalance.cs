using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AccountBalance
    {
        public decimal AccountId { get; set; }
        public decimal? Acclevelsid { get; set; }
        public string AccountCode { get; set; }
        public string LeafCode { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? InitialDebit { get; set; }
        public decimal? InitialCredit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
