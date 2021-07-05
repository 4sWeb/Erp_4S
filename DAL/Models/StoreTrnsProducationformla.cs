using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsProducationformla
    {
        public decimal Id { get; set; }
        public decimal? StoreTrnsoId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unitid { get; set; }

        public virtual StoreItem StoreItems { get; set; }
        public virtual StoreTrnsO StoreTrnso { get; set; }
    }
}
