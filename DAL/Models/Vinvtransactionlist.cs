using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vinvtransactionlist
    {
        public decimal Transactioncode { get; set; }
        public decimal Transactionno { get; set; }
        public string Transactiontype { get; set; }
        public string Transactionetype { get; set; }
        public string Branchname { get; set; }
        public string Branchename { get; set; }
        public DateTime Transactiondate { get; set; }
        public string Fromcode { get; set; }
        public string Fromname { get; set; }
        public string Fromename { get; set; }
        public string Tocode { get; set; }
        public string Fromtype { get; set; }
        public string Frometype { get; set; }
        public string Totype { get; set; }
        public string Toetype { get; set; }
        public string Toname { get; set; }
        public string Toename { get; set; }
        public decimal? Grossvalue { get; set; }
        public decimal? Netvalue { get; set; }
        public decimal? Totalquantity { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? FgroupfId { get; set; }
        public decimal? TgroupfId { get; set; }
        public decimal? TmtFromid { get; set; }
        public decimal? TmtToid { get; set; }
        public string Salesrep { get; set; }
        public string SalesrepCode { get; set; }
        public string Branchcode { get; set; }
        public decimal? Docnum { get; set; }
        public decimal? Currencyid { get; set; }
        public string Currencyname { get; set; }
        public string Currencyename { get; set; }
    }
}
