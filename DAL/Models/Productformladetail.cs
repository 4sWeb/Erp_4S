using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Productformladetail
    {
        public decimal Id { get; set; }
        public decimal? Producatformlaid { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Factor { get; set; }

        public virtual Producationformla Producatformla { get; set; }
        public virtual StoreItem StoreItems { get; set; }
        public virtual StoreUnit Unit { get; set; }
    }
}
