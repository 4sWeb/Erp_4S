using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsPrice
    {
        public decimal? TrnsId { get; set; }
        public decimal? StoreId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Averageprice { get; set; }
        public decimal? Period { get; set; }
        public decimal Trnspriceid { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? TrnsPriceForcost { get; set; }
        public decimal? BranchId { get; set; }

        public virtual StoreItem Item { get; set; }
        public virtual StoreAllcode Store { get; set; }
        public virtual StoreTrnsM Trns { get; set; }
        public virtual StoreUnit Unit { get; set; }
    }
}
