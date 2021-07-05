using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Xtempindividualtable
    {
        public decimal? StoreId { get; set; }
        public decimal? Debitwithrate { get; set; }
        public decimal? Creditwithrate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
        public decimal? Checkdebit { get; set; }
        public decimal? Checkcredit { get; set; }
        public decimal? Checkundercollection { get; set; }
        public string Id { get; set; }
        public decimal? Transactionno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Remarks { get; set; }
        public decimal? Debitbal { get; set; }
        public decimal? Creditbal { get; set; }
        public decimal? Checkdebitbal { get; set; }
        public decimal? Checkcreditbal { get; set; }
        public string Branchcodev { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Checkid { get; set; }
        public string IsPre { get; set; }
        public string Xtransfertoacc { get; set; }
        public string Xchecknum { get; set; }
        public bool? Currencyid { get; set; }
        public decimal? Currencyrate { get; set; }
    }
}
