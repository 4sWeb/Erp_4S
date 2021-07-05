using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VtransactionhistoryMod
    {
        public decimal? Distid { get; set; }
        public decimal? Transactionno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Remarks { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Checkdebit { get; set; }
        public decimal? Checkcredit { get; set; }
        public string Aname { get; set; }
        public string Code { get; set; }
        public decimal? Maintypeid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Cd { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Formid { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
    }
}
