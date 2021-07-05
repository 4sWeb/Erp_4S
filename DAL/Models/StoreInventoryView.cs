using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreInventoryView
    {
        public decimal? InventoryNum { get; set; }
        public DateTime? InventoryDate { get; set; }
        public string Storeaname { get; set; }
        public string Storeename { get; set; }
        public decimal? StoreId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Itembalance { get; set; }
        public decimal? Inventoryqtydifference { get; set; }
        public decimal? Cost { get; set; }
        public string Itemcode { get; set; }
        public string Itemaname { get; set; }
        public string Itemename { get; set; }
        public string Unitaname { get; set; }
        public string Unitename { get; set; }
        public string InventoryNote { get; set; }
    }
}
