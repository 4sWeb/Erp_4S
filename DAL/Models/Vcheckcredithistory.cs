using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vcheckcredithistory
    {
        public decimal StoreId { get; set; }
        public long? Transactionno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Remarks { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debitbal { get; set; }
        public decimal? Creditbal { get; set; }
        public decimal? Checkdebit { get; set; }
        public decimal? Checkcredit { get; set; }
        public decimal? Checkdebitbal { get; set; }
        public decimal? Checkcreditbal { get; set; }
        public decimal? Period { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currencyrate { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
        public decimal Statusid { get; set; }
        public string Aname1 { get; set; }
        public string Code1 { get; set; }
        public decimal Maintypeid { get; set; }
        public string Transname { get; set; }
        public decimal? CD { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Formid { get; set; }
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public decimal Checkid { get; set; }
        public decimal? Hafzatype { get; set; }
        public DateTime? Duedate { get; set; }
        public string Checkno { get; set; }
        public string Bankname { get; set; }
        public string Beneficiary { get; set; }
        public int? Hafzano { get; set; }
        public decimal? IsAccepted { get; set; }
        public decimal Trnid { get; set; }
        public decimal? Casheffect { get; set; }
        public string DocNo { get; set; }
    }
}
