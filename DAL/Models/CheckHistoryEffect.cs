using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CheckHistoryEffect
    {
        public string Aname { get; set; }
        public decimal? StoreId { get; set; }
        public string Code { get; set; }
        public decimal Distid { get; set; }
        public decimal? Isdist { get; set; }
        public DateTime? Hstamp { get; set; }
        public decimal Hafzamid { get; set; }
        public int? Hafzano { get; set; }
        public decimal? Period { get; set; }
        public string Hafzatypeaname { get; set; }
        public string Hafzatypeename { get; set; }
        public decimal Checkid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
        public decimal? CD { get; set; }
        public decimal Statusid { get; set; }
        public decimal Checktype { get; set; }
        public string Statusaname { get; set; }
        public string Statusename { get; set; }
        public string Remarks { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Cash { get; set; }
        public decimal? CreditFactor { get; set; }
        public decimal? CashFactor { get; set; }
        public string Aname1 { get; set; }
        public string Code1 { get; set; }
        public decimal Maintypeid { get; set; }
        public string Fremarks { get; set; }
        public decimal? Branchid { get; set; }
        public decimal? Formid { get; set; }
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public decimal? Purpose { get; set; }
        public string Iscash { get; set; }
        public string Kind { get; set; }
        public decimal? Hafzatype { get; set; }
        public DateTime? Duedate { get; set; }
        public string Checkno { get; set; }
        public string Bankname { get; set; }
        public string Beneficiary { get; set; }
        public long? Trnsno { get; set; }
        public decimal? Bankexpenses { get; set; }
        public decimal? Debtorid { get; set; }
        public decimal? Vendorid { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal? Tdistid { get; set; }
        public decimal? Chkvalue { get; set; }
        public string Transname { get; set; }
        public decimal? IsAccepted { get; set; }
        public decimal Trnid { get; set; }
        public decimal? Casheffect { get; set; }
        public string DocNo { get; set; }
    }
}
