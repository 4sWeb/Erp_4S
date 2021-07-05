using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsBal
    {
        public StoreItemsBal()
        {
            StoreItemsBalExps = new HashSet<StoreItemsBalExp>();
        }

        public decimal? UnitId { get; set; }
        public decimal? IPurchPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? DealPrice { get; set; }
        public decimal IQty { get; set; }
        public decimal? Period { get; set; }
        public decimal StoreItemsBalId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? Minimumorder { get; set; }
        public decimal? Orderlimit { get; set; }
        public decimal? Maximumorder { get; set; }

        public virtual StoreAllcode StoreAllcodes { get; set; }
        public virtual StoreItem StoreItems { get; set; }
        public virtual StoreUnit Unit { get; set; }
        public virtual ICollection<StoreItemsBalExp> StoreItemsBalExps { get; set; }
    }
}
