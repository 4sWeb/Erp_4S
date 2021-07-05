using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vcheckcredithistory2
    {
        public decimal StoreId { get; set; }
        public int? Transactionno { get; set; }
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
        public decimal Statusid { get; set; }
        public string Aname1 { get; set; }
        public string Code1 { get; set; }
        public decimal Maintypeid { get; set; }
        public string Transname { get; set; }
        public string TypeAname2 { get; set; }
        public string Aname2 { get; set; }
    }
}
