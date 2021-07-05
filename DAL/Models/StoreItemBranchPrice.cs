using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemBranchPrice
    {
        public decimal IPurchPrice { get; set; }
        public decimal? Period { get; set; }
        public decimal SiBranchPricesId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? BranchId { get; set; }

        public virtual StoreAllsubcode Branch { get; set; }
        public virtual StoreItem StoreItems { get; set; }
    }
}
