using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreInventoryO
    {
        public decimal Invoid { get; set; }
        public decimal? InventoryMId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? ItemBalance { get; set; }

        public virtual StoreInventoryM InventoryM { get; set; }
        public virtual StoreItem Item { get; set; }
        public virtual StoreUnit Unit { get; set; }
    }
}
