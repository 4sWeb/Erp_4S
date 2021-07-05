using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ItemDiscountO
    {
        public decimal ItemOId { get; set; }
        public decimal Itemchangeid { get; set; }
        public string ItemCode { get; set; }
        public string Aname { get; set; }
        public decimal StoreItemsId { get; set; }
        public decimal Discount { get; set; }
        public decimal? OldDiscount { get; set; }

        public virtual DiscountItemM Itemchange { get; set; }
        public virtual StoreItem StoreItems { get; set; }
    }
}
