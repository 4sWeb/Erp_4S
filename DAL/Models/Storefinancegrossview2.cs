using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storefinancegrossview2
    {
        public decimal StoreTrnsMId { get; set; }
        public decimal? BranchId { get; set; }
        public string Branchname { get; set; }
        public string Fromname { get; set; }
        public string Toname { get; set; }
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public DateTime TrnsDate { get; set; }
        public string Rem { get; set; }
        public decimal? FromStoreAllcodesId { get; set; }
        public decimal? ToStoreAllcodesId { get; set; }
        public decimal? Period { get; set; }
        public decimal? Grossleft { get; set; }
        public decimal? Currencyid { get; set; }
        public string Currencyname { get; set; }
    }
}
