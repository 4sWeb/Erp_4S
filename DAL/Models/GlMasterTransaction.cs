using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlMasterTransaction
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public DateTime? GlMasterTransactionDate { get; set; }
        public decimal? Totalamount { get; set; }
        public bool? Islocked { get; set; }
        public string Refusalreason { get; set; }
        public string Notes { get; set; }
        public bool? Isposted { get; set; }
        public string Serial { get; set; }
        public DateTime? Fromtime { get; set; }
        public DateTime? Totime { get; set; }
        public decimal? Currency { get; set; }
        public decimal? Financialperiod { get; set; }
        public decimal? Transactionstatus { get; set; }
        public decimal? Types { get; set; }
        public decimal? Journaltype { get; set; }
        public decimal? Analyticalno { get; set; }
        public decimal? Repeatabletransaction { get; set; }
        public decimal? Canceledtransaction { get; set; }
        public decimal? Frequency { get; set; }
        public string Transactionclass { get; set; }
        public decimal? Transactiontype { get; set; }
        public bool? Isopening { get; set; }
        public decimal? Integratingapplication { get; set; }
        public bool? Revised { get; set; }
        public bool? Refused { get; set; }
        public bool? Isdraft { get; set; }
        public bool? Suspended { get; set; }
        public bool? Readytostopsuspension { get; set; }
        public bool? Suspensionbanned { get; set; }
        public string Branch { get; set; }
        public DateTime? Transdate { get; set; }
        public string Documentserial { get; set; }
    }
}
