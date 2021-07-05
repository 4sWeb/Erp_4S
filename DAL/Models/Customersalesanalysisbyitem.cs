using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Customersalesanalysisbyitem
    {
        public DateTime TrnsDate { get; set; }
        public decimal? BranchId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemEname { get; set; }
        public decimal Itemid { get; set; }
        public string Custname { get; set; }
        public string Custename { get; set; }
        public string Custcode { get; set; }
        public decimal? Custid { get; set; }
        public string Custformname { get; set; }
        public string Custformename { get; set; }
        public decimal? Custformid { get; set; }
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
        public decimal? Itemgroupf { get; set; }
        public decimal? Currencyid { get; set; }
        public string Curraname { get; set; }
        public string Currename { get; set; }
        public decimal? Currencyrate { get; set; }
        public bool? Payeffect { get; set; }
        public bool? Qtyeffect { get; set; }
        public decimal? Freeitem { get; set; }
    }
}
