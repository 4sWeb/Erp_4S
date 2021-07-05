using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemUnit
    {
        public decimal Unitid { get; set; }
        public decimal? UnitRate { get; set; }
        public bool? BasicUnit { get; set; }
        public decimal StoreItemUnitsId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public string Barcode { get; set; }

        public virtual StoreItem StoreItems { get; set; }
        public virtual StoreUnit Unit { get; set; }
    }
}
