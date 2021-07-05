using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ItemChangePriceO
    {
        public decimal? Itemchangeid { get; set; }
        public string ItemCode { get; set; }
        public string Aname { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? NewSalePrice { get; set; }
        public decimal? BranchPrice { get; set; }
        public decimal? NewBranchPrice { get; set; }
        public decimal? DealPrice { get; set; }
        public decimal? NewDealPrice { get; set; }
        public decimal ItemOId { get; set; }
        public decimal? StoreItemsId { get; set; }

        public virtual ItemChangePriceM Itemchange { get; set; }
        public virtual StoreItem StoreItems { get; set; }
    }
}
