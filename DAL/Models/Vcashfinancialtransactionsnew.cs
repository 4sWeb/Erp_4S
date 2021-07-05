using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vcashfinancialtransactionsnew
    {
        public decimal? StoreId { get; set; }
        public long? Transactionno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Remarks { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debitbal { get; set; }
        public decimal? Creditbal { get; set; }
        public decimal? Period { get; set; }
        public decimal? Currencyid { get; set; }
        public string Aname { get; set; }
        public string Code { get; set; }
        public decimal? Maintypeid { get; set; }
        public string Transname { get; set; }
        public string Aname2 { get; set; }
        public string Typename { get; set; }
        public string Typename2 { get; set; }
        public decimal? CD { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Formid { get; set; }
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public decimal? Purpose { get; set; }
        public decimal? Checkdebit { get; set; }
        public decimal? Checkcredit { get; set; }
    }
}
