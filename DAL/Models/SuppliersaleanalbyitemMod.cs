using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SuppliersaleanalbyitemMod
    {
        public decimal TrnsNo { get; set; }
        public DateTime? TrnsDate { get; set; }
        public decimal? BranchId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemEname { get; set; }
        public decimal Itemid { get; set; }
        public bool? PayEffect { get; set; }
        public bool? QtyEffect { get; set; }
        public string Supplname { get; set; }
        public string Supplename { get; set; }
        public string Supplcode { get; set; }
        public decimal? Supplid { get; set; }
        public string Supplformname { get; set; }
        public string Supplformename { get; set; }
        public decimal? Supplformid { get; set; }
        public decimal? Salesqty { get; set; }
        public decimal? Salesprice { get; set; }
        public decimal? Backqty { get; set; }
        public decimal? Backprice { get; set; }
        public decimal? Allsalesvalue { get; set; }
        public decimal? Allreturnedvalue { get; set; }
        public decimal? Staxsalesvalue { get; set; }
        public decimal? Staxreturnedvalue { get; set; }
        public decimal? Ctaxsalesvalue { get; set; }
        public decimal? Ctaxreturnedvalue { get; set; }
        public decimal? Ctaxdiscsalesvalue { get; set; }
        public decimal? Ctaxdiscreturnedvalue { get; set; }
        public string Unitname { get; set; }
        public string Unitename { get; set; }
        public string Itemformname { get; set; }
        public string Itemformename { get; set; }
        public decimal? Itemformid { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Currencyid { get; set; }
    }
}
